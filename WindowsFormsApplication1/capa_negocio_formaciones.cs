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

        public System.Data.DataTable GetAll(string sUser)
        {
            return capa_logica_formaciones.ObtenerRegistros(sUser);
        }
        public void Insert_Motivo(capa_presentacion_formaciones pmotivo)
        {
            if (string.IsNullOrWhiteSpace(pmotivo.motivo) || string.IsNullOrWhiteSpace(pmotivo.descripcion))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                int resultado = capa_logica_formaciones.Agregar(pmotivo);

                if (resultado == 1)
                {
                    MessageBox.Show("Registro Guardado", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("No se pudo guardar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public static string busqueda_asignacion(string nombre, string usuario, string descripcion) {
            string idcapacitacion = "";
            string empresa = "";
            empresa = usuario;
            //empresa = capa_logica_formaciones.consulta_empresa(usuario);

            idcapacitacion = capa_logica_formaciones.cod_capacitacion(nombre, empresa, descripcion);

            return idcapacitacion;
        }

        public static List<capa_presentacion_formaciones.infotipocapacitacion> infotipocapacitacion() {
            List<capa_presentacion_formaciones.infotipocapacitacion> tipocapacitacion = capa_logica_formaciones.info_tipocapacitaciones();
            return tipocapacitacion;
        }


        public static List<capa_presentacion_formaciones.area> consultaarea() {
            List<capa_presentacion_formaciones.area> area = capa_logica_formaciones.consultaarea();

            return area;
        }
        public static List<capa_presentacion_formaciones.info_capa> capacitaciones(string usuario) {
            List<capa_presentacion_formaciones.info_capa> capa = capa_logica_formaciones.info_capacitaciones(usuario);
            return capa;
        }

        public static int eliminar_area(string idarea) {
            int eliminar = 0;

            eliminar = capa_logica_formaciones.eliminararea(idarea);

            return eliminar;
        }

        public static List<capa_presentacion_formaciones.asignacion> consulta_info(string idempresa) {
            List<capa_presentacion_formaciones.asignacion> asig = capa_logica_formaciones.consulta_asignacion(idempresa);
            return asig;
        }

        public static List<capa_presentacion_formaciones.infodetasig> infodet(string idasignacion) {

            List<capa_presentacion_formaciones.infodetasig> infodet = capa_logica_formaciones.infodetalleasignacion(idasignacion);
            return infodet;
        }

        public static List<capa_presentacion_formaciones.detaasig> detasi(string idcapacitacion,string idempresa) {
            List<capa_presentacion_formaciones.detaasig> dasignc = capa_logica_formaciones.consultadetasi(idcapacitacion,idempresa); ;
            return dasignc;
        }

        public static List<capa_presentacion_formaciones.departamento> departamentos(string usuario)
        {
            List<capa_presentacion_formaciones.departamento> departamento = capa_logica_formaciones.departamentos(usuario);
            return departamento;
        }

        public static List<capa_presentacion_formaciones.empleados> empleados(string usuario)
        {
            List<capa_presentacion_formaciones.empleados> emp = capa_logica_formaciones.empleados(usuario);
            return emp;
        }

        public static List<capa_presentacion_formaciones.metrica> consultametricadep(string idempresa, string departamento) {
            List<capa_presentacion_formaciones.metrica> metrics = capa_logica_formaciones.metricadep(idempresa, departamento);
            return metrics;
        }

        public static int detalleevaluacion(string comenhr, string comensup, string comenemp, string totalmetrica, string idmetrica, string idevaluacion)
        {
            int ingreso = 0;

            ingreso = capa_logica_formaciones.ingresometrica( comenhr,  comensup,  comenemp,  totalmetrica,  idmetrica,  idevaluacion);
            return ingreso;
        }


        public static int evaluadas(string idevaluacion) {
            int metricaseva = 0;

            metricaseva = capa_logica_formaciones.metricasevaluadas(idevaluacion);

            return metricaseva;
        }

        public static int totalevaluacion(string idevaluacion) {
            int total = 0;

            total = capa_logica_formaciones.totalevaluacion(idevaluacion);
            return total;

        }

        public static int evaluacion(string idempleado, string totalevaluacin, string fechainicio, string fechafin, string periodo, string idempresa) {
            int creacion = 0;

            creacion = capa_logica_formaciones.evaluaciondesempeño(idempleado, totalevaluacin, fechainicio, fechafin,  periodo,idempresa);

            return creacion;

        }

        public static int actualizararesultado(string idevaluacion,string resultado) {
            int update = 0;

            update = capa_logica_formaciones.actualizararesultado(idevaluacion, resultado);
            return update;
        }


        public static List<capa_presentacion_formaciones.evaluacionesdesempeñconsulta> consultaevade(string idempresa) {
            List<capa_presentacion_formaciones.evaluacionesdesempeñconsulta> desempeva = capa_logica_formaciones.consultaevaluacion(idempresa);


            return desempeva;
        }


        public static List<capa_presentacion_formaciones.empleadosdep> empleadosdepartamento(string idempresa,string departamento) {

            List<capa_presentacion_formaciones.empleadosdep> empleadodep = capa_logica_formaciones.empleadosdepartamento(idempresa, departamento);

            return empleadodep;
        } 

        public static int modificararea(string idarea, string nombre, string descripcion) {
            int modificacion = 0;
            modificacion = capa_logica_formaciones.modificararea(idarea, nombre, descripcion);

            return modificacion;
        }

        public static List<capa_presentacion_formaciones.metrica> consultametrica(string idempresa) {

            List<capa_presentacion_formaciones.metrica> metrica = capa_logica_formaciones.consultametrica(idempresa);

            return metrica;
        }


        public static int nuevametrica(string idempresa,string nombre,string descripcion,string departamento) {
            int creacion = 0;

            creacion = capa_logica_formaciones.metricanueva(idempresa,nombre,descripcion,departamento);

            return creacion;
        }
        public static int nueva_area(string descripcion,string nombre) {
            int nueva=0;

            nueva = capa_logica_formaciones.nuevaarea(descripcion,nombre);
            return nueva;
        }

        public static int eliminar_capacitacion(string id_capacitacion) {
            int resultado = 0;


            resultado = capa_logica_formaciones.eliminar_capacitacion(id_capacitacion);
            
            return resultado;
        }


        public static string consultaiddepartamento(string nombredepartamento) {
            string id = "";
           id= capa_logica_formaciones.consultardepartamentoid(nombredepartamento);


            return id;
        }

        public static string idtipoarea(string area) {
            string id="";
            id = capa_logica_formaciones.idtipoarea(area);
            return id;
        }

        public static int modificarmetrica(string metricaid,string nombre,string descripcion,string departamento) {

            int modificar = 0;

            modificar = capa_logica_formaciones.modificarmetrica(metricaid,nombre,descripcion,departamento);
            return modificar;

        }

        public static int eliminarmetrica(string idmetrica) {
            int eliminar = 0;

            eliminar = capa_logica_formaciones.eliminarmetrica(idmetrica);
            return eliminar;
        }


        public static List<capa_presentacion_formaciones.periodo> consultaperiodo() {
            List<capa_presentacion_formaciones.periodo> periodo = new List<capa_presentacion_formaciones.periodo>();

            periodo = capa_logica_formaciones.consultasperido();

            return periodo;
            
        }
        public static int nueva_capacitacion(string nombre, string descripcion,string expositor,string  costo, string area,string usuario) {
            int nuevo=0;
                        
            nuevo = capa_logica_formaciones.nueva_capacitacion(nombre, descripcion, expositor, costo, area,usuario);
                        
            return nuevo;
        }

        public static int nuevoperiodo(string periodo) {
            int creacion = 0;

            creacion = capa_logica_formaciones.crearperiodo(periodo);

            return creacion;
        }

        public static int eliminarperiodo(string idperiodo) {
            int eliminar = 0;
            eliminar = capa_logica_formaciones.eliminarperiodo(idperiodo);

            return eliminar;
        }
        public static int modificar_periodo(string periodo, string per) {
            int modificar = 0;
            modificar = capa_logica_formaciones.modificarperiodo(periodo, per);
            return modificar;
        }

        public static int modificar_capacitacion(string id_capacitacion,string nombre, string descripcion,string expositor,string costo,string area) {
            int result=0;

            result=capa_logica_formaciones.modificar_capacitacion(id_capacitacion,nombre, descripcion, expositor, costo, area);

            return result;

        }

        public static int asignar(string idcapacitacion, string metodoasignacion, string empleado,string departamento, string fechainicio,string fechafin, string horario,string metodo,string usuario) {
            int asignacion=0;

            asignacion = capa_logica_formaciones.asignacion(idcapacitacion,metodoasignacion,empleado,departamento,fechainicio,fechafin,horario,metodo,usuario);
            
            return asignacion;
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
