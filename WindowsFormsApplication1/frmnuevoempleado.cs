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
            int Estado = 1;
            string CodUsuario = "1";
            int Empresa = 2;
            string sueldo = "122.12";
            string aumento = "0";
            string puesto = "Desarrollador";
            string jornada = "8 horas";
            string departamento = "Sistemas";
            string feciniciolaboral = "";
            string nombre1 = txtNombre1.Text;
            string nombre2 = "nomb2";
            string apellido1 = "ape3";
            string apellido2 = "ape2";
            string apellido3 = "ape1";
            string nacionalidad = "Guate";
            string sexo = "M";
            string fechanacimiento = "";
            string direccion = "direccion";
            int telefono=45641231;
            string identificacion = "dpi";

            if (MessageBox.Show("Desea crear el Empleado: "+nombre1+" ?", "Empleado", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int result = new capa_negocio_Empleado().InsertaEmpleado(Estado, CodUsuario, Empresa, sueldo, aumento, puesto, jornada, departamento, feciniciolaboral, nombre1, nombre2, apellido1, apellido2, apellido3, nacionalidad, sexo, fechanacimiento, direccion, telefono, identificacion);
                if (result > 0)
                {
                    MessageBox.Show("Empleado " +nombre1+ " Creado Correctamente", "Empleado");
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al crear el Empleado " + nombre1, "Empleado");
                }
            }
            else
            {

            }

            
        }

        private void frmnuevoempleado_Load(object sender, EventArgs e)
        {

        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"c:\ayuda.pdf");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
