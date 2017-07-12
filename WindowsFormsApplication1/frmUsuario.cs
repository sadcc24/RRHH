using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Navegador;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class frmUsuario : Form
    {
        int idempleado;
        string empresamdi;
        int empresaidmdi;
        int empresaid;
        string usuario;
        public static SqlConnection SQL_Conexion = new SqlConnection();
        public frmUsuario(string emp, int idemp)
        {
            InitializeComponent();
            empresamdi = emp;
            //empresaidmdi = idemp;
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            carga_gried();
        }
        private void carga_gried()
        {
            try
            {
                DataTable DT_dat = new capa_negocio_Empleado().GetUsuarioGrid();
                this.dataGridView1.DataSource = DT_dat;
                SQL_Conexion.Close();
            }
            catch (Exception ei)
            {
                MessageBox.Show("Ocurrio un error" + ei.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int result = new capa_negocio_Empleado().vepassword(idempleado, txtactual.Text);
                if (result > 0)
                {
                string pass = classEncryptD.Encrypt(txtnueva.Text);
                int result2 = new capa_negocio_Empleado().ActualizaPass(idempleado, pass);
                if (result2 > 0)
                {
                    MessageBox.Show("Contraseña Actualizada de Usuario " + usuario + " Correctamente", "Empleado");
                    txtnueva.Clear();
                    txtactual.Clear();
                    button3.Enabled = false;
                    carga_gried();
                    txtactual.Enabled = false;
                    txtnueva.Enabled = false;
                }
                //MessageBox.Show(desencr);
                    carga_gried();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al actualizar la contraseña", "Empleado");
                }

            }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            txtactual.Enabled = true;
            txtnueva.Enabled = true;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            carga_gried();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idempleado = Convert.ToInt32(dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString());
            usuario = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            //DataTable data = new capa_negocio_Empleado().GetContraseña(Convert.ToString(idempleado));
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtactual.Enabled = false;
            txtnueva.Enabled = false;
            txtnueva.Clear();
            txtactual.Clear();
            button3.Enabled = false;
            carga_gried();
        }

        private void btnAdelantefin_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(dataGridView1);
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
    }
}
