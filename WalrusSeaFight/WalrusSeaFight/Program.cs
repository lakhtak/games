using System;
using System.Windows.Forms;
using Logic;

namespace WalrusSeaFight
{
    class Program
    {
        [STAThread]
        public static void Main()
        {
            Allocator.AllocateShipsRandomly(MyField.Instance);
            Allocator.AllocateShipsRandomly(OpponentsField.Instance);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
