using System;
using System.Windows.Forms;

namespace COPIA
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new ListaPlantas());
            }
            catch (ArgumentException) { }
        }
    }
}
