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
    public partial class frmtipousuario : Form
    {
        int idempleado;
        string empresamdi;
        int empresaidmdi;
        int empresaid;
        string usuario;
        public static SqlConnection SQL_Conexion = new SqlConnection();
        public frmtipousuario(string emp, int idemp)
        {
            InitializeComponent();
            empresamdi = emp;
            empresaidmdi = idemp;
        }

        private void frmtipousuario_Load(object sender, EventArgs e)
        {
            carga_gried();
        }
        private void carga_gried()
        {
            try
            {
                DataTable DT_dat = new capa_negocio_Empleado().GetTipoGrid();
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

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int result2 = new capa_negocio_Empleado().InsertaRol(txtactual.Text);
            if (result2 > 0)
            {
                MessageBox.Show("Rol: " + usuario + "Creado Correctamente", "Empleado");
                txtactual.Clear();
                button3.Enabled = false;
                carga_gried();
                txtactual.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error al crear el Rol: " + usuario, "Empleado");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtactual.Enabled = true;
            button3.Enabled = true;
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
