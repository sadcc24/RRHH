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

        public capa_presentacion_vacaciones motivoactual { get; set; }
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

        private void frmmotivo_Load(object sender, EventArgs e)
        {
            /*
              conexionbd.ObtenerConexion();
              MessageBox.Show("conexion correcta");*/
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            capa_presentacion_vacaciones pmotivo = new capa_presentacion_vacaciones();
            pmotivo.motivo = txtmotivo.Text.Trim();
            pmotivo.descripcion = txtdescripcion.Text.Trim();
            new capa_negocio_vacaciones().Insert_Motivo(pmotivo);
            txtmotivo.Enabled = false;
            txtdescripcion.Enabled = false;
        }
        

     

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmconsultarmotivo buscar = new frmconsultarmotivo();
            buscar.ShowDialog();


            if (buscar.motivoseleccionado != null)
            {
                motivoactual = buscar.motivoseleccionado;
                txtmotivo.Text = buscar.motivoseleccionado.motivo;
                txtdescripcion.Text = buscar.motivoseleccionado.descripcion;
            }
        }

  

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            capa_presentacion_vacaciones pmotivo = new capa_presentacion_vacaciones();
            pmotivo.motivo = txtmotivo.Text.Trim();
            pmotivo.descripcion = txtdescripcion.Text.Trim();
            pmotivo.codmotivo = motivoactual.codmotivo; // capa presentacion motivo actual

            if (capa_logica_vacaciones.modificarmotivo(pmotivo) > 0)
            {
                //  MessageBox.Show("Los datos del motivo se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //  MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            new capa_negocio_vacaciones().modificar_motivo(pmotivo);
        }

        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            capa_presentacion_vacaciones pmotivo = new capa_presentacion_vacaciones();
            if (MessageBox.Show("Esta Seguro que desea eliminar el Motivo Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (capa_logica_vacaciones.Eliminarmotivo(motivoactual.codmotivo) > 0)
                {

                    MessageBox.Show("Motivo Eliminado Correctamente!", "Motivo Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el Motivo", "Motivo No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
    }
}
