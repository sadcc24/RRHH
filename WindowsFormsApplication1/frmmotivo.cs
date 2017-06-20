using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmmotivo : Form
    {
        public frmmotivo()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtmotivo.Enabled = true;
            txtdescripcion.Enabled = true;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtmotivo.Enabled = false;
            txtdescripcion.Enabled = false;
        }
    }
}
