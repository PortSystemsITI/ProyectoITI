using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTesting.Forms.SubFormsPedidos
{
    public partial class FormIngresarPedido : Form
    {
        private int cantidadViandas;
        public FormIngresarPedido()
        {
            InitializeComponent();
            labelViandas.Visible = false;
           // labelMenuComun.Visible = false;
           // menusGrid.Visible = false;
            viandasGrid.Visible = false;
            labelCantidadViandas.Visible = false;
            labelCantViandasText.Visible = false;
        }

  

        private void checkPersonalizado_CheckedChanged(object sender, EventArgs e)
        {
            viandasGrid.Visible = checkPersonalizado.Checked;
            menusGrid.Visible = !checkPersonalizado.Checked;
            labelMenuComun.Visible = !checkPersonalizado.Checked;
            labelViandas.Visible = checkPersonalizado.Checked;
            labelCantViandasText.Visible = true;
            labelCantidadViandas.Visible = checkPersonalizado.Checked;
        }

        

        private void radioSemanal_CheckedChanged(object sender, EventArgs e)
        {
            cantidadViandas = 5;
            labelCantidadViandas.Text = Convert.ToString(cantidadViandas);
        }

        private void radioQuincenal_CheckedChanged(object sender, EventArgs e)
        {
            cantidadViandas = 13;
            labelCantidadViandas.Text = Convert.ToString(cantidadViandas);
        }

        private void radioMensual_CheckedChanged(object sender, EventArgs e)
        {
            cantidadViandas = 20;
            labelCantidadViandas.Text = Convert.ToString(cantidadViandas);
        }

        private void btnAgregarMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
