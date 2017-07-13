using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class frmfestivos : Form
    {

        public int idempleado;
        public capa_presentacion_festivos fiestaactual { get; set; }
        public frmfestivos()
        {
            InitializeComponent();

            cmbperiodo.DataSource = capa_logica_vacaciones.Obtenerperiodos();
            cmbperiodo.DisplayMember = "perdescripcion";
            cmbperiodo.ValueMember = "codperiodo";

           comboBox2.DataSource = capa_logica_vacaciones.Obtenerempleado();
           comboBox2.DisplayMember = "nombre1";
           comboBox2.ValueMember = "idempleado";
        }
       

        private void frmfestivos_Load(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            capa_presentacion_festivos pfestivo = new capa_presentacion_festivos();
            pfestivo.idempresa = Convert.ToInt32(comboBox1.SelectedValue);
            pfestivo.idempleado = Convert.ToInt32(comboBox2.SelectedValue); 
            pfestivo.fecha = dtpfecha.Text;
            pfestivo.descripcion = txtdescripcion.Text.Trim();
            pfestivo.codperiodo = Convert.ToInt32(cmbperiodo.SelectedValue);
            new capa_negocio_vacaciones().Insert_festivo(pfestivo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmconsultafestivos aa = new frmconsultafestivos();
            aa.ShowDialog();
           if (aa.fiestaseleccionada!=null) {
                fiestaactual = aa.fiestaseleccionada;
                comboBox2.SelectedValue = Convert.ToInt32(aa.fiestaseleccionada.idempleado);
                comboBox1.SelectedValue = Convert.ToInt32(aa.fiestaseleccionada.idempresa);
                txtdescripcion.Text = aa.fiestaseleccionada.descripcion;
                dtpfecha.Text = aa.fiestaseleccionada.fecha;
                cmbperiodo.SelectedValue = Convert.ToInt32(aa.fiestaseleccionada.codperiodo);
              

            }
            // fncCargacmb1();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.ValueMember != "")
            {
                comboBox1.DataSource = capa_logica_vacaciones.buscarempresa(comboBox2.SelectedValue.ToString());
                comboBox1.DisplayMember = "nombre_empresa";
                comboBox1.ValueMember = "idempresa";
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            capa_presentacion_festivos pfes = new capa_presentacion_festivos();
         pfes.idempleado = Convert.ToInt32(comboBox2.SelectedValue);
           pfes.idempresa = Convert.ToInt32(comboBox1.SelectedValue);
            pfes.codperiodo = Convert.ToInt32(cmbperiodo.SelectedValue);
            pfes.fecha = dtpfecha.Text.Trim();
            pfes.descripcion = txtdescripcion.Text.Trim();
            pfes.idempleado = fiestaactual.idempleado; // capa presentacion motivo actual

            if (capa_logica_vacaciones.modificarfestivo(pfes) > 0)
            {
                //  MessageBox.Show("Los datos del motivo se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //  MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            new capa_negocio_vacaciones().modificar_festivo(pfes);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            capa_presentacion_festivos pfes = new capa_presentacion_festivos();
            if (MessageBox.Show("Esta Seguro que desea eliminar el Feriado Actual", "Estas Seguro??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
             {
            if (capa_logica_vacaciones.Eliminarfestivo(fiestaactual.descripcion) > 0)
                {
                  
                    MessageBox.Show("Feriado Eliminado Correctamente!", "Feriado Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                MessageBox.Show("No se pudo eliminar el Feriado", "Feriado No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
           MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnretorno_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnayuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\MANUALDEAYUDA-festivos.pdf");
        }
    }
    }

