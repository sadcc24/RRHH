using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class capa_presentacion_vacaciones
    {
        public int codmotivo { get; set; }
        public string motivo { get; set; }
        public string descripcion { get; set; }

        public capa_presentacion_vacaciones() { }

        public capa_presentacion_vacaciones(int pcodmotivo, string pmotivo, string pdescripcion)

        {
            this.codmotivo = pcodmotivo;
            this.motivo = pmotivo;
            this.descripcion = pdescripcion;

        }
    }

    public class capa_presentacion_solicitud
    {
        public int codsolicitud { get; set; }
        public int codmotivo { get; set; }
        public string motivo { get; set; }
        public string fecinicial { get; set; }
        public string fecfinal { get; set; }
        public string candias { get; set; }
        public string fecsolicitud { get; set; }
        public string fecdecision { get; set; }
        public string decision { get; set; }
        public string descomentario { get; set; }
        public int idempleado { get; set; }

        public string nombre1 { get; set; }
        public string nombre2 { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public int idempresa { get; set; }

        public string nombre_empresa { get; set; }

        public capa_presentacion_solicitud() { }
        public capa_presentacion_solicitud(int pcodsolicitud, int pcodmotivo, string pfecinicial, string pfecfinal, string pcandias, string pfecsolicitud, string pfecdecision, string pdecision, string pdescomentario, int pidempleado, int pidempresa, string pmotivo, string pnombre1, string pnombre2, string papellido1, string papellido2, string pnombre_empresa)
        {
            this.codsolicitud = pcodsolicitud;
            this.codmotivo = pcodmotivo;
            this.motivo = pmotivo;
            this.fecinicial = pfecinicial;
            this.fecfinal = pfecfinal;
            this.candias = pcandias;
            this.fecsolicitud = pfecsolicitud;
            this.fecdecision = pfecdecision;
            this.decision = pdecision;
            this.descomentario = pdescomentario;
            this.idempleado = pidempleado;
            this.nombre1 = pnombre1;
            this.nombre2 = pnombre2;
            this.apellido1 = papellido1;
            this.apellido2 = papellido2;
            this.idempresa = pidempresa;
            this.nombre_empresa = pnombre_empresa;
        }

    }

    public class capa_presentacion_fecinilaboral
    {
        public int idempleado { get; set; }
        public int idempresa { get; set; }
        public string sueldo { get; set; }
        public string aumento { get; set; }
        public string jornada { get; set; }
        public string feciniciolaboral { get; set; }
        public int idpuestodetrabajo { get; set; }
        public int idexperiencialaboral { get; set; }
        public int idestudios { get; set; }

        public capa_presentacion_fecinilaboral() { }

        public capa_presentacion_fecinilaboral(int pidempleado, int pidempresa, string psueldo, string paumento, string pjornada, string pfeciniciolaboral, int pidpidpuestodetrabajo, int pidexperiencialaboral, int pidestudios)

        {
            this.idempleado = pidempleado;
            this.idempresa = pidempresa;
            this.sueldo = psueldo;
            this.aumento = paumento;
            this.jornada = pjornada;
            this.feciniciolaboral = pfeciniciolaboral;
            this.idpuestodetrabajo = pidpidpuestodetrabajo;
            this.idexperiencialaboral = pidexperiencialaboral;
            this.idestudios = pidestudios;

        }
    }

    public class capa_presentacion_festivos
    {
        public int idempleado { get; set; }
        // public string nombre1 { get; set; }
        public int idempresa { get; set; }
        //  public string nombre_empresa { get; set; }
        public int codperiodo { get; set; }
        public string fecha { get; set; }
        public string descripcion { get; set; }


        public capa_presentacion_festivos() { }
        //  public capa_presentacion_festivos(int pidempleado,string pnombre1, int pidempresa,string pnombre_empresa, int pcodperiodo, string pfecha, string pdescripcion)

        public capa_presentacion_festivos(int pidempleado, int pidempresa, int pcodperiodo, string pfecha, string pdescripcion)

        {
            this.idempleado = pidempleado;
            // this.nombre1 = pnombre1;
            this.idempresa = pidempresa;
            //this.nombre_empresa = pnombre_empresa;
            this.codperiodo = pcodperiodo;
            this.fecha = pfecha;
            this.descripcion = pdescripcion;

        }
    }
    public class capa_presentacion_extra
    {
        public int idempleado { get; set; }
        public string nombre1 { get; set; }
        public int idempresa { get; set; }
        public string nombre_empresa { get; set; }
        public int codperiodo { get; set; }
        public string fecha { get; set; }
        public string descripcion { get; set; }


        public capa_presentacion_extra() { }

        public capa_presentacion_extra(int pidempleado, string pnombre1, int pidempresa, string pnombre_empresa, int pcodperiodo, string pfecha, string pdescripcion)

        {
            this.idempleado = pidempleado;
            this.nombre1 = pnombre1;
            this.idempresa = pidempresa;
            this.nombre_empresa = pnombre_empresa;
            this.codperiodo = pcodperiodo;
            this.fecha = pfecha;
            this.descripcion = pdescripcion;

        }
    }




    public class capa_presentacion_periodo
    {
        public int codperiodo { get; set; }
        public string perdescripcion { get; set; }
        public string perestatus { get; set; }

        public capa_presentacion_periodo() { }

        public capa_presentacion_periodo(int pcodperiodo, string pperdescripcion, string pperestatus)

        {
            this.codperiodo = pcodperiodo;
            this.perdescripcion = pperdescripcion;
            this.perestatus = pperestatus;

        }

    }
    public class capa_presentacion_diasvac
    {
        public int codvacaciones { get; set; }
        public string diarestantes { get; set; }
        public string diasacumulados { get; set; }
        public int idempleado { get; set; }
        public int idempresa { get; set; }
        public int codsolicitud { get; set; }


        public capa_presentacion_diasvac() { }

        public capa_presentacion_diasvac(int pcodvacaciones, string pdiarestantes, string pdiasacumulados, int pidempleado, int pidempresa, int pcodsolicitud)

        {
            this.codvacaciones = pcodvacaciones;
            this.diarestantes = pdiarestantes;
            this.diasacumulados = diasacumulados;
            this.idempleado = pidempleado;
            this.idempresa = pidempresa;
            this.codvacaciones = pcodvacaciones;

        }

    }

        public class capa_presentacion_diasextra
        {
            public int codvacaciones { get; set; }
            public string diarestantes { get; set; }
            public string diasacumulados { get; set; }
            public int idempleado { get; set; }
            public string nombre1 { get; set; }
            public string apellido1 { get; set; }

            public int idempresa { get; set; }
            public string nombre_empresa { get; set; }
            public int codsolicitud { get; set; }


            public capa_presentacion_diasextra() { }

            public capa_presentacion_diasextra(int pcodvacaciones, string pdiarestantes, string pdiasacumulados, int pidempleado, string pnombre1, string papellido1, int pidempresa, string pnombre_empresa, int pcodsolicitud)

            {
                this.codvacaciones = pcodvacaciones;
                this.diarestantes = pdiarestantes;
                this.diasacumulados = diasacumulados;
                this.idempleado = pidempleado;
                this.nombre1 = pnombre1;
                this.apellido1 = papellido1;
                this.idempresa = pidempresa;
                this.nombre_empresa = pnombre_empresa;
                this.codvacaciones = pcodvacaciones;

            }

        }

    
}
