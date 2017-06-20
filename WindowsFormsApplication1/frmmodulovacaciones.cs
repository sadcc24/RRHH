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
    public partial class frmmodulovacaciones : Form
    {
        public frmmodulovacaciones()
        {
            InitializeComponent();
        }

        private void modulovacaciones_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsolicitud_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            fechainicio.Enabled = true;
            fechafin.Enabled = true;
            combomotivo.Enabled = true;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            fechainicio.Enabled = false;
            fechafin.Enabled = false;
            combomotivo.Enabled = false;
        }

        private void btnretorno_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
