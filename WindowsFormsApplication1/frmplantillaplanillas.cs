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
    public partial class frmplantillaplanillas : Form
    {
        public frmplantillaplanillas()
        {
            InitializeComponent();
            showPagoDescuentos();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        public void showPagoDescuentos()
        {
            List<capa_presentacion_planillas.ListPercepciones> showListPercepciones = capa_negocio_planillas.showListPercepciones();
            List<capa_presentacion_planillas.ListDeducciones> showListDeducciones = capa_negocio_planillas.showListDeducciones();

            list_percepciones.DataSource = showListPercepciones;
            list_percepciones.ValueMember = "idbonificacion";
            list_percepciones.DisplayMember = "descripcion";

            list_deducciones.DataSource = showListDeducciones;
            list_deducciones.ValueMember = "iddescuento";
            list_deducciones.DisplayMember = "descripcion";
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            ABCPercepcionesDeducciones a = new ABCPercepcionesDeducciones();
            a.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            showPagoDescuentos();
        }

        private void btn_findEmp_Click(object sender, EventArgs e)
        {
            List<capa_presentacion_planillas.showEmpleados> showEmpleados = capa_negocio_planillas.showEmpleados();

            grid_empleados.DataSource = showEmpleados;
        }
    }
}
