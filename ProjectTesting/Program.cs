using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTesting
{
    static class Program
    {
        private static Form menuPrincipal;
        public static string Rol;


        //Colecciones


        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
        public static void AbrirMenu(string rol)
        {
            Rol = rol;
            menuPrincipal = new Form1(rol);
            menuPrincipal.Show();
            if(rol == "cocina")
            {
                Form programinCocina = new FormPrograminCocina();
                programinCocina.Show();
            }
        }
    }
}
