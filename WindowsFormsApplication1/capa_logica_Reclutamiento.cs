using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class capa_logica_Reclutamiento
    {
        public static SqlConnection SQL_Conexion = new SqlConnection();
        private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;

        //INSERTAR CANDIDATO
        public bool insertarimagen(string idcandidato, string idestadocandidato, string idestadocivil, string idsexo, string idnacionalidad, string nombre1, string nombre2, string apellido1, string apellido2, string apellido3, string direccion, string telefono, string nidentificacion, string fechanacimiento, PictureBox fotografia)
        {
            SqlCommand cmd = new SqlCommand("insert into CANDIDATO(idcandidato, idestadocandidato, idestadocivil, idsexo, idnacionalidad, nombre1, nombre2, apellido1, apellido2, apellido3, direccion, telefono, nidentificacion, fechanacimiento, fotografia) values (@idcandidato, @idestadocandidato, @idestadocivil, @idsexo, @idnacionalidad, @nombre1, @nombre2, @apellido1, @apellido2, @apellido3, @direccion, @telefono, @nidentificacion, @fechanacimiento, @fotografia)", conexionbd_Reclutamiento.ObtenerConexion());
            cmd.Parameters.Add("@idcandidato", SqlDbType.Int);
            cmd.Parameters.Add("@idestadocandidato", SqlDbType.Int);
            cmd.Parameters.Add("@idestadocivil", SqlDbType.Int);
            cmd.Parameters.Add("@idsexo", SqlDbType.Int);
            cmd.Parameters.Add("@idnacionalidad", SqlDbType.Int);

            cmd.Parameters.Add("@nombre1", SqlDbType.VarChar);
            cmd.Parameters.Add("@nombre2", SqlDbType.VarChar);
            cmd.Parameters.Add("@apellido1", SqlDbType.VarChar);
            cmd.Parameters.Add("@apellido2", SqlDbType.VarChar);
            cmd.Parameters.Add("@apellido3", SqlDbType.VarChar);

            cmd.Parameters.Add("@direccion", SqlDbType.VarChar);
            cmd.Parameters.Add("@telefono", SqlDbType.VarChar);
            cmd.Parameters.Add("@nidentificacion", SqlDbType.VarChar);
            cmd.Parameters.Add("@fechanacimiento", SqlDbType.Date);
            cmd.Parameters.Add("@fotografia", SqlDbType.Image);

            cmd.Parameters["@idcandidato"].Value = idcandidato;
            cmd.Parameters["@idestadocandidato"].Value = idestadocandidato;
            cmd.Parameters["@idestadocivil"].Value = idestadocivil;
            cmd.Parameters["@idsexo"].Value = idsexo;
            cmd.Parameters["@idnacionalidad"].Value = idnacionalidad;

            cmd.Parameters["@nombre1"].Value = nombre1;
            cmd.Parameters["@nombre2"].Value = nombre2;
            cmd.Parameters["@apellido1"].Value = apellido1;
            cmd.Parameters["@apellido2"].Value = apellido2;
            cmd.Parameters["@apellido3"].Value = apellido3;

            cmd.Parameters["@direccion"].Value = direccion;
            cmd.Parameters["@telefono"].Value = telefono;
            cmd.Parameters["@nidentificacion"].Value = nidentificacion;
            cmd.Parameters["@fechanacimiento"].Value = fechanacimiento;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();

            fotografia.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            cmd.Parameters["@fotografia"].Value = ms.GetBuffer();

            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }


        //LLENAR GRID
        public void consulta(string sql, string tabla)
        {
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, conexionbd_Reclutamiento.ObtenerConexion());
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);
        }

        //LLENAR COMBOBOX
        public void llenaritem(ComboBox cb)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select descripcion from SEXO", conexionbd_Reclutamiento.ObtenerConexion());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["descripcion"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se lleno el combo" + ex.ToString());
            }
        }
        public void llenaritem2(ComboBox cb)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select descipcion from ESTADOCIVIL", conexionbd_Reclutamiento.ObtenerConexion());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["descipcion"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se lleno el combo" + ex.ToString());
            }
        }
        public void llenaritem3(ComboBox cb)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select descipcion from ESTADOCANDIDATO", conexionbd_Reclutamiento.ObtenerConexion());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["descipcion"].ToString());

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se lleno el combo" + ex.ToString());
            }
        }
        public void llenaritem4(ComboBox cb)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select descripcion from NACIONALIDAD", conexionbd_Reclutamiento.ObtenerConexion());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["descripcion"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se lleno el combo" + ex.ToString());
            }
        }


    }
}
