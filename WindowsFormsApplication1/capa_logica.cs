using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class capa_logica
    {
        public static SqlConnection SQL_Conexion = new SqlConnection();

        public static int Agregar(capa_presentacion pMotivo)
<<<<<<< HEAD
            {

                int retorno = 0;
            
                SqlCommand comando = new SqlCommand(string.Format("Insert into motivouno (motivo, descripcion) values ('{0}','{1}')",
                   pMotivo.motivo, pMotivo.descripcion), conexionbd.ObtenerConexion());
                retorno = comando.ExecuteNonQuery();
                return retorno;
            }

        public void cargagrid()
        {

        }

=======
        {

            int retorno = 0;

            SqlCommand comando = new SqlCommand(string.Format("Insert into motivouno (motivo, descripcion) values ('{0}','{1}')",
               pMotivo.motivo, pMotivo.descripcion), conexionbd.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static List<capa_presentacion.info_capa> info_capacitaciones() {

            List<capa_presentacion.info_capa> info_cap = new List<capa_presentacion.info_capa>();
            SqlCommand comando = new SqlCommand("select c.idcapacitacion,c.costo,c.nombre,c.descripcion,dc.expositor,t.tipo from CAPACITACION c left join  DETALLECAPACITACION dc on dc.idcapacitacion = c.idcapacitacion left join TIPO t on t.idtipo = dc.idtipo where c.status = 1", conexionbd.ObtenerConexion());
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read()) {

                info_cap.Add(new capa_presentacion.info_capa() { idcapacitacion = dr["idcapacitacion"].ToString(), nombre_capa = dr["nombre"].ToString(), descripcion_capa = dr["descripcion"].ToString(), area = dr["tipo"].ToString(), expositor = dr["expositor"].ToString(), costo = dr["costo"].ToString() });

            }

            return info_cap;
        }

        public static List<capa_presentacion.infotipocapacitacion> info_tipocapacitaciones() {
            List<capa_presentacion.infotipocapacitacion> infotipo_cap = new List<capa_presentacion.infotipocapacitacion>();
            SqlCommand comando = new SqlCommand("select * from TIPO where status=1", conexionbd.ObtenerConexion());
            SqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {

                infotipo_cap.Add(new capa_presentacion.infotipocapacitacion() { idtipo=dr["idtipo"].ToString(), tipo = dr["tipo"].ToString() });

            }
            SQL_Conexion.Close();
            return infotipo_cap;
        }


        public static int modificar_capacitacion(string id_capacitacion,string nombre, string descripcion, string expositor, string costo, string area) {

            int modificacion = 0;
            SqlCommand comando = new SqlCommand("  update CAPACITACION set nombre='"+nombre+"' , descripcion='"+descripcion+"' where idcapacitacion="+id_capacitacion, conexionbd.ObtenerConexion());
            modificacion = comando.ExecuteNonQuery();
            SQL_Conexion.Close();

            
            SqlCommand comando2 = new SqlCommand("  update DETALLECAPACITACION set expositor='"+expositor+"', idtipo="+area +" where idcapacitacion="+ id_capacitacion, conexionbd.ObtenerConexion());
            modificacion = comando2.ExecuteNonQuery();
            SQL_Conexion.Close();

            return modificacion;
        }
>>>>>>> fix_2
        public static int LoginD(string sUser, string sContra)
        {
            int retorno = 0;
            SqlCommand comando = new SqlCommand("Select usuario from USUARIO_1 WHERE usuario='" + sUser + "'And password ='" + sContra + "'", conexionbd.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
<<<<<<< HEAD
            Object obj = comando.ExecuteScalar();

=======
            object obj = comando.ExecuteScalar();
>>>>>>> fix_2
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
        }
<<<<<<< HEAD
    

    public static int InsertaEmpleado()
    {
        int retorno = 0;
        SqlCommand comando = new SqlCommand("EXEC InsertaEmpleado", conexionbd.ObtenerConexion());
        retorno = comando.ExecuteNonQuery();
        return retorno;
    }
}
}
=======
    }
}
>>>>>>> fix_2
