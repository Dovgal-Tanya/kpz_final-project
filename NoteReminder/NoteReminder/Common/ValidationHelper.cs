using System;

namespace NoteReminder.Common
{
    public static class ValidationHelper
    {
        public static bool ValidateNoteInput(string title, string content, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                errorMessage = "Заголовок нотатки не може бути порожнім!";
                return false;
            }
            if (title.Length > 100)
            {
                errorMessage = "Заголовок занадто довгий (макс. 100 символів).";
                return false;
            }
            if (string.IsNullOrWhiteSpace(content))
            {
                errorMessage = "Вміст нотатки не може бути порожнім!";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }
    }
}