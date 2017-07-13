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
    public partial class frmenrevistageneral : Form
    {
        public frmenrevistageneral()
        {
            InitializeComponent();
        }
        capa_logica_Reclutamiento pt = new capa_logica_Reclutamiento(); 
        private void button2_Click(object sender, EventArgs e)
        {
            frmentrevista ventanaP = new frmentrevista();
            ventanaP.Show();
        }

        private void frmenrevistageneral_Load(object sender, EventArgs e)
        {
            pt.consulta("select e.identrevista, e.idcandidato, c.nombre1, c.apellido1, c.idestadocandidato,e.idpuestodetrabajo, pt.nombrepuesto, e.idetapaentrevista, et.descripcion, e.fecha, e.horario from Entrevista e inner join Candidato c on e.idcandidato=c.idcandidato inner join Puestodetrabajo pt on e.idpuestodetrabajo = pt.idpuestodetrabajo inner join etapaentrevista et on e.idetapaentrevista = et.idetapaentrevista", "Entrevista");
            dataGridView1.DataSource = pt.ds.Tables["Entrevista"];
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[7].Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            pt.consulta("select e.identrevista, e.idcandidato, c.nombre1, c.apellido1, c.idestadocandidato,e.idpuestodetrabajo, pt.nombrepuesto, e.idetapaentrevista, et.descripcion, e.fecha, e.horario from Entrevista e inner join Candidato c on e.idcandidato=c.idcandidato inner join Puestodetrabajo pt on e.idpuestodetrabajo = pt.idpuestodetrabajo inner join etapaentrevista et on e.idetapaentrevista = et.idetapaentrevista", "Entrevista");
            dataGridView1.DataSource = pt.ds.Tables["Entrevista"];
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[7].Visible = false;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmentrevista cargarentrevista = new frmentrevista();

            cargarentrevista.txtidentrevista.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cargarentrevista.txtidcandidato.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cargarentrevista.txtestadocandidato.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            cargarentrevista.txtidpuestodetrabajo.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            cargarentrevista.txtetapaentrevista.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            cargarentrevista.dateTimefecha.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            cargarentrevista.dateTimehora.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();

            cargarentrevista.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\EntrevistaGeneral.pdf");
        }
    }
}
