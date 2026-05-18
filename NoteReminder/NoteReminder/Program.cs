using System;
using System.Windows.Forms;

namespace NoteReminder
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Запускаємо нашу головну форму Form1
            Application.Run(new Form1());
        }
    }
}