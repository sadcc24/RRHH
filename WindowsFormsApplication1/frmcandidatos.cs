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
    public partial class frmcandidatos : Form
    {
        public frmcandidatos()
        {
            InitializeComponent();
        }

        capa_logica_Reclutamiento con = new capa_logica_Reclutamiento();

        private void button2_Click(object sender, EventArgs e)
        {
            frmcandidatonuevo ventanaP = new frmcandidatonuevo();
            ventanaP.Show();
        }

        private void frmcandidatos_Load(object sender, EventArgs e)
        {
            con.consulta("select * from CANDIDATO", "CANDIDATO");
            dgvCandidato.DataSource = con.ds.Tables["CANDIDATO"];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.consulta("select * from CANDIDATO", "CANDIDATO");
            dgvCandidato.DataSource = con.ds.Tables["CANDIDATO"];
        }
    }
}
