﻿using System;
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

        public static List<capa_presentacion_planillas.cbx_bondesc> cbx_bondesc()
        {
            List<capa_presentacion_planillas.cbx_bondesc> cbx_bondesc = capa_logica_planillas.cbx_bondesc();
            return cbx_bondesc;
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

        public static List<capa_presentacion_planillas.showEmpleadosSinNomina> showEmpleadosSinNomina()
        {
            List<capa_presentacion_planillas.showEmpleadosSinNomina> showEmpleados = capa_logica_planillas.showEmpleadosSinNomina();
            return showEmpleados;
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

        public static int updatePercepciones(int idbonificacion, string descripcion, string porcentaje, int tipoPago)
        {
            int response = 0;

            if (string.IsNullOrWhiteSpace(descripcion))
            {
                MessageBox.Show("La Descripción es Obligatoria", "Completar Campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                response = capa_logica_planillas.updatePercepciones(idbonificacion, descripcion, porcentaje, tipoPago);
            }

            return response;
        }

        public static int updateDeducciones(int iddescuento, string descripcion, string porcentaje, int tipoPago)
        {
            int response = 0;

            if (string.IsNullOrWhiteSpace(descripcion))
            {
                MessageBox.Show("La Descripción es Obligatoria", "Completar Campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                response = capa_logica_planillas.updateDeducciones(iddescuento, descripcion, porcentaje, tipoPago);
            }

            return response;
        }

        public static int saveEmpleadoPercepcion(List<capa_presentacion_planillas.percepcionEmpleado> listPercepiones, List<capa_presentacion_planillas.empleadoPerDedc> empleadoPercepcion)
        {
            int response = 0;

            /*if (string.IsNullOrWhiteSpace(listPercepiones))
            {
                MessageBox.Show("La Descripción es Obligatoria", "Completar Campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {*/
            foreach (var percepcion in listPercepiones)
            {
                foreach (var empleado in empleadoPercepcion)
                {
                    response = capa_logica_planillas.saveEmpleadoPercepcion(percepcion.idpercepcion, empleado.idempleado);
                }
            }
            //}

            return response;
        }

        public static int undoEmpleadosNomina(List<capa_presentacion_planillas.empleadoPerDedc> undoEmpleadosNomina)
        {
            int response = 0;

            foreach (var empleado in undoEmpleadosNomina)
            {
                response = capa_logica_planillas.undoEmpleadosNomina(empleado.idempleado);
            }

            return response;
        }

        public static int saveEmpleadoDeduccion(List<capa_presentacion_planillas.deduccionEmpleado> lisDeducciones, List<capa_presentacion_planillas.empleadoPerDedc> empleados)
        {
            int response = 0;

            foreach (var deduccion in lisDeducciones)
            {
                foreach (var empleado in empleados)
                {
                    response = capa_logica_planillas.saveEmpleadoDeduccion(deduccion.iddeduccion, empleado.idempleado);
                }
            }

            return response;
        }
    }
}
