using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class capa_presentacion_planillas
    {
        public class cbx_tipo
        {
            public string idtipo { get; set; }
            public string descripcion { get; set; }
        }

        public class cbx_tipoPago
        {
            public string idtipopago { get; set; }
            public string descripcion { get; set; }
        }

        public class showPagoDescuentos
        {
            public string descripcion { get; set; }
            public string porcentaje { get; set; }
            public string tipoPago { get; set; }
            public string nombre_sede { get; set; }
        }

        public class ListPercepciones
        {
            public string idbonificacion { get; set; }
            public string descripcion { get; set; }
        }

        public class ListDeducciones
        {
            public string iddescuento { get; set; }
            public string descripcion { get; set; }
        }

        public class showEmpleados
        {
            public string nombre_empresa { get; set; }
            public string nombre1 { get; set; }
            public string nombre2 { get; set; }
            public string apellido1 { get; set; }
            public string apellido2 { get; set; }
        }


        //public class showPagoDescuentos
        //{
        //    public string idbonificacion { get; set; }
        //    public string idtipobonificacion { get; set; }
        //    public string idtipopago { get; set; }
        //    public string id { get; set; }
        //    public string id_sede { get; set; }
        //    public string descripcion { get; set; }
        //    public string porcentaje { get; set; }
        //    public string defaultt { get; set; }
        //    public string estado { get; set; }
        //}
    }
}
