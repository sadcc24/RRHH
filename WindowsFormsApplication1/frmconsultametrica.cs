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
    public partial class frmconsultametrica : Form
    {

        string idempresa;
        public frmconsultametrica(string empresa)
        {
            idempresa = empresa;
            InitializeComponent();
            List<capa_presentacion_formaciones.metrica> metrica = capa_negocio_formaciones.consultametrica(idempresa);

            dgvmetrica.DataSource = metrica;
            dgvmetrica.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvmetrica.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<capa_presentacion_formaciones.metrica> metrica = capa_negocio_formaciones.consultametrica(idempresa);

            dgvmetrica.DataSource = metrica;
            dgvmetrica.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvmetrica.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dgvmetrica_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string idmetrica, nombre, descripcion, empresa, departamento;
            idmetrica = dgvmetrica[0, dgvmetrica.CurrentCell.RowIndex].Value.ToString();
            nombre=dgvmetrica[1, dgvmetrica.CurrentCell.RowIndex].Value.ToString();
            descripcion=dgvmetrica[2, dgvmetrica.CurrentCell.RowIndex].Value.ToString();
            empresa=dgvmetrica[3, dgvmetrica.CurrentCell.RowIndex].Value.ToString();
            departamento=dgvmetrica[4, dgvmetrica.CurrentCell.RowIndex].Value.ToString();


            frmabcmetrica capa = new frmabcmetrica(idempresa,idmetrica,nombre,descripcion,empresa,departamento,"1");
            capa.MdiParent = this.MdiParent;
            capa.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(dgvmetrica);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(dgvmetrica);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(dgvmetrica);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(dgvmetrica);
        }
    }
}
