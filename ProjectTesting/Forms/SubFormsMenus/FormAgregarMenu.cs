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

namespace ProjectTesting.Forms.SubFormsMenus
{
    public partial class FormAgregarMenu : Form
    {
        public FormAgregarMenu()
        {
            InitializeComponent();
        }
        private void FormAgregarMenu_Load(object sender, EventArgs e)
        {
            //eventos
            textTiempoCoccionHoras.KeyPress += textTiempoCoccionHoras_KeyPress;
            textTiempoCoccionMinutos.KeyPress += textTiempoCoccionMinutos_KeyPress;


           

            MostrarDatosEnTablas();
        }
        public void MostrarDatosEnTablas()
        {

            //cargar dietas para filtrar
            foreach (Dieta d in ColeccionDatosPrueba.dietasPrueba.GetDietas())
            {
                Console.WriteLine(d.nombre);
                checkedListDietas.Items.Add(d.nombre);

            }

            //Cargar Viandas
            List<Vianda> viandas = ColeccionDatosPrueba.viandasPrueba.GetViandas();
            int index = 0;
            foreach (Vianda v in viandas)
            {

                //int id = m.id;
                string nombre = v.nombre;
                List<string> dietas = new List<string>();
                foreach (Dieta d in v.listaDietas)
                {
                    dietas.Add(d.nombre);
                }


                index++;
                ItemVianda itemVianda = new ItemVianda(index, nombre, dietas);
                panelViandas.Controls.Add(itemVianda);
                itemVianda.Dock = DockStyle.Top;
            }





        }
        private void btnAgregarMenu_Click(object sender, EventArgs e)
        {
          // AgregarMenuALista(CrearNuevoMenu());
           
        }
        //private Modelos.Menu CrearNuevoMenu()
        //{
            
        //    string nombre = textNombre.Text;
        //    TiempoCoccion tiempoCoccion = new TiempoCoccion();
        //    tiempoCoccion.horas = Convert.ToInt32(textTiempoCoccionHoras.Text);
        //    tiempoCoccion.minutos = Convert.ToInt32(textTiempoCoccionMinutos.Text);


        //    tipoMenu tipo = new tipoMenu();
        //    if (radioSemanal.Checked == true)
        //    {
        //        tipo = tipoMenu.Semanal;
        //    }
        //    if (radioQuincenal.Checked == true)
        //    {
        //        tipo = tipoMenu.Quincenal;
        //    }
        //    if (radioMensual.Checked == true)
        //    {
        //        tipo = tipoMenu.Mensual;
        //    }


        //    Modelos.Menu m = new Modelos.Menu(nombre, tipo, tiempoCoccion, TomarViandasSeleccionadas());

        //    return m;
        //}
        //private void AgregarMenuALista(Modelos.Menu m)
        //{
        //    ColeccionDatosPrueba.menusPrueba.AgregarMenu(m);
        //}
        //private Viandas TomarViandasSeleccionadas()
        //{
        //    int cantidad = dataGridViandas.Rows.Count - 1;
        //    List<Vianda> viandasSeleccionadas = new List<Vianda>();
        //    for (int i = 0; i < cantidad; i++)
        //    {
        //        if (dataGridViandas.Rows[i].Cells[3] is DataGridViewCheckBoxCell checkBoxCell)
        //        {
        //            bool isChecked = (bool)checkBoxCell.Value;
        //            if (isChecked)
        //            {
        //                viandasSeleccionadas.Add(ColeccionDatosPrueba.viandasPrueba.listaViandas[i]);

        //            }


        //        }

        //    }
        //    Viandas viandas = new Viandas();
        //    viandas.listaViandas = viandasSeleccionadas;
        //    return viandas;

        //}
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminarVianda_Click(object sender, EventArgs e)
        {

        }

        private void checkVegana_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        //Ignorar input que no sea numerico en tiempo de coccion
        private void textTiempoCoccionHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textTiempoCoccionMinutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
