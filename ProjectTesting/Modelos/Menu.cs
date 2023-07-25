using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTesting.Colecciones;


namespace ProjectTesting.Modelos
{
    public class Menu
    {
        //Menu (IdMenu, TipoMenu, NombMenu, TiempoElavoracion)

        public int id { get; set; }
        public string nombre { get; set; }

        //(mm:ss)
        public TiempoCoccion tiempoElaboracion { get; set; }
        public tipoMenu tipoMenu { get; set; }
        public Viandas viandas { get; set; } 
        public int stockColchhon { get; set; }
        public int stockMaximo { get; set; }

            

        public Menu()
        {

        }
        public Menu(string nombre, tipoMenu tipo)
        {
            viandas = new Viandas();
            this.nombre = nombre;
            this.tipoMenu = tipo;

        }
        public Menu(string nombre, tipoMenu tipo, Viandas viandas)
        {
            viandas = new Viandas();
            this.viandas = viandas;
            this.nombre = nombre;
            tipoMenu = tipo;

        }
        public Menu(string nombre, tipoMenu tipo,TiempoCoccion tiempo, Viandas viandas)
        {
            viandas = new Viandas();
            tiempoElaboracion = new TiempoCoccion();
            this.viandas = viandas;
            this.nombre = nombre;
            this.tiempoElaboracion = tiempo;
            tipoMenu = tipo;

        }
        public string getNombre()
        {
            return this.nombre;
        }
        public TiempoCoccion GetTiempoElaboracion()
        {
            return this.tiempoElaboracion;
        }
        public tipoMenu GetTipoMenu()
        {
            return this.tipoMenu;
        }
        public List<Vianda> GetViandas()
        {

            return viandas.GetViandas();
            
        }
        public List<string> GetNombresViandas()
        {
            List<string> vs = new List<string>();
            foreach (Vianda v in viandas.listaViandas)
            {
                vs.Add(v.nombre);
            }
            return vs;
        }
        
        public string ToString()
        {
            string message = "";
            foreach (Vianda v in viandas.listaViandas)
            {
                message += v.nombre + "\n";
            }
            return message;
        }
    }

    public enum tipoMenu
    {
        Semanal,
        Quincenal,
        Mensual
    }
    public class TiempoCoccion
    {
        public int minutos { get; set; }
        public int horas { get; set; }
        //agregar metodos de calculos de tiempo.
        
    }
}
