using System;

namespace NoteReminder.Models
{
    public class ReminderNote : Note
    {
        public DateTime ReminderTime { get; set; }
        public bool IsTriggered { get; set; }

        public override string GetNoteType() => "Нагадування";
        public override string GetSummary() => "[Діє до: " + ReminderTime.ToString("dd.MM HH:mm") + "] " + Content;
    }
}