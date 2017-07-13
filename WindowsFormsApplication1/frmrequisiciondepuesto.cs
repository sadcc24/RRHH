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
    public partial class frmrequisiciondepuesto : Form
    {
        public frmrequisiciondepuesto()
        {
            InitializeComponent();
        }
        capa_logica_Reclutamiento pt = new capa_logica_Reclutamiento();
        capa_negocio_Reclutamiento cnr = new capa_negocio_Reclutamiento();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Requisiciondepuesto_Load(object sender, EventArgs e)
        {
            pt.consulta("select * from PUESTODETRABAJO where idestadopuesto = 1", "PUESTO");
            dataGridView1.DataSource = pt.ds.Tables["PUESTO"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nuevo_Puesto ventanaP = new Nuevo_Puesto();
            ventanaP.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            pt.consulta("select * from PUESTODETRABAJO where idestadopuesto = 1", "PUESTO");
            dataGridView1.DataSource = pt.ds.Tables["PUESTO"];
        }
        
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Nuevo_Puesto cargarpuesto = new Nuevo_Puesto();

            cargarpuesto.txtidpuesto.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cargarpuesto.txtdepartamento.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cargarpuesto.txtestadopuesto.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cargarpuesto.txtnombrepuesto.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cargarpuesto.txtempresa.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            cargarpuesto.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\PuestosGeneral.pdf");
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
