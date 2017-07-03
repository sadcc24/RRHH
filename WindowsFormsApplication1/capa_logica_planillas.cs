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

        public static List<capa_presentacion_planillas.ListPercepciones> showListPercepciones()
        {
            List<capa_presentacion_planillas.ListPercepciones> listPercepciones = new List<capa_presentacion_planillas.ListPercepciones>();
            SqlCommand cmd = new SqlCommand("SELECT idbonificacion, descripcion FROM bonificaciones", conexionbd.ObtenerConexion());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                listPercepciones.Add(new capa_presentacion_planillas.ListPercepciones() { idbonificacion = dr["idbonificacion"].ToString(), descripcion = dr["descripcion"].ToString() });
            }

            return listPercepciones;
        }

        public static List<capa_presentacion_planillas.ListDeducciones> showListDeducciones()
        {
            List<capa_presentacion_planillas.ListDeducciones> listDeducciones = new List<capa_presentacion_planillas.ListDeducciones>();
            SqlCommand cmd = new SqlCommand("SELECT iddescuento, descripcion FROM descuentos", conexionbd.ObtenerConexion());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                listDeducciones.Add(new capa_presentacion_planillas.ListDeducciones() { iddescuento = dr["iddescuento"].ToString(), descripcion = dr["descripcion"].ToString() });
            }

            return listDeducciones;
        }

        public static List<capa_presentacion_planillas.showPagoDescuentos> showPercepciones()
        {

            List<capa_presentacion_planillas.showPagoDescuentos> showPagoDescuentos = new List<capa_presentacion_planillas.showPagoDescuentos>();
            string sqlText = "SELECT bon.descripcion, bon.porcentaje, tpg.descripcion AS tipoPago, s.nombre_sede FROM bonificaciones bon " +
                                " JOIN tipopago tpg ON tpg.idtipopago = bon.idtipopago " +
                                " JOIN sede s ON s.idsede = bon.id_sede";

            SqlCommand cmd = new SqlCommand(sqlText, conexionbd.ObtenerConexion());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                showPagoDescuentos.Add(new capa_presentacion_planillas.showPagoDescuentos() { descripcion = dr["descripcion"].ToString(), porcentaje = dr["porcentaje"].ToString(), tipoPago = dr["tipoPago"].ToString(), nombre_sede = dr["nombre_sede"].ToString() });
            }

            return showPagoDescuentos;
        }

        public static List<capa_presentacion_planillas.showPagoDescuentos> showDeducciones()
        {

            List<capa_presentacion_planillas.showPagoDescuentos> showPagoDescuentos = new List<capa_presentacion_planillas.showPagoDescuentos>();
            string sqlText = "SELECT des.descripcion, des.porcentaje, tpg.descripcion AS tipoPago, s.nombre_sede FROM descuentos des " +
                                " JOIN tipopago tpg ON tpg.idtipopago = des.idtipopago " +
                                " JOIN sede s ON s.idsede = des.id_sede";

            SqlCommand cmd = new SqlCommand(sqlText, conexionbd.ObtenerConexion());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                showPagoDescuentos.Add(new capa_presentacion_planillas.showPagoDescuentos() { descripcion = dr["descripcion"].ToString(), porcentaje = dr["porcentaje"].ToString(), tipoPago = dr["tipoPago"].ToString(), nombre_sede = dr["nombre_sede"].ToString() });
            }

            return showPagoDescuentos;
        }

        public static int  savePercepciones(string descripcion, string porcentaje, int idtipopago)
        {
            int response = 0;
            decimal porcentajeDecimal = decimal.Parse(porcentaje);

            string sqlString = "INSERT INTO bonificaciones (idbonificacion, idtipobonificacion, idtipopago, id, id_sede, descripcion, porcentaje, defaultt, estado) VALUES ((SELECT COALESCE(MAX(idbonificacion + 1), 1) FROM bonificaciones), 1, @idtipopago, 1, 1, @descripcion, @porcentaje, @defaultt, @estado)";
            SqlCommand cmd = new SqlCommand(sqlString, conexionbd.ObtenerConexion());

            //cmd.Parameters.Add("@idtipobonificacion", SqlDbType.Int);
            cmd.Parameters.Add("@idtipopago", SqlDbType.Int);
            //cmd.Parameters.Add("@id", SqlDbType.Int);
            //cmd.Parameters.Add("@id_sede", SqlDbType.Int);
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar);
            cmd.Parameters.Add("@porcentaje", SqlDbType.Decimal);
            cmd.Parameters.Add("@defaultt", SqlDbType.Int);
            cmd.Parameters.Add("@estado", SqlDbType.Int);

            cmd.Parameters["@idtipopago"].Value = idtipopago;
            cmd.Parameters["@descripcion"].Value = descripcion;
            cmd.Parameters["@porcentaje"].Value = porcentajeDecimal;
            cmd.Parameters["@defaultt"].Value = 1;
            cmd.Parameters["@estado"].Value = 1;

            response = cmd.ExecuteNonQuery();

            return response;
        }

        public static int saveDeducciones(string descripcion, string porcentaje, int idtipopago)
        {
            int response = 0;
            decimal porcentajeDecimal = decimal.Parse(porcentaje);

            string sqlString = "INSERT INTO descuentos (iddescuento, idtipodescuento, idtipopago, id, id_sede, descripcion, porcentaje, defaultt, estado) VALUES ((SELECT COALESCE(MAX(iddescuento + 1), 1) FROM descuentos), 1, @idtipodescuento, 1, 1, @descripcion, @porcentaje, @defaultt, @estado)";
            SqlCommand cmd = new SqlCommand(sqlString, conexionbd.ObtenerConexion());

            //cmd.Parameters.Add("@idtipobonificacion", SqlDbType.Int);
            cmd.Parameters.Add("@idtipodescuento", SqlDbType.Int);
            //cmd.Parameters.Add("@id", SqlDbType.Int);
            //cmd.Parameters.Add("@id_sede", SqlDbType.Int);
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar);
            cmd.Parameters.Add("@porcentaje", SqlDbType.Decimal);
            cmd.Parameters.Add("@defaultt", SqlDbType.Int);
            cmd.Parameters.Add("@estado", SqlDbType.Int);

            cmd.Parameters["@idtipodescuento"].Value = idtipopago;
            cmd.Parameters["@descripcion"].Value = descripcion;
            cmd.Parameters["@porcentaje"].Value = porcentajeDecimal;
            cmd.Parameters["@defaultt"].Value = 1;
            cmd.Parameters["@estado"].Value = 1;

            response = cmd.ExecuteNonQuery();

            return response;
        }

        public static List<capa_presentacion_planillas.showEmpleados> showEmpleados()
        {
            List<capa_presentacion_planillas.showEmpleados> showEmpleados = new List<capa_presentacion_planillas.showEmpleados>();
            string sqlTet = "SELECT emp.nombre_empresa, e.nombre1, e.nombre2, e.apellido1, e.apellido2 " +
                            "FROM detallepersonal e " +
                            "JOIN empresa emp ON emp.idempresa = e.idempresa";

            SqlCommand cmd = new SqlCommand(sqlTet, conexionbd.ObtenerConexion());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                showEmpleados.Add(new capa_presentacion_planillas.showEmpleados() { nombre_empresa = dr["nombre_empresa"].ToString(), nombre1 = dr["nombre1"].ToString(), nombre2 = dr["nombre2"].ToString(), apellido1 = dr["apellido1"].ToString(), apellido2 = dr["apellido2"].ToString() });
            }

            return showEmpleados;
        }
    }
}
