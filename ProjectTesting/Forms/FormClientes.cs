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
    public partial class FormClientes : Form, ISubForm
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void tipoClienteCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresarCliente_Click(object sender, EventArgs e)
        {
            Form ingresarCliente = new SubFormsClientes.FormIngresarCliente();
            ingresarCliente.Show();
        }
        public void OcultarElementos()
        {
            switch (Program.Rol)
            {
                case "admin":
                    break;
                case "ventas":
                    btnIngresarCliente.Visible = false;
                    btnModificarCliente.Visible = false;
                    btnEliminarCliente.Visible = false;

                    break;
                case "cocina":

                    break;
                case "transporte":
                    btnIngresarCliente.Visible = false;
                    btnModificarCliente.Visible = false;
                    btnEliminarCliente.Visible = false;
                    break;


            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {

        }

        private void FormClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
