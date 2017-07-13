using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class capa_logica_planillas
    {
        public static SqlConnection SQL_Conexion = new SqlConnection();

        public static int beginTransaction()
        {
            int response = 0;
            //string sqlString = "BEGIN TRANSACTION";
            //SqlCommand cmd = new SqlCommand(sqlString, conexionbd.ObtenerConexion());
            SqlCommand cmd = conexionbd.ObtenerConexion().CreateCommand();
            SqlTransaction transaction;

            // Start a local transaction.
            transaction = conexionbd.ObtenerConexion().BeginTransaction("");

            response = cmd.ExecuteNonQuery();

            return response;
        }

        public static int commit()
        {
            int response = 0;
            SqlTransaction transaction;
            transaction = conexionbd.ObtenerConexion().BeginTransaction("");

            //response = cmd.ExecuteNonQuery();

            return response;
        }

        public static int rollback()
        {
            int response = 0;
            string sqlString = "ROLLBACK";
            SqlCommand cmd = new SqlCommand(sqlString, conexionbd.ObtenerConexion());

            response = cmd.ExecuteNonQuery();

            return response;
        }

        public static List<capa_presentacion_planillas.cbx_periodo> cbx_periodo()
        {
            List<capa_presentacion_planillas.cbx_periodo> cbx_periodo = new List<capa_presentacion_planillas.cbx_periodo>();

            SqlCommand cmd = new SqlCommand("SELECT * FROM periodoplanilla ORDER BY id ASC", conexionbd.ObtenerConexion());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cbx_periodo.Add(new capa_presentacion_planillas.cbx_periodo() { idperiodo = dr["id"].ToString(), mes = dr["mes"].ToString() +  " del    " + dr["year"].ToString() });
            }

            return cbx_periodo;
        }

        public static List<capa_presentacion_planillas.cbx_tipo> cbx_tipo()
        {
            List<capa_presentacion_planillas.cbx_tipo> cbx_tipo = new List<capa_presentacion_planillas.cbx_tipo>();

            cbx_tipo.Add(new capa_presentacion_planillas.cbx_tipo() { idtipo = "1", descripcion = "Percepción" });
            cbx_tipo.Add(new capa_presentacion_planillas.cbx_tipo() { idtipo = "2", descripcion = "Deducción" });

            return cbx_tipo;
        }

        public static List<capa_presentacion_planillas.cbx_tipoPago> cbx_tipoPago()
        {
            List<capa_presentacion_planillas.cbx_tipoPago> cbx_tipoPago = new List<capa_presentacion_planillas.cbx_tipoPago>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tipopago", conexionbd.ObtenerConexion());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cbx_tipoPago.Add(new capa_presentacion_planillas.cbx_tipoPago() { idtipopago = dr["idtipopago"].ToString(), descripcion = dr["descripcion"].ToString()});
            }

            return cbx_tipoPago;
        }

        public static List<capa_presentacion_planillas.cbx_bondesc> cbx_bondesc()
        {
            List<capa_presentacion_planillas.cbx_bondesc> cbx_bondesc = new List<capa_presentacion_planillas.cbx_bondesc>();

            cbx_bondesc.Add(new capa_presentacion_planillas.cbx_bondesc() { idbondesc = "1", descripcion = "Nomina Aplicada" });
            cbx_bondesc.Add(new capa_presentacion_planillas.cbx_bondesc() { idbondesc = "2", descripcion = "Nomina sin Aplicar" });

            return cbx_bondesc;
        }

        public static List<capa_presentacion_planillas.ListPercepciones> showListPercepciones()
        {
            List<capa_presentacion_planillas.ListPercepciones> listPercepciones = new List<capa_presentacion_planillas.ListPercepciones>();
            SqlCommand cmd = new SqlCommand("SELECT idbonificacion, descripcion, porcentaje, monto_fijo FROM bonificaciones", conexionbd.ObtenerConexion());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                listPercepciones.Add(new capa_presentacion_planillas.ListPercepciones() { idbonificacion = dr["idbonificacion"].ToString(), descripcion = dr["descripcion"].ToString(), porcentaje = dr["porcentaje"].ToString(), monto_fijo = dr["porcentaje"].ToString() });
            }

            return listPercepciones;
        }

        public static List<capa_presentacion_planillas.ListDeducciones> showListDeducciones()
        {
            List<capa_presentacion_planillas.ListDeducciones> listDeducciones = new List<capa_presentacion_planillas.ListDeducciones>();
            SqlCommand cmd = new SqlCommand("SELECT iddescuento, descripcion, porcentaje, monto_fijo FROM descuentos", conexionbd.ObtenerConexion());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                listDeducciones.Add(new capa_presentacion_planillas.ListDeducciones() { iddescuento = dr["iddescuento"].ToString(), descripcion = dr["descripcion"].ToString(), porcentaje = dr["porcentaje"].ToString(), monto_fijo = dr["porcentaje"].ToString() });
            }

            return listDeducciones;
        }

        public static List<capa_presentacion_planillas.showPagoDescuentos> showPercepciones()
        {

            List<capa_presentacion_planillas.showPagoDescuentos> showPagoDescuentos = new List<capa_presentacion_planillas.showPagoDescuentos>();
            string sqlText = "SELECT bon.idbonificacion, bon.descripcion, bon.porcentaje, bon.monto_fijo, tpg.descripcion AS tipoPago, s.nombre_sede FROM bonificaciones bon " +
                                " JOIN tipopago tpg ON tpg.idtipopago = bon.idtipopago " +
                                " JOIN sede s ON s.idsede = bon.id_sede";

            SqlCommand cmd = new SqlCommand(sqlText, conexionbd.ObtenerConexion());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                showPagoDescuentos.Add(new capa_presentacion_planillas.showPagoDescuentos() { id = dr["idbonificacion"].ToString(), descripcion = dr["descripcion"].ToString(), porcentaje = dr["porcentaje"].ToString(), monto_fijo = dr["monto_fijo"].ToString(), tipoPago = dr["tipoPago"].ToString(), nombre_sede = dr["nombre_sede"].ToString() });
            }

            return showPagoDescuentos;
        }

        public static List<capa_presentacion_planillas.showPagoDescuentos> showDeducciones()
        {

            List<capa_presentacion_planillas.showPagoDescuentos> showPagoDescuentos = new List<capa_presentacion_planillas.showPagoDescuentos>();
            string sqlText = "SELECT des.iddescuento, des.descripcion, des.porcentaje, des.monto_fijo, tpg.descripcion AS tipoPago, s.nombre_sede FROM descuentos des " +
                                " JOIN tipopago tpg ON tpg.idtipopago = des.idtipopago " +
                                " JOIN sede s ON s.idsede = des.id_sede";

            SqlCommand cmd = new SqlCommand(sqlText, conexionbd.ObtenerConexion());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                showPagoDescuentos.Add(new capa_presentacion_planillas.showPagoDescuentos() { id = dr["iddescuento"].ToString(), descripcion = dr["descripcion"].ToString(), porcentaje = dr["porcentaje"].ToString(), monto_fijo = dr["monto_fijo"].ToString(), tipoPago = dr["tipoPago"].ToString(), nombre_sede = dr["nombre_sede"].ToString() });
            }

            return showPagoDescuentos;
        }

        public static int  savePercepciones(string descripcion, string porcentaje, string monto, int idtipopago, int idperiodo)
        {
            int response = 0;
            decimal porcentajeDecimal = decimal.Parse(porcentaje);
            decimal montoDecimal = decimal.Parse(monto);

            string sqlString = "INSERT INTO bonificaciones (idtipobonificacion, idtipopago, idperiodo, id_sede, descripcion, porcentaje, monto_fijo, defaultt, estado) VALUES (1, @idtipopago, @idperiodo, 2, @descripcion, @porcentaje, @monto_fijo, @defaultt, @estado)";
            SqlCommand cmd = new SqlCommand(sqlString, conexionbd.ObtenerConexion());

            //cmd.Parameters.Add("@idtipobonificacion", SqlDbType.Int);
            cmd.Parameters.Add("@idtipopago", SqlDbType.Int);
            cmd.Parameters.Add("@idperiodo", SqlDbType.Int);
            //cmd.Parameters.Add("@id_sede", SqlDbType.Int);
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar);
            cmd.Parameters.Add("@porcentaje", SqlDbType.Decimal);
            cmd.Parameters.Add("@monto_fijo", SqlDbType.Decimal);
            cmd.Parameters.Add("@defaultt", SqlDbType.Int);
            cmd.Parameters.Add("@estado", SqlDbType.Int);

            cmd.Parameters["@idtipopago"].Value = idtipopago;
            cmd.Parameters["@idperiodo"].Value = idperiodo;
            cmd.Parameters["@descripcion"].Value = descripcion;
            cmd.Parameters["@porcentaje"].Value = porcentajeDecimal;
            cmd.Parameters["@monto_fijo"].Value = montoDecimal;
            cmd.Parameters["@defaultt"].Value = 1;
            cmd.Parameters["@estado"].Value = 1;

            response = cmd.ExecuteNonQuery();

            return response;
        }

        public static int saveDeducciones(string descripcion, string porcentaje, string monto, int idtipopago, int idperiodo)
        {
            int response = 0;
            decimal porcentajeDecimal = decimal.Parse(porcentaje);
            decimal montoDecimal = decimal.Parse(monto);

            string sqlString = "INSERT INTO descuentos (idtipodescuento, idtipopago, idperiodo, id_sede, descripcion, porcentaje, monto_fijo, defaultt, estado) VALUES (1, @idtipodescuento, @idperiodo, 2, @descripcion, @porcentaje, @monto_fijo, @defaultt, @estado)";
            SqlCommand cmd = new SqlCommand(sqlString, conexionbd.ObtenerConexion());

            //cmd.Parameters.Add("@idtipobonificacion", SqlDbType.Int);
            cmd.Parameters.Add("@idtipodescuento", SqlDbType.Int);
            cmd.Parameters.Add("@idperiodo", SqlDbType.Int);
            //cmd.Parameters.Add("@id_sede", SqlDbType.Int);
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar);
            cmd.Parameters.Add("@porcentaje", SqlDbType.Decimal);
            cmd.Parameters.Add("@monto_fijo", SqlDbType.Decimal);
            cmd.Parameters.Add("@defaultt", SqlDbType.Int);
            cmd.Parameters.Add("@estado", SqlDbType.Int);

            cmd.Parameters["@idtipodescuento"].Value = idtipopago;
            cmd.Parameters["@descripcion"].Value = descripcion;
            cmd.Parameters["@idperiodo"].Value = idperiodo;
            cmd.Parameters["@porcentaje"].Value = porcentajeDecimal;
            cmd.Parameters["@monto_fijo"].Value = montoDecimal;
            cmd.Parameters["@defaultt"].Value = 1;
            cmd.Parameters["@estado"].Value = 1;

            response = cmd.ExecuteNonQuery();

            return response;
        }

        public static int updatePercepciones(int idbonificacion, string descripcion, string porcentaje, string monto, int idtipopago, int idperiodo)
        {
            int response = 0;
            decimal porcentajeDecimal = decimal.Parse(porcentaje);
            decimal montoDecimal = decimal.Parse(monto);

            string sqlString = "UPDATE bonificaciones SET " +
                                "idtipopago = @idtipopago, " +
                                "descripcion = @descripcion, " + 
                                "porcentaje = @porcentaje, " +
                                "monto_fijo = @monto_fijo " +
                                "WHERE idbonificacion = @idbonificacion;";
            SqlCommand cmd = new SqlCommand(sqlString, conexionbd.ObtenerConexion());

            cmd.Parameters.Add("@idbonificacion", SqlDbType.Int);
            cmd.Parameters.Add("@idtipopago", SqlDbType.Int);
            cmd.Parameters.Add("@idperiodo", SqlDbType.Int);
            //cmd.Parameters.Add("@id_sede", SqlDbType.Int);
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar);
            cmd.Parameters.Add("@porcentaje", SqlDbType.Decimal);
            cmd.Parameters.Add("@monto_fijo", SqlDbType.Decimal);

            cmd.Parameters["@idbonificacion"].Value = idbonificacion;
            cmd.Parameters["@idtipopago"].Value = idtipopago;
            cmd.Parameters["@descripcion"].Value = descripcion;
            cmd.Parameters["@idperiodo"].Value = idperiodo;
            cmd.Parameters["@porcentaje"].Value = porcentajeDecimal;
            cmd.Parameters["@monto_fijo"].Value = montoDecimal;

            response = cmd.ExecuteNonQuery();

            return response;
        }

        public static int updateDeducciones(int iddescuento, string descripcion, string porcentaje, string monto, int idtipopago,int  idperiodo)
        {
            int response = 0;
            decimal porcentajeDecimal = decimal.Parse(porcentaje);
            decimal montoDecimal = decimal.Parse(monto);

            string sqlString = "UPDATE descuentos SET " +
                                "idtipopago = @idtipopago, " +
                                "descripcion = @descripcion, " +
                                "porcentaje = @porcentaje, " +
                                "monto_fijo = @monto_fijo " +
                                "WHERE iddescuento = @iddescuento;";
            SqlCommand cmd = new SqlCommand(sqlString, conexionbd.ObtenerConexion());

            cmd.Parameters.Add("@iddescuento", SqlDbType.Int);
            cmd.Parameters.Add("@idtipopago", SqlDbType.Int);
            cmd.Parameters.Add("@idperiodo", SqlDbType.Int);
            //cmd.Parameters.Add("@id_sede", SqlDbType.Int);
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar);
            cmd.Parameters.Add("@porcentaje", SqlDbType.Decimal);
            cmd.Parameters.Add("@monto_fijo", SqlDbType.Decimal);

            cmd.Parameters["@iddescuento"].Value = iddescuento;
            cmd.Parameters["@idtipopago"].Value = idtipopago;
            cmd.Parameters["@descripcion"].Value = descripcion;
            cmd.Parameters["@idperiodo"].Value = idperiodo;
            cmd.Parameters["@porcentaje"].Value = porcentajeDecimal;
            cmd.Parameters["@monto_fijo"].Value = montoDecimal;

            response = cmd.ExecuteNonQuery();

            return response;
        }

        public static List<capa_presentacion_planillas.showEmpleados> showEmpleados()
        {
            List<capa_presentacion_planillas.showEmpleados> showEmpleados = new List<capa_presentacion_planillas.showEmpleados>();
            string sqlTet = " SELECT e.idempleado, emp.nombre_empresa, e.nombre1, e.nombre2, e.apellido1, e.apellido2, 1 AS tipo, bon.idbonificacion AS cuenta, bon.descripcion, bon.monto_fijo, " +
                            " CASE WHEN bon.monto_fijo > 0 " +
                            "    THEN 0 " +
                            "    ELSE bper.monto " +
                            " END as porcentaje, " +
                            " detl.sueldo, detl.aumento " +
                            " FROM detallepersonal e " +
                            " JOIN detallelaboral detl ON detl.idempleado = e.idempleado " +
                            " JOIN empresa emp ON emp.idempresa = e.idempresa " +
                            " JOIN detallebonemp bper ON bper.idempleado = e.idempleado " +
                            " JOIN bonificaciones bon ON bon.idbonificacion = bper.idbonificacion " +
                            " WHERE bper.estado = 1" +
                            " UNION " +
                            " SELECT e.idempleado, emp.nombre_empresa, e.nombre1, e.nombre2, e.apellido1, e.apellido2, 2 AS tipo, desct.iddescuento AS cuenta, desct.descripcion, desct.monto_fijo, " +
                            " CASE WHEN desct.monto_fijo > 0 " +
                            "    THEN 0 " +
                            "    ELSE demp.monto " +
                            " END as porcentaje, " +
                            " detl.sueldo, detl.aumento " +
                            " FROM detallepersonal e " +
                            " JOIN detallelaboral detl ON detl.idempleado = e.idempleado " +
                            " JOIN empresa emp ON emp.idempresa = e.idempresa " +
                            " JOIN detalledescemp demp ON demp.idempleado = e.idempleado " +
                            " JOIN descuentos desct ON desct.iddescuento = demp.iddescuento" +
                            " WHERE demp.estado = 1 " +
                            " ORDER BY e.idempleado, tipo ASC ";

            SqlCommand cmd = new SqlCommand(sqlTet, conexionbd.ObtenerConexion());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                showEmpleados.Add(new capa_presentacion_planillas.showEmpleados() { idempleado = dr["idempleado"].ToString(), nombre_empresa = dr["nombre_empresa"].ToString(), nombre1 = dr["nombre1"].ToString(), nombre2 = dr["nombre2"].ToString(), apellido1 = dr["apellido1"].ToString(), apellido2 = dr["apellido2"].ToString(), tipo = dr["tipo"].ToString(), cuenta = dr["cuenta"].ToString(), descripcion = dr["descripcion"].ToString(), monto_fijo = dr["monto_fijo"].ToString(), porcenteje = dr["porcentaje"].ToString(), sueldo = dr["sueldo"].ToString(), aumento = dr["aumento"].ToString() });
            }

            return showEmpleados;
        }

        public static List<capa_presentacion_planillas.showEmpleadosSinNomina> showEmpleadosSinNomina()
        {
            List<capa_presentacion_planillas.showEmpleadosSinNomina> showEmpleados = new List<capa_presentacion_planillas.showEmpleadosSinNomina>();
            string sqlTet = "SELECT e.idempleado, emp.nombre_empresa, e.nombre1, e.nombre2, e.apellido1, e.apellido2, emp.nombre_empresa, detl.sueldo, detl.aumento " +
                            "FROM detallepersonal e " +
                            "JOIN detallelaboral detl ON detl.idempleado = e.idempleado " + 
                            "JOIN empresa emp ON emp.idempresa = e.idempresa " +
                             "WHERE e.idempleado not in ( " +
                                "SELECT idempleado FROM detallebonemp WHERE estado = 1 " +
                             ") " +
                             "AND e.idempleado NOT IN ( " +
                                "SELECT idempleado FROM detalledescemp WHERE estado = 1" +
                             ") ";

            SqlCommand cmd = new SqlCommand(sqlTet, conexionbd.ObtenerConexion());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                showEmpleados.Add(new capa_presentacion_planillas.showEmpleadosSinNomina() { idempleado = dr["idempleado"].ToString(), nombre_empresa = dr["nombre_empresa"].ToString(), nombre1 = dr["nombre1"].ToString(), nombre2 = dr["nombre2"].ToString(), apellido1 = dr["apellido1"].ToString(), apellido2 = dr["apellido2"].ToString(), sueldo = dr["sueldo"].ToString(), aumento = dr["aumento"].ToString() });
            }

            return showEmpleados;
        }

        public static int saveEmpleadoPercepcion(string percepcion, string empleado)
        {
            int response = 0;
            string sqlString = "INSERT INTO detallebonemp " +
                                "(iddetallebonemp, idempleado, idbonificacion, monto, estado, idempresa) " +
                                "VALUES " +
                                "((SELECT COALESCE(MAX(iddetallebonemp + 1), 1) FROM detallebonemp), " +
                                "@empleado, @percepcion, " +
                                "(" +
                                    "SELECT " +
                                        "CASE WHEN (select porcentaje from bonificaciones where idbonificacion = @percepcion) != 0 THEN " +
                                            "cast((((e.sueldo + e.aumento) * (select porcentaje from bonificaciones where idbonificacion = @percepcion)) / 100) as decimal(10,2)) " +
                                        "ELSE " +
                                            "cast((select monto_fijo  from bonificaciones where idbonificacion = @percepcion) as decimal(10,2)) " +
                                        "END AS monto " +
                                    "FROM detallelaboral e " +
                                    "WHERE e.idempleado = @empleado " +
                                "), " +
                                "1, 1)";

            SqlCommand cmd = new SqlCommand(sqlString, conexionbd.ObtenerConexion());

            cmd.Parameters.Add("@empleado", SqlDbType.Int);
            cmd.Parameters.Add("@percepcion", SqlDbType.Int);

            cmd.Parameters["@percepcion"].Value = Convert.ToInt32(percepcion);
            cmd.Parameters["@empleado"].Value = Convert.ToInt32(empleado);

            response = cmd.ExecuteNonQuery();

            return response;
        }

        public static int undoEmpleadosNomina(string empleado)
        {
            int response = 0;
            string sqlString = "UPDATE detallebonemp SET " +
                                "estado = 0 " +
                                "WHERE idempleado = @empleado; " +
                                "UPDATE detalledescemp SET " +
                                "estado = 0 " +
                                "WHERE idempleado = @empleado;";

            SqlCommand cmd = new SqlCommand(sqlString, conexionbd.ObtenerConexion());

            cmd.Parameters.Add("@empleado", SqlDbType.Int);
            cmd.Parameters["@empleado"].Value = Convert.ToInt32(empleado);

            response = cmd.ExecuteNonQuery();

            return response;
        }

        public static int saveEmpleadoDeduccion(string deduccion, string empleado)
        {
            int response = 0;
            string sqlString = "INSERT INTO detalledescemp" +
                                "(iddetalledescemp, idempleado, iddescuento, monto, estado, idempresa) " +
                                "VALUES " +
                                "((SELECT COALESCE(MAX(iddetalledescemp + 1), 1) FROM detalledescemp), " + 
                                "@empleado, @deduccion, " +
                                "(" +
                                    "SELECT " +
                                        "CASE WHEN (select porcentaje from descuentos where iddescuento = @deduccion) != 0 THEN " +
                                            "cast((((e.sueldo + e.aumento) * (select porcentaje from descuentos where iddescuento = @deduccion)) / 100) as decimal(10,2)) " +
                                        "ELSE " +
                                            "cast((select monto_fijo  from descuentos where iddescuento = @deduccion) as decimal(10,2)) " +
                                        "END AS monto " +
                                    "FROM detallelaboral e " +
                                    "WHERE e.idempleado = @empleado " +
                                "), " +
                                "1, 1)";

            SqlCommand cmd = new SqlCommand(sqlString, conexionbd.ObtenerConexion());

            cmd.Parameters.Add("@empleado", SqlDbType.Int);
            cmd.Parameters.Add("@deduccion", SqlDbType.Int);

            cmd.Parameters["@deduccion"].Value = Convert.ToInt32(deduccion);
            cmd.Parameters["@empleado"].Value = Convert.ToInt32(empleado);

            response = cmd.ExecuteNonQuery();

            return response;
        }
    }
}
