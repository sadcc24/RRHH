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
    
    public partial class frmconsultafestivos : Form
    {
        public frmconsultafestivos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvbuscar.DataSource = capa_logica_vacaciones.Buscarferiados(dfechainicio.Text);
        }
        public capa_presentacion_festivos fiestaseleccionada { get; set; }
        private void button2_Click(object sender, EventArgs e)
        {
           
            if (dgvbuscar.SelectedRows.Count == 1)
            {
                int pId = Convert.ToInt32(dgvbuscar.CurrentRow.Cells[0].Value);
               fiestaseleccionada = capa_logica_vacaciones.Obtenerfiestas(pId);
                this.Close();
            }
            else
                MessageBox.Show("debe de seleccionar una fila");
        }

        private void frmconsultafestivos_Load(object sender, EventArgs e)
        {
          
        }
    }

}
  