using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
     public class capa_negocio_planillas
    {
        public static List<capa_presentacion_planillas.cbx_tipo> cbx_tipo()
        {
            List<capa_presentacion_planillas.cbx_tipo> cbx_tipo = capa_logica_planillas.cbx_tipo();
            return cbx_tipo;
        }

        public static List<capa_presentacion_planillas.cbx_tipoPago> cbx_tipoPago()
        {
            List<capa_presentacion_planillas.cbx_tipoPago> cbx_tipoPago = capa_logica_planillas.cbx_tipoPago();
            return cbx_tipoPago;
        }

        public static List<capa_presentacion_planillas.showPagoDescuentos> showPercepciones()
        {
            List<capa_presentacion_planillas.showPagoDescuentos> showPercepciones = capa_logica_planillas.showPercepciones();
            return showPercepciones;
        }

        public static List<capa_presentacion_planillas.showPagoDescuentos> showDeducciones()
        {
            List<capa_presentacion_planillas.showPagoDescuentos> showDeducciones = capa_logica_planillas.showDeducciones();
            return showDeducciones;
        }

        public static List<capa_presentacion_planillas.ListPercepciones> showListPercepciones()
        {
            List<capa_presentacion_planillas.ListPercepciones> showPercepciones = capa_logica_planillas.showListPercepciones();
            return showPercepciones;
        }

        public static List<capa_presentacion_planillas.ListDeducciones> showListDeducciones()
        {
            List<capa_presentacion_planillas.ListDeducciones> showDeducciones = capa_logica_planillas.showListDeducciones();
            return showDeducciones;
        }

        public static List<capa_presentacion_planillas.showEmpleados> showEmpleados()
        {
            List<capa_presentacion_planillas.showEmpleados> showEmpleados = capa_logica_planillas.showEmpleados();
            return showEmpleados;
        }

        public static int savePercepciones(string descripcion, string porcentaje, int tipoPago)
        {
            int response = 0;

            if (string.IsNullOrWhiteSpace(descripcion))
            {
                MessageBox.Show("La Descripción es Obligatoria", "Completar Campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                response = capa_logica_planillas.savePercepciones(descripcion, porcentaje, tipoPago);
            }

            return response;
        }

        public static int saveDeducciones(string descripcion, string porcentaje, int tipoPago)
        {
            int response = 0;

            if (string.IsNullOrWhiteSpace(descripcion))
            {
                MessageBox.Show("La Descripción es Obligatoria", "Completar Campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                response = capa_logica_planillas.saveDeducciones(descripcion, porcentaje, tipoPago);
            }

            return response;
        }
    }
}
