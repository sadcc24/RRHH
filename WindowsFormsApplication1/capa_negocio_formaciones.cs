using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
     public class capa_negocio_formaciones
    {

        public System.Data.DataTable GetAll(string sUser)
        {
            return capa_logica_formaciones.ObtenerRegistros(sUser);
        }
        public void Insert_Motivo(capa_presentacion_formaciones pmotivo)
        {
            if (string.IsNullOrWhiteSpace(pmotivo.motivo) || string.IsNullOrWhiteSpace(pmotivo.descripcion))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                int resultado = capa_logica_formaciones.Agregar(pmotivo);

                if (resultado ==1)
                {
                    MessageBox.Show("Registro Guardado", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { 
                    MessageBox.Show("No se pudo guardar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
         }

        public static string busqueda_asignacion(string nombre,string usuario,string descripcion) {
            string idcapacitacion = "";
            string empresa = "";

            empresa = capa_logica_formaciones.consulta_empresa(usuario);
            
            idcapacitacion = capa_logica_formaciones.cod_capacitacion(nombre, empresa, descripcion);

            return idcapacitacion;
        }

        public static List<capa_presentacion_formaciones.infotipocapacitacion> infotipocapacitacion() {
            List<capa_presentacion_formaciones.infotipocapacitacion> tipocapacitacion = capa_logica_formaciones.info_tipocapacitaciones();
            return tipocapacitacion;
        }
        public static List<capa_presentacion_formaciones.info_capa> capacitaciones(string usuario) {
            List<capa_presentacion_formaciones.info_capa> capa = capa_logica_formaciones.info_capacitaciones(usuario);
            return capa;
        }


        public static List<capa_presentacion_formaciones.departamento> departamentos(string usuario)
        {
            List<capa_presentacion_formaciones.departamento> departamento = capa_logica_formaciones.departamentos(usuario);
            return departamento;
        }

        public static List<capa_presentacion_formaciones.empleados> empleados(string usuario)
        {
            List<capa_presentacion_formaciones.empleados> emp = capa_logica_formaciones.empleados(usuario);
            return emp;
        }



        public static int eliminar_capacitacion(string id_capacitacion) {
            int resultado = 0;


            resultado = capa_logica_formaciones.eliminar_capacitacion(id_capacitacion);
            
            return resultado;
        }


        public static int nueva_capacitacion(string nombre, string descripcion,string expositor,string  costo, string area,string usuario) {
            int nuevo=0;
                        
            nuevo = capa_logica_formaciones.nueva_capacitacion(nombre, descripcion, expositor, costo, area,usuario);

            
            return nuevo;
        }
        public static int modificar_capacitacion(string id_capacitacion,string nombre, string descripcion,string expositor,string costo,string area) {
            int result=0;

            result=capa_logica_formaciones.modificar_capacitacion(id_capacitacion,nombre, descripcion, expositor, costo, area);

            return result;

        }

        public static int asignar(string idcapacitacion, string metodoasignacion, string empleado,string departamento, string fechainicio,string fechafin, string horario,string metodo,string usuario) {
            int asignacion=0;

            asignacion = capa_logica_formaciones.asignacion(idcapacitacion,metodoasignacion,empleado,departamento,fechainicio,fechafin,horario,metodo,usuario);
            
            return asignacion;
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
                resultado = capa_logica_formaciones.LoginD(sUser, sContra);
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
    }
}
