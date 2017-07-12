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

        public System.Data.DataTable obtieneRol()
        {
            return capa_logica_Empleado.obtieneRol();
        }
        public System.Data.DataTable obtieneDepto()
        {
            return capa_logica_Empleado.obtieneDepto();
        }
        public System.Data.DataTable obtieneEmpresa()
        {
            return capa_logica_Empleado.obtieneEmpresa();
        }
        public System.Data.DataTable obtienePuesto(string dep)
        {
            return capa_logica_Empleado.obtienePuesto(dep);
        }
        public System.Data.DataTable GetEmpleadoGrid()
        {
            return capa_logica_Empleado.GetEmpleadoGrid();
        }
        public System.Data.DataTable GetUsuarioGrid()
        {
            return capa_logica_Empleado.GetUsuarioGrid();
        }
        public System.Data.DataTable GetTipoGrid()
        {
            return capa_logica_Empleado.GetTipoGrid();
        }
        public System.Data.DataTable GetEmpleadoGridCandidato()
        {
            return capa_logica_Empleado.GetEmpleadoGridCandidato();
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


        public int InsertaEmpleado(int? experiencia, int? estudio,int Estado, int CodUsuario, int Empresa,int rol, string sueldo, string aumento, string puesto, string jornada, string feciniciolaboral, string nombre1, string nombre2, string apellido1, string apellido2, string apellido3, string nacionalidad, string sexo, string fechanacimiento, string direccion, int telefono, string identificacion, byte[] fotografia)
        {
            int resultado = 0;
            //if (string.IsNullOrWhiteSpace(experiencia) || string.IsNullOrWhiteSpace(estudio) || string.IsNullOrWhiteSpace(Estado) || string.IsNullOrWhiteSpace(CodUsuario) || string.IsNullOrWhiteSpace(Empresa) || string.IsNullOrWhiteSpace(rol) || string.IsNullOrWhiteSpace(sueldo) || string.IsNullOrWhiteSpace(aumento) || string.IsNullOrWhiteSpace(estudio) || string.IsNullOrWhiteSpace(estudio) || string.IsNullOrWhiteSpace(estudio) || string.IsNullOrWhiteSpace(estudio) || string.IsNullOrWhiteSpace(estudio) || string.IsNullOrWhiteSpace(estudio) || string.IsNullOrWhiteSpace(estudio) || string.IsNullOrWhiteSpace(estudio))
            //{
            //    MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            //else
            //{
                resultado = capa_logica_Empleado.InsertaEmpleado(experiencia,estudio, Estado, CodUsuario, Empresa,rol, sueldo, aumento, puesto, jornada, feciniciolaboral, nombre1, nombre2, apellido1, apellido2, apellido3, nacionalidad, sexo, fechanacimiento, direccion, telefono, identificacion, fotografia);
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
        public int ActualizaEmpleado(int idempresa,int? experiencia, int? estudio, int Estado, int Empresa, int rol, string sueldo, string aumento, int puesto, int jornada, string feciniciolaboral, string nombre1, string nombre2, string apellido1, string apellido2, string apellido3, string nacionalidad, string sexo, string fechanacimiento, string direccion, int telefono, string identificacion, byte[] fotografia)
        {
            int resultado = 0;
            resultado = capa_logica_Empleado.ActualizaEmpleado(idempresa,experiencia, estudio, Estado, Empresa, rol, sueldo, aumento, puesto, jornada, feciniciolaboral, nombre1, nombre2, apellido1, apellido2, apellido3, nacionalidad, sexo, fechanacimiento, direccion, telefono, identificacion, fotografia);
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
        public int ActualizaPass(int idempleado, string pass)
        {
            int resultado = 0;
            resultado = capa_logica_Empleado.ActualizaPass(idempleado, pass);
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
        public int InsertaRol(string pass)
        {
            int resultado = 0;
            resultado = capa_logica_Empleado.InsertaRol(pass);
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
        public int decandidatoaempleado(string jornada, int rol, string sueldo, string aumento, int idempresa, int candidato)
        {
            int resultado = 0;
            resultado = capa_logica_Empleado.decandidatoaempleado(jornada, rol, sueldo, aumento, idempresa, candidato);
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

        public int vepassword(int id, string pass)
        {
            int resultado = 0;
            resultado = capa_logica_Empleado.vepassword(id,pass);

            return resultado;
        }
    }
}
