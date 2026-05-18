using System;
using NoteReminder.Models;

namespace NoteReminder.Services
{
    public static class NoteFactory
    {
        // Виправлено помилку версії мови 7.3 (замінено умовний вираз із null на чіткий if-else)
        public static Note CreateNote(string type, string title, string content, string priority, string category, DateTime? reminderTime)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Заголовок не може бути порожнім.");

            if (type.ToLower() == "нагадування" || type.ToLower() == "reminder")
            {
                if (!reminderTime.HasValue)
                    throw new ArgumentException("Для нагадування обов'язково вказувати час сповіщення.");

                ReminderNote rNote = new ReminderNote();
                rNote.Title = title;
                rNote.Content = content;
                rNote.Priority = priority;
                rNote.Category = category;
                rNote.ReminderTime = reminderTime.Value;
                rNote.IsTriggered = false;
                return rNote;
            }
            else
            {
                SimpleNote sNote = new SimpleNote();
                sNote.Title = title;
                sNote.Content = content;
                sNote.Priority = priority;
                sNote.Category = category;
                return sNote;
            }
        }
    }
}