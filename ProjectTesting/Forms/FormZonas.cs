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
    public partial class FormZonas : Form, ISubForm
    {
        public FormZonas()
        {
            InitializeComponent();
        }

        private void btnAgregarSucursal_Click(object sender, EventArgs e)
        {

        }
        public void OcultarElementos()
        {
            switch (Program.Rol)
            {
                case "admin":
                    break;
                case "ventas":
                    btnAgregarZona.Visible = false;
                    btnEliminarZona.Visible = false;
                    break;
                case "cocina":

                    break;
                case "transporte":
                    btnAgregarZona.Visible = false;
                    btnEliminarZona.Visible = false;
                    break;


            }
        }

        private void btnAgregarZona_Click(object sender, EventArgs e)
        {
            Form f = new SubFormsZonas.FormAgregarZona();
            f.Show();
        }

        private void btnEliminarZona_Click(object sender, EventArgs e)
        {

        }
    }
}
