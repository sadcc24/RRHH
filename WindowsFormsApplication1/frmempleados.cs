using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Threading;
using System.Globalization;
using Navegador;
// Put the following code before InitializeComponent()
// Sets the culture to French (France)

namespace WindowsFormsApplication1
{
    public partial class frmempleados : Form
    {

        string empresamdi;
        int empresaidmdi;
        string depto;
        int puesto;
        byte[] arr;
        int idempleado;
        int idempresa;
        string sueldo;
        string aumento;
        public static SqlConnection SQL_Conexion = new SqlConnection();

        public frmempleados(string emp, int idemp)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
            // Sets the UI culture to French (France)
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-FR");
            InitializeComponent();
            empresamdi = emp;
            empresaidmdi = idemp;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Size = new Size(665, 674);
            idempleado = Convert.ToInt32(dataGridView1[9, dataGridView1.CurrentCell.RowIndex].Value.ToString());
            DataTable data = new capa_negocio_Empleado().GetEmpleadoDatos(Convert.ToString(idempleado));
            
            txtNombre1.Text = (string)data.Rows[0][0];
            txtNombre2.Text = (string)data.Rows[0][1];
            txtApellido1.Text = (string)data.Rows[0][2];
            txtApellido2.Text = (string)data.Rows[0][3];
            txtApellido3.Text = (string)data.Rows[0][4];
            txtDireccion.Text = (string)data.Rows[0][5];
            dateTimePicker2.Text = ((DateTime)data.Rows[0][6]).ToString("yyyy-MM-dd");
            txtIdentificacion.Text = (string)data.Rows[0][7];
            cmbSexo.Text = (string)data.Rows[0][8];
            txtNacionalidad.Text = (string)data.Rows[0][9];
            txtTelefono.Text = Convert.ToString((int)data.Rows[0][10]);
            txtJornada.Text = (string)data.Rows[0][11];
            txtSueldo.Text = ((string)data.Rows[0][12]).ToString();
            txtAumento.Text = ((string)data.Rows[0][13]).ToString();
            dateTimePicker1.Text = (string)data.Rows[0][14];
            int estado = (int)data.Rows[0][17];
            txtEmpresa.Text = (string)data.Rows[0][18];
            //cargafotografia();
            //byte[] datos = new byte[0];
            arr = (byte[])data.Rows[0][19];
            //System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
            //pictureBox1.Image = System.Drawing.Bitmap.FromStream(ms);
            int valor1 = Convert.ToInt32((decimal)data.Rows[0][20]);
            int valor2 = Convert.ToInt32((decimal)data.Rows[0][21]);
            cmbPuesto.SelectedValue = valor1;
            cmbDepto.SelectedValue = valor2;
            int valor3 = (int)data.Rows[0][22];
            cmbRol.SelectedValue = valor3;
            idempresa = (int)data.Rows[0][23];

            if (estado == 1)
            {
                radioButton1.Checked = true;
            }
            if (estado == 2)
            {
                radioButton2.Checked = true;
            }
            if (estado == 3)
            {
                radioButton3.Checked = true;
            }

        }

