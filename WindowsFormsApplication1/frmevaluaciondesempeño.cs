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
    public partial class evaluacion_desempeño : Form
    {
        string idempresa;
        string idevaluacion = "0";
        int nummetre = 0;

        public evaluacion_desempeño(string idempre)
        {
            idempresa = idempre;
            InitializeComponent();
            List<capa_presentacion_formaciones.departamento> dep = new List<capa_presentacion_formaciones.departamento>();
            dep = capa_negocio_formaciones.departamentos("0");

             
            cbdepartamento.DataSource = dep;
            cbdepartamento.DisplayMember = "nombredepartamento";
            cbdepartamento.ValueMember = "iddepartamento";

           
            txtfechaeva.Text = DateTime.Now.ToString("dd-MM-yyyy");

            List<capa_presentacion_formaciones.periodo> periodo = new List<capa_presentacion_formaciones.periodo>();
            periodo = capa_negocio_formaciones.consultaperiodo();
            cbperiodo.DataSource = periodo;
            cbperiodo.DisplayMember = "Periodo";
            cbperiodo.ValueMember = "id";




        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void evaluacion_desempeño_Load(object sender, EventArgs e)
        {
            

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbdepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<capa_presentacion_formaciones.empleadosdep> emp = new List<capa_presentacion_formaciones.empleadosdep>();

            string departamento = "";

            departamento = cbdepartamento.SelectedValue.ToString();

            emp = capa_negocio_formaciones.empleadosdepartamento(idempresa, departamento);
            cbempleado.DataSource = emp;
            cbempleado.DisplayMember = "empleado";
            cbempleado.ValueMember = "idempleado";


            List<capa_presentacion_formaciones.metrica> metrics = new List<capa_presentacion_formaciones.metrica>();
            metrics = capa_negocio_formaciones.consultametricadep(idempresa,departamento);
            cbmetrica.DataSource = metrics;
            cbmetrica.DisplayMember = "Metrica";
            cbmetrica.ValueMember = "id";

            int numerometricas = metrics.Count();
            nummetre = numerometricas;


        }

        private void cbdepartamento_DisplayMemberChanged(object sender, EventArgs e)
        {
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            string idemplead = cbempleado.SelectedValue.ToString();
            string fechainicio = "";
            string fechafin = "";
            string totalevaluacion = "";
            string etapa = "";
            string idperiodo = "";

            etapa = "0";
            
            totalevaluacion = txttotalevaluacion.Text;
            fechainicio = dtpfechainicio.Value.Date.ToString("yyyy-MM-dd");
            fechafin = dtpfechafin.Value.Date.ToString("yyyy-MM-dd"); 
            idperiodo = cbperiodo.SelectedValue.ToString();

           


            int creacion = 0;

            creacion = capa_negocio_formaciones.evaluacion(idemplead, totalevaluacion, fechainicio,  fechafin,  idperiodo,  idempresa);

            idevaluacion = creacion.ToString();

            if (creacion == 0)
            {
                MessageBox.Show("Error en la Creacion de Evaluacion de Desempeño", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                MessageBox.Show("Evaluacion Creada Exitosamente, Proceda a Completar Evaluacion por Metricas", "Evaluacion Desempeño", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            







        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idmetrica = "";
            string comentarioempleado = "";
            string comentariosup = "";
            string comentariorh = "";
            string totalmetrica = "";
            int totalevaluacion = 0;
            int resultado = 0;


            totalmetrica = txttotalmetrica.Text;
            comentarioempleado = txtemp.Text;
            comentariosup = txtsup.Text;
            comentariorh = txtrrhh.Text;
            idmetrica = cbmetrica.SelectedValue.ToString();

            int metrica = 0;
            int metricasevaluadas = 0;
            metrica = capa_negocio_formaciones.detalleevaluacion(comentariorh,comentariosup,comentarioempleado,totalmetrica,idmetrica,idevaluacion);

            if (metrica == 1) {
                metricasevaluadas = capa_negocio_formaciones.evaluadas(idevaluacion);
                if (metricasevaluadas == nummetre)
                {
                    MessageBox.Show("evaluacion completadada con exito");
                    txtemp.Clear();
                    txtrrhh.Clear();
                    txtsup.Clear();
                    txttotalmetrica.Clear();
                    totalevaluacion = capa_negocio_formaciones.totalevaluacion(idevaluacion);
                    resultado = totalevaluacion / nummetre;


                    txttotalevaluacion.Text = resultado.ToString();
                    if (resultado < 70)
                    {
                        txttotalevaluacion.BackColor = Color.Red;
                    }
                    else if (resultado >= 70 && resultado < 90)
                    {
                        txttotalevaluacion.BackColor = Color.Yellow;
                    }
                    else if (resultado >= 90) {
                        txttotalevaluacion.BackColor = Color.Green;
                    }

                    int update = capa_negocio_formaciones.actualizararesultado(idevaluacion, resultado.ToString());
                }
                else {
                    int total = nummetre - metricasevaluadas;
                    MessageBox.Show("Metrica Guardada, porfavor completar la evaluacion, Metricas Restantes: " + total.ToString());
                    txtemp.Clear();
                    txtrrhh.Clear();
                    txtsup.Clear();
                    txttotalmetrica.Clear();
                    totalevaluacion = capa_negocio_formaciones.totalevaluacion(idevaluacion);
                    resultado = totalevaluacion / nummetre;


                    txttotalevaluacion.Text = resultado.ToString();
                    if (resultado < 70)
                    {
                        txttotalevaluacion.BackColor = Color.Red;
                    }
                    else if (resultado >= 70 && resultado < 90)
                    {
                        txttotalevaluacion.BackColor = Color.Yellow;
                    }
                    else if (resultado >= 90)
                    {
                        txttotalevaluacion.BackColor = Color.Green;
                    }

                }


                
            }

            


        }
    }
}
