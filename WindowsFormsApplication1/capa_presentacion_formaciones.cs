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


        public class area
        {
             public string id { get; set; }
            public string Nombre_Area { get; set; }
            public string Descripcion { get; set; }


        }

        public class asignacion {
            public string id { get; set; }
            public string nombre { get; set; }
            public string Asignaciones { get; set; }
        }

        public class detaasig
        {
            public string id { get; set; }
            public string Inicio { get; set; }
            public string Fin { get; set; }
            public string horario { get; set; }
            public string Asignados { get; set; }
        }
         
        public class infodetasig {
            public string Empleado { get; set; }
            public string Departamento { get; set; }
            public string Puesto { get; set; }
          
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

        public class empleadosdep
        {
            public string idempleado { get; set; }
            public string empleado { get; set; }

        }


        public class evaluacionesdesempeñconsulta
        {
            public string id { get; set; }
            public string Empleado { get; set; }
            public string Nombre_Empresa { get; set; }
            public string Departamento { get; set; }
            public string Periodo { get; set; }
            public string Resultado { get; set; }
            public string Fecha { get; set; }


        }

        public class metrica {
            public string id { get; set; }
            public string Metrica { get; set; }
            public string Descripcion { get; set; }
            public string Empresa { get; set; }
            public string Departamento { get; set; }

          
        }


        public class periodo {
            public string id { get; set; }
            public string Periodo { get; set; }
                                               
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
