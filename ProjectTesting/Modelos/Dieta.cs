using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTesting.Modelos
{
    public class Dieta
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }


        public Dieta()
        {   
        }
        public Dieta(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;

        }
        public Dieta(int id, string nombre, string descripcion)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;

        }

    }
}
