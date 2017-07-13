using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class frmcandidatos : Form
    {
        public frmcandidatos()
        {
            InitializeComponent();
        }
 
        capa_logica_Reclutamiento clr = new capa_logica_Reclutamiento();
        capa_negocio_Reclutamiento cnr = new capa_negocio_Reclutamiento();
        private void button2_Click(object sender, EventArgs e)
        {
            frmcandidatonuevo ventanaP = new frmcandidatonuevo();
            ventanaP.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cnr.consultacandidato(dgvCandidatos);
            this.dgvCandidatos.Columns[2].Visible = false;
            this.dgvCandidatos.Columns[4].Visible = false;
            this.dgvCandidatos.Columns[6].Visible = false;
            this.dgvCandidatos.Columns[17].Visible = false;
            this.dgvCandidatos.Columns[18].Visible = false;
        }

        private void frmcandidatos_Load(object sender, EventArgs e)
        {
            cnr.consultacandidato(dgvCandidatos);
            this.dgvCandidatos.Columns[2].Visible = false;
            this.dgvCandidatos.Columns[4].Visible = false;
            this.dgvCandidatos.Columns[6].Visible = false;
            this.dgvCandidatos.Columns[17].Visible = false;
            this.dgvCandidatos.Columns[18].Visible = false;
        }
        private void dgvCandidatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvCandidatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCandidatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmcandidatonuevo cargardatoscandidato = new frmcandidatonuevo();

            cargardatoscandidato.txtcodigocandidato.Text = dgvCandidatos.Rows[e.RowIndex].Cells[0].Value.ToString();
            cargardatoscandidato.txtestadocandidato.Text = dgvCandidatos.Rows[e.RowIndex].Cells[1].Value.ToString();
            cargardatoscandidato.txtestadocivilcandidato.Text = dgvCandidatos.Rows[e.RowIndex].Cells[2].Value.ToString();
            cargardatoscandidato.txtsexocandidato.Text = dgvCandidatos.Rows[e.RowIndex].Cells[4].Value.ToString();
            cargardatoscandidato.txtnacioncandidato.Text = dgvCandidatos.Rows[e.RowIndex].Cells[6].Value.ToString();

            cargardatoscandidato.textBox1.Text = dgvCandidatos.Rows[e.RowIndex].Cells[8].Value.ToString();
            cargardatoscandidato.textBox2.Text = dgvCandidatos.Rows[e.RowIndex].Cells[9].Value.ToString();
            cargardatoscandidato.textBox4.Text = dgvCandidatos.Rows[e.RowIndex].Cells[10].Value.ToString();
            cargardatoscandidato.textBox3.Text = dgvCandidatos.Rows[e.RowIndex].Cells[11].Value.ToString();
            cargardatoscandidato.textBox8.Text = dgvCandidatos.Rows[e.RowIndex].Cells[12].Value.ToString();
            cargardatoscandidato.textBox6.Text = dgvCandidatos.Rows[e.RowIndex].Cells[13].Value.ToString();
            cargardatoscandidato.textBox7.Text = dgvCandidatos.Rows[e.RowIndex].Cells[14].Value.ToString();
            cargardatoscandidato.textBox5.Text = dgvCandidatos.Rows[e.RowIndex].Cells[15].Value.ToString();
            cargardatoscandidato.dateTimePicker1.Text = dgvCandidatos.Rows[e.RowIndex].Cells[16].Value.ToString();
            cargardatoscandidato.txtidpuesto.Text = dgvCandidatos.Rows[e.RowIndex].Cells[18].Value.ToString();
            clr.verimagen(cargardatoscandidato.pictureBox1, cargardatoscandidato.txtcodigocandidato);
            cargardatoscandidato.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\CandidatoGeneral.pdf");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            clr.anteriordgv(dgvCandidatos);
        }

        private void button11_Click(object sender, EventArgs e)
        {
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
