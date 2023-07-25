using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectTesting.Colecciones;
using ProjectTesting.Modelos;
namespace ProjectTesting.Forms
{
    public partial class FormViandas : Form, ISubForm
    {
        Viandas viandas = ColeccionDatosPrueba.viandasPrueba;
        public FormViandas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        public void MostrarDatosEnTabla()
        {

            foreach (Vianda v in viandas.listaViandas)
            {
                //int id = m.id;

                string nombre = v.nombre;
               
                dataGridViandas.Rows.Add(0, nombre, "dietas", false);

            }



        }
            private void btnAgregarVianda_Click(object sender, EventArgs e)
        {
            Form agregarVianda = new SubFormsViandas.FormAgregarVianda();
            agregarVianda.Show();
        }

        private void btnEliminarVianda_Click(object sender, EventArgs e)
        {

        }
        public void OcultarElementos()
        {
            switch (Program.Rol)
            {
                case "admin":
                    break;
                case "ventas":
                    btnAgregarVianda.Visible = false;
                    btnEliminarVianda.Visible = false;
                    break;
                case "cocina":
                    break;
                case "transporte":
                    break;


            }
        }

        private void FormViandas_Load(object sender, EventArgs e)
        {
            MostrarDatosEnTabla();
        }
    }
}
