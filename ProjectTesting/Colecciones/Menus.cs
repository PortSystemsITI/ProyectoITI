using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTesting.Modelos;
namespace ProjectTesting.Colecciones
{
   public class Menus
    {
        public List<Menu> listaMenus = new List<Menu>();

        public Menus(params  Menu[] menus)
        {
            listaMenus.AddRange(menus);
        }
        public Menus()
        {
            
        }
        public void AgregarMenus(params Menu [] menus)
        {
            listaMenus.AddRange(menus);
        }
        public void AgregarMenu(Menu m)
        {
            listaMenus.Add(m);
        }
    }
}
