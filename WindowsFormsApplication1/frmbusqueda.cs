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
    public partial class frmbusqueda : Form
    {
        public frmbusqueda()
        {
            InitializeComponent();
        }

        capa_logica_Reclutamiento clr = new capa_logica_Reclutamiento();
        private void frmbusqueda_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmentrevista entrevista = new frmentrevista();
            entrevista.txtidcandidato.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            entrevista.txtestadocandidato.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            entrevista.txtidpuestodetrabajo.Text = dataGridView1.Rows[e.RowIndex].Cells[18].Value.ToString();
            this.Close();
            entrevista.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtidetapa_TextChanged(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            clr.consultarcandidato("CANDIDATO");
            dataGridView1.DataSource = clr.ds.Tables["CANDIDATO"];
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            clr.consultarcandidato2("CANDIDATO");
            dataGridView1.DataSource = clr.ds.Tables["CANDIDATO"];
        }
    }
}
