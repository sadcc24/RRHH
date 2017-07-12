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
    public partial class frmvacacionesplanilla : Form
    {
        public frmvacacionesplanilla()
        {
            InitializeComponent();


            dataGridView1.DataSource = capa_logica_vacaciones.Buscarsolipla(label6.Text);


        }



        private void frmvacacionesplanilla_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                label16.Text = row.Cells["codsolicitud"].Value.ToString();
                label5.Text = row.Cells["idempleado"].Value.ToString();
                label3.Text = row.Cells["motivo"].Value.ToString();
                label11.Text = row.Cells["nombre1"].Value.ToString();
                label12.Text = row.Cells["nombre2"].Value.ToString();
                label13.Text = row.Cells["apellido1"].Value.ToString();
                label14.Text = row.Cells["apellido2"].Value.ToString();
                label15.Text = row.Cells["nombre_empresa"].Value.ToString();


            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = capa_logica_vacaciones.Buscarvistadia(label16.Text);
        }
    }
}