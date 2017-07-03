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

        capa_logica_Reclutamiento con = new capa_logica_Reclutamiento();
        capa_negocio_Reclutamiento con2 = new capa_negocio_Reclutamiento();
        private void button2_Click(object sender, EventArgs e)
        {
            frmcandidatonuevo ventanaP = new frmcandidatonuevo();
            ventanaP.Show();
        }

        private void frmcandidatos_Load(object sender, EventArgs e)
        {
            con.consulta("select * from CANDIDATO where idestadocandidato = 1", "CANDIDATO");
            dgvCandidato.DataSource = con.ds.Tables["CANDIDATO"];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.consulta("select * from CANDIDATO where idestadocandidato = 1", "CANDIDATO");
            dgvCandidato.DataSource = con.ds.Tables["CANDIDATO"];
        }

        private void dgvCandidato_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmcandidatonuevo cargardatoscandidato = new frmcandidatonuevo();

            cargardatoscandidato.txtcodigocandidato.Text = dgvCandidato.Rows[e.RowIndex].Cells[0].Value.ToString();
            cargardatoscandidato.txtestadocandidato.Text = dgvCandidato.Rows[e.RowIndex].Cells[1].Value.ToString();
            cargardatoscandidato.txtestadocivilcandidato.Text = dgvCandidato.Rows[e.RowIndex].Cells[2].Value.ToString();
            cargardatoscandidato.txtsexocandidato.Text = dgvCandidato.Rows[e.RowIndex].Cells[3].Value.ToString();
            cargardatoscandidato.txtnacioncandidato.Text = dgvCandidato.Rows[e.RowIndex].Cells[4].Value.ToString();

            cargardatoscandidato.textBox1.Text = dgvCandidato.Rows[e.RowIndex].Cells[5].Value.ToString();
            cargardatoscandidato.textBox2.Text = dgvCandidato.Rows[e.RowIndex].Cells[6].Value.ToString();
            cargardatoscandidato.textBox4.Text = dgvCandidato.Rows[e.RowIndex].Cells[7].Value.ToString();
            cargardatoscandidato.textBox3.Text = dgvCandidato.Rows[e.RowIndex].Cells[8].Value.ToString();
            cargardatoscandidato.textBox8.Text = dgvCandidato.Rows[e.RowIndex].Cells[9].Value.ToString();
            cargardatoscandidato.textBox6.Text = dgvCandidato.Rows[e.RowIndex].Cells[10].Value.ToString();
            cargardatoscandidato.textBox7.Text = dgvCandidato.Rows[e.RowIndex].Cells[11].Value.ToString();
            cargardatoscandidato.textBox5.Text = dgvCandidato.Rows[e.RowIndex].Cells[12].Value.ToString();
            cargardatoscandidato.dateTimePicker1.Text = dgvCandidato.Rows[e.RowIndex].Cells[13].Value.ToString();
            con.verimagen(cargardatoscandidato.pictureBox1, cargardatoscandidato.txtcodigocandidato);
            cargardatoscandidato.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process pr = new Process();
            pr.StartInfo.WorkingDirectory = @"C:\Users\VICTOR RODAS\Documents\GitHub\RRHH\WindowsFormsApplication1\ayuda\";
            pr.StartInfo.FileName = "Ayuda Candidato.pdf";
            pr.Start();

        }
    }
}
