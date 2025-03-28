// Program.cs
using System;
using System.Windows.Forms;
using Sistema_de_Ventas_y_Inventarios_San_Marcos.Forms;

namespace Sistema_de_Ventas_y_Inventarios_San_Marcos
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPrincipal());
        }
    }
}