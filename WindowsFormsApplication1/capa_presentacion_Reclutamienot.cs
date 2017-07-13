using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class capa_presentacion_Reclutamienot
    {
      
        public string idcandidato { get; set; }
        public string idestadocandidato { get; set; }
        public string idestadocivil { get; set; }
        public string idsexo { get; set; }
        public string idnacionalidad { get; set; }
        public string nombre1 { get; set; }
        public string nombre2 { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string apellido3 { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string nidentificacion { get; set; }
        public string fechanacimiento { get; set; }
        
 
        public capa_presentacion_Reclutamienot() { }

        public capa_presentacion_Reclutamienot(string pidcandidato, string pidestadocandidato, string pidestadocivil, string pidsexo, string  pidnacionalidad, string pnombre1, string pnombre2, string papellido1, string papellido2, string papellido3, string pdireccion, string ptelefono, string pdpi, string pfechanacimiento)
        {
            this.idcandidato = pidcandidato;
            this.idestadocandidato = pidestadocandidato;
            this.idestadocivil = pidestadocivil;
            this.idsexo = pidsexo;
            this.idnacionalidad = pidnacionalidad;
            this.nombre1 = pnombre1;
            this.nombre2 = pnombre2;
            this.apellido1 = papellido1;
            this.apellido2 = papellido2;
            this.apellido3 = papellido3;
            this.direccion = pdireccion;
            this.telefono = ptelefono;
            this.nidentificacion = pdpi;
            this.fechanacimiento = pfechanacimiento;
        }


        

    }
}
