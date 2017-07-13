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
    public partial class frmconsultaevaluacion : Form
    {

        string idempresa="";
        public frmconsultaevaluacion(string empresa)
        {
            idempresa = empresa;
            InitializeComponent();

            List<capa_presentacion_formaciones.evaluacionesdesempeñconsulta> consulta = capa_negocio_formaciones.consultaevade(idempresa);
            dgvevaluacionesdesemp.DataSource = consulta;

            dgvevaluacionesdesemp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvevaluacionesdesemp.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<capa_presentacion_formaciones.evaluacionesdesempeñconsulta> consulta = capa_negocio_formaciones.consultaevade(idempresa);
            dgvevaluacionesdesemp.DataSource = consulta;

            dgvevaluacionesdesemp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvevaluacionesdesemp.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            evaluacion_desempeño evde = new evaluacion_desempeño(idempresa);
            evde.MdiParent = this.MdiParent;
            evde.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(dgvevaluacionesdesemp);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(dgvevaluacionesdesemp);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(dgvevaluacionesdesemp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(dgvevaluacionesdesemp);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\ConsultaEvaluaciónDesempeño-mike.pdf");
        }
    }
}
