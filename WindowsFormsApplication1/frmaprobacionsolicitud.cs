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
    public partial class frmaprobacionsolicitud : Form
    {
        public frmaprobacionsolicitud()
        {
            InitializeComponent();
            dgvsolicitud.DataSource = capa_logica_vacaciones.Obtenerdatossolicitud(comboBox1.Text);
        }
        public capa_presentacion_solicitud solicitudseleccionada { get; set; }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //informacion_solicitud frminfo = new informacion_solicitud();
            //frminfo.Show();
            //this.Close();
        }

        private void btnretorno_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\MANUALDEAYUDA-aprobacion.pdf");

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            dgvsolicitud.DataSource = capa_logica_vacaciones.Buscarsolicitud(comboBox1.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dgvsolicitud.SelectedRows.Count == 1)
            {
                int codsolicitud = Convert.ToInt32(dgvsolicitud.CurrentRow.Cells[0].Value);
                capa_presentacion_solicitud solicitud = capa_logica_vacaciones.Obtenersolicitud(codsolicitud);

                informacion_solicitud frm = new informacion_solicitud(solicitud);
                frm.Show();


                this.Close();
            }
            else
                MessageBox.Show("debe de seleccionar una fila");
        }

        private void frmaprobacionsolicitud_Load(object sender, EventArgs e)
        {

        }
    }
}
