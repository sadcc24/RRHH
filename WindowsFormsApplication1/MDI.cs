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
    public partial class MDI : Form
    {
        string usuario;
        string empresa;
        public MDI(string user, string empr)
        {
            InitializeComponent();
            usuario = user;
            empresa = empr;   
        }

        private void RRHH_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = usuario;
            toolStripStatusLabel4.Text = "Administrador";
            label1.Text = empresa;
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmempleados ventanaP = new frmempleados(empresa);
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }

        private void solicitudesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmaceptacion ventanaP = new frmaceptacion();
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
            frmmodulovacaciones ventanaP = new frmmodulovacaciones();
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
            frmcapacitaciones ventanaP = new frmcapacitaciones();
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asignacion_capacitaciones ventanaP = new asignacion_capacitaciones();
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }

        private void evaluacionDeDesempeñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            evaluacion_desempeño ventanaP = new evaluacion_desempeño();
            ventanaP.MdiParent = this;
            ventanaP.Show();
        }

        private void nuevoEmpleadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmnuevoempleado ventanaP = new frmnuevoempleado();
            ventanaP.MdiParent = this;
            ventanaP.Show();
            
        }
    }
}
