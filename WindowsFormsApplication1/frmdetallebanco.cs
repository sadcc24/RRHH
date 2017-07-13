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
    public partial class frmdetallebanco : Form
    {
        public frmdetallebanco()
        {
            InitializeComponent();
        }

        capa_logica_Reclutamiento clr = new capa_logica_Reclutamiento();
        capa_negocio_Reclutamiento cnr = new capa_negocio_Reclutamiento();
        private void frmdetallebanco_Load(object sender, EventArgs e)
        {
            cnr.consultaestudios(dataGridView1, txtidcandidato);
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[4].Visible = false;
            this.dataGridView1.Columns[5].Visible = false;


            cnr.consultaexperiencialab(dataGridView2, txtidcandidato);
            this.dataGridView2.Columns[0].Visible = false;
            this.dataGridView2.Columns[4].Visible = false;
            this.dataGridView1.Columns[5].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Activar al Candidato", "Activación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                    clr.updatecandidato1(this.txtidcandidato.Text);
                    MessageBox.Show("Candidato Activado correcramente");
                    this.Close();
            }
                else
                {

         }

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtidcandidato_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
