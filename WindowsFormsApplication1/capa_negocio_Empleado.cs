using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
     class capa_negocio_Empleado
    {

        public System.Data.DataTable GetAll(string sUser)
        {
            return capa_logica_Empleado.ObtenerRegistros(sUser);
        }

        public System.Data.DataTable GetEmpleadoGrid()
        {
            return capa_logica_Empleado.GetEmpleadoGrid();
        }
        public System.Data.DataTable GetEmpleadoDatos(string idemp)
        {
            return capa_logica_Empleado.GetEmpleadoDatos(idemp);
        }

        public void Insert_Motivo(capa_presentacion_Empleado pmotivo)
        {
            if (string.IsNullOrWhiteSpace(pmotivo.motivo) || string.IsNullOrWhiteSpace(pmotivo.descripcion))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                int resultado = capa_logica_Empleado.Agregar(pmotivo);

                if (resultado > 0)
                {
                    MessageBox.Show("Registro Guardado", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
         }
        public int Login(string sUser, string sContra)
        {
            int resultado = 0;
            if (string.IsNullOrWhiteSpace(sUser) || string.IsNullOrWhiteSpace(sContra))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                resultado = capa_logica_Empleado.LoginD(sUser, sContra);
                if (resultado > 0)
                {
                    resultado = 1;
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrecta", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            return resultado;
        }


        public int InsertaEmpleado(int Estado, string CodUsuario, int Empresa, string sueldo, string aumento, string puesto, string jornada, string departamento, string feciniciolaboral, string nombre1, string nombre2, string apellido1, string apellido2, string apellido3, string nacionalidad, string sexo, string fechanacimiento, string direccion, int telefono, string identificacion)
        {
            int resultado = 0;
            //if (string.IsNullOrWhiteSpace(sUser) || string.IsNullOrWhiteSpace(sContra))
            //{
            //    MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            //else
            //{
            resultado = capa_logica_Empleado.InsertaEmpleado(Estado, CodUsuario, Empresa, sueldo, aumento, puesto, jornada, departamento, feciniciolaboral, nombre1, nombre2, apellido1, apellido2, apellido3, nacionalidad, sexo, fechanacimiento, direccion, telefono, identificacion);
                if (resultado > 0)
                {
                    resultado = 1;
                }
                else
                {
                    MessageBox.Show("Usuario no Creado", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            
            return resultado;
        }
    }
}
