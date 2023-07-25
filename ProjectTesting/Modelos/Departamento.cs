using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTesting.Colecciones;

namespace ProjectTesting.Modelos
{
    class Departamento
    {
       public string nombre { get; set; }
        public Zonas zonas { get; set; }

        public Departamento(string nom, Zonas zonas)
        {
            this.nombre = nom;
            this.zonas = zonas;
        }
        
    }
}
