using System;
using System.Windows.Forms;

namespace NoteReminder
{
    static class Program
    {
 feature/architecture
 main
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Form1());
        }
    }
}
