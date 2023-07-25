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

namespace ProjectTesting.Forms
{
    public partial class FormSucursales : Form, ISubForm 
    {

       
        public FormSucursales()
        {
            InitializeComponent();
        }

        private void btnAgregarSucursal_Click(object sender, EventArgs e)
        {
            Form f = new SubFormsSucursales.FormAgregarSucursal();
            f.Show();
        }
        public void OcultarElementos()
        {
            switch (Program.Rol)
            {
                case "admin":
                    break;
                case "ventas":
                    btnAgregarSucursal.Visible = false;
                    btnEliminarSucursal.Visible = false;
                    btnModificarSucursal.Visible = false;

                    break;
                case "cocina":

                    break;
                case "transporte":
                    btnAgregarSucursal.Visible = false;
                    btnEliminarSucursal.Visible = false;
                    btnModificarSucursal.Visible = false;
                    break;


            }
        }

        private void btnModificarSucursal_Click(object sender, EventArgs e)
        {

        }
    }
}
