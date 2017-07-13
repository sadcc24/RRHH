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
    public partial class frmplanilla : Form
    {
        public frmplanilla()
        {
            InitializeComponent();
            combo_periodo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void combo_periodo()
        {
            List<capa_presentacion_planillas.cbx_periodo> periodos = capa_negocio_planillas.cbx_periodo();

            cbx_periodo.DataSource = periodos;
            cbx_periodo.DisplayMember = "mes";
            cbx_periodo.ValueMember = "idperiodo";
        }

        public void totalDevengado()
        {
            double sueldo = 0;
            double percepciones = 0;
            double deducciones = 0;
            double devengado = 0;
            double totalPlanilla = 0;
            int rowIndex = 0;

            foreach (DataGridViewRow row in grid_empleados.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    int index = cell.ColumnIndex;
                    if (index == 8)
                    {
                        if (cell.Value != null)
                        {
                            deducciones = Convert.ToDouble(cell.Value.ToString());
                        }
                    }
                    if (index == 9)
                    {
                        if (cell.Value != null)
                        {
                            percepciones = Convert.ToDouble(cell.Value.ToString());
                        }
                    }
                    if (index == 10)
                    {
                        if (cell.Value != null)
                        {
                            sueldo = Convert.ToDouble(cell.Value.ToString());
                        }
                    }
                }
                devengado = (sueldo + percepciones) - deducciones;
                totalPlanilla += devengado;
                grid_empleados.Rows[rowIndex].Cells[1].Value = devengado.ToString();

                devengado = 0;
                sueldo = 0;
                percepciones = 0;
                deducciones = 0;

                rowIndex++;
            }
            txt_totalPlanilla.Text = totalPlanilla.ToString();
        }

        private void btn_findEmp_Click(object sender, EventArgs e)
        {
            frmplantillaplanillas frm = new frmplantillaplanillas();
            DataTable table = frm.getEmpleadosNomina();

            if (table != null)
            {
                grid_empleados.DataSource = table;
                grid_empleados.Columns["idempleado"].Visible = false;
            }
            else
            {
                grid_empleados.DataSource = table;
            }

            totalDevengado();
        }

        private void btn_applyNomina_Click(object sender, EventArgs e)
        {

        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(grid_empleados);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(grid_empleados);
        }

        private void btnAtrasfin_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(grid_empleados);
        }

        private void btnAdelantefin_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(grid_empleados);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Manualdeplanillas.pdf");
        }
    }
}
