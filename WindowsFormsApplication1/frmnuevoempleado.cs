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
    public partial class frmnuevoempleado : Form
    {
        public frmnuevoempleado()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int result = new capa_negocio().InsertaEmpleado();
            if (result > 0)
            {
                MessageBox.Show("Empleado Creado Correctamente");
            }
        }
    }
}
