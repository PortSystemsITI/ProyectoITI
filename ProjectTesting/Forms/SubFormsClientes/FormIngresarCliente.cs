using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTesting.Forms.SubFormsClientes
{
    public partial class FormIngresarCliente : Form
    {
        public FormIngresarCliente()
        {
            InitializeComponent();
           
            labelNombreEmpresa.Visible = false;
            labelRut.Visible = false;
            textNombreEmpresa.Visible = false;
            textRUT.Visible = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tipoClienteCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(tipoClienteCombo.SelectedIndex == 0)
            //{
            //    labelNombreEmpresa.Visible = false;
            //    labelRut.Visible = false;
            //    labelNombre.Visible = true;
            //    labelApellido.Visible = true;

            //    textNombre.Visible = true;
            //    textNombreEmpresa.Visible = false;
            //    textApellido.Visible = true;
            //    textRUT.Visible = false;
            //    textDocumento.Visible = true;
            //    labelDocumento.Visible = true;
            //}
            //else
            //{
            //    labelNombreEmpresa.Visible = true;
            //    labelRut.Visible = true;
            //    labelNombre.Visible = false;
            //    labelApellido.Visible = false;
            //    labelDocumento.Visible = false;

            //    textNombre.Visible = false;
            //    textNombreEmpresa.Visible = true;
            //    textApellido.Visible = false;
            //    textRUT.Visible = true;
            //    textDocumento.Visible = false;
            //}
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioComun_CheckedChanged(object sender, EventArgs e)
        {
            labelNombreEmpresa.Visible = false;
            labelRut.Visible = false;
            textNombreEmpresa.Visible = false;
            textRUT.Visible = false;


            labelNombre.Visible = true;
            labelApellido.Visible = true;

            textNombre.Visible = true;
            textApellido.Visible = true;
            textDocumento.Visible = true;
            labelDocumento.Visible = true;

        }

        private void radioEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            labelNombreEmpresa.Visible = true;
            labelRut.Visible = true;
            labelNombre.Visible = false;
            labelApellido.Visible = false;
            labelDocumento.Visible = false;

            textNombre.Visible = false;
            textNombreEmpresa.Visible = true;
            textApellido.Visible = false;
            textRUT.Visible = true;
            textDocumento.Visible = false;
        }
    }
}
