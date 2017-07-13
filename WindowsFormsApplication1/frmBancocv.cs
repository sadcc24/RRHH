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
    public partial class frmBancocv : Form
    {
        public frmBancocv()
        {
            InitializeComponent();
        }
        capa_logica_Reclutamiento clr = new capa_logica_Reclutamiento();
        private void button5_Click(object sender, EventArgs e)
        {
            clr.consultarBancocv("Personas");
            dgvbanco.DataSource = clr.ds.Tables["Personas"];
            dgvbanco.Columns[0].Visible = false;
            dgvbanco.Columns[1].Visible = false;
            dgvbanco.Columns[2].Visible = false;
            dgvbanco.Columns[4].Visible = false;
            dgvbanco.Columns[6].Visible = false;
            dgvbanco.Columns[14].Visible = false;
            dgvbanco.Columns[19].Visible = false;
            dgvbanco.Columns[24].Visible = false;
        }

        private void frmBancocv_Load(object sender, EventArgs e)
        {
            clr.consultarBancocv("Personas");
            dgvbanco.DataSource = clr.ds.Tables["Personas"];
            dgvbanco.Columns[0].Visible = false;
            dgvbanco.Columns[1].Visible = false;
            dgvbanco.Columns[2].Visible = false;
            dgvbanco.Columns[4].Visible = false;
            dgvbanco.Columns[6].Visible = false;
            dgvbanco.Columns[14].Visible = false;
            dgvbanco.Columns[19].Visible = false;
            dgvbanco.Columns[24].Visible = false;



        }

        private void dgvbanco_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmdetallebanco bancocv = new frmdetallebanco();
            bancocv.txtidcandidato.Text = dgvbanco.Rows[e.RowIndex].Cells[0].Value.ToString();
            bancocv.txtsexo.Text = dgvbanco.Rows[e.RowIndex].Cells[5].Value.ToString();
            bancocv.txtn1.Text = dgvbanco.Rows[e.RowIndex].Cells[8].Value.ToString();
            bancocv.txtn2.Text = dgvbanco.Rows[e.RowIndex].Cells[9].Value.ToString();
            bancocv.txta1.Text = dgvbanco.Rows[e.RowIndex].Cells[10].Value.ToString();
            bancocv.txta2.Text = dgvbanco.Rows[e.RowIndex].Cells[11].Value.ToString();
            bancocv.txta3.Text = dgvbanco.Rows[e.RowIndex].Cells[12].Value.ToString();
            bancocv.txtdireccion.Text = dgvbanco.Rows[e.RowIndex].Cells[13].Value.ToString();
            bancocv.txttelefono.Text = dgvbanco.Rows[e.RowIndex].Cells[14].Value.ToString();
            bancocv.txtestadocivil.Text = dgvbanco.Rows[e.RowIndex].Cells[3].Value.ToString();
            bancocv.txtnacionalidad.Text = dgvbanco.Rows[e.RowIndex].Cells[7].Value.ToString();
            bancocv.txtidentificacion.Text = dgvbanco.Rows[e.RowIndex].Cells[15].Value.ToString();
            bancocv.txtpuesto.Text = dgvbanco.Rows[e.RowIndex].Cells[25].Value.ToString();
            bancocv.dateTimePicker1.Text = dgvbanco.Rows[e.RowIndex].Cells[16].Value.ToString();

            clr.verimagen(bancocv.pictureBox1, bancocv.txtidcandidato);
            bancocv.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\BancoGeneral.pdf");
        }
    }
}
