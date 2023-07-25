using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTesting.Modelos;
using ProjectTesting.Colecciones;

namespace ProjectTesting.Modelos
{
    public class Vianda
    {
       // Vianda (IdVianda, NombVianda)

        public int id { get; set; }
        public string nombre { get; set; }

        public List<Dieta> listaDietas { get; set; }

          public Vianda() { }
           
        public Vianda(string nombre)
        {
            this.nombre = nombre;

        }
        public Vianda(string nombre, params Modelos.Dieta[] dietas)
        {
            this.nombre = nombre;
            listaDietas = new List<Dieta>();
            listaDietas.AddRange(dietas);

        }
        public Vianda(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;

        }

        public void SetDietas<Dieta>(params Modelos.Dieta[] dietas)
        {

            

            listaDietas.AddRange(dietas);
         
        }

    }
}
