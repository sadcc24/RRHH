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
    public partial class frmperiodo : Form
    {

        public capa_presentacion_periodo periodoactual { get; set; }
        public frmperiodo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmperiodo_Load(object sender, EventArgs e)
        {

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
           txtdescripcion.Enabled = true;
            comboBox1.Enabled = true;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            capa_presentacion_periodo pfestivo = new capa_presentacion_periodo();
            pfestivo.perdescripcion = txtdescripcion.Text.Trim();
            pfestivo.perestatus = comboBox1.Text.Trim();
            new capa_negocio_vacaciones().Insert_periodoo(pfestivo);
            txtdescripcion.Enabled = false;
            comboBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmconsultaperiodo buscar = new frmconsultaperiodo();
            buscar.ShowDialog();


            if (buscar.periodoseleccionado != null)
            {
                periodoactual = buscar.periodoseleccionado;
                txtdescripcion.Text = buscar.periodoseleccionado.perdescripcion;
                comboBox1.Text = buscar.periodoseleccionado.perestatus;
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            capa_presentacion_periodo pperiodoo = new capa_presentacion_periodo();
            pperiodoo.perdescripcion = txtdescripcion.Text.Trim();
            pperiodoo.perestatus = comboBox1.Text.Trim();
            pperiodoo.codperiodo = periodoactual.codperiodo; // capa presentacion motivo actual

            if (capa_logica_vacaciones.modificarperiodoo(pperiodoo) > 0)
            {
                //  MessageBox.Show("Los datos del motivo se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //  MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            new capa_negocio_vacaciones().modificar_periodoo(pperiodoo);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            capa_presentacion_periodo pmotivo = new capa_presentacion_periodo();
            if (MessageBox.Show("Esta Seguro que desea eliminar el periodo Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (capa_logica_vacaciones.Eliminarperiodoo(periodoactual.codperiodo) > 0)
                {

                    MessageBox.Show("Periodo Eliminado Correctamente!", "Motivo Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el periodo", "Motivo No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
                MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtdescripcion.Enabled = false;
            comboBox1.Enabled = false;
        }

        private void btnretorno_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
 }

