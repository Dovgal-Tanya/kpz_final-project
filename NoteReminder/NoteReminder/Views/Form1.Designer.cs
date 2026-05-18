namespace NoteReminder
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvNotes = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSummary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.dtpReminderTime = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbFilterCategory = new System.Windows.Forms.ComboBox();
            this.cmbFilterPriority = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.grpCreate = new System.Windows.Forms.GroupBox();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).BeginInit();
            this.grpCreate.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.SuspendLayout();

            this.dgvNotes.AllowUserToAddRows = false;
            this.dgvNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColTitle,
            this.ColType,
            this.ColCategory,
            this.ColPriority,
            this.ColSummary});
            this.dgvNotes.Location = new System.Drawing.Point(12, 330);
            this.dgvNotes.Name = "dgvNotes";
            this.dgvNotes.ReadOnly = true;
            this.dgvNotes.RowHeadersWidth = 51;
            this.dgvNotes.RowTemplate.Height = 29;
            this.dgvNotes.Size = new System.Drawing.Size(910, 320);
            this.dgvNotes.TabIndex = 0;
             
            this.ColId.HeaderText = "ID";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Visible = false;
             
            this.ColTitle.HeaderText = "Заголовок";
            this.ColTitle.Name = "ColTitle";
            this.ColTitle.ReadOnly = true;
            this.ColTitle.Width = 150;
              
            this.ColType.HeaderText = "Тип";
            this.ColType.Name = "ColType";
            this.ColType.ReadOnly = true;
            this.ColType.Width = 120;
             
            this.ColCategory.HeaderText = "Категорія";
            this.ColCategory.Name = "ColCategory";
            this.ColCategory.ReadOnly = true;
            this.ColCategory.Width = 120;
             
            this.ColPriority.HeaderText = "Пріоритет";
            this.ColPriority.Name = "ColPriority";
            this.ColPriority.ReadOnly = true;
            this.ColPriority.Width = 120;
             
            this.ColSummary.HeaderText = "Короткий зміст / Час";
            this.ColSummary.Name = "ColSummary";
            this.ColSummary.ReadOnly = true;
            this.ColSummary.Width = 230;
             
            this.lblTitle.Location = new System.Drawing.Point(10, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 23);
            this.lblTitle.Text = "Заголовок:";
            
            this.txtTitle.Location = new System.Drawing.Point(110, 27);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(200, 27);
             
            this.lblContent.Location = new System.Drawing.Point(10, 70);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(100, 23);
            this.lblContent.Text = "Текст нотатки:";
             
            this.txtContent.Location = new System.Drawing.Point(110, 67);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(200, 70);
             
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Items.AddRange(new object[] { "Звичайна", "Нагадування" });
            this.cmbType.Location = new System.Drawing.Point(430, 27);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(150, 28);
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
             
            this.lblType.Location = new System.Drawing.Point(340, 30);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(80, 23);
            this.lblType.Text = "Тип:";
             
            this.dtpReminderTime.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpReminderTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReminderTime.Location = new System.Drawing.Point(430, 67);
            this.dtpReminderTime.Name = "dtpReminderTime";
            this.dtpReminderTime.Size = new System.Drawing.Size(150, 27);
              
            this.lblTime.Location = new System.Drawing.Point(340, 72);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(80, 23);
            this.lblTime.Text = "Час:";
             
            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.Items.AddRange(new object[] { "Low", "Medium", "High" });
            this.cmbPriority.Location = new System.Drawing.Point(710, 27);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(150, 28);
              
            this.lblPriority.Location = new System.Drawing.Point(610, 30);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(90, 23);
            this.lblPriority.Text = "Пріоритет:";
             
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Items.AddRange(new object[] { "Personal", "Work", "Study" });
            this.cmbCategory.Location = new System.Drawing.Point(710, 67);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(150, 28);
              
            this.lblCategory.Location = new System.Drawing.Point(610, 72);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(90, 23);
            this.lblCategory.Text = "Категорія:";
              
            this.btnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdd.Location = new System.Drawing.Point(710, 110);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 35);
            this.btnAdd.Text = "Створити запис";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
             
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Location = new System.Drawing.Point(772, 285);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 35);
            this.btnDelete.Text = "Видалити обране";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
             
            this.txtSearch.Location = new System.Drawing.Point(10, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 27);
             
            this.cmbFilterCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterCategory.Items.AddRange(new object[] { "Всі", "Personal", "Work", "Study" });
            this.cmbFilterCategory.Location = new System.Drawing.Point(230, 29);
            this.cmbFilterCategory.Name = "cmbFilterCategory";
            this.cmbFilterCategory.Size = new System.Drawing.Size(150, 28);
             
            this.cmbFilterPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterPriority.Items.AddRange(new object[] { "Всі", "Low", "Medium", "High" });
            this.cmbFilterPriority.Location = new System.Drawing.Point(400, 29);
            this.cmbFilterPriority.Name = "cmbFilterPriority";
            this.cmbFilterPriority.Size = new System.Drawing.Size(150, 28);
             
            this.btnFilter.Location = new System.Drawing.Point(580, 26);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(120, 32);
            this.btnFilter.Text = "Застосувати";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
             
            this.grpCreate.Controls.Add(this.lblTitle);
            this.grpCreate.Controls.Add(this.txtTitle);
            this.grpCreate.Controls.Add(this.lblContent);
            this.grpCreate.Controls.Add(this.txtContent);
            this.grpCreate.Controls.Add(this.lblType);
            this.grpCreate.Controls.Add(this.cmbType);
            this.grpCreate.Controls.Add(this.lblTime);
            this.grpCreate.Controls.Add(this.dtpReminderTime);
            this.grpCreate.Controls.Add(this.lblPriority);
            this.grpCreate.Controls.Add(this.cmbPriority);
            this.grpCreate.Controls.Add(this.lblCategory);
            this.grpCreate.Controls.Add(this.cmbCategory);
            this.grpCreate.Controls.Add(this.btnAdd);
            this.grpCreate.Location = new System.Drawing.Point(12, 12);
            this.grpCreate.Name = "grpCreate";
            this.grpCreate.Size = new System.Drawing.Size(910, 160);
            this.grpCreate.TabStop = false;
            this.grpCreate.Text = "Додати нову подію";
             
            this.grpFilter.Controls.Add(this.txtSearch);
            this.grpFilter.Controls.Add(this.cmbFilterCategory);
            this.grpFilter.Controls.Add(this.cmbFilterPriority);
            this.grpFilter.Controls.Add(this.btnFilter);
            this.grpFilter.Location = new System.Drawing.Point(12, 190);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(910, 80);
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Фільтрація та Пошук";
             
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 665);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.grpCreate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvNotes);
            this.Name = "Form1";
            this.Text = "NoteReminder";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotes)).EndInit();
            this.grpCreate.ResumeLayout(false);
            this.grpCreate.PerformLayout();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSummary;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.DateTimePicker dtpReminderTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbFilterCategory;
        private System.Windows.Forms.ComboBox cmbFilterPriority;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.GroupBox grpCreate;
        private System.Windows.Forms.GroupBox grpFilter;
    }
}