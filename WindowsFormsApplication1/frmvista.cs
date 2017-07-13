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
    public partial class frmvista : Form
    {
        public frmvista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = capa_logica_vacaciones.Buscarvista(dfechainicio.Text,dfechafin.Text);
        }

        private void frmvista_Load(object sender, EventArgs e)
        {

        }

        private void btnretorno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\MANUALDEAYUDA-vistavacaciones.pdf");
        }
    }
}
