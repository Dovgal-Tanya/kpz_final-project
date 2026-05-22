using System;
using NoteReminder.Models;

namespace NoteReminder.Services
{
    public static class NoteFactory
    {
        public static Note CreateNote(Models.NoteType type, string title, string content, string priority, string category, DateTime? reminderTime)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Заголовок не може бути порожнім.");

            if (type == Models.NoteType.Reminder)
            {
                if (!reminderTime.HasValue)
                    throw new ArgumentException("Для нагадування обов'язково вказувати час сповіщення.");

                return new ReminderNote
                {
                    Title = title,
                    Content = content,
                    Priority = priority,
                    Category = category,
                    ReminderTime = reminderTime.Value,
                    IsTriggered = false
                };
            }
            else
            {
                return new SimpleNote
                {
                    Title = title,
                    Content = content,
                    Priority = priority,
                    Category = category
                };
            }
        }
    }
}
