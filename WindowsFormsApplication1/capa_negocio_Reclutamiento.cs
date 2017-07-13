using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class capa_negocio_Reclutamiento
    {
        capa_logica_Reclutamiento clr = new capa_logica_Reclutamiento();
        public int Login(string sUser, string sContra)
        {
            int resultado = 0;
            if (string.IsNullOrWhiteSpace(sUser) || string.IsNullOrWhiteSpace(sContra))
            {
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                resultado = capa_logica_Reclutamiento.LoginD(sUser, sContra);
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


        public void camposenabledfalse(Control control, GroupBox gb)
        {
            foreach (var combo in gb.Controls)
            {
                if (combo is TextBox)
                {
                    ((TextBox)combo).Enabled = false;
                }
                else if (combo is ComboBox)
                {
                    ((ComboBox)combo).Enabled = false;
                }
            }
        }


        public void camposenabledtrue(Control control, GroupBox gb)
        {
            foreach (var combo in gb.Controls)
            {
                if (combo is TextBox)
                {
                    ((TextBox)combo).Enabled = true;
                }
                else if (combo is ComboBox)
                {
                    ((ComboBox)combo).Enabled = true;
                }
            }
        }

        public void camposclear(Control control, GroupBox gb)
        {
            foreach (var combo in gb.Controls)
            {
                if (combo is TextBox)
                {
                    ((TextBox)combo).Clear();
                }
                else if (combo is ComboBox)
                {
//                    ((ComboBox)combo).SelectedIndex = 0;
                }
            }
        }

        public void camposnulos(Control control, GroupBox gb)
        {
            foreach (var combo in gb.Controls)
            {
                if (combo is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(((TextBox)combo).Text))
                    {
                        MessageBox.Show("No pueden quedar espacios vacios");
                    }
                }
            }
        }


        public void resultado(TextBox txtresultado, Label lblresultado)
        {
            if (string.IsNullOrWhiteSpace(txtresultado.Text))
            {
                lblresultado.Text = "";
            }
            else
            {
                if (txtresultado.Text == ("1"))
                {
                    lblresultado.ForeColor = System.Drawing.Color.Green;
                    lblresultado.Text = "APROBADO";
                }
                else if (txtresultado.Text == ("2"))
                {
                    lblresultado.ForeColor = System.Drawing.Color.Red;
                    lblresultado.Text = "REPROBADO";
                }
            }
        }

        public void resultadoT(TextBox tbr1, TextBox tbr2, TextBox tbr3, TextBox tbrt)
        {
            if (string.IsNullOrWhiteSpace(tbr1.Text) || string.IsNullOrWhiteSpace(tbr2.Text) || string.IsNullOrWhiteSpace(tbr3.Text))
            {
                tbrt.Text = "";
            }
            else
            {
                tbrt.Text = ((Convert.ToInt32(tbr1.Text) + Convert.ToInt32(tbr2.Text) + Convert.ToInt32(tbr3.Text)) / 3).ToString();
            }
        }

        public void trasladarR(TextBox tbrt, TextBox resultado)
        {
            if (string.IsNullOrWhiteSpace(tbrt.Text))
            {
                tbrt.Text = "";
                resultado.Text = "";
            }
            else
            {
                int i;
                i = Convert.ToInt32(tbrt.Text);
                i = int.Parse(tbrt.Text);

                if (i >= 0 && i < 70)
                {
                    resultado.Text = "2";
                }
                else if (i >= 70 && i <= 100)
                {
                    resultado.Text = "1";

                }
            }

        }

        public void solonumeros(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }


        public void sololetras(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        public void rango(TextBox tb)
        {
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                tb.Text = "";
            }
            else
            {
                int i;
                i = Convert.ToInt32(tb.Text);
                i = int.Parse(tb.Text);

                if (i >= 0 && i <= 100)
                {
                    tb.Text = i.ToString();
                }
                else
                {
                    MessageBox.Show("Número Fuera de Rango Permitido");
                    tb.Text = "";
                }
            }
        }

        public void etiquetapreba(Label l1, Label l2, Label l3, TextBox tb)
        {
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                l1.Text = "";
                l2.Text = "";
                l3.Text = "";
            }
            else
            {
                if (tb.Text == ("1"))
                {
                    l1.Text = "Pruebas de Inteligenica  General";
                    l2.Text = "Pruebas Psicométricas";
                    l3.Text = "Prueba de Personalidad";
                }
                else if (tb.Text == ("2"))
                {
                    l1.Text = "Pruebas Especificas de Área";
                    l2.Text = "Prueba Tecnica";
                    l3.Text = "Prueba de Simulación";
                }

            }
        }

        public void tamano(Control c, TextBox tb)
        {
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                c.Width = 455;
                c.Height = 240;
            }
            else
            {
                c.Width = 455;
                c.Height = 550;
            }

        }

        public void insertardetalleentrevista(string identrevista, string comentario, string resultado1, string resultado2, string resultado3, string total, string idresultadoentrevista, TextBox tbr1, TextBox tbr2, TextBox tbr3, TextBox coment)
        {
            Resultado_Pueba rp = new Resultado_Pueba();

            if (string.IsNullOrWhiteSpace(tbr1.Text) || string.IsNullOrWhiteSpace(tbr2.Text) || string.IsNullOrWhiteSpace(tbr3.Text) || string.IsNullOrWhiteSpace(coment.Text))
            {
                MessageBox.Show("Hay uno o mas campos Vacios");

            }
            else
            {
                if (clr.insertardetalleentrevista(identrevista, comentario, resultado1, resultado2, resultado3, total, idresultadoentrevista))
                {
                    MessageBox.Show("La Información se Guardo Correctamente");
                    rp.Close();
                }
                else
                {
                    MessageBox.Show("La Información No se Guardo Correctamente");
                }
            }
        }

        public void modificardetalleentrevista(string iddetalleentrevista, string identrevista, string comentario, string resultado1, string resultado2, string resultado3, string total, string idresultadoentrevista, TextBox tbr1, TextBox tbr2, TextBox tbr3, TextBox coment)
        {
            if (string.IsNullOrWhiteSpace(tbr1.Text) || string.IsNullOrWhiteSpace(tbr2.Text) || string.IsNullOrWhiteSpace(tbr3.Text) || string.IsNullOrWhiteSpace(coment.Text))
            {
                MessageBox.Show("Hay uno o mas campos Vacios");

            }
            else
            {
                if (clr.ModificarDetalleEntrevista(iddetalleentrevista, identrevista, comentario, resultado1, resultado2, resultado3, total, idresultadoentrevista))
                {
                    MessageBox.Show("La Información se Modifico Correctamente");
                }
                else
                {
                    MessageBox.Show("La Información No se Modifico Correctamente");
                }

            }

        }

        public void consultatdentrevista(DataGridView dgv)
        {
            clr.consultadtentrevista("DETALLEENTREVISTA");
            dgv.DataSource = clr.ds.Tables["DETALLEENTREVISTA"];

        }

        public void consultacandidato(DataGridView dgv)
        {
            clr.consultarcandidato("CANDIDATO");
            dgv.DataSource = clr.ds.Tables["CANDIDATO"];
        }


        public void insertarcandidato(string idestadocandidato, string idestadocivil, string idsexo, string idnacionalidad, string nombre1, string nombre2, string apellido1, string apellido2, string apellido3, string direccion, string telefono, string nidentificacion, string fechanacimiento, PictureBox fotografia,string idpuestodetrabajo, TextBox sexo, TextBox tb1, TextBox tb2, TextBox tb3, TextBox tb4, TextBox tb5, TextBox tb6, TextBox tb7, TextBox tb8, TextBox tb9, TextBox tb10, PictureBox pic, TextBox idpuesto)
        {
            if (string.IsNullOrWhiteSpace(sexo.Text) || string.IsNullOrWhiteSpace(tb1.Text) || string.IsNullOrWhiteSpace(tb2.Text) || string.IsNullOrWhiteSpace(tb3.Text) || string.IsNullOrWhiteSpace(tb4.Text) || string.IsNullOrWhiteSpace(tb5.Text) || string.IsNullOrWhiteSpace(tb6.Text) || string.IsNullOrWhiteSpace(tb7.Text) || string.IsNullOrWhiteSpace(tb8.Text) || string.IsNullOrWhiteSpace(tb9.Text) || string.IsNullOrWhiteSpace(tb10.Text) || string.IsNullOrWhiteSpace(idpuesto.Text))
                {
                MessageBox.Show("Hay uno o mas campos Vacios");
            }
            else if ( pic.Image == null)
            {
                MessageBox.Show("Debe de seleccionar una fotografia para el Candidato");
            }
            else
            {
                frmcandidatonuevo cn = new frmcandidatonuevo();
                
                if (clr.insertarimagen(idestadocandidato, idestadocivil, idsexo, idnacionalidad, nombre1, nombre2, apellido1, apellido2, apellido3, direccion, telefono, nidentificacion, fechanacimiento, fotografia, idpuestodetrabajo))
                {
                    MessageBox.Show("La Información se Guardo Correctamente");
                    cn.Close();
                }
                else
                {
                    MessageBox.Show("La Información No se Guardo Correctamente");
                }

            }
        }

        public void actualizarcandidato(string idcandidato, string idestadocandidato, string idestadocivil, string idsexo, string idnacionalidad, string nombre1, string nombre2, string apellido1, string apellido2, string apellido3, string direccion, string telefono, string nidentificacion, string fechanacimiento, PictureBox fotografia, string idpuestodetrabajo, TextBox sexo, TextBox tb1, TextBox tb2, TextBox tb3, TextBox tb4, TextBox tb5, TextBox tb6, TextBox tb7, TextBox tb8, TextBox tb9, TextBox tb10, PictureBox pic,TextBox idpuesto)
        {
            if (string.IsNullOrWhiteSpace(sexo.Text) || string.IsNullOrWhiteSpace(tb1.Text) || string.IsNullOrWhiteSpace(tb2.Text) || string.IsNullOrWhiteSpace(tb3.Text) || string.IsNullOrWhiteSpace(tb4.Text) || string.IsNullOrWhiteSpace(tb5.Text) || string.IsNullOrWhiteSpace(tb6.Text) || string.IsNullOrWhiteSpace(tb7.Text) || string.IsNullOrWhiteSpace(tb8.Text) || string.IsNullOrWhiteSpace(tb9.Text) || string.IsNullOrWhiteSpace(tb10.Text) || string.IsNullOrWhiteSpace(idpuesto.Text))
            {
                MessageBox.Show("Hay uno o mas campos Vacios");
            }
            else if (pic.Image == null)
            {
                MessageBox.Show("Debe de seleccionar una fotografia para el Candidato");
            }
            else
            {

                if (clr.actualizarimagen(idcandidato, idestadocandidato, idestadocivil, idsexo, idnacionalidad, nombre1, nombre2, apellido1, apellido2, apellido3, direccion, telefono, nidentificacion, fechanacimiento, fotografia, idpuestodetrabajo))
                {
                    MessageBox.Show("Los Datos se Actualizaron Correctamente");
                    frmcandidatonuevo cn = new frmcandidatonuevo();
                    cn.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al Actualizar Datos");
                }
            }
        }

        public void consultaestudios (DataGridView dgv, TextBox tb)
        {
            clr.consulta("select * from ESTUDIOS where idcandidato = '" + tb.Text + "'", "CANDIDATO");
            dgv.DataSource = clr.ds.Tables["CANDIDATO"];
        }

        public void consultaexperiencialab(DataGridView dgv, TextBox tb)
        {
            clr.consulta("select * from EXPERIENCIALABORAL where idcandidato = '" + tb.Text + "'", "EXPERIENCIALABORAL");
            dgv.DataSource = clr.ds.Tables["EXPERIENCIALABORAL"];

        }
    }
}
