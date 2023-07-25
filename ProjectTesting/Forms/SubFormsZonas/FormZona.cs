using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTesting.Forms.SubFormsZonas
{
    public partial class FormZona : Form
    {
        public FormZona(int id, string nombre)
        {

            InitializeComponent();
            labelID.Text = Convert.ToString(id);
            labelNombre.Text = Convert.ToString(nombre);
        }

        private void labelID_Click(object sender, EventArgs e)
        {

        }
        public void setID(int id)
        {
            labelID.Text = Convert.ToString(id);
        }
        public void setNombre(string nombre)
        {
            labelNombre.Text = Convert.ToString(nombre);
        }
    }
}