        private void cargafotografia()
        {
            try
            {

                SqlDataAdapter SQL_da = new SqlDataAdapter("select fotografia from DETALLEPERSONAL where idempleado ='" + idempleado + "';", conexionbd.ObtenerConexion());
                DataSet DT_dat = new DataSet();
                SQL_da.Fill(DT_dat, "fotografia");
                byte[] datos = new byte[0];
                DataRow dr = DT_dat.Tables["fotografia"].Rows[0];
                datos = (byte[])dr["fotografia"];
                arr = (byte[])dr["fotografia"];
                System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
                pictureBox1.Image = System.Drawing.Bitmap.FromStream(ms);
                SQL_Conexion.Close();
            }

            catch(Exception ex)
            {
                MessageBox.Show("Problema en BD"+ex);
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(665, 409);
            label9.Text = empresamdi;
            carga_gried();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            label9.Text = empresamdi;
            DataTable data = new capa_negocio_Empleado().obtieneRol();
            cmbRol.DataSource = data;
            cmbRol.ValueMember = "idrol";
            cmbRol.DisplayMember = "rol";
            DataTable dataDepto = new capa_negocio_Empleado().obtieneDepto();
            cmbDepto.DataSource = dataDepto;
            cmbDepto.DisplayMember = "nombredeptoempresa";
            cmbDepto.ValueMember = "id";
            depto = cmbDepto.SelectedValue.ToString();
            DataTable datapuesto = new capa_negocio_Empleado().obtienePuesto(depto);
            cmbPuesto.DataSource = datapuesto;
            cmbPuesto.ValueMember = "idpuestodetrabajo";
            cmbPuesto.DisplayMember = "nombrepuesto";
        }

        private void carga_gried()
        {
            try
            {
                DataTable DT_dat = new capa_negocio_Empleado().GetEmpleadoGrid();
                this.dataGridView1.DataSource = DT_dat;
                SQL_Conexion.Close();
            }
            catch (Exception ei)
            {
                MessageBox.Show("Ocurrio un error" + ei.Message);
            }
        }


        private void button8_Click(object sender, EventArgs e)
        {
            txtJornada.Enabled = true;
            txtSueldo.Enabled = true;
            txtAumento.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Size = new Size(665, 409);
            txtJornada.Clear();
            txtSueldo.Clear();
            txtAumento.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            #region enable
            txtEmpresa.Enabled = true;
            cmbRol.Enabled = false;
            txtApellido1.Enabled = true;
            txtApellido2.Enabled = true;
            txtApellido3.Enabled = true;
            txtAumento.Enabled = true;
            cmbPuesto.Enabled = true;
            txtDireccion.Enabled = true;
            txtEmpresa.Enabled = false;
            dateTimePicker1.Enabled = true;
            txtIdentificacion.Enabled = true;
            dateTimePicker2.Enabled = true;
            txtJornada.Enabled = true;
            txtNacionalidad.Enabled = true;
            txtNombre1.Enabled = true;
            txtNombre2.Enabled = true;
            cmbDepto.Enabled = true;
            cmbSexo.Enabled = true;
            txtSueldo.Enabled = true;
            txtTelefono.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            #endregion

        }

        //Actualiza Empleado
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtApellido1.Text == "" || txtApellido2.Text == "" || txtAumento.Text == "" || txtDireccion.Text == "" || txtDireccion.Text == "" || txtIdentificacion.Text == "" || txtJornada.Text == "" || txtNacionalidad.Text == "" || txtNombre1.Text == "" || txtNombre2.Text == "" || txtSueldo.Text == "" || txtTelefono.Text == "")
                {
                    MessageBox.Show("Existe uno o mas campos Vacios");
                }
                else
                {
                    #region llena variables
                    int Estado = 0;
                    if (radioButton1.Checked == true) { Estado = 1; }
                    if (radioButton2.Checked == true) { Estado = 2; }
                    if (radioButton3.Checked == true) { Estado = 3; }
                    int CodUsuario = 1;
                    int Empresa = empresaidmdi;

                    int rol = Convert.ToInt32(cmbRol.SelectedValue);
                    sueldo = txtSueldo.Text;
                    aumento = txtAumento.Text;
                    puesto = Convert.ToInt32(cmbPuesto.SelectedValue.ToString());
                    int jornada = Convert.ToInt32(txtJornada.Text);
                    string feciniciolaboral = dateTimePicker1.Text;
                    string nombre1 = txtNombre1.Text;
                    string nombre2 = txtNombre2.Text;
                    string apellido1 = txtApellido1.Text;
                    string apellido2 = txtApellido2.Text;
                    string apellido3 = txtApellido3.Text;
                    string nacionalidad = txtNacionalidad.Text;
                    string sexo = cmbSexo.Text;
                    string fechanacimiento = dateTimePicker2.Text;
                    string direccion = txtDireccion.Text;
                    int telefono = Convert.ToInt32(txtTelefono.Text);
                    string identificacion = txtIdentificacion.Text;
                    byte[] fotografia = arr;
                    int? experiencia = 1;
                    int? estudio = 1;
                    #endregion
                    if (MessageBox.Show("Desea Actualizar el Empleado: " + nombre1 + " ?", "Empleado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int result = new capa_negocio_Empleado().ActualizaEmpleado(idempleado, experiencia, estudio, Estado, idempresa, rol, sueldo, aumento, puesto, jornada, feciniciolaboral, nombre1, nombre2, apellido1, apellido2, apellido3, nacionalidad, sexo, fechanacimiento, direccion, telefono, identificacion, fotografia);
                        if (result > 0)
                        {
                            MessageBox.Show("Empleado " + nombre1 + " Actualizado Correctamente", "Empleado");
                            carga_gried();
                            txtEmpresa.Enabled = false;
                            cmbRol.Enabled = false;
                            txtApellido1.Enabled = false;
                            txtApellido2.Enabled = false;
                            txtApellido3.Enabled = false;
                            txtAumento.Enabled = false;
                            cmbPuesto.Enabled = false;
                            txtDireccion.Enabled = false;
                            txtEmpresa.Enabled = false;
                            dateTimePicker1.Enabled = false;
                            txtIdentificacion.Enabled = false;
                            dateTimePicker2.Enabled = false;
                            txtJornada.Enabled = false;
                            txtNacionalidad.Enabled = false;
                            txtNombre1.Enabled = false;
                            txtNombre2.Enabled = false;
                            cmbDepto.Enabled = false;
                            cmbSexo.Enabled = false;
                            txtSueldo.Enabled = false;
                            txtTelefono.Enabled = false;
                            radioButton1.Enabled = false;
                            radioButton2.Enabled = false;
                            radioButton3.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Ocurrio un error al actualizar el Empleado " + nombre1, "Empleado");
                        }
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error en el Software o BD:" + ex.ToString(), "Empleado");
            }
        }

        private void cmbDepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            depto = cmbDepto.SelectedValue.ToString();
            DataTable datapuesto = new capa_negocio_Empleado().obtienePuesto(depto);
            cmbPuesto.DataSource = datapuesto;
            cmbPuesto.ValueMember = "idpuestodetrabajo";
            cmbPuesto.DisplayMember = "nombrepuesto";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            #region enable
            txtApellido1.Enabled = false;
            txtApellido2.Enabled = false;
            txtApellido3.Enabled = false;
            txtAumento.Enabled = false;
            cmbPuesto.Enabled = false;
            txtDireccion.Enabled = false;
            txtEmpresa.Enabled = false;
            dateTimePicker1.Enabled = false;
            txtIdentificacion.Enabled = false;
            dateTimePicker2.Enabled = false;
            txtJornada.Enabled = false;
            txtNacionalidad.Enabled = false;
            txtNombre1.Enabled = false;
            txtNombre2.Enabled = false;
            cmbDepto.Enabled = false;
            cmbSexo.Enabled = false;
            txtSueldo.Enabled = false;
            txtTelefono.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            cmbRol.Enabled = false;
            #endregion
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            carga_gried();
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(dataGridView1);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(dataGridView1);
        }

        private void btnAtrasfin_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(dataGridView1);
        }

        private void btnAdelantefin_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(dataGridView1);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"c:\ayuda.pdf");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.jpeg;)|*.jpeg;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();

                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                arr = ms.GetBuffer();

            }
        }
    }
}
