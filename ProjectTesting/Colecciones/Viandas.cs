using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTesting.Modelos;
namespace ProjectTesting.Colecciones
{
    public class Viandas
    {
        public List<Vianda> listaViandas = new List<Vianda>();



        public void AgregarVianda(Vianda vianda)
        {
           

            if (listaViandas == null)
            {
                vianda.id = 0;
                listaViandas.Add(vianda);
            }
            else
            {
                vianda.id = listaViandas.Count;
                

                   
                        listaViandas.Add(vianda);
                    
                

            }

        }

        //Funcion unicamente para datos de prueba
        public void AgregarViandas(params Vianda[] viandas)
        {
            for (int i = 0; i < viandas.Length; i++)
            {
                AgregarVianda(viandas[i]);
            }
        }
        public List<Vianda> GetViandas()
        {

            return listaViandas;

        }
        public List<string> GetNombresViandas()
        {
            List<string> vs = new List<string>();
            foreach(Vianda v in listaViandas)
            {
                vs.Add(v.nombre);
            }
            return vs;
        }
    }
}

