using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

/* Abner Josué Rodas Andrade
 * 0901-11-9850
 * SAD 2017
*/

namespace WindowsFormsApplication1
{
    class capa_logica_Reclutamiento
    {
        public static SqlConnection SQL_Conexion = new SqlConnection();
        private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;
        public DataRow dr;

//      Inserción de Candidato
        public bool insertarimagen(string idestadocandidato, string idestadocivil, string idsexo, string idnacionalidad, string nombre1, string nombre2, string apellido1, string apellido2, string apellido3, string direccion, string telefono, string nidentificacion, string fechanacimiento, PictureBox fotografia,string idpuestodetrabajo)
        {
            SqlCommand cmd = new SqlCommand("insert into CANDIDATO(idestadocandidato, idestadocivil, idsexo, idnacionalidad, nombre1, nombre2, apellido1, apellido2, apellido3, direccion, telefono, identificacion, fechanacimiento, fotografia,idpuestodetrabajo) values (@idestadocandidato, @idestadocivil, @idsexo, @idnacionalidad, @nombre1, @nombre2, @apellido1, @apellido2, @apellido3, @direccion, @telefono, @nidentificacion, @fechanacimiento, @fotografia,@idpuestodetrabajo)", conexionbd.ObtenerConexion());
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
            cmd.Parameters.Add("@idpuestodetrabajo", SqlDbType.Int);


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
            cmd.Parameters["@idpuestodetrabajo"].Value = idpuestodetrabajo;

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



 //     Actualizar candidato
        public bool actualizarimagen(string idcandidato, string idestadocandidato, string idestadocivil, string idsexo, string idnacionalidad, string nombre1, string nombre2, string apellido1, string apellido2, string apellido3, string direccion, string telefono, string nidentificacion, string fechanacimiento, PictureBox fotografia, string idpuestodetrabajo)
        {
            SqlCommand cmd = new SqlCommand("update CANDIDATO set idestadocandidato=@idestadocandidato, idestadocivil=@idestadocivil, idsexo=@idsexo, idnacionalidad=@idnacionalidad, nombre1=@nombre1, nombre2=@nombre2, apellido1=@apellido1, apellido2=@apellido2, apellido3=@apellido3, direccion=@direccion, telefono=@telefono, identificacion=@nidentificacion, fechanacimiento=@fechanacimiento, fotografia=@fotografia, idpuestodetrabajo=@idpuestodetrabajo" + " where idcandidato=@idcandidato", conexionbd.ObtenerConexion());
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
            cmd.Parameters.Add("@idpuestodetrabajo", SqlDbType.Int);

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
            cmd.Parameters["@idpuestodetrabajo"].Value = idpuestodetrabajo;


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


 //     Borrar candidato
        public bool borrarimagen(string idcandidato)
        {
            SqlCommand cmd = new SqlCommand("update CANDIDATO set idestadocandidato=@idestadocandidato" + " where idcandidato=@idcandidato", conexionbd.ObtenerConexion());
            cmd.Parameters.Add("@idcandidato", SqlDbType.Int);
            cmd.Parameters.Add("@idestadocandidato", SqlDbType.Int);

            cmd.Parameters["@idcandidato"].Value = idcandidato;
            cmd.Parameters["@idestadocandidato"].Value = 5;

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


 //     Obtencion de imagen
        public void verimagen(PictureBox fotografia, TextBox txtc)
        {
            try
            {
                da = new SqlDataAdapter("select fotografia from CANDIDATO where idcandidato = '" + txtc.Text + "'", conexionbd.ObtenerConexion());
                ds = new DataSet();
                da.Fill(ds, "CANDIDATO");
                byte[] datos = new byte[0];
                dr = ds.Tables["CANDIDATO"].Rows[0];
                datos = (byte[])dr["fotografia"];
                System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                fotografia.Image = System.Drawing.Bitmap.FromStream(ms);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede consultar la imagen: " + ex.ToString());
            }
        }


//      CONSULTAS
        public void consulta(string sql, string tabla)
        {
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, conexionbd.ObtenerConexion());
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);
        }

        public void consultarcandidato(string tabla)
        {
            ds.Tables.Clear();
            da = new SqlDataAdapter("select c.idcandidato, c.idestadocandidato, c.idestadocivil, ec.descipcion AS 'Estado Civil', c.idsexo, s.descripcion AS 'Sexo', c.idnacionalidad, n.descripcion AS 'Nacionalidad', c.nombre1 AS 'Primer Nombre', c.nombre2 AS 'Segundo Nombre', c.apellido1 AS 'Primer Apellido', c.apellido2 AS 'Segundo Apellido', c.apellido3 AS 'Apellido de Matrimonio', c.direccion, c.telefono, c.identificacion, c.fechanacimiento, c.fotografia, c.idpuestodetrabajo, pt.nombrepuesto as 'Puesto de Trabajo' from CANDIDATO c inner join SEXO s on c.idsexo = s.idsexo inner join ESTADOCIVIL ec on c.idestadocivil = ec.idestadocivil inner join NACIONALIDAD n on c.idnacionalidad = n.idnacionalidad inner join PUESTODETRABAJO pt on c.idpuestodetrabajo = pt.idpuestodetrabajo where idestadocandidato = 1", conexionbd.ObtenerConexion());
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);
        }

