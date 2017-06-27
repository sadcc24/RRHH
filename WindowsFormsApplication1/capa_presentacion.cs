using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class capa_presentacion
    {
            public int codmotivo { get; set; }
            public string motivo { get; set; }
            public string descripcion { get; set; }

<<<<<<< HEAD
            public capa_presentacion() { }
=======
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


        public capa_presentacion() { }
>>>>>>> fix_2

            public capa_presentacion(int pcodmotivo, string pmotivo, string pdescripcion)

            {
                this.codmotivo = pcodmotivo;
                this.motivo = pmotivo;
                this.descripcion = pdescripcion;
               
            }
      }
}
