using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class capa_presentacion_formaciones
    {
            public int codmotivo { get; set; }
            public string motivo { get; set; }
            public string descripcion { get; set; }

        public class info_capa {
            public string idcapacitacion { get; set; }
            public string nombre_capa { get; set; }
            public string descripcion_capa { get; set; }
            public string area { get; set; }
            public string expositor { get; set; }
            public string costo { get; set; }
        }

        public class infotipocapacitacion
        {
            public string idtipo { get; set; }
            public string tipo { get; set; }
                       
        }

        public class departamento
        {
            public string iddepartamento { get; set; }
            public string nombredepartamento { get; set; }

        }

        public class empleados
        {
            public string idempleado { get; set; }
            public string empleado { get; set; }

        }


        public capa_presentacion_formaciones() { }

            public capa_presentacion_formaciones(int pcodmotivo, string pmotivo, string pdescripcion)

            {
                this.codmotivo = pcodmotivo;
                this.motivo = pmotivo;
                this.descripcion = pdescripcion;
               
            }
      }
}
