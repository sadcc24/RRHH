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
        string empleado;
        public static SqlConnection SQL_Conexion = new SqlConnection();

        public frmempleados(string empr)
        {
            InitializeComponent();
            empleado = empr;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Size = new Size(665, 521);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(665, 322);
            label9.Text = empleado;

        }

        private void carga_gried()
        {
            try
            {
                SqlDataAdapter SQL_da = new SqlDataAdapter("exec gridEmpleado", conexionbd_Empleado.ObtenerConexion());
                DataTable DT_dat = new DataTable();
                SQL_da.Fill(DT_dat);
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
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Size = new Size(665, 322);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }
    }
}
