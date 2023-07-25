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
    public partial class Form1 : Form
    {

        private Form formActivo;
        private Button botonActivo;
        private string testRol; 


        //Constructor con roles de test harcodeados en la clase FormLogin
       public Form1(string rol)
        {
            testRol = rol;
            InitializeComponent();
            OcultarElementos(testRol);
        }

        //Paleta Colores
        ////botones
        Color colorBotonBase = Color.FromArgb(23, 51, 145);
        Color colorBotonActivo = Color.FromArgb(27, 64, 174);
        public Form1()
        {
            InitializeComponent();
        }



        //Click Botones
        private void btnMenus_Click(object sender, EventArgs e)
        {
            //CambiarPanelActivo(panelMenus);
            
            CambiarBotonActivo(btnMenus);
            AbrirFormulario(new Forms.FormMenus(), sender);
          
        }
        private void btnPedidos_Click(object sender, EventArgs e)
        {

            CambiarBotonActivo(btnPedidos);
            AbrirFormulario(new Forms.FormPedidos(), sender);
            

        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            CambiarBotonActivo(btnClientes);
            AbrirFormulario(new Forms.FormClientes(), sender);
        }
        private void btnViandas_Click(object sender, EventArgs e)
        {
            CambiarBotonActivo(btnViandas);
            AbrirFormulario(new Forms.FormViandas(), sender);
        }
        private void btnDietas_Click(object sender, EventArgs e)
        {
            CambiarBotonActivo(btnDietas);
            AbrirFormulario(new Forms.FormDietas(), sender);
        }

        private void btnSucursales_Click(object sender, EventArgs e)
        {
            CambiarBotonActivo(btnSucursales);
            AbrirFormulario(new Forms.FormSucursales(), sender);
        }

        private void btnZonas_Click(object sender, EventArgs e)
        {
            CambiarBotonActivo(btnZonas);
            AbrirFormulario(new Forms.FormZonas(), sender);
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Dispose();
        }


        #region //Efectos botones

        private void btnMenus_MouseEnter(object sender, EventArgs e)
        {
            btnMenus.Font = new Font(btnMenus.Font.FontFamily, btnMenus.Font.Size + 1, btnMenus.Font.Style);
        }

        private void btnMenus_MouseLeave(object sender, EventArgs e)
        {
            btnMenus.Font = new Font(btnMenus.Font.FontFamily, btnMenus.Font.Size - 1, btnMenus.Font.Style);
        }
        private void btnPedidos_MouseEnter(object sender, EventArgs e)
        {
            btnPedidos.Font = new Font(btnPedidos.Font.FontFamily, btnPedidos.Font.Size + 1, btnPedidos.Font.Style);
        }

        private void btnPedidos_MouseLeave(object sender, EventArgs e)
        {
            btnPedidos.Font = new Font(btnPedidos.Font.FontFamily, btnPedidos.Font.Size - 1, btnPedidos.Font.Style);
        }
        private void btnClientes_MouseEnter(object sender, EventArgs e)
        {
            btnDietas.Font = new Font(btnDietas.Font.FontFamily, btnDietas.Font.Size + 1, btnDietas.Font.Style);
        }

        private void btnClientes_MouseLeave(object sender, EventArgs e)
        {
            btnDietas.Font = new Font(btnDietas.Font.FontFamily, btnDietas.Font.Size - 1, btnDietas.Font.Style);
        }
        private void btnViandas_MouseEnter(object sender, EventArgs e)
        {
            btnViandas.Font = new Font(btnViandas.Font.FontFamily, btnViandas.Font.Size + 1, btnViandas.Font.Style);
        }

        private void btnViandas_MouseLeave(object sender, EventArgs e)
        {
            btnViandas.Font = new Font(btnViandas.Font.FontFamily, btnViandas.Font.Size - 1, btnViandas.Font.Style);
        }
        private void CambiarBotonActivo(Button b)
        {

            if (botonActivo != null)
            {
                botonActivo.BackColor = colorBotonBase;
                botonActivo.Font = new Font(btnMenus.Font.FontFamily, btnMenus.Font.Size - 1, btnMenus.Font.Style);
                
                botonActivo = b;
                botonActivo.BackColor = colorBotonActivo;
                
                botonActivo.Font = new Font(btnMenus.Font.FontFamily, btnMenus.Font.Size + 1, btnMenus.Font.Style);

            }
            else
            {
                botonActivo = b;
                botonActivo.BackColor = colorBotonActivo;
                botonActivo.Font = new Font(btnMenus.Font.FontFamily, btnMenus.Font.Size + 1, btnMenus.Font.Style);
            }


        }
        #endregion


        //Activar y desactivar formularios
        private void AbrirFormulario(Form childForm, object btnSender)
        {
            if(formActivo != null)
            {
                formActivo.Close();

            }
            formActivo = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelOpciones.Controls.Add(childForm);
            this.panelOpciones.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitulo.Text = childForm.Text.Replace("Form", "");
            
        }

        //Esconder según roles (HARDCODED VERSION)

        private void OcultarElementos(string rol)
        {
            switch (rol)
            {
                case "admin":
                    break;
                case "ventas":
                    btnDietas.Visible = false;
                    btnEstadisticas.Visible = false;
                    
                    break;
                case "cocina":
                    btnSucursales.Visible = false;
                    btnZonas.Visible = false;
                    btnClientes.Visible = false;
                    btnEstadisticas.Visible = false;
                    break;
                case "transporte":
                    btnMenus.Visible = false;
                    btnClientes.Visible = false;
                    btnViandas.Visible = false;
                    btnDietas.Visible = false;
                    btnEstadisticas.Visible = false;
                    break;


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Colecciones.ColeccionDatosPrueba.CargarDatosPrueba();
        }

        private void panelOpciones_Paint(object sender, PaintEventArgs e)
        {

        }
    }
   
}
