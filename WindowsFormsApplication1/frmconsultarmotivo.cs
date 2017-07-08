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
    public partial class frmconsultarmotivo : Form
    {
        public frmconsultarmotivo()
        {
            InitializeComponent();
        }
        public capa_presentacion_vacaciones motivoseleccionado { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            dgvbuscar.DataSource = capa_logica_vacaciones.Buscarmotivo(txtmotivo.Text);
        }

        private void txtmotivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnretorno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvbuscar.SelectedRows.Count == 1)
            {
                int codmotivo = Convert.ToInt32(dgvbuscar.CurrentRow.Cells[0].Value);
                motivoseleccionado = capa_logica_vacaciones.Obtenermotivo(codmotivo);

                this.Close();
            }
            else
                MessageBox.Show("debe de seleccionar una fila");
        }

        private void frmconsultarmotivo_Load(object sender, EventArgs e)
        {

        }
    }
}
