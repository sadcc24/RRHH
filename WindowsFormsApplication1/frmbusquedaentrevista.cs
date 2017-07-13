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
    public partial class frmbusquedeentrevista : Form
    {
        public frmbusquedeentrevista()
        {
            InitializeComponent();
        }
        capa_logica_Reclutamiento clr = new capa_logica_Reclutamiento();
        private void frmbusquedeentrevista_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Resultado_Pueba resultadop = new Resultado_Pueba();
            resultadop.txtidentrevista.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            resultadop.txtidcandidato.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            resultadop.txtetapaentrevista.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            this.Close();
            resultadop.Show();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            clr.consultarentrevista("DETALLEENTREVISTA");
            dataGridView1.DataSource = clr.ds.Tables["DETALLEENTREVISTA"];
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[1].Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            clr.consultarentrevista2("DETALLEENTREVISTA");
            dataGridView1.DataSource = clr.ds.Tables["DETALLEENTREVISTA"];
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[1].Visible = false;
        }
    }
}
