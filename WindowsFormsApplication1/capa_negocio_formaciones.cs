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
        public void Insert_Motivo(capa_presentacion_formaciones pmotivo)
        {
            if (string.IsNullOrWhiteSpace(pmotivo.motivo) || string.IsNullOrWhiteSpace(pmotivo.descripcion))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                int resultado = capa_logica_formaciones.Agregar(pmotivo);

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

        public static List<capa_presentacion_formaciones.infotipocapacitacion> infotipocapacitacion() {
            List<capa_presentacion_formaciones.infotipocapacitacion> tipocapacitacion = capa_logica_formaciones.info_tipocapacitaciones();
            return tipocapacitacion;
        }
        public static List<capa_presentacion_formaciones.info_capa> capacitaciones() {
            List<capa_presentacion_formaciones.info_capa> capa = capa_logica_formaciones.info_capacitaciones();
            return capa;
        }

        public static int eliminar_capacitacion(string id_capacitacion) {
            int resultado = 0;

            resultado = capa_logica_formaciones.eliminar_capacitacion(id_capacitacion);
            
            return resultado;
        }
        public static int modificar_capacitacion(string id_capacitacion,string nombre, string descripcion,string expositor,string costo,string area) {
            int result=0;

            result=capa_logica_formaciones.modificar_capacitacion(id_capacitacion,nombre, descripcion, expositor, costo, area);

            return result;

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
