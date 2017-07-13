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
    public partial class frmExperienciaLaboral : Form
    {
        public frmExperienciaLaboral()
        {
            InitializeComponent();
        }

        capa_logica_Reclutamiento clr = new capa_logica_Reclutamiento();
        capa_negocio_Reclutamiento cnr = new capa_negocio_Reclutamiento();
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Descripción de Puesto");
            dt.Columns.Add("Lugar");
            dt.Columns.Add("Tiempo");
            dataGridView1.DataSource = dt;
            button4.Enabled = true;
            button6.Enabled = true;
            button8.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cnr.consultaexperiencialab(dataGridView1, txtidcandidato);
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[4].Visible = false;
            this.dataGridView1.Columns[5].Visible = false;
            button3.Enabled = true;
            button9.Enabled = true;
            button6.Enabled = false;
            button8.Enabled = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow row = dt.NewRow();
            dt.Rows.Add(row);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("No hay datos para guardar");
            }
            else
            {
                clr.InsertarDGV2(dataGridView1, txtidcandidato);
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            clr.modificar2(dataGridView1);
        }

        private void frmExperienciaLaboral_Load(object sender, EventArgs e)
        {
            clr.concatenar(txtidcandidato, txtnombrecandidato);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Se eliminara la información ¿Está seguro?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                clr.eliminardgv2(txtcodigo);
                cnr.consultaexperiencialab(dataGridView1, txtidcandidato);
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
