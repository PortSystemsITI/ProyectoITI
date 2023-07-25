using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTesting.Forms
{
    public partial class FormDietas : Form, ISubForm
    {
        public FormDietas()
        {
            InitializeComponent();
        }

        private void menusGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnIngresarPedidos_Click(object sender, EventArgs e)
        {

        }
        public void OcultarElementos()
        {
            switch (Program.Rol)
            {
                case "admin":
                    break;
                case "ventas":
                    btnIngresarDieta.Visible = false;
                    btnEliminarDieta.Visible = false;

                    break;
                case "cocina":

                    break;
                case "transporte":

                    break;


            }
        }

        private void btnIngresarDieta_Click(object sender, EventArgs e)
        {
            Form f = new SubFormsDietas.FormIngresarDieta();
            f.Show();
        }
    }
}
