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
    public partial class frmmotivo : Form
    {
        public frmmotivo()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtmotivo.Enabled = true;
            txtdescripcion.Enabled = true;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtmotivo.Enabled = false;
            txtdescripcion.Enabled = false;
        }

        private void frmmotivo_Load(object sender, EventArgs e)
        {
          /*
            conexionbd.ObtenerConexion();
            MessageBox.Show("conexion correcta");*/
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            capa_presentacion pmotivo = new capa_presentacion();
            pmotivo.motivo = txtmotivo.Text.Trim();
            pmotivo.descripcion = txtdescripcion.Text.Trim();
            new capa_negocio().Insert_Motivo(pmotivo);
            txtmotivo.Enabled = false;
            txtdescripcion.Enabled = false;
        }
    }
}
