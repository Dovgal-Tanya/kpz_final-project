using System;
using System.Windows.Forms;
using NoteReminder.Common;
using NoteReminder.Models;
using NoteReminder.Services;

namespace NoteReminder
{
    public partial class Form1 : Form
    {
        private readonly NoteManager _noteManager;
        private readonly ReminderScheduler _scheduler;

        public Form1()
        {
            InitializeComponent();
            _noteManager = new NoteManager();

            _scheduler = new ReminderScheduler(_noteManager.GetAllNotes());
            _scheduler.OnReminderAlert += ShowReminderNotification;
            _scheduler.Start();

            InitializeDefaultUIValues();
            RefreshNotesGrid();
        }

        private void InitializeDefaultUIValues()
        {
            cmbType.SelectedIndex = 0;
            cmbPriority.SelectedIndex = 1;
            cmbCategory.SelectedIndex = 0;

            cmbFilterCategory.SelectedIndex = 0;
            cmbFilterPriority.SelectedIndex = 0;
        }

        private void RefreshNotesGrid()
        {
            dgvNotes.Rows.Clear();
            var notes = _noteManager.GetAllNotes();
            foreach (var note in notes)
            {
                dgvNotes.Rows.Add(note.Id, note.Title, note.GetNoteType(), note.Category, note.Priority, note.GetSummary());
            }
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpReminderTime.Enabled = (cmbType.SelectedItem.ToString() == "Нагадування");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string content = txtContent.Text;
            NoteType type = cmbType.SelectedItem.ToString() == "Нагадування" ? NoteType.Reminder : NoteType.Simple;
            string priority = cmbPriority.SelectedItem.ToString();
            string category = cmbCategory.SelectedItem.ToString();
            DateTime reminderTime = dtpReminderTime.Value;

            string error;
            if (!ValidationHelper.ValidateNoteInput(title, content, out error))
            {
                MessageBox.Show(error, "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Note newNote = NoteFactory.CreateNote(type, title, content, priority, category, type == NoteType.Reminder ? (DateTime?)reminderTime : null);
                _noteManager.AddNote(newNote);

                ClearFormInput();
                RefreshNotesGrid();
                MessageBox.Show("Запис успішно додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFormInput()
        {
            txtTitle.Clear();
            txtContent.Clear();
            cmbType.SelectedIndex = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvNotes.CurrentRow == null) return;

            Guid id = (Guid)dgvNotes.CurrentRow.Cells["ColId"].Value;
            var confirm = MessageBox.Show("Ви впевнені, що хочете видалити цей запис?", "Підтвердження", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                _noteManager.RemoveNote(id);
                RefreshNotesGrid();
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            string cat = cmbFilterCategory.SelectedItem.ToString();
            string prio = cmbFilterPriority.SelectedItem.ToString();

            var filtered = _noteManager.SearchAndFilter(keyword, cat, prio);

            dgvNotes.Rows.Clear();
            foreach (var note in filtered)
            {
                dgvNotes.Rows.Add(note.Id, note.Title, note.GetNoteType(), note.Category, note.Priority, note.GetSummary());
            }
        }

        private void ShowReminderNotification(ReminderNote reminder)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ShowReminderNotification(reminder)));
                return;
            }
            MessageBox.Show("[НАГАДУВАННЯ] " + reminder.Title + "\n\n" + reminder.Content,
                            "Увага! Спрацював будильник", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            RefreshNotesGrid();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _scheduler.Stop();
            base.OnFormClosing(e);
        }
    }
}