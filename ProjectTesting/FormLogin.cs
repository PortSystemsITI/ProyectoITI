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
    public partial class FormLogin : Form
    {
        List<string> roles = new List<string>() { "admin", "ventas", "cocina", "transporte", "thiago" };
        bool canLogin = false;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            TestLogin();


        }
      
        //Presionar enter para loggear (NO FUNCIONA, REVISAR)
        private void FormLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                Console.WriteLine("ENTER");
                TestLogin();
            }
        }
        private void TestLogin()
        {
            //Harcoded login para testing
            if (textUsuario.Text == "" || textPass.Text == "")
            {
                MessageBox.Show("Los campos no deben estar vacios");
            }
            else
            {
                string usuario = textUsuario.Text;
                string pass = textPass.Text;
                if (pass == usuario)
                {
                    foreach (string rol in roles)
                    {
                        if (rol == usuario)
                        {
                            if(usuario != "thiago")
                            {
                                canLogin = true;

                            }
                        }
                    }
                    if(usuario == "thiago"){
                        MessageBox.Show("En el umbral del adiós, Thiago se va\nEl gran desertor de Port Systems hoy será.\nCon sus sueños y anhelos en la maleta,\nParte en busca de una nueva meta.\n\nEn la oficina, su silla quedará vacía,\nPero su esencia en nosotros perdurará cada día.\nCon su ingenio y talento nos inspiró,\nEn cada proyecto, su huella quedó.\nAhora el viento lo lleva a un destino incierto,\nDonde el futuro y el presente se funden en concierto.\nLe deseamos, con cariño y gratitud,\nQue su camino esté lleno de plenitud.\nAunque nos deja, su legado perdura,\nY en nuestra memoria, su imagen perdura.\nThiago, el gran desertor, ¡hasta siempre!\nQue la vida le traiga lo mejor y más valiente.");
                    }

                }
                else
                {
                    MessageBox.Show("El nombre de usuario y/o contraseña no son válidos");
                }

                if (canLogin)
                {
                    Program.AbrirMenu(usuario);
                    

                }




            }

        }





        //mostrar Usuarios test 
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuarios de test:\n" +
                "nombre de usuario: admin - pass: admin\n" +
                "nombre de usuario: ventas -  pass: ventas\n" +
                "nombre de usuario: cocina - pass: cocina\n" +
                "nombre de usuario: transporte - pass: transporte\n");
        }
    }
}
