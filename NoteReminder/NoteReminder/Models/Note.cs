using System;

namespace NoteReminder.Models
{
    public abstract class Note
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Priority { get; set; }
        public string Category { get; set; }

        protected Note()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.Now;
        }

        public abstract string GetNoteType();
        public abstract string GetSummary();
    }
}