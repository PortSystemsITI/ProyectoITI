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
    public partial class CocinaAlerta : UserControl
    {
        public CocinaAlerta()
        {
            InitializeComponent();
        }
        public CocinaAlerta(Color backColor, Color BtnColor)
        {
            InitializeComponent();
            this.BackColor = backColor;
            btnConfirmar.BackColor = BtnColor;
            btnVerDetalles.BackColor = BtnColor;
        }

        private void CocinaAlerta_Load(object sender, EventArgs e)
        {

        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {

        }
    }
}
