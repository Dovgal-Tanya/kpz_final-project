using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NoteReminder.Models;

namespace NoteReminder.Services
{
    public class ReminderScheduler
    {
        private readonly Timer _clock;
        private readonly List<Note> _notesSource;

        public event Action<ReminderNote> OnReminderAlert;

        public ReminderScheduler(List<Note> notesSource)
        {
            _notesSource = notesSource;
            _clock = new Timer();
            _clock.Interval = 5000;
            _clock.Tick += ExecuteCheck;
        }

        public void Start() => _clock.Start();
        public void Stop() => _clock.Stop();

        private void ExecuteCheck(object sender, EventArgs e)
        {
            DateTime currentMoment = DateTime.Now;

            foreach (var note in _notesSource)
            {
                ReminderNote reminder = note as ReminderNote;
                if (reminder != null)
                {
                    if (!reminder.IsTriggered && reminder.ReminderTime <= currentMoment)
                    {
                        reminder.IsTriggered = true;
                        if (OnReminderAlert != null)
                        {
                            OnReminderAlert.Invoke(reminder);
                        }
                    }
                }
            }
        }
    }
}