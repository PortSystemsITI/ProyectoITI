using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTesting.Modelos;
namespace ProjectTesting.Colecciones
{
    public class Dietas
    {
        public List<Dieta> listaDietas = new List<Dieta>();



        public void AgregarDieta(Dieta dieta)
        {
            

            if(listaDietas == null)
            {
                
                dieta.id = 0;
                listaDietas.Add(dieta);
            }
            else
            {
                dieta.id = listaDietas.Count;
                listaDietas.Add(dieta);

            }
           
        }
        public List<Dieta> GetDietas()
        {
            
            return this.listaDietas;

        }
    }


}
