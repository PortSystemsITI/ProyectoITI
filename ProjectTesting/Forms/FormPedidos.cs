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
    public partial class FormPedidos : Form, ISubForm 
    {
        public FormPedidos()
        {
            InitializeComponent();
        }
        public void OcultarElementos()
        {
            switch (Program.Rol)
            {
                case "admin":

                    break;
                case "ventas":
                    

                    break;
                case "cocina":
                    btnIngresarPedidos.Visible = false;

                    break;
                case "transporte":
                    btnIngresarPedidos.Visible = false;
                    break;


            }
        }
        private void btnIngresarPedidos_Click(object sender, EventArgs e)
        {
            Form f = new SubFormsPedidos.FormIngresarPedido();
            f.Show();
        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {

        }

        private void menusGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
