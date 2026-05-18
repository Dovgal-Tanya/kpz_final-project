using System;
using System.Collections.Generic;
using System.Linq;
using NoteReminder.Models;

namespace NoteReminder.Services
{
    public class NoteManager
    {
        private readonly List<Note> _notes;
        private readonly StorageService _storageService;

        public NoteManager()
        {
            _storageService = new StorageService();
            _notes = _storageService.Load();
        }

        public List<Note> GetAllNotes() => _notes;

        public void AddNote(Note note)
        {
            if (note == null) throw new ArgumentNullException(nameof(note));
            _notes.Add(note);
            _storageService.Save(_notes);
        }

        public void RemoveNote(Guid id)
        {
            var note = _notes.FirstOrDefault(n => n.Id == id);
            if (note != null)
            {
                _notes.Remove(note);
                _storageService.Save(_notes);
            }
        }

        public List<Note> SearchAndFilter(string keyword, string category, string priority)
        {
            var query = _notes.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(n => n.Title.ToLower().Contains(keyword.ToLower()) ||
                                         n.Content.ToLower().Contains(keyword.ToLower()));
            }

            if (!string.IsNullOrWhiteSpace(category) && category != "Всі")
            {
                query = query.Where(n => n.Category == category);
            }

            if (!string.IsNullOrWhiteSpace(priority) && priority != "Всі")
            {
                query = query.Where(n => n.Priority == priority);
            }

            return query.ToList();
        }
    }
}