using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class capa_logica_vacaciones
    {
        public static SqlConnection SQL_Conexion = new SqlConnection();

        public static int Agregar(capa_presentacion_vacaciones pMotivo)
        {

            int retorno = 0;

            SqlCommand comando = new SqlCommand(string.Format("Insert into motivouno (motivo, descripcion) values ('{0}','{1}')",
               pMotivo.motivo, pMotivo.descripcion), conexionbd_vacaciones.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }


        public static List<capa_presentacion_vacaciones> Buscarmotivo(string pmotivo)
        {
            List<capa_presentacion_vacaciones> _lista = new List<capa_presentacion_vacaciones>();

            SqlCommand _comando = new SqlCommand(String.Format(
           "SELECT codmotivo, motivo, descripcion FROM motivouno where motivo ='{0}'", pmotivo), conexionbd_vacaciones.ObtenerConexion());
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                capa_presentacion_vacaciones pMotivoo = new capa_presentacion_vacaciones();
                pMotivoo.codmotivo = _reader.GetInt32(0);
                pMotivoo.motivo = _reader.GetString(1);
                pMotivoo.descripcion = _reader.GetString(2);



                _lista.Add(pMotivoo);
            }

            return _lista;
        }

        public static capa_presentacion_vacaciones Obtenermotivo(int pcod)
        {
            capa_presentacion_vacaciones pMotivo = new capa_presentacion_vacaciones();
            SqlConnection conexion = conexionbd_vacaciones.ObtenerConexion();

            SqlCommand _comando = new SqlCommand(String.Format("SELECT codmotivo, motivo, descripcion FROM motivouno where codmotivo={0}", pcod), conexion);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pMotivo.codmotivo = _reader.GetInt32(0);
                pMotivo.motivo = _reader.GetString(1);
                pMotivo.descripcion = _reader.GetString(2);
            }

            conexion.Close();
            return pMotivo;

        }

        public static int modificarmotivo(capa_presentacion_vacaciones pmotivo)
        {
            int retorno = 0;
            SqlConnection conexion = conexionbd_vacaciones.ObtenerConexion();

            SqlCommand comando = new SqlCommand(string.Format("Update motivouno set motivo='{0}', descripcion='{1}' where codmotivo={2}",
                pmotivo.motivo, pmotivo.descripcion, pmotivo.codmotivo), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;


        }

        public static int Eliminarmotivo(int pcodmotivo)
        {
            int retorno = 0;
            SqlConnection conexion = conexionbd_vacaciones.ObtenerConexion();

            SqlCommand comando = new SqlCommand(string.Format("Delete From motivouno where codmotivo={0}", pcodmotivo), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }
    }
}