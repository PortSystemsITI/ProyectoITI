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
    public partial class ItemVianda : UserControl
    {
        public ItemVianda(int id, string nombre, List<string> dietas)
        {
            InitializeComponent();
            checkBox.Text = Convert.ToString(id);
            textBoxNombre.Text = nombre;
            foreach (string s in dietas)
            {
                listBoxDietas.Items.Add(s);
            }
            if (id % 2 == 0)
            {
                this.BackColor = Color.FromArgb(102, 177, 212);
            }
        }

        public ItemVianda()
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ItemVianda_Load(object sender, EventArgs e)
        {
            

        }
    }
}
