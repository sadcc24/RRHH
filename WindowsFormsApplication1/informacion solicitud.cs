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
    public partial class informacion_solicitud : Form
    {
        public capa_presentacion_vacaciones solicitudactual { get; set; }
        int codsolicitud = 0;
        string cantidad;
        public informacion_solicitud(capa_presentacion_solicitud solicitud)
        {
            InitializeComponent();



            //capa_presentacion_fecinilaboral fechainicio = capa_logica_vacaciones.fechainiciolaboral();

            if (solicitud != null)
            {
                //solicitudactual = buscar.solicitudseleccionada.codsolicitud;
                label1.Text = solicitud.nombre1;
                label2.Text = solicitud.apellido1;
                label3.Text = solicitud.nombre_empresa;
                label8.Text = solicitud.candias;
                dfechainicio.Text = solicitud.fecinicial;
                dfechafin.Text = solicitud.fecfinal;

                label11.Text = Convert.ToString(solicitud.codsolicitud);
                label12.Text = Convert.ToString(solicitud.idempleado);
                label13.Text = Convert.ToString(solicitud.idempresa);

              



                combosolicitud.Text = solicitud.motivo;

                txtdiast.Text = capa_logica_vacaciones.diastomados(solicitud.idempleado).candias.ToString();

                codsolicitud = solicitud.codsolicitud;
                cantidad = solicitud.candias;
                
                capa_presentacion_fecinilaboral fechainicio = capa_logica_vacaciones.fechainiciolaboral(solicitud.idempleado);
              
                DateTime dt = Convert.ToDateTime(fechainicio.feciniciolaboral);
                DateTime dt2 = DateTime.Today;
                string sd= dt2.ToString("yyyyMMdd");
                TimeSpan s = dt2 - dt;
                double days = s.TotalDays;

                double vacaciones = (days / 30) * 1.5;

                txttd.Text = vacaciones.ToString();





                int uno = Convert.ToInt32(txttd.Text);
                int dos = Convert.ToInt32(txtdiast.Text);
                int resultado = uno - dos;

                string mostrarresultado = Convert.ToString(resultado);

                txtdiasl.Text = mostrarresultado;


                
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            int idem = Convert.ToInt32(label12.Text);


            capa_presentacion_diasvac pdi = new capa_presentacion_diasvac();
            pdi.diarestantes = txtdiasl.Text.Trim();
            pdi.diasacumulados = txtdiast.Text.Trim();
            pdi.idempleado = Convert.ToInt32(idem);
            pdi.idempresa = Convert.ToInt32(label13.Text);
            pdi.codsolicitud = Convert.ToInt32(label11.Text);
            new capa_negocio_vacaciones().Insert_dias(pdi);

            

            int solicitudAuto = capa_logica_vacaciones.modificaraceptado(codsolicitud);

            if (solicitudAuto > 0)
            {
                frmaprobacionsolicitud frmapro = new frmaprobacionsolicitud();
                frmapro.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al realizar la Tranzaccion");
            }



        }

        private void btnrechazar_Click(object sender, EventArgs e)
        {

            int idem = Convert.ToInt32(label12.Text);


            capa_presentacion_diasvac pdi = new capa_presentacion_diasvac();
            pdi.diarestantes = txtdiasl.Text.Trim();
            pdi.diasacumulados = txtdiast.Text.Trim();
            pdi.idempleado = Convert.ToInt32(idem);
            pdi.idempresa = Convert.ToInt32(label13.Text);
            pdi.codsolicitud = Convert.ToInt32(label11.Text);
            new capa_negocio_vacaciones().Insert_dias(pdi);



            int solicitudAuto = capa_logica_vacaciones.modificarrechazado(codsolicitud);

            if (solicitudAuto > 0)
            {
                frmaprobacionsolicitud frmapro = new frmaprobacionsolicitud();
                frmapro.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al realizar la Tranzaccion");
            }
        }

        private void informacion_solicitud_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtdiasl_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = capa_logica_vacaciones.Buscarpersonas(dfechainicio.Text, dfechafin.Text);
        }
    }
    
}
