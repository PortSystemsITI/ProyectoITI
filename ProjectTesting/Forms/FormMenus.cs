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
    public partial class FormMenus : Form, ISubForm

    {
        Form agregarMenuForm;
        Menus menus = ColeccionDatosPrueba.menusPrueba;
        private void FormMenus_Load(object sender, EventArgs e)
        {
            MostrarDatosEnTabla();

            
        }
        public void MostrarDatosEnTabla()
        {
            
            foreach (Modelos.Menu m in menus.listaMenus)
            {
                //int id = m.id;

                string nombre = m.nombre;
                tipoMenu tipo = m.tipoMenu;
                menusGrid.Rows.Add(0, nombre, "ver viandas" , tipo, 5, "3h 30m", false);

            }




        }
        public FormMenus()
        {
            InitializeComponent();
            OcultarElementos();



            
           
        }

        private void btnAgregarMenu_Click(object sender, EventArgs e)
        {
            Form f = new SubFormsMenus.FormAgregarMenu();

            agregarMenuForm = f;
            agregarMenuForm.Show();

          
           

        }
        // void OcultarElementos(string rol)
        //{
           
        //}
        private void menusGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if(e.ColumnIndex == 2)
            {

                string message = "";
                foreach (string s in menus.listaMenus[indice].GetNombresViandas())
                {
                    message += s + "\n";
                }
                MessageBox.Show(message);
            }
        }

       public void OcultarElementos()
        {
            switch (Program.Rol)
            {
                case "admin":
                    break;
                case "ventas":
                    btnAgregarMenu.Visible = false;
                    btnEliminarMenu.Visible = false;

                    break;
                case "cocina":

                    break;
                case "transporte":

                    break;


            }
        }


    }
}
