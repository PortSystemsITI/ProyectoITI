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

namespace ProjectTesting.Forms.SubFormsSucursales
{
    
    public partial class FormAgregarSucursal : Form
    {
        Departamentos departamentos = new Departamentos();
    
       
        public FormAgregarSucursal()
        {
            InitializeComponent();
            
            foreach(Departamento d in departamentos.departamentos)
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
        
        private void Departamento_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelZonas_Paint(object sender, PaintEventArgs e)
        {

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
