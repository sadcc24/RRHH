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
using Navegador;
namespace WindowsFormsApplication1

{
    public partial class frmaceptacion : Form
    {
        string empresamdi;
        int rol;
        string sueldo;
        string aumento;
        int idempresa;
        int candidato;
        string empleado;
        string jornada;
        string fotografia;
        public static SqlConnection SQL_Conexion = new SqlConnection();
        public frmaceptacion(string emp, int idemp)
        {
            InitializeComponent();
            idempresa = idemp;
            empresamdi = emp;
        }

        private void Aceptacion_Load(object sender, EventArgs e)
        {
            label9.Text = empresamdi;
            byte[] arr;
            carga_gried();
            DataTable data = new capa_negocio_Empleado().obtieneRol();
            cmbRol.DataSource = data;
            cmbRol.ValueMember = "idrol";
            cmbRol.DisplayMember = "rol";
        }
        private void carga_gried()
        {
            try
            {
                DataTable DT_dat = new capa_negocio_Empleado().GetEmpleadoGridCandidato();
                this.dataGridView1.DataSource = DT_dat;
                SQL_Conexion.Close();
            }
            catch (Exception ei)
            {
                MessageBox.Show("Ocurrio un error" + ei.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            candidato = Convert.ToInt32(dataGridView1[8, dataGridView1.CurrentCell.RowIndex].Value.ToString());
            empleado = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            fotografia = dataGridView1[9, dataGridView1.CurrentCell.RowIndex].Value.ToString();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            rol = Convert.ToInt32(cmbRol.SelectedValue);
            sueldo = txtsueldo.Text;
            aumento = txtaumento.Text;
            

            try
            {
                if (txtsueldo.Text == "" || cmbRol.Text == "")
                {
                    MessageBox.Show("Existe uno o mas campos Vacios");
                }
                else
                {
                    #region llena variables
                    rol = Convert.ToInt32(cmbRol.SelectedValue);
                    sueldo = txtsueldo.Text;
                    aumento = txtaumento.Text;
                    jornada = txtJornada.Text;
                    #endregion
                    if (MessageBox.Show("Desea Contratar al Empleado: " + empleado + " ?", "Aceptacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int result = new capa_negocio_Empleado().decandidatoaempleado(jornada, rol, sueldo, aumento, idempresa, candidato);
                        if (result > 0)
                        {
                            MessageBox.Show("Nuevo Empleado " + empleado + " Creado Correctamente", "Empleado");
                            carga_gried();
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un error al contratar el Empleado " + empleado, "Empleado");
                        }
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error en el Software o BD:" + ex.ToString(), "Empleado");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            txtaumento.Enabled = true;
            txtJornada.Enabled = true;
            txtsueldo.Enabled = true;
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(dataGridView1);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(dataGridView1);
        }

        private void btnAtrasfin_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(dataGridView1);
        }

        private void btnAdelantefin_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(dataGridView1);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cmbRol.Text = "Seleccionar";
            cmbRol.Enabled = false;
            txtaumento.Enabled = false;
            txtJornada.Enabled = false;
            txtsueldo.Enabled = false;
            txtaumento.Clear();
            txtJornada.Clear();
            txtsueldo.Clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            carga_gried();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"c:\ayuda.pdf");
        }
    }
}
