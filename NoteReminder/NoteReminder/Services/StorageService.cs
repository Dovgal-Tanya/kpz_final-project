using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using NoteReminder.Common;
using NoteReminder.Models;

namespace NoteReminder.Services
{
    public class StorageService
    {
        private readonly string _filePath;
        private readonly JsonSerializerSettings _settings;

        public StorageService()
        {
            _filePath = ConfigurationManager.Instance.DataStoragePath;
            _settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All,
                Formatting = Formatting.Indented
            };
        }

        public void Save(List<Note> notes)
        {
            try
            {
                string jsonString = JsonConvert.SerializeObject(notes, _settings);
                File.WriteAllText(_filePath, jsonString);
            }
            catch (Exception ex)
            {
                throw new IOException("Помилка під час збереження даних.", ex);
            }
        }

        public List<Note> Load()
        {
            if (!File.Exists(_filePath))
                return new List<Note>();

            try
            {
                string jsonString = File.Exists(_filePath) ? File.ReadAllText(_filePath) : "[]";
                var result = JsonConvert.DeserializeObject<List<Note>>(jsonString, _settings);
                return result ?? new List<Note>();
            }
            catch
            {
                return new List<Note>();
            }
        }
    }
}