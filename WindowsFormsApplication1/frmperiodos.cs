using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Navegador;
namespace WindowsFormsApplication1
{
    public partial class frmperiodos : Form
    {
        public frmperiodos()
        {
            
            InitializeComponent();
            List<capa_presentacion_formaciones.periodo> periodo = new List<capa_presentacion_formaciones.periodo>();
            periodo = capa_negocio_formaciones.consultaperiodo();

            dgvperiodo.DataSource = periodo;
            dgvperiodo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvperiodo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }



    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string idperiodo;
            string periodo;
            idperiodo = dgvperiodo[0, dgvperiodo.CurrentCell.RowIndex].Value.ToString();
            periodo = dgvperiodo[1, dgvperiodo.CurrentCell.RowIndex].Value.ToString();

            frmabcperiodos capa = new frmabcperiodos(idperiodo,periodo, "1");
            capa.MdiParent = this.MdiParent;
            capa.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<capa_presentacion_formaciones.periodo> periodo = new List<capa_presentacion_formaciones.periodo>();
            periodo = capa_negocio_formaciones.consultaperiodo();

            dgvperiodo.DataSource = periodo;
            dgvperiodo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvperiodo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmabcperiodos periodo = new frmabcperiodos("0", "0","0");
            periodo.MdiParent = this.MdiParent;
            periodo.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(dgvperiodo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(dgvperiodo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(dgvperiodo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(dgvperiodo);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\ConsultaPeriodo-mike.pdf");
        }
    }
}
