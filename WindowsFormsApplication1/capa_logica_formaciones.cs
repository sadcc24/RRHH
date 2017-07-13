using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication1
{
    class capa_logica_formaciones
    {
        public static SqlConnection SQL_Conexion = new SqlConnection();

        public static int Agregar(capa_presentacion_formaciones pMotivo)
        {

            int retorno = 0;

            SqlCommand comando = new SqlCommand(string.Format("Insert into motivouno (motivo, descripcion) values ('{0}','{1}')",
               pMotivo.motivo, pMotivo.descripcion), conexionbd.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            SQL_Conexion.Close();
            return retorno;
        }


        public static List<capa_presentacion_formaciones.departamento> departamentos(string usuario) {
            List<capa_presentacion_formaciones.departamento> dep = new List<capa_presentacion_formaciones.departamento>();

            SqlCommand comando = new SqlCommand("select * from DEPARTAMENTOEMPRESA ", conexionbd.ObtenerConexion());
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {

                dep.Add(new capa_presentacion_formaciones.departamento() {iddepartamento= dr["iddepartamentoempresa"].ToString(), nombredepartamento=dr["nombredeptoempresa"].ToString() });

            }
            SQL_Conexion.Close();
            return dep;
        }

        public static List<capa_presentacion_formaciones.area> consultaarea() {
            List<capa_presentacion_formaciones.area> area = new List<capa_presentacion_formaciones.area>();
            SqlCommand comando = new SqlCommand("select * from TIPO where status=1 ", conexionbd.ObtenerConexion());
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {
                area.Add(new capa_presentacion_formaciones.area() { id = dr["idtipo"].ToString(), Nombre_Area = dr["tipo"].ToString(),Descripcion=dr["descripcion"].ToString() });
            }
            SQL_Conexion.Close();
            return area;
        }

        public static int eliminararea(string idarea) {
            int eliminar = 0;

            SqlCommand comando2 = new SqlCommand(" update TIPO set status=0 where idtipo="+idarea, conexionbd.ObtenerConexion());
            eliminar = comando2.ExecuteNonQuery();
            SQL_Conexion.Close();

            return eliminar;
        }

        public static int modificararea(string idarea,string nombre,string descripcion) {
            int modificacion = 0;

            SqlCommand comando2 = new SqlCommand(" update TIPO set tipo='"+nombre+"', descripcion='"+descripcion+"' where idtipo=" + idarea, conexionbd.ObtenerConexion());
            modificacion = comando2.ExecuteNonQuery();
            SQL_Conexion.Close();


            return modificacion;
        }



        public static List<capa_presentacion_formaciones.metrica> metricadep(string idempresa,string departamento) {
            List<capa_presentacion_formaciones.metrica> metrics = new List<capa_presentacion_formaciones.metrica>();


            try
            {
                Convert.ToInt64(departamento);

            }
            catch
            {
                departamento = "0";
            }

            SqlCommand comando = new SqlCommand("select me.idmetrica,me.nommetrica,me.descripmetrica,em.nombre_empresa,dem.nombredeptoempresa from METRICA me join EMPRESA em on em.idempresa = me.idempresa join DEPARTAMENTOEMPRESA dem on dem.iddepartamentoempresa = me.iddepartamentoempresa where me.status = 1 and me.idempresa = " + idempresa+ " and me.iddepartamentoempresa="+departamento, conexionbd.ObtenerConexion());
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {
                metrics.Add(new capa_presentacion_formaciones.metrica() { id = dr["idmetrica"].ToString(), Metrica = dr["nommetrica"].ToString(), Descripcion = dr["descripmetrica"].ToString(), Departamento = dr["nombredeptoempresa"].ToString(), Empresa = dr["nombre_empresa"].ToString() });
            }
            SQL_Conexion.Close();
            return metrics;

        }


        public static int idevaluacion() {
            int id = 0;
            SqlCommand comando = new SqlCommand("select ISNULL(MAX(idevaluacion),0)as id from EVALUACIONDESEMPEÑO", conexionbd.ObtenerConexion());
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {
                id = Convert.ToInt32(dr["id"].ToString());
            }
            SQL_Conexion.Close();
            id = id + 1;
            return id;

        }
        public static int evaluaciondesempeño(string idempleado,string totalevaluacin,string fechainicio,string fechafin,string periodo,string idempresa) {
            int evaluacion = 0;
            int ideva = 0;

            ideva = idevaluacion();

            SqlCommand comando2 = new SqlCommand(" insert into EVALUACIONDESEMPEÑO (idevaluacion,idempleado,totalevaluacion,fechainicio,fechafin,idperiodo,idempresa,estatuseva) values ("+ideva+","+idempleado+","+totalevaluacin+",'"+fechainicio+"','"+fechafin+"',"+periodo+","+idempresa+",1)", conexionbd.ObtenerConexion());
            evaluacion = comando2.ExecuteNonQuery();
            SQL_Conexion.Close();
            return ideva;
            
        }

        public static int actualizararesultado(string idevaluacion,string resultado) {
            int update = 0;
            SqlCommand comando2 = new SqlCommand(" update EVALUACIONDESEMPEÑO set totalevaluacion="+resultado+" where idevaluacion="+idevaluacion, conexionbd.ObtenerConexion());
            update = comando2.ExecuteNonQuery();
            SQL_Conexion.Close();
            return update;
        }

        public static int iddetalle_evaluacion() {
            int id = 0;

            SqlCommand comando = new SqlCommand("select ISNULL(MAX(iddetalle),0)as id from DETALLEEVALUACION", conexionbd.ObtenerConexion());
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {
                id = Convert.ToInt32(dr["id"].ToString());
            }
            SQL_Conexion.Close();
            id = id + 1;
            return id;
        }

        public static int  ingresometrica(string comenhr,string comensup,string comenemp,string totalmetrica,string idmetrica,string idevaluacion) {

            int ingreso = 0;


            int iddeta = 0;

            iddeta = iddetalle_evaluacion();


            SqlCommand comando2 = new SqlCommand("insert into DETALLEEVALUACION (iddetalle,comenhr,totalmetrica,comenempleado,comensupervisor,idmetrica,idevaluacion) values("+iddeta.ToString()+",'"+comenhr+"',"+totalmetrica+",'"+comenemp+"','"+comensup+"',"+idmetrica+","+idevaluacion+")", conexionbd.ObtenerConexion());
            ingreso = comando2.ExecuteNonQuery();
            SQL_Conexion.Close();

            return ingreso;


        }


        public static int metricasevaluadas(string idevaluacion) {
            int evaluadas = 0;
            SqlCommand comando = new SqlCommand("select count(distinct idmetrica) as cuenta from DETALLEEVALUACION where idevaluacion="+idevaluacion, conexionbd.ObtenerConexion());
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {
                evaluadas = Convert.ToInt32(dr["cuenta"].ToString());
            }
            SQL_Conexion.Close();
            return evaluadas;
        }

        public static int totalevaluacion(string idevaluacion) {
            int total = 0;

            SqlCommand comando = new SqlCommand("select sum(totalmetrica) as total from DETALLEEVALUACION where idevaluacion = " + idevaluacion, conexionbd.ObtenerConexion());
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {
                total = Convert.ToInt32(dr["total"].ToString());
            }
            SQL_Conexion.Close();

            return total;
        }

        public static List<capa_presentacion_formaciones.metrica> consultametrica(string empresa) {
            List<capa_presentacion_formaciones.metrica> metric = new List<capa_presentacion_formaciones.metrica>();

            SqlCommand comando = new SqlCommand("select me.idmetrica,me.nommetrica,me.descripmetrica,em.nombre_empresa,dem.nombredeptoempresa from METRICA me join EMPRESA em on em.idempresa = me.idempresa join DEPARTAMENTOEMPRESA dem on dem.iddepartamentoempresa = me.iddepartamentoempresa where me.status = 1 and me.idempresa = " + empresa, conexionbd.ObtenerConexion());
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {
                metric.Add(new capa_presentacion_formaciones.metrica() {id=dr["idmetrica"].ToString(), Metrica= dr["nommetrica"].ToString(),Descripcion= dr["descripmetrica"].ToString(),Departamento= dr["nombredeptoempresa"].ToString(),Empresa= dr["nombre_empresa"].ToString() });
            }
            SQL_Conexion.Close();
            return metric;
        }

        
        public static List<capa_presentacion_formaciones.empleados> empleados(string usuario)
        {
            List<capa_presentacion_formaciones.empleados> emp = new List<capa_presentacion_formaciones.empleados>();

            SqlCommand comando = new SqlCommand("select e.idempleado,e.idempresa,CONCAT(dp.nombre1,' ',dp.nombre2,' ',dp.apellido1,' ', dp.apellido2) as nombre from EMPLEADO e left join DetallePersonal dp on e.idempleado = dp.idempleado ", conexionbd.ObtenerConexion());
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {

                emp.Add(new capa_presentacion_formaciones.empleados() { idempleado = dr["idempleado"].ToString(), empleado = dr["nombre"].ToString() });

            }
            SQL_Conexion.Close();
            return emp;
        }

        public static List<capa_presentacion_formaciones.empleadosdep> empleadosdepartamento(string idempresa,string departamento) {
            if (idempresa == "") {
                idempresa = "0";
            }

         

            try
            {
                Convert.ToInt64(departamento);
                
            }
            catch
            {
                departamento = "0";
            }
            List<capa_presentacion_formaciones.empleadosdep> empdep = new List<capa_presentacion_formaciones.empleadosdep>();
            SqlCommand comando = new SqlCommand("select e.idempleado,e.idempresa,CONCAT(dp.nombre1,' ',dp.nombre2,' ',dp.apellido1,' ', dp.apellido2) as nombre from EMPLEADO e left join DetallePersonal dp on e.idempleado = dp.idempleado join DetalleLaboral dl on dl.idempleado=e.idempleado join PUESTOdeTRABAJO pt on pt.idpuestodetrabajo=dl.idpuestodetrabajo join departamentoempresa demp on demp.iddepartamentoempresa = pt.iddepartamentoempresa  where e.idempresa = "+idempresa+ " and pt.iddepartamentoempresa = " + departamento, conexionbd.ObtenerConexion());
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {

                empdep.Add(new capa_presentacion_formaciones.empleadosdep() { idempleado = dr["idempleado"].ToString(), empleado = dr["nombre"].ToString() });

            }
            SQL_Conexion.Close();

            return empdep;
        }


        

        public static int nuevaarea(string descripcin,string nombre) {
            int nueva = 0;

            SqlCommand comando2 = new SqlCommand(" insert into tipo (descripcion,status,tipo) values('"+descripcin+"',1,'"+nombre+"')", conexionbd.ObtenerConexion());
            nueva = comando2.ExecuteNonQuery();
            SQL_Conexion.Close();

            return nueva;
        }


        public static string id_asignacion2()
        {
            string id = "";

            SqlCommand comando = new SqlCommand("SELECT MAX(idasignacion)as id FROM ASIGNACION_CAPACITACION ", conexionbd.ObtenerConexion());
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {
                id = dr["id"].ToString();

            }
            SQL_Conexion.Close();


            return id;
        }

        public static string empresa_empleado(string empleado) {
            string idempresa = "";

            SqlCommand comando = new SqlCommand("SELECT idempresa from EMPLEADO where idempleado="+empleado, conexionbd.ObtenerConexion());
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {
                idempresa = dr["idempresa"].ToString();

            }
            SQL_Conexion.Close();

            return idempresa;
        }

        public static int consutaidmetrica() {
            int id=0;

            SqlCommand comando = new SqlCommand("select isnull(max(idmetrica),0) as codigo from METRICA", conexionbd.ObtenerConexion());
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {
                id = Convert.ToInt32(dr["codigo"].ToString());

            }
            SQL_Conexion.Close();
            return id+1;
           
        }

        public static int metricanueva(string idempresa,string nombre,string descripcion,string departamento)
        {
            int creacion = 0;
            int idmetrica = 0;
            idmetrica = consutaidmetrica();

            SqlCommand comando2 = new SqlCommand("insert into metrica(idmetrica, nommetrica, descripmetrica, idempresa, status, iddepartamentoempresa) values("+idmetrica+", '"+nombre+"','"+descripcion+"',"+idempresa+", 1, "+departamento+")", conexionbd.ObtenerConexion());
            creacion = comando2.ExecuteNonQuery();
            SQL_Conexion.Close();


            return creacion;
        }

        public static int asignacion(string idcapacitacion, string metodoasignacion, string empleado, string departamento, string fechainicio, string fechafin, string horario,string metodo,string usuario) {
            int rasignacion=0;

            if (metodo == "1")
            {
                SqlCommand comando2 = new SqlCommand(" insert into ASIGNACION_CAPACITACION (asigfecha,idcapacitacion,horario,fecha_inicio,fecha_fin) values(GETDATE()," + idcapacitacion + ",'"+horario+"','"+ fechainicio + "','"+fechafin+"')", conexionbd.ObtenerConexion());
                rasignacion = comando2.ExecuteNonQuery();
                SQL_Conexion.Close();

                string asignacionid = id_asignacion2();
                string empresa = usuario;

                comando2 = new SqlCommand("insert into DETALLEASIGNACION_CAPACITACION (idasignacion,idempleado,idempresa) values (" + asignacionid + "," + empleado + "," + empresa + ")", conexionbd.ObtenerConexion());
                rasignacion = comando2.ExecuteNonQuery();
                SQL_Conexion.Close();

            }
            else if (metodo == "2") {

                string empresa_asig = usuario;

                SqlCommand comando2 = new SqlCommand(" insert into ASIGNACION_CAPACITACION (asigfecha,idcapacitacion,horario,fecha_inicio,fecha_fin) values(GETDATE()," + idcapacitacion + ",'" + horario + "','" + fechainicio + "','" + fechafin + "')", conexionbd.ObtenerConexion());
                rasignacion = comando2.ExecuteNonQuery();
                SQL_Conexion.Close();


                SqlCommand comando = new SqlCommand("select e.idempleado,e.idempresa,demp.nombredeptoempresa from empleado e left join DetalleLaboral dl on e.idempleado = dl.idempleado left join PUESTOdeTRABAJO pt on pt.idpuestodetrabajo = dl.idpuestodetrabajo left  join departamentoempresa demp on demp.iddepartamentoempresa = pt.iddepartamentoempresa where pt.iddepartamentoempresa = " + departamento+ " and e.idestado = 1 and e.idempresa = " + empresa_asig, conexionbd.ObtenerConexion());
                SqlDataReader dr = comando.ExecuteReader();

                while (dr.Read())
                {
                   

                    string asignacionid = id_asignacion2();
                    string empresa = usuario;

                    comando2 = new SqlCommand("insert into DETALLEASIGNACION_CAPACITACION (idasignacion,idempleado,idempresa) values (" + asignacionid + "," + dr["idempleado"].ToString() + "," + empresa + ")", conexionbd.ObtenerConexion());
                    rasignacion = comando2.ExecuteNonQuery();
                  


                }
                SQL_Conexion.Close();
                              
            }
            return rasignacion;
        }

        public static List<capa_presentacion_formaciones.asignacion> consulta_asignacion(string idempresa) {

            List<capa_presentacion_formaciones.asignacion> asig = new List<capa_presentacion_formaciones.asignacion>();

            SqlCommand comando = new SqlCommand("select c.idcapacitacion,c.nombre,COUNT(distinct dc.idasignacion) as asignaciones from CAPACITACION c join ASIGNACION_CAPACITACION a on c.idcapacitacion = a.idcapacitacion join DETALLEASIGNACION_CAPACITACION dc on dc.idasignacion = a.idasignacion where dc.idempresa = "+idempresa+" group by c.nombre, c.idcapacitacion", conexionbd.ObtenerConexion());
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {

                asig.Add(new capa_presentacion_formaciones.asignacion() { id = dr["idcapacitacion"].ToString(), Asignaciones = dr["asignaciones"].ToString(), nombre=dr["nombre"].ToString() });

            }
            SQL_Conexion.Close();

            return asig;
        }


        public static List<capa_presentacion_formaciones.detaasig> consultadetasi(string idcapacitacion,string idempresa) {

            List<capa_presentacion_formaciones.detaasig> detasig = new List<capa_presentacion_formaciones.detaasig>();

            SqlCommand comando = new SqlCommand("select dc.idasignacion,convert(varchar(10), cast(AC.fecha_inicio as date), 103) as fechainicio , convert(varchar(10), cast(AC.fecha_fin as date), 103) as fechafin ,AC.horario,count(dc.idempleado) as empleados from ASIGNACION_CAPACITACION AC join DETALLEASIGNACION_CAPACITACION DC on  AC.idasignacion = DC.idasignacion WHERE AC.idcapacitacion = " + idcapacitacion+" and DC.idempresa = "+idempresa+" group by DC.idasignacion, AC.fecha_inicio, AC.fecha_fin, AC.horario", conexionbd.ObtenerConexion());
            SqlDataReader dr = comando.ExecuteReader();

            string fecha = "";


            while (dr.Read())
            {
                

                detasig.Add(new capa_presentacion_formaciones.detaasig() { Fin = dr["fechafin"].ToString(), Inicio = dr["fechainicio"].ToString(), horario = dr["horario"].ToString(), id = dr["idasignacion"].ToString(),Asignados = dr["empleados"].ToString() });

            }
            SQL_Conexion.Close();

            return detasig;
        }


        public static List<capa_presentacion_formaciones.evaluacionesdesempeñconsulta> consultaevaluacion(string idempresa) {
            List < capa_presentacion_formaciones.evaluacionesdesempeñconsulta > consulta=new List<capa_presentacion_formaciones.evaluacionesdesempeñconsulta>();

            SqlCommand comando = new SqlCommand("select distinct ed.idevaluacion,concat(dp.nombre1,' ',dp.nombre2+' ', dp.apellido1+' '+dp.apellido2) as nombre, e.nombre_empresa,deptoemp.nombredeptoempresa ,p.periodo, CONCAT(convert(varchar(10), cast(ed.fechainicio as date), 103),' - ', convert(varchar(10), cast(ed.fechafin as date), 103)) as fecha, ed.totalevaluacion from EVALUACIONDESEMPEÑO ed join DetallePersonal dp on dp.idempleado = ed.idempleado  join PERIODO p on p.idperiodo = ed.idperiodo join EMPRESA e on e.idempresa = ed.idempresa join DetalleLaboral dl on dl.idempleado = dl.idempleado join PUESTOdeTRABAJO pt on pt.idpuestodetrabajo=dl.idpuestodetrabajo  join departamentoempresa deptoemp on deptoemp.iddepartamentoempresa = pt.iddepartamentoempresa  where e.idempresa = "+idempresa+" and ed.estatuseva = 1", conexionbd.ObtenerConexion());
            SqlDataReader dr = comando.ExecuteReader();

            
            while (dr.Read())
            {


                consulta.Add(new capa_presentacion_formaciones.evaluacionesdesempeñconsulta() {id=dr["idevaluacion"].ToString(), Departamento=dr["nombredeptoempresa"].ToString(),Empleado=dr["nombre"].ToString(),Nombre_Empresa=dr["nombre_empresa"].ToString(),Periodo=dr["periodo"].ToString(),Resultado=dr["totalevaluacion"].ToString(),Fecha=dr["fecha"].ToString() });

            }
            SQL_Conexion.Close();

            return consulta;
        }
        public static List<capa_presentacion_formaciones.info_capa> info_capacitaciones(string usuario) {


            string empresa = usuario;

            List<capa_presentacion_formaciones.info_capa> info_cap = new List<capa_presentacion_formaciones.info_capa>();
            SqlCommand comando = new SqlCommand("select c.idcapacitacion,c.costo,c.nombre,c.descripcion,dc.expositor,t.tipo from CAPACITACION c left join  DETALLECAPACITACION dc on dc.idcapacitacion = c.idcapacitacion left join TIPO t on t.idtipo = dc.idtipo where c.status = 1 and c.idempresa="+empresa+" order by C.idcapacitacion ASC ", conexionbd.ObtenerConexion());
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read()) {

                info_cap.Add(new capa_presentacion_formaciones.info_capa() { idcapacitacion = dr["idcapacitacion"].ToString(), nombre_capa = dr["nombre"].ToString(), descripcion_capa = dr["descripcion"].ToString(), area = dr["tipo"].ToString(), expositor = dr["expositor"].ToString(), costo = dr["costo"].ToString() });

            }
            SQL_Conexion.Close();

            return info_cap;
        }

        public static List<capa_presentacion_formaciones.infotipocapacitacion> info_tipocapacitaciones() {
            List<capa_presentacion_formaciones.infotipocapacitacion> infotipo_cap = new List<capa_presentacion_formaciones.infotipocapacitacion>();
            SqlCommand comando = new SqlCommand("select * from TIPO where status=1", conexionbd.ObtenerConexion());
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {

                infotipo_cap.Add(new capa_presentacion_formaciones.infotipocapacitacion() { idtipo = dr["idtipo"].ToString(), tipo = dr["tipo"].ToString() });

            }
            SQL_Conexion.Close();
            return infotipo_cap;
        }

        public static List<capa_presentacion_formaciones.infodetasig> infodetalleasignacion(string idcapacitacion) {
            List<capa_presentacion_formaciones.infodetasig> infodeas = new List<capa_presentacion_formaciones.infodetasig>();

            SqlCommand comando = new SqlCommand("select CONCAT(dp.nombre1,' ', nombre2,' ',apellido1,' ',apellido2)as nombre,demp.nombredeptoempresa as departamento, pt.nombrepuesto from ASIGNACION_CAPACITACION ac join DETALLEASIGNACION_CAPACITACION dc ON ac.idasignacion = dc.idasignacion join DetallePersonal dp on dp.idempleado = dc.idempleado join detallelaboral dl on dl.idempleado = dc.idempleado join PUESTOdeTRABAJO pt on pt.idpuestodetrabajo = dl.idpuestodetrabajo join departamentoempresa demp on demp.iddepartamentoempresa = pt.iddepartamentoempresa where dc.idasignacion = "+ idcapacitacion, conexionbd.ObtenerConexion());
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {

                infodeas.Add(new capa_presentacion_formaciones.infodetasig() {Empleado=dr["nombre"].ToString(),Departamento=dr["departamento"].ToString(), Puesto=dr["nombrepuesto"].ToString()  });

            }
            SQL_Conexion.Close();

            return infodeas;

        }


        public static int modificar_capacitacion(string id_capacitacion, string nombre, string descripcion, string expositor, string costo, string area) {

            int modificacion = 0;
            SqlCommand comando = new SqlCommand("  update CAPACITACION set nombre='" + nombre + "' , descripcion='" + descripcion + "' where idcapacitacion=" + id_capacitacion, conexionbd.ObtenerConexion());
            modificacion = comando.ExecuteNonQuery();
            SQL_Conexion.Close();


            SqlCommand comando2 = new SqlCommand("  update DETALLECAPACITACION set expositor='" + expositor + "', idtipo=" + area + " where idcapacitacion=" + id_capacitacion, conexionbd.ObtenerConexion());
            modificacion = comando2.ExecuteNonQuery();
            SQL_Conexion.Close();

            return modificacion;
        }

        public static int eliminar_capacitacion(string id_capacitacion) {
            int eliminar = 0;

            SqlCommand comando2 = new SqlCommand(" update CAPACITACION set status=0 where idcapacitacion=" + id_capacitacion, conexionbd.ObtenerConexion());
            eliminar = comando2.ExecuteNonQuery();
            SQL_Conexion.Close();


            return eliminar;
            ;
        }


        public static string consulta_empresa(string usuario) {
            string empresa="";

            SqlCommand comando = new SqlCommand("select e.idempresa from USUARIO_1 u left join EMPLEADO e on u.codusuario = e.codusuario where u.usuario = '"+usuario+"'", conexionbd.ObtenerConexion());
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {
                empresa = dr["idempresa"].ToString();

            }
            SQL_Conexion.Close();


            return empresa;
        }



        public static string cod_capacitacion(string nombre, string empresa, string descripcion) {
            string codigo="";

            SqlCommand comando = new SqlCommand("select idcapacitacion from CAPACITACION where status=1 and nombre='"+nombre+"' and descripcion='"+descripcion+"' and idempresa="+empresa, conexionbd.ObtenerConexion());
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {
                codigo = dr["idcapacitacion"].ToString();

            }
            SQL_Conexion.Close();
            return codigo;
        }

        public static string consultardepartamentoid(string departamentonombre) {
            string id = "";

            SqlCommand comando = new SqlCommand("select iddepartamentoempresa from DEPARTAMENTOEMPRESA where nombredeptoempresa='" + departamentonombre + "' ", conexionbd.ObtenerConexion());
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {
                id = dr["iddepartamentoempresa"].ToString();

            }
            SQL_Conexion.Close();
            return id;

        }

        public static string idtipoarea(string area) {
            string id = "";
            SqlCommand comando = new SqlCommand("select idtipo from tipo where tipo='" + area + "' ", conexionbd.ObtenerConexion());
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {
                id = dr["idtipo"].ToString();

            }
            SQL_Conexion.Close();
            return id;
        }


        public static List<capa_presentacion_formaciones.periodo> consultasperido()
        {

            List<capa_presentacion_formaciones.periodo> per = new List<capa_presentacion_formaciones.periodo>();

            SqlCommand comando = new SqlCommand("select * from PERIODO where status=1", conexionbd.ObtenerConexion());
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {
                per.Add(new capa_presentacion_formaciones.periodo() {id=dr["idperiodo"].ToString(), Periodo=dr["periodo"].ToString() });

            }
            SQL_Conexion.Close();

            return per;

        }

        public static int modificarmetrica(string metricaid,string nombre,string descripcion,string departamento) {
            int modificar = 0;

            SqlCommand comando2 = new SqlCommand("update METRICA set nommetrica='"+nombre+ "', descripmetrica='"+descripcion+ "',iddepartamentoempresa="+departamento+" where idmetrica="+metricaid, conexionbd.ObtenerConexion());
            modificar = comando2.ExecuteNonQuery();
            SQL_Conexion.Close();

            return modificar;
        }

        public static int cidperiodo() {
            int id=0;

            SqlCommand comando = new SqlCommand("select ISNULL(MAX(idperiodo),0)as id from periodo", conexionbd.ObtenerConexion());
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {
                id = Convert.ToInt32(dr["id"].ToString());
            }
            SQL_Conexion.Close();
            id = id + 1;

            return id;
        }

        public static int crearperiodo(string periodo) {
            int creacion = 0;
            int idperiodo = 0;

            idperiodo = cidperiodo();
            SqlCommand comando2 = new SqlCommand("insert into PERIODO (idperiodo,periodo,status) values("+idperiodo+",'"+periodo+"',1)", conexionbd.ObtenerConexion());
            creacion = comando2.ExecuteNonQuery();
            SQL_Conexion.Close();

            return creacion;
        }

        public static int modificarperiodo(string periodo,string nombrepre)
        {
            int modificar = 0;

            SqlCommand comando2 = new SqlCommand("update PERIODO set periodo='"+ nombrepre + "' where idperiodo="+periodo, conexionbd.ObtenerConexion());
            modificar = comando2.ExecuteNonQuery();
            SQL_Conexion.Close();

            return modificar;
        }

        public static int eliminarperiodo(string idperiodo) {
            int eliminar = 0;

            SqlCommand comando2 = new SqlCommand("update PERIODO set status=0 where idperiodo=" + idperiodo, conexionbd.ObtenerConexion());
            eliminar = comando2.ExecuteNonQuery();
            SQL_Conexion.Close();
            return eliminar;
        }

        public static int eliminarmetrica(string idmetrica) {
            int eliminar = 0;
            SqlCommand comando2 = new SqlCommand("update METRICA set status=0 where idmetrica="+idmetrica, conexionbd.ObtenerConexion());
            eliminar = comando2.ExecuteNonQuery();
            SQL_Conexion.Close();

            return eliminar;
        }


       
        public static int nueva_capacitacion(string nombre, string descripcion, string expositor, string costo, string area, string usuario) {
            int nuevo = 0;

            // string empresa = consulta_empresa(usuario);

            string empresa = usuario;

            SqlCommand comando2 = new SqlCommand("insert into CAPACITACION (fechapago,costo,nombre,descripcion,status,idempresa) values(GETDATE(),"+costo+",'"+nombre+"','"+descripcion+"',1,"+empresa+")", conexionbd.ObtenerConexion());
            nuevo = comando2.ExecuteNonQuery();
            SQL_Conexion.Close();

            string idcapacitacion = cod_capacitacion(nombre, empresa, descripcion);

            comando2 = new SqlCommand("insert into DETALLECAPACITACION(expositor, idtipo, idcapacitacion) values('"+expositor+"',"+area+","+idcapacitacion+")", conexionbd.ObtenerConexion());
            nuevo = comando2.ExecuteNonQuery();
            SQL_Conexion.Close();

            return nuevo;
        } 

        public static int LoginD(string sUser, string sContra)
        {
            string ecrypt = classEncryptD.Encrypt(sContra);

            int retorno = 0;
            SqlCommand comando2 = new SqlCommand("Select usuario from USUARIO_1 WHERE usuario='" + sUser + "'And password ='" + ecrypt + "'", conexionbd.ObtenerConexion());
            Object obj = comando2.ExecuteScalar();
            if (obj == null)
            {
                retorno = 0;
                SQL_Conexion.Close();
            }
            else
            {
                retorno = 1;
                SQL_Conexion.Close();
            }
            //devolvvemos la variable
            return retorno;

            SQL_Conexion.Close();
        }


        public static DataTable ObtenerRegistros(string sUser)
        {
            DataTable dtRegistros = new DataTable();//Tabla de datos
            try
            {//Llamada de Conexion y Query
                SqlCommand comando = new SqlCommand(string.Format("SELECT c.usuario , b.nombre_empresa FROM EMPLEADO A INNER JOIN Empresa B ON A.idempresa = B.idempresa INNER JOIN USUARIO_1 C ON C.codusuario = A.codusuario WHERE C.usuario = '" + sUser + "';"), conexionbd.ObtenerConexion());
                SqlDataAdapter SqlDAdAdaptador = new SqlDataAdapter();
                SqlDAdAdaptador.SelectCommand = comando;
                SqlDAdAdaptador.Fill(dtRegistros);//Llena la tabla dtRegistros
                SQL_Conexion.Close();
            }
            catch (Exception Ex)
            {
            }
            return dtRegistros;
        }
    }
}
