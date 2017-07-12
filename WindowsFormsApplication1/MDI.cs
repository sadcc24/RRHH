using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Xpf.Printing;
namespace WindowsFormsApplication1
{
    public partial class MDI : Form
    {
        public int idempleado;
        public int idempresas;
        public string idempresa;
        public string usuario;
        public string rol;
        public string empresa;
        public string nombre_moneda;
        public MDI(int idemp, string empr, int idempre, string user, string ro, string mon)
        {
            InitializeComponent();
            idempleado = idemp;
            idempresas = idempre;
            idempresa = idempre.ToString();
            empresa = empr;
            usuario = user;
            rol = ro;
            nombre_moneda = mon;  
        }

        private void RRHH_Load(object sender, EventArgs e)
        {

            toolStripStatusLabel2.Text = usuario;
            toolStripStatusLabel4.Text = rol;
            toolStripStatusLabel6.Text = empresa;
            toolStripStatusLabel8.Text = nombre_moneda;
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmempleados ventanaP = new frmempleados(empresa, idempresas);
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }

        private void solicitudesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmaceptacion ventanaP = new frmaceptacion(empresa, idempresas);
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }

        private void consultaMotivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmotivo ventanaP = new frmmotivo();
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }

        private void consultaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmmodulovacaciones ventanaP = new frmmodulovacaciones(idempleado, idempresas, usuario, empresa);
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }

        private void solicitudDeVacacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmaprobacionsolicitud ventanaP = new frmaprobacionsolicitud();
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }

        private void requisicionDePuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrequisiciondepuesto ventanaP = new frmrequisiciondepuesto();
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }

        private void agregarCandidatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcandidatos ventanaP = new frmcandidatos();
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }

        private void entrevistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmenrevistageneral ventanaP = new frmenrevistageneral();
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }

        private void pruebasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmpruebas ventanaP = new frmpruebas();
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(usuario + " ¿Está seguro de Cerrar la Aplicacion? ", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                
            }
        }

        private void planillaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmplanilla ventanaP = new frmplanilla();
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }

        private void plantillasPlanillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmplantillaplanillas ventanaP = new frmplantillaplanillas();
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }

        private void vacacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmvacacionesplanilla ventanaP = new frmvacacionesplanilla();
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmcapacitaciones ventanaP = new frmcapacitaciones(idempresa);
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //asignacion_capacitaciones ventanaP = new asignacion_capacitaciones();
            //ventanaP.MdiParent = this;
            //ventanaP.Show();
        }

        private void evaluacionDeDesempeñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            evaluacion_desempeño ventanaP = new evaluacion_desempeño(idempresa);
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }

        private void nuevoEmpleadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmnuevoempleado ventanaP = new frmnuevoempleado(empresa, idempresas);
            ventanaP.MdiParent = this;
            ventanaP.Show();
            
        }

        private void asignacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmconsultaasignaciones ventanaP = new frmconsultaasignaciones(idempresa);
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }

        private void consultaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            asignacion_capacitaciones ventanaP = new asignacion_capacitaciones("0","0",idempresa);
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }

        private void consultaAreasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmconsultaarea ventanaP = new frmconsultaarea();
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }

        private void creacionAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcreacionarea ventanaP = new frmcreacionarea("0", "0", "0", "0");
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }

        private void creacionEvaluacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            evaluacion_desempeño ventanaP = new evaluacion_desempeño(idempresa);
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }

        private void consultaEvaluacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmconsultaevaluacion ventanaP = new frmconsultaevaluacion(idempresa);
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }

        private void consultaMetricasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmconsultametrica ventanaP = new frmconsultametrica(idempresa);
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }

        private void creacionMetricasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmabcmetrica ventanaP = new frmabcmetrica(idempresa,"0","0","0","0","0","0");
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }

        private void consultaPeriodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmperiodos ventanaP = new frmperiodos();
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }

        private void creacionPeriodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmabcperiodos ventanaP = new frmabcperiodos("0","0","0");
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }

        private void vacacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vistaDeTomaDeVacacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmvista ventanaP = new frmvista();
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }

        private void diasFestivosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmfestivos ventanaP = new frmfestivos();
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }

        private void extraPeriodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmperiodo ventanaP = new frmperiodo();
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmUsuario ventanaP = new frmUsuario(empresa, idempresas);
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }

        private void tipoDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtipousuario ventanaP = new frmtipousuario(empresa, idempresas);
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }

        private void r1ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Reporte ventanaP = new Reporte();
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }

        private void empleadosInactivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmreporteinactivo ventanaP = new frmreporteinactivo();
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }

        private void r2ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmReporteActivos ventanaP = new frmReporteActivos();
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }

        private void candidatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteCandidatos ventanaP = new frmReporteCandidatos();
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }
    }
}
