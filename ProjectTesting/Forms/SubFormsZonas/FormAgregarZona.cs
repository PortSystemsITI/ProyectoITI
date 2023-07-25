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

namespace ProjectTesting.Forms.SubFormsZonas
{
    public partial class FormAgregarZona : Form
    {

        Departamentos departamentos = new Departamentos();
        public FormAgregarZona()
        {
            InitializeComponent();
            foreach (Departamento d in departamentos.departamentos)
            {
                departamentosCombo.Items.Add(d.nombre);

            }
            departamentosCombo.SelectedIndex = 0;
        }
        private void MostrarZonas(Form childForm)
        {


            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Top;
            this.panelZonas.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();


        }
        private void departamentosCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Departamento departamentoSeleccionado = departamentos.GetDepartamento(departamentosCombo.SelectedIndex);
            List<Zona> _zonas = departamentoSeleccionado.zonas.GetZonas();
            panelZonas.Controls.Clear();
            foreach (Zona z in _zonas)
            {
                Form newZona = new SubFormsZonas.FormZona(z.id, z.nombre);

                MostrarZonas(newZona);
            }


        }

        private void btnIngresarCliente_Click(object sender, EventArgs e)
        {
            Departamento departamentoSeleccionado = departamentos.GetDepartamento(departamentosCombo.SelectedIndex);

            departamentoSeleccionado.zonas.AgregarZona(textNombreZona.Text);


        }
    }
}
