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
    public partial class informacion_solicitud : Form
    {
        public informacion_solicitud()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            frmaprobacionsolicitud frmapro = new frmaprobacionsolicitud();
            frmapro.Show();
            this.Close();
        }

        private void btnrechazar_Click(object sender, EventArgs e)
        {
            frmaprobacionsolicitud frmapro = new frmaprobacionsolicitud();
            frmapro.Show();
            this.Close();
        }
    }
    
}
