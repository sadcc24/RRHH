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
    public partial class frmEstudios : Form
    {
        public frmEstudios()
        {
            InitializeComponent();
        }
        capa_logica_Reclutamiento clr = new capa_logica_Reclutamiento();
        capa_negocio_Reclutamiento cnr = new capa_negocio_Reclutamiento();

        private void frmEstudios_Load(object sender, EventArgs e)
        {
            clr.concatenar(txtidcandidato, txtnombrecandidato);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("No hay datos para guardar");
            }

            else
            {
                clr.InsertarDGV(dataGridView1, txtidcandidato);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow row = dt.NewRow();
            dt.Rows.Add(row);
            dataGridView1.DataSource = dt;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            cnr.consultaestudios(dataGridView1, txtidcandidato);
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[4].Visible = false;
            this.dataGridView1.Columns[5].Visible = false;
            button1.Enabled = false;
            button8.Enabled = false;
            button3.Enabled = true;
            button9.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            clr.modificar(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Descripción");
            dt.Columns.Add("Tipo de Estudios");
            dt.Columns.Add("Lugar");
            dataGridView1.DataSource = dt;
            button1.Enabled = true;
            button8.Enabled = true;
            button4.Enabled = true;
            txtcodigo.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("No hay datos para guardar");
            }

            else
            {
                clr.InsertarDGV(dataGridView1, txtidcandidato);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Se eliminara la información ¿Está seguro?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                clr.eliminardgv(txtcodigo);
                cnr.consultaestudios(dataGridView1, txtcodigo);
            }
            else
            {
                MessageBox.Show("Registro no Eliminado");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = dataGridView1.Rows[e.RowIndex];
            txtcodigo.Text = dgv.Cells[0].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Candidato.pdf");
        }
    }
}
