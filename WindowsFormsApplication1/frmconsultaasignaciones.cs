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
    public partial class frmconsultaasignaciones : Form
    {
        string usuario;
        public frmconsultaasignaciones(string user)
        {
            InitializeComponent();
            usuario = user;
            List<capa_presentacion_formaciones.asignacion> asig = capa_negocio_formaciones.consulta_info(usuario);

            dgvasignaciones.DataSource = asig;

            dgvasignaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvasignaciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void dgvasignaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string  idcapacitacion, nombre, asignaciones;
            idcapacitacion = dgvasignaciones[0, dgvasignaciones.CurrentCell.RowIndex].Value.ToString();
            nombre = dgvasignaciones[1, dgvasignaciones.CurrentCell.RowIndex].Value.ToString();
            asignaciones = dgvasignaciones[2, dgvasignaciones.CurrentCell.RowIndex].Value.ToString();

        
            List<capa_presentacion_formaciones.detaasig> detasig = capa_negocio_formaciones.detasi(idcapacitacion,usuario);
            dgvdet2.DataSource = detasig;
            dgvdet2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvdet2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;




        }

        private void dgvdet2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string idasignacion;
            idasignacion = dgvdet2[0, dgvdet2.CurrentCell.RowIndex].Value.ToString();
            List<capa_presentacion_formaciones.infodetasig> detasign = capa_negocio_formaciones.infodet(idasignacion);
            dgvdet2.DataSource = detasign;
            dgvdet2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvdet2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string idempresa = usuario;
            List<capa_presentacion_formaciones.asignacion> asig = capa_negocio_formaciones.consulta_info(idempresa);
            dgvasignaciones.DataSource = asig;
            dgvasignaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvasignaciones.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            asignacion_capacitaciones ventanaP = new asignacion_capacitaciones("0", "0", usuario);
            ventanaP.MdiParent = this.MdiParent;
            ventanaP.Show();
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(dgvasignaciones);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(dgvasignaciones);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(dgvasignaciones);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(dgvasignaciones);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(dgvdet2);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(dgvdet2);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(dgvdet2);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(dgvdet2);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\ConsultaAsignacionCapacitaciones-mike.pdf");
        }
    }
}
