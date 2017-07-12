using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class capa_presentacion_Empleado
    {
            public int codmotivo { get; set; }
            public string motivo { get; set; }
            public string descripcion { get; set; }

            public capa_presentacion_Empleado() { }

            public capa_presentacion_Empleado(int pcodmotivo, string pmotivo, string pdescripcion)

            {
                this.codmotivo = pcodmotivo;
                this.motivo = pmotivo;
                this.descripcion = pdescripcion;
            }
      }
}