        public void consultarcandidato2(string tabla)
        {
            ds.Tables.Clear();
            da = new SqlDataAdapter("select c.idcandidato, c.idestadocandidato, c.idestadocivil, ec.descipcion AS 'Estado Civil', c.idsexo, s.descripcion AS 'Sexo', c.idnacionalidad, n.descripcion AS 'Nacionalidad', c.nombre1 AS 'Primer Nombre', c.nombre2 AS 'Segundo Nombre', c.apellido1 AS 'Primer Apellido', c.apellido2 AS 'Segundo Apellido', c.apellido3 AS 'Apellido de Matrimonio', c.direccion, c.telefono, c.identificacion, c.fechanacimiento, c.fotografia, c.idpuestodetrabajo, pt.nombrepuesto as 'Puesto de Trabajo' from CANDIDATO c inner join SEXO s on c.idsexo = s.idsexo inner join ESTADOCIVIL ec on c.idestadocivil = ec.idestadocivil inner join NACIONALIDAD n on c.idnacionalidad = n.idnacionalidad inner join PUESTODETRABAJO pt on c.idpuestodetrabajo = pt.idpuestodetrabajo where idestadocandidato = 8", conexionbd.ObtenerConexion());
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);
        }
        public void consultarentrevista(string tabla)
        {
            ds.Tables.Clear();
            da = new SqlDataAdapter("select e.identrevista, e.idcandidato, c.nombre1, c.nombre2, c.apellido1, c.apellido2, e.idetapaentrevista, c.idestadocandidato from ENTREVISTA e inner join CANDIDATO c on e.idcandidato = c.idcandidato where idestadocandidato=3", conexionbd.ObtenerConexion());
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);
        }

        public void consultarentrevista2(string tabla)
        {
            ds.Tables.Clear();
            da = new SqlDataAdapter("select e.identrevista, e.idcandidato, c.nombre1, c.nombre2, c.apellido1, c.apellido2, e.idetapaentrevista, c.idestadocandidato from ENTREVISTA e inner join CANDIDATO c on e.idcandidato = c.idcandidato where idestadocandidato=4 and idetapaentrevista =2", conexionbd.ObtenerConexion());
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);
        }

        public void consultadtentrevista(string tabla)
        {
            ds.Tables.Clear();
            da = new SqlDataAdapter("select de.iddetalleentrevista, e.identrevista, e.idcandidato, e.idetapaentrevista, ee.descripcion, c.nombre1, c.nombre2, c.apellido1, c.apellido2, de.comentario, de.resultado1, de.resultado2,de.resultado3, de.total, re.ideresultadoentrevista, re.descripcion from DETALLEENTREVISTA de inner join ENTREVISTA e on de.identrevista = e.identrevista inner join Candidato c on e.idcandidato = c.idcandidato inner join RESULTADOENTREVISTA re on de.ideresultadoentrevista = re.ideresultadoentrevista inner join ETAPAENTREVISTA ee on e.idetapaentrevista = ee.idetapaentrevista", conexionbd.ObtenerConexion());
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);

        }

        public void consultarBancocv(string tabla)
        {
            ds.Tables.Clear();
            da = new SqlDataAdapter("select c.idcandidato, c.idestadocandidato, c.idestadocivil, ec.descipcion AS 'Estado Civil', c.idsexo, s.descripcion AS 'Sexo', c.idnacionalidad, n.descripcion AS 'Nacionalidad', c.nombre1 AS 'Primer Nombre', c.nombre2 AS 'Segundo Nombre', c.apellido1 AS 'Primer Apellido', c.apellido2 AS 'Segundo Apellido', c.apellido3 AS 'Apellido de Matrimonio', c.direccion, c.telefono, c.identificacion, c.fechanacimiento, c.fotografia, el.descripcion AS 'Descripcion de Puesto', el.lugar AS 'Empresa', el.anos AS 'Tiempo Laborado', et.descripcion AS 'Descripcion de Estudios', et.tipodeestudio AS 'Tipo de Estudios', et.lugar AS 'Centro de Estudios', c.idpuestodetrabajo, pt.nombrepuesto  from CANDIDATO c inner join SEXO s on c.idsexo = s.idsexo inner join ESTADOCIVIL ec on c.idestadocivil = ec.idestadocivil inner join NACIONALIDAD n on c.idnacionalidad = n.idnacionalidad inner join Experiencialaboral el on c.idcandidato=el.idcandidato inner join estudios et on c.idcandidato= et.idcandidato inner join puestodetrabajo pt on c.idpuestodetrabajo= pt.idpuestodetrabajo where idestadocandidato in (6,7)", conexionbd.ObtenerConexion());
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, tabla);
        }

 //     LOGIN
        public static int LoginD(string sUser, string sContra)
        {
            int retorno = 0;
            SqlCommand comando = new SqlCommand("Select usuario from USUARIO_1 WHERE usuario='" + sUser + "'And password ='" + sContra + "'", conexionbd.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            Object obj = comando.ExecuteScalar();

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
            return retorno;
        }


 //   LLENAR COMBOBOX
        public void llenaritem(ComboBox cb)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select descripcion from SEXO", conexionbd.ObtenerConexion());
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
                SqlCommand cmd = new SqlCommand("select descipcion from ESTADOCIVIL", conexionbd.ObtenerConexion());
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
                SqlCommand cmd = new SqlCommand("select descipcion from ESTADOCANDIDATO", conexionbd.ObtenerConexion());
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
                SqlCommand cmd = new SqlCommand("select descripcion from NACIONALIDAD", conexionbd.ObtenerConexion());
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
        public void llenaritem5(ComboBox cb)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select nombrepuesto from PUESTODETRABAJO", conexionbd.ObtenerConexion());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["nombrepuesto"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se lleno el combo" + ex.ToString());
            }
        }

        public void llenarCB(TextBox txtb, ComboBox cbb, string st)
        {
            string cadcon = st + txtb.Text + "'";
            SqlCommand cm = new SqlCommand(cadcon, conexionbd.ObtenerConexion());
            SqlDataReader leer = cm.ExecuteReader();
            if (leer.Read() == true)
            {
                cbb.Text = leer["descripcion"].ToString();
            }
            else
            {
                cbb.Text = "";
            }

        }

        public void llenarCB2(TextBox txtb, ComboBox cbb, string st)
        {
            string cadcon = st + txtb.Text + "'";
            SqlCommand cm = new SqlCommand(cadcon, conexionbd.ObtenerConexion());
            SqlDataReader leer = cm.ExecuteReader();
            if (leer.Read() == true)
            {
                cbb.Text = leer["descipcion"].ToString();
            }
            else
            {
                cbb.Text = "";
            }

        }

        public void llenarCB3(TextBox txtb, ComboBox cbb)
        {
            string cadcon = "select nombrepuesto from PUESTODETRABAJO where idpuestodetrabajo ='" + txtb.Text + "'";
            SqlCommand cm = new SqlCommand(cadcon, conexionbd.ObtenerConexion());
            SqlDataReader leer = cm.ExecuteReader();
            if (leer.Read() == true)
            {
                cbb.Text = leer["nombrepuesto"].ToString();
            }
            else
            {
                cbb.Text = "";
            }

        }

   //   llenar textbox
        public void llenartxt2(TextBox tb, TextBox tbid)
        {
                SqlCommand cmd = new SqlCommand("select descripcion from ETAPAENTREVISTA where idetapaentrevista ='" + tbid.Text + "'", conexionbd.ObtenerConexion());
                SqlDataReader leer = cmd.ExecuteReader();
                if (leer.Read() == true)
                {
                    tb.Text = leer["descripcion"].ToString();
                }
                else
                {
                    tb.Text = "";
                }
                       
            }

        public void llenartxt3(TextBox tb, TextBox tbid)
        {
            SqlCommand cmd = new SqlCommand("select nombrepuesto from PUESTODETRABAJO where idpuestodetrabajo ='" + tbid.Text + "'", conexionbd.ObtenerConexion());
            SqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read() == true)
            {
                tb.Text = leer["nombrepuesto"].ToString();
            }
            else
            {
                tb.Text = "";
            }

        }


        //aqui abajo
        public void llenarcombobox(string consulta, string parametro, ComboBox cb)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(consulta, conexionbd.ObtenerConexion());
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr[parametro].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se lleno el combo" + ex.ToString());
            }
        }


 // llenar combobox
        public void llenarCB3(TextBox txtb, ComboBox cbb, string st, string parametro)
        {
            string cadcon = st + txtb.Text + "'";
            SqlCommand cm = new SqlCommand(cadcon, conexionbd.ObtenerConexion());
            SqlDataReader leer = cm.ExecuteReader();
            if (leer.Read() == true)
            {
                cbb.Text = leer[parametro].ToString();
            }
            else
            {
                cbb.Text = "";
            }

        }


        public void llenarCBE(TextBox txtb, ComboBox cbb, string st, string parametro, string parametro2)
        {
            string cadcon = st + txtb.Text + "'";
            SqlCommand cm = new SqlCommand(cadcon, conexionbd.ObtenerConexion());
            SqlDataReader leer = cm.ExecuteReader();
            if (leer.Read() == true)
            {
                cbb.Text = leer[parametro] + " " + leer[parametro2].ToString();
            }
            else
            {
                cbb.Text = "";
            }

        }

        public void llenartxt(string st, string parametro, ComboBox cb, TextBox tb)
        {
            string cadcon = st + cb.Text + "'";
            SqlCommand cm = new SqlCommand(cadcon, conexionbd.ObtenerConexion());

            SqlDataReader leer = cm.ExecuteReader();
            if (leer.Read() == true)
            {
                tb.Text = leer[parametro].ToString();
            }
            else
            {
                tb.Text = "";
            }
        }

        // genera id
        public void generarid (TextBox tb,TextBox tb1, TextBox tbt)
        {
                SqlCommand cmd = new SqlCommand("select top(1) * from PUESTODETRABAJO order by idpuestodetrabajo desc", conexionbd.ObtenerConexion());
                SqlDataReader leer = cmd.ExecuteReader();

                if (leer.Read()==true)
                {
                tb.Text = leer["idpuestodetrabajo"].ToString();
                tbt.Text = (Convert.ToInt32(tb.Text) + Convert.ToInt32(tb1.Text)).ToString();
                
            }
                else
            {
                tb.Text = "no";
            }
        }

   // insertar puesto 
        public bool insertarPuesto(string idempresa, string iddepartamentoempresa, string nombreempresa, string idestadopuesto)
        {
            SqlCommand cmd = new SqlCommand("insert into PUESTODETRABAJO(iddepartamentoempresa, idestadopuesto, nombrepuesto, idempresa) values (@iddepartamentoempresa, @idestadopuesto, @nombrepuesto, @idempresa)", conexionbd.ObtenerConexion());
            cmd.Parameters.Add("@iddepartamentoempresa", SqlDbType.Int);
            cmd.Parameters.Add("@idestadopuesto", SqlDbType.Int);

            cmd.Parameters.Add("@nombrepuesto", SqlDbType.VarChar);
            cmd.Parameters.Add("@idempresa", SqlDbType.Int);


            cmd.Parameters["@iddepartamentoempresa"].Value = iddepartamentoempresa;
            cmd.Parameters["@idestadopuesto"].Value = idestadopuesto;
            cmd.Parameters["@nombrepuesto"].Value = nombreempresa;

            cmd.Parameters["@idempresa"].Value = idempresa;

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

//      modificar puesto
        public bool ModificarPuesto(string idpuestodetrabajo, string idempresa, string iddepartamentoempresa, string nombreempresa, string idestadopuesto)
        {
            SqlCommand cmd = new SqlCommand("update PUESTODETRABAJO set iddepartamentoempresa=@iddepartamentoempresa, idestadopuesto=@idestadopuesto, nombrepuesto=@nombrepuesto, idempresa=@idempresa" + " where idpuestodetrabajo=@idpuestodetrabajo", conexionbd.ObtenerConexion());
            cmd.Parameters.Add("@idpuestodetrabajo", SqlDbType.Int);
            cmd.Parameters.Add("@iddepartamentoempresa", SqlDbType.Int);
            cmd.Parameters.Add("@idestadopuesto", SqlDbType.Int);

            cmd.Parameters.Add("@nombrepuesto", SqlDbType.VarChar);
            cmd.Parameters.Add("@idempresa", SqlDbType.Int);

            cmd.Parameters["@idpuestodetrabajo"].Value = idpuestodetrabajo;
            cmd.Parameters["@iddepartamentoempresa"].Value = iddepartamentoempresa;
            cmd.Parameters["@idestadopuesto"].Value = idestadopuesto;
            cmd.Parameters["@nombrepuesto"].Value = nombreempresa;

            cmd.Parameters["@idempresa"].Value = idempresa;

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

        // borrar puesto
        public bool borrarpuesto(string idpuestodetrabajo)
        {
            SqlCommand cmd = new SqlCommand("update PUESTODETRABAJO set idestadopuesto=@idestadopuesto" + " where idpuestodetrabajo=@idpuestodetrabajo", conexionbd.ObtenerConexion());
            cmd.Parameters.Add("@idpuestodetrabajo", SqlDbType.Int);
            cmd.Parameters.Add("@idestadopuesto", SqlDbType.Int);

            cmd.Parameters["@idpuestodetrabajo"].Value = idpuestodetrabajo;
            cmd.Parameters["@idestadopuesto"].Value = 3;

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


        //Insertar Detalle Entrevista
        public bool insertardetalleentrevista(string identrevista, string comentario, string resultado1, string resultado2, string resultado3,string total, string idresultadoentrevista)
        {
            SqlCommand cmd = new SqlCommand("insert into DETALLEENTREVISTA (identrevista, comentario, resultado1, resultado2, resultado3, total, ideresultadoentrevista) values (@identrevista, @comentario, @resultado1, @resultado2, @resultado3, @total, @idresultadoentrevista)", conexionbd.ObtenerConexion());
            cmd.Parameters.Add("@identrevista", SqlDbType.Int);
            cmd.Parameters.Add("@comentario", SqlDbType.VarChar);
            cmd.Parameters.Add("@resultado1", SqlDbType.VarChar);
            cmd.Parameters.Add("@resultado2", SqlDbType.VarChar);
            cmd.Parameters.Add("@resultado3", SqlDbType.VarChar);
            cmd.Parameters.Add("@total", SqlDbType.VarChar);
            cmd.Parameters.Add("@idresultadoentrevista", SqlDbType.VarChar);

            cmd.Parameters["@identrevista"].Value = identrevista;
            cmd.Parameters["@comentario"].Value = comentario;
            cmd.Parameters["@resultado1"].Value = resultado1;
            cmd.Parameters["@resultado2"].Value = resultado2;
            cmd.Parameters["@resultado3"].Value = resultado3;
            cmd.Parameters["@total"].Value = total;
            cmd.Parameters["@idresultadoentrevista"].Value = idresultadoentrevista;

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
   
        // modifica entrevista

        public bool ModificarDetalleEntrevista(string iddetalleentrevista, string identrevista, string comentario, string resultado1, string resultado2, string resultado3, string total, string idresultadoentrevista)
        {
            SqlCommand cmd = new SqlCommand("update DETALLEENTREVISTA set identrevista=@identrevista, comentario=@comentario, resultado1=@resultado1, resultado2=@resultado2, resultado3=@resultado3, total=@total, ideresultadoentrevista=@idresultadoentrevista where iddetalleentrevista=@iddetalleentrevista", conexionbd.ObtenerConexion());
            cmd.Parameters.Add("@iddetalleentrevista", SqlDbType.Int);
            cmd.Parameters.Add("@identrevista", SqlDbType.Int);
            cmd.Parameters.Add("@comentario", SqlDbType.VarChar);
            cmd.Parameters.Add("@resultado1", SqlDbType.VarChar);
            cmd.Parameters.Add("@resultado2", SqlDbType.VarChar);
            cmd.Parameters.Add("@resultado3", SqlDbType.VarChar);
            cmd.Parameters.Add("@total", SqlDbType.VarChar);
            cmd.Parameters.Add("@idresultadoentrevista", SqlDbType.VarChar);

            cmd.Parameters["@iddetalleentrevista"].Value = iddetalleentrevista;
            cmd.Parameters["@identrevista"].Value = identrevista;
            cmd.Parameters["@comentario"].Value = comentario;
            cmd.Parameters["@resultado1"].Value = resultado1;
            cmd.Parameters["@resultado2"].Value = resultado2;
            cmd.Parameters["@resultado3"].Value = resultado3;
            cmd.Parameters["@total"].Value = total;
            cmd.Parameters["@idresultadoentrevista"].Value = idresultadoentrevista;

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

        //ENTREVISTA
        public bool insertarEntrevista(string idcandidato, string idpuestodetrabajo, string idetapaentrevista, string fecha, string hora)
        {
            SqlCommand cmd = new SqlCommand("insert into ENTREVISTA(idcandidato, idpuestodetrabajo, idetapaentrevista, fecha, horario) values (@idcandidato, @idpuestodetrabajo, @idetapaentrevista, @fecha, @horario)", conexionbd.ObtenerConexion());
            cmd.Parameters.Add("@idcandidato", SqlDbType.Int);
            cmd.Parameters.Add("@idpuestodetrabajo", SqlDbType.Int);
            cmd.Parameters.Add("@idetapaentrevista", SqlDbType.Int);

            cmd.Parameters.Add("@fecha", SqlDbType.Date);
            cmd.Parameters.Add("@horario", SqlDbType.DateTime);

            cmd.Parameters["@idcandidato"].Value = idcandidato;
            cmd.Parameters["@idpuestodetrabajo"].Value = idpuestodetrabajo;
            cmd.Parameters["@idetapaentrevista"].Value = idetapaentrevista;
            cmd.Parameters["@fecha"].Value = fecha;

            cmd.Parameters["@horario"].Value = hora;

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
        // modificar entrevista general
        public bool ModificarEntrevista(string identrevista, string idcandidato, string idpuestodetrabajo, string idetapaentrevista, string fecha, string hora)
        {
            SqlCommand cmd = new SqlCommand("update ENTREVISTA set idcandidato=@idcandidato, idpuestodetrabajo=@idpuestodetrabajo, idetapaentrevista=@idetapaentrevista, fecha=@fecha, horario=@horario" + " where identrevista=@identrevista", conexionbd.ObtenerConexion());
            cmd.Parameters.Add("@identrevista", SqlDbType.Int);
            cmd.Parameters.Add("@idcandidato", SqlDbType.Int);
            cmd.Parameters.Add("@idpuestodetrabajo", SqlDbType.Int);
            cmd.Parameters.Add("@idetapaentrevista", SqlDbType.Int);

            cmd.Parameters.Add("@fecha", SqlDbType.Date);
            cmd.Parameters.Add("@horario", SqlDbType.DateTime);

            cmd.Parameters["@identrevista"].Value = identrevista;
            cmd.Parameters["@idcandidato"].Value = idcandidato;
            cmd.Parameters["@idpuestodetrabajo"].Value = idpuestodetrabajo;
            cmd.Parameters["@idetapaentrevista"].Value = idetapaentrevista;
            cmd.Parameters["@fecha"].Value = fecha;

            cmd.Parameters["@horario"].Value = hora;

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
        // borrar entrevista general
        public bool borrarentrevista(string identrevista)
        {
            SqlCommand cmd = new SqlCommand("update ENTREVISTA set idetapaentrevista=@idetapaentrevista" + " where identrevista=@identrevista", conexionbd.ObtenerConexion());
            cmd.Parameters.Add("@identrevista", SqlDbType.Int);
            cmd.Parameters.Add("@idetapaentrevista", SqlDbType.Int);

            cmd.Parameters["@identrevista"].Value = identrevista;
            cmd.Parameters["@idetapaentrevista"].Value = 3;

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

        //concatenar
        public void concatenar(TextBox tb, TextBox tb2)
        {
            SqlCommand cmd = new SqlCommand("select * from CANDIDATO where idcandidato ='" + tb.Text + "'", conexionbd.ObtenerConexion());
            SqlDataReader leer = cmd.ExecuteReader();

            if (leer.HasRows)
            {
                leer.Read();
                tb2.Text = leer["nombre1"] + " " + leer["nombre2"] + " " + leer["apellido1"] + " " + leer["apellido2"].ToString();
            }
        }

        // insertar desde datagridview
        public void InsertarDGV(DataGridView dgv, TextBox tb)
        {
            SqlCommand agregar = new SqlCommand("insert into ESTUDIOS (descripcion, tipodeestudio, lugar, idcandidato) values (@descripcion, @tipodeestudio, @lugar, @idcandidato)", conexionbd.ObtenerConexion());
            try
            {

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    agregar.Parameters.Clear();


                    agregar.Parameters.AddWithValue("@descripcion", Convert.ToString(row.Cells[0].Value));
                    agregar.Parameters.AddWithValue("@tipodeestudio", Convert.ToString(row.Cells[1].Value));
                    agregar.Parameters.AddWithValue("@lugar", Convert.ToString(row.Cells[2].Value));
                    agregar.Parameters.AddWithValue("@idcandidato", Convert.ToString(tb.Text));
                    agregar.ExecuteNonQuery();
                }
                MessageBox.Show("Datos Ingresados Correctamente");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Los Datos no se Ingresaron Correctamente" + ex.ToString());
            }
        }

        public void InsertarDGV2(DataGridView dgv, TextBox tb)
        {
            SqlCommand agregar = new SqlCommand("insert into EXPERIENCIALABORAL (descripcion, lugar, anos, idcandidato) values (@descripcion, @lugar, @anos, @idcandidato)", conexionbd.ObtenerConexion());
            try
            {

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    agregar.Parameters.Clear();


                    agregar.Parameters.AddWithValue("@descripcion", Convert.ToString(row.Cells[0].Value));
                    agregar.Parameters.AddWithValue("@lugar", Convert.ToString(row.Cells[1].Value));
                    agregar.Parameters.AddWithValue("@anos", Convert.ToString(row.Cells[2].Value));
                    agregar.Parameters.AddWithValue("@idcandidato", Convert.ToString(tb.Text));
                    agregar.ExecuteNonQuery();
                }
                MessageBox.Show("Datos Ingresados Correctamente");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Los Datos no se Ingresaron Correctamente" + ex.ToString());
            }
        }


        // modificar desde datagridview
        public void modificar(DataGridView dgv)
        {
            SqlCommand agregar = new SqlCommand("update ESTUDIOS set descripcion=@descripcion, tipodeestudio=@tipodeestudio, lugar=@lugar, idcandidato =@idcandidato where idestudios=@idestudios", conexionbd.ObtenerConexion());
            try
            {

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    agregar.Parameters.Clear();

                    agregar.Parameters.AddWithValue("@idestudios", Convert.ToString(row.Cells[0].Value));
                    agregar.Parameters.AddWithValue("@descripcion", Convert.ToString(row.Cells[1].Value));
                    agregar.Parameters.AddWithValue("@tipodeestudio", Convert.ToString(row.Cells[2].Value));
                    agregar.Parameters.AddWithValue("@lugar", Convert.ToString(row.Cells[3].Value));
                    agregar.Parameters.AddWithValue("@idcandidato", Convert.ToString(row.Cells[4].Value));
                    agregar.ExecuteNonQuery();
                }
                MessageBox.Show("Datos Modificados Correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Modificar" + ex.ToString());
            }
        }

        public void modificar2(DataGridView dgv)
        {
            SqlCommand agregar = new SqlCommand("update EXPERIENCIALABORAL set descripcion=@descripcion, lugar=@lugar, anos=@anos, idcandidato=@idcandidato where idexperencialaboral=@idexperencialaboral", conexionbd.ObtenerConexion());
            try
            {

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    agregar.Parameters.Clear();

                    agregar.Parameters.AddWithValue("@idexperencialaboral", Convert.ToString(row.Cells[0].Value));
                    agregar.Parameters.AddWithValue("@descripcion", Convert.ToString(row.Cells[1].Value));
                    agregar.Parameters.AddWithValue("@lugar", Convert.ToString(row.Cells[2].Value));
                    agregar.Parameters.AddWithValue("@anos", Convert.ToString(row.Cells[3].Value));
                    agregar.Parameters.AddWithValue("@idcandidato", Convert.ToString(row.Cells[4].Value));
                    agregar.ExecuteNonQuery();
                }
                MessageBox.Show("Datos Modificados Correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Modificar" + ex.ToString());
            }
        }

        public void eliminardgv(TextBox tb)
        {

            SqlCommand cmd = new SqlCommand("Delete from ESTUDIOS where idestudios=" + Convert.ToInt32(tb.Text) + "", conexionbd.ObtenerConexion());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro Eliminado");
           

        }


        public void eliminardgv2(TextBox tb)
        {

            SqlCommand cmd = new SqlCommand("Delete from EXPERIENCIALABORAL where idexperencialaboral=" + Convert.ToInt32(tb.Text) + "", conexionbd.ObtenerConexion());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro Eliminado");


        }

        public void anteriordgv(DataGridView dgv)
        {
            int prev = dgv.CurrentRow.Index - 1;
            if (prev >= 0)
            {
                dgv.CurrentCell = dgv.Rows[prev].Cells[dgv.CurrentCell.ColumnIndex];
            }
            else
            {
                MessageBox.Show("Ya se encuentra en la primera fila");
            }
        }

        public void siguientedgv(DataGridView dgv)
        {
            int prev = dgv.CurrentRow.Index + 1;
            if (prev <= 0)
            {
                dgv.CurrentCell = dgv.Rows[prev].Cells[dgv.CurrentCell.ColumnIndex]; ;
            }
            else
            {
                MessageBox.Show("Ya se encuentra en la primera fila");
            }
        }

        //Update de estados
 
        public bool updatecandidato1(string idcandidato)
        {
            SqlCommand cmd = new SqlCommand("update CANDIDATO set idestadocandidato=@idestadocandidato" + " where idcandidato=@idcandidato", conexionbd.ObtenerConexion());
            cmd.Parameters.Add("@idcandidato", SqlDbType.Int);
            cmd.Parameters.Add("@idestadocandidato", SqlDbType.Int);

            cmd.Parameters["@idcandidato"].Value = idcandidato;
            cmd.Parameters["@idestadocandidato"].Value = 1;

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


        public bool updatecandidato3(string idcandidato)
        {
            SqlCommand cmd = new SqlCommand("update CANDIDATO set idestadocandidato=@idestadocandidato" + " where idcandidato=@idcandidato", conexionbd.ObtenerConexion());
            cmd.Parameters.Add("@idcandidato", SqlDbType.Int);
            cmd.Parameters.Add("@idestadocandidato", SqlDbType.Int);

            cmd.Parameters["@idcandidato"].Value = idcandidato;
            cmd.Parameters["@idestadocandidato"].Value = 3;

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
        public bool updatecandidato4(string idcandidato)
        {
            SqlCommand cmd = new SqlCommand("update CANDIDATO set idestadocandidato=@idestadocandidato" + " where idcandidato=@idcandidato", conexionbd.ObtenerConexion());
            cmd.Parameters.Add("@idcandidato", SqlDbType.Int);
            cmd.Parameters.Add("@idestadocandidato", SqlDbType.Int);

            cmd.Parameters["@idcandidato"].Value = idcandidato;
            cmd.Parameters["@idestadocandidato"].Value = 4;

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


        public bool updatecandidato6(string idcandidato)
        {
            SqlCommand cmd = new SqlCommand("update CANDIDATO set idestadocandidato=@idestadocandidato" + " where idcandidato=@idcandidato", conexionbd.ObtenerConexion());
            cmd.Parameters.Add("@idcandidato", SqlDbType.Int);
            cmd.Parameters.Add("@idestadocandidato", SqlDbType.Int);

            cmd.Parameters["@idcandidato"].Value = idcandidato;
            cmd.Parameters["@idestadocandidato"].Value = 6;

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


        public bool updatecandidato7(string idcandidato)
        {
            SqlCommand cmd = new SqlCommand("update CANDIDATO set idestadocandidato=@idestadocandidato" + " where idcandidato=@idcandidato", conexionbd.ObtenerConexion());
            cmd.Parameters.Add("@idcandidato", SqlDbType.Int);
            cmd.Parameters.Add("@idestadocandidato", SqlDbType.Int);

            cmd.Parameters["@idcandidato"].Value = idcandidato;
            cmd.Parameters["@idestadocandidato"].Value = 7;

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

        public bool updatecandidato8(string idcandidato)
        {
            SqlCommand cmd = new SqlCommand("update CANDIDATO set idestadocandidato=@idestadocandidato" + " where idcandidato=@idcandidato", conexionbd.ObtenerConexion());
            cmd.Parameters.Add("@idcandidato", SqlDbType.Int);
            cmd.Parameters.Add("@idestadocandidato", SqlDbType.Int);

            cmd.Parameters["@idcandidato"].Value = idcandidato;
            cmd.Parameters["@idestadocandidato"].Value = 8;

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


        public bool updatecandidato5(string idcandidato)
        {
            SqlCommand cmd = new SqlCommand("update CANDIDATO set idestadocandidato=@idestadocandidato" + " where idcandidato=@idcandidato", conexionbd.ObtenerConexion());
            cmd.Parameters.Add("@idcandidato", SqlDbType.Int);
            cmd.Parameters.Add("@idestadocandidato", SqlDbType.Int);

            cmd.Parameters["@idcandidato"].Value = idcandidato;
            cmd.Parameters["@idestadocandidato"].Value = 5;

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


    }
}

