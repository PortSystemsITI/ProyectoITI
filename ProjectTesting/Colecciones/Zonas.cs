using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTesting.Modelos;
namespace ProjectTesting.Colecciones
{
    class Zonas
    {
        public List<Zona> zonas = new List<Zona>();
        public Zonas()
        {
           
        }

        public void AgregarZona(int id, string nombre)
        {
            zonas.Add(new Zona(id, nombre));
        }
        public void AgregarZona(string nombre)
        {
            int index = zonas.Count();
            zonas.Add(new Zona(index, nombre));
        }
        public List<Zona> GetZonas() {
            return zonas;
        }
        public bool BuscarZonaPorNombre(string nombre)
        {
            string nom = nombre.ToLower();
            bool existe = false;
            foreach(Zona z in zonas)
            {
                if(z.nombre.ToLower() == "nombre")
                {
                    existe = true;
                }
                
            }
            return existe;
        }
    }
}
