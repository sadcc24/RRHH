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

    public partial class frmpruebas : Form
    {
        public frmpruebas()
        {
            InitializeComponent();
        }

        capa_logica_Reclutamiento con = new capa_logica_Reclutamiento();
        capa_negocio_Reclutamiento cnr = new capa_negocio_Reclutamiento();
        private void button2_Click(object sender, EventArgs e)
        {
            Resultado_Pueba ventanaP = new Resultado_Pueba();
            ventanaP.Show();
        }

        private void frmpruebas_Load(object sender, EventArgs e)
        {
            cnr.consultatdentrevista(dataGridView1);
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[1].Visible = false;
            this.dataGridView1.Columns[2].Visible = false;
            this.dataGridView1.Columns[3].Visible = false;
            this.dataGridView1.Columns[14].Visible = false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Resultado_Pueba rp = new Resultado_Pueba();

            rp.txtiddetalle.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            rp.txtidentrevista.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            rp.txtidcandidato.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            rp.txtetapaentrevista.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            rp.txtcomentario.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            rp.txtresultado1.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            rp.txtresultado2.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            rp.txtresultado3.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            rp.Show();
            rp.txtresultado1.Enabled = false;
            rp.txtresultado2.Enabled = false;
            rp.txtresultado3.Enabled = false;
            rp.txtcomentario.Enabled = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            cnr.consultatdentrevista(dataGridView1);
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[1].Visible = false;
            this.dataGridView1.Columns[2].Visible = false;
            this.dataGridView1.Columns[3].Visible = false;
            this.dataGridView1.Columns[14].Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\PruebaGeneral.pdf");
        }
    }
}
