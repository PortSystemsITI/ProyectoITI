using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTesting
{
    public partial class FormPrograminCocina : Form
    {
        private int cuentaAlertas;
       
      
        public FormPrograminCocina()
        {
            InitializeComponent();
            cuentaAlertas = 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panelAlertas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTestAgregarAlerta_Click(object sender, EventArgs e)
        {
            AgregarAlerta();
        }

        private void AgregarAlerta()
        {


            if (cuentaAlertas % 2 == 1)
            {
                CocinaAlerta alerta = new CocinaAlerta();
                panelAlertas.Controls.Add(alerta);
                alerta.Dock = DockStyle.Top;
                cuentaAlertas++;
            }
            else
            {
                CocinaAlerta alerta = new CocinaAlerta(Colecciones.PaletaDeColores.highlight, Colecciones.PaletaDeColores.background);
                panelAlertas.Controls.Add(alerta);
                alerta.Dock = DockStyle.Top;
                cuentaAlertas++;
            }




        }

        private void btnAlertaMenu_Click(object sender, EventArgs e)
        {

        }

        private void cocinaAlerta1_Load(object sender, EventArgs e)
        {

        }
    }
}
