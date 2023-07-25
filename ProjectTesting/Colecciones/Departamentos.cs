using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTesting.Modelos;

namespace ProjectTesting.Colecciones
{
    class Departamentos
    {
        public List<Departamento> departamentos = new List<Departamento>();

        public Departamentos()
        {
            Zonas zonasMontevideo = new Zonas();
            zonasMontevideo.AgregarZona(0, "Palermo");
            zonasMontevideo.AgregarZona(1, "Malvin");
            zonasMontevideo.AgregarZona(2, "Capurro");
            departamentos.Add(new Departamento("Montevideo", zonasMontevideo));

            Zonas zonasCanelones = new Zonas();
            zonasCanelones.AgregarZona(0, "Canelones");
            zonasCanelones.AgregarZona(1, "Jaureguiberry");
            zonasCanelones.AgregarZona(2, "Sauce");
            departamentos.Add(new Departamento("Canelones", zonasCanelones));
            
        }
        public Departamento GetDepartamento(int index)
        {
            return departamentos[index];
        }

    }
}
