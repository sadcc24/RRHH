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
    public partial class frmconsultaarea : Form
    {

        
        public frmconsultaarea()
        {
            
            InitializeComponent();

            List<capa_presentacion_formaciones.area> area = capa_negocio_formaciones.consultaarea();

            dgvconsultarea.DataSource = area;

            dgvconsultarea.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvconsultarea.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<capa_presentacion_formaciones.area> area = capa_negocio_formaciones.consultaarea();

            dgvconsultarea.DataSource = area;

            dgvconsultarea.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvconsultarea.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void button5_Click(object sender, EventArgs e)
        {   
            frmcreacionarea ventanaP = new frmcreacionarea("0","0","0","0");
            ventanaP.MdiParent = this.MdiParent;
            ventanaP.Show();
        }

        private void dgvconsultarea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string idarea, nombre, descripcion;
            idarea = dgvconsultarea[0, dgvconsultarea.CurrentCell.RowIndex].Value.ToString();
            nombre = dgvconsultarea[1, dgvconsultarea.CurrentCell.RowIndex].Value.ToString();
            descripcion = dgvconsultarea[2, dgvconsultarea.CurrentCell.RowIndex].Value.ToString();

            frmcreacionarea ventanaP = new frmcreacionarea("1",idarea,nombre,descripcion);
            ventanaP.MdiParent = this.MdiParent;
            ventanaP.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(dgvconsultarea);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(dgvconsultarea);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(dgvconsultarea);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(dgvconsultarea);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\ConsultaAreaCapacitaciones-mike.pdf");
        }
    }
}
