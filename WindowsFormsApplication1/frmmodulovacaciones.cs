using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class frmmodulovacaciones : Form
    {

        public int idempleado;
        public int idempresa;
        public string usuario;
        public string empresa;
       
        public frmmodulovacaciones(int idempre,  int idemp, string user, string empr)
        {
            InitializeComponent();
         
            timer1.Enabled = true;
            
            idempleado = idemp;
            idempresa = idempre;
            empresa = empr;
            usuario = user;

            nombreempresa.Text = empresa;
            nombreempleado.Text = usuario;

         //-----combobox------
         combomotivo.DataSource = capa_logica_vacaciones.Obtenermotivos();
            combomotivo.DisplayMember = "motivo";
            combomotivo.ValueMember = "codmotivo";
        }

        private void modulovacaciones_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsolicitud_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            dfechainicio.Enabled = true;
            dfechafin.Enabled = true;
            combomotivo.Enabled = true;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            dfechainicio.Enabled = false;
            dfechafin.Enabled = false;
            combomotivo.Enabled = false;
        }

        private void btnretorno_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToString();
        }

        private void dfechafin_ValueChanged(object sender, EventArgs e)
        {

            DateTime fi = dfechainicio.Value;
            DateTime ff = dfechafin.Value;

            TimeSpan s = ff - fi;

            label5.Text = s.TotalDays.ToString();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            capa_presentacion_solicitud psolicitud = new capa_presentacion_solicitud();

            psolicitud.codmotivo = Convert.ToInt32(combomotivo.SelectedValue);
            //psolicitud.codvacaciones = user;//Convert.ToInt32(label9.Text);
            psolicitud.fecinicial = dfechainicio.Text;
            psolicitud.fecfinal = dfechafin.Text;
            psolicitud.candias = label5.Text;
            psolicitud.fecsolicitud = label7.Text;
            psolicitud.fecdecision = label10.Text;
            psolicitud.decision = label11.Text;
            psolicitud.descomentario = txtcomentario.Text;
            psolicitud.idempleado = idempresa;
            psolicitud.idempresa = idempleado;
            new capa_negocio_vacaciones().Insert_solicitud(psolicitud);
        }

        private void btnayuda_Click(object sender, EventArgs e)
        {
            Process proceso = new Process();
            proceso.StartInfo.FileName = @"C:\Users\chepe\Desktop\recursos humanos\RRHH\WindowsFormsApplication1\manuales\MANUALDEAYUDA-solicitud.pdf";
            proceso.Start();
        }
       
    }
}
