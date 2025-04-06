using OOP_Lab1_Shalygin_Korsunov.Lab4;
using System;
using System.Windows.Forms;

namespace OOP_Lab1_Shalygin_Korsunov
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FacadeForm());
        }
    }
}
