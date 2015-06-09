using System;
using System.Windows.Forms;

namespace WalrusEnglishGui
{
    static class Program
    {
        public static GameForm TheGameForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            TheGameForm = new GameForm();
            Application.Run(TheGameForm);
        }
    }
}
