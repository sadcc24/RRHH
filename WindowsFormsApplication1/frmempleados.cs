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
    public partial class frmempleados : Form
    {
        public string idempleado;
        string empleado;
        public static SqlConnection SQL_Conexion = new SqlConnection();

        public frmempleados(string empr)
        {
            InitializeComponent();
            empleado = empr;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Size = new Size(665,606);
            string idempleado = dataGridView1[8, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            DataTable data = new capa_negocio_Empleado().GetEmpleadoDatos(idempleado);
            
            txtNombre1.Text = (string)data.Rows[0][0];
            txtNombre2.Text = (string)data.Rows[0][1];
            txtApellido1.Text = (string)data.Rows[0][2];
            txtApellido2.Text = (string)data.Rows[0][3];
            txtApellido3.Text = (string)data.Rows[0][4];
            txtDireccion.Text = (string)data.Rows[0][5];
            txtFecha.Text = ((DateTime)data.Rows[0][6]).ToString("yyyy-MM-dd");
            txtIdentificacion.Text = (string)data.Rows[0][7];
            txtSexo.Text = (string)data.Rows[0][8];
            txtNacionalidad.Text = (string)data.Rows[0][9];
            txtTelefono.Text = Convert.ToString((int)data.Rows[0][10]);
            txtJornada.Text = (string)data.Rows[0][11];
            txtSueldo.Text = Convert.ToString((decimal)data.Rows[0][12]);
            txtAumento.Text = Convert.ToString((decimal)data.Rows[0][13]);
            txtIniciolaboral.Text = (string)data.Rows[0][14];
            txtPuesto.Text = (string)data.Rows[0][15];
            txtDepartamento.Text = (string)data.Rows[0][16];
            string estado = (string)data.Rows[0][16];
            if (estado == "1")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
                

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(665, 322);
            label9.Text = empleado;
            carga_gried();
        }

        private void carga_gried()
        {
            try
            {
                DataTable DT_dat = new capa_negocio_Empleado().GetEmpleadoGrid();
                this.dataGridView1.DataSource = DT_dat;
                SQL_Conexion.Close();
            }
            catch (Exception ei)
            {
                MessageBox.Show("Ocurrio un error" + ei.Message);
            }
        }


        private void button8_Click(object sender, EventArgs e)
        {
            txtJornada.Enabled = true;
            txtSueldo.Enabled = true;
            txtAumento.Enabled = true;
            txtIniciolaboral.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Size = new Size(665, 322);
            txtJornada.Clear();
            txtSueldo.Clear();
            txtAumento.Clear();
            txtIniciolaboral.Clear();
        }
    }
}
