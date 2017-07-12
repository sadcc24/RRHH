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
    public partial class frmcapacitaciones : Form
    {
        string usuario;
        public frmcapacitaciones(string user)
        {
            usuario = user;
            InitializeComponent();
            List<capa_presentacion_formaciones.info_capa> info_capacitaciones = capa_negocio_formaciones.capacitaciones(user);

            dgvCapacitaciones.DataSource = info_capacitaciones;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(dgvCapacitaciones);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string idcapacitacion, nombre, descripcion, expositor, costo, tipo;
            idcapacitacion = dgvCapacitaciones[0, dgvCapacitaciones.CurrentCell.RowIndex].Value.ToString();
            nombre = dgvCapacitaciones[1, dgvCapacitaciones.CurrentCell.RowIndex].Value.ToString();
            descripcion = dgvCapacitaciones[2, dgvCapacitaciones.CurrentCell.RowIndex].Value.ToString();
            expositor = dgvCapacitaciones[4, dgvCapacitaciones.CurrentCell.RowIndex].Value.ToString();
            tipo = dgvCapacitaciones[3, dgvCapacitaciones.CurrentCell.RowIndex].Value.ToString();
            costo = dgvCapacitaciones[5, dgvCapacitaciones.CurrentCell.RowIndex].Value.ToString();

            Detalle_Capacitacion capa = new Detalle_Capacitacion(idcapacitacion, nombre, descripcion, expositor, tipo, costo,usuario);
            
            capa.MdiParent = this.MdiParent;
            capa.Show();
            this.Close();
        }

        private void frmcapacitaciones_Load(object sender, EventArgs e)
        {

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {

            Detalle_Capacitacion capa = new Detalle_Capacitacion("0", "0", "0", "0", "0", "0",usuario);
            capa.MdiParent = this.MdiParent;
            capa.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            List<capa_presentacion_formaciones.info_capa> info_capacitaciones = capa_negocio_formaciones.capacitaciones(usuario);
            dgvCapacitaciones.DataSource = info_capacitaciones;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<capa_presentacion_formaciones.info_capa> info_capacitaciones = capa_negocio_formaciones.capacitaciones(usuario);

            dgvCapacitaciones.DataSource = info_capacitaciones;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Detalle_Capacitacion capa = new Detalle_Capacitacion("0", "0", "0", "0", "0", "0",usuario);
            capa.MdiParent = this.MdiParent;
            capa.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(dgvCapacitaciones);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(dgvCapacitaciones);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(dgvCapacitaciones);
        }
    }
}