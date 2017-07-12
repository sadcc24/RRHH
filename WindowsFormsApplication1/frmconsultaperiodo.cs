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
   
    public partial class frmconsultaperiodo : Form
    {
        public frmconsultaperiodo()
        {
            InitializeComponent();
        }
        public capa_presentacion_periodo periodoseleccionado { get; set; }
        private void frmconsultaperiodo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvbuscar.DataSource = capa_logica_vacaciones.Buscarperiodoo(comboBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dgvbuscar.SelectedRows.Count == 1)
            {
                int codperiodo = Convert.ToInt32(dgvbuscar.CurrentRow.Cells[0].Value);
                periodoseleccionado = capa_logica_vacaciones.Obtenerperiodoo(codperiodo);

                this.Close();
            }
            else
                MessageBox.Show("debe de seleccionar una fila");
        }

        private void btnretorno_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
