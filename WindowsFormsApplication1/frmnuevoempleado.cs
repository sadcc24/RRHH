using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class frmnuevoempleado : Form
    {
        string empresamdi;
        int empresaidmdi;
        string depto;
        string puesto;
        byte[] arr;
        public frmnuevoempleado(string emp, int idemp)
        {
            InitializeComponent();
            empresamdi = emp;
            empresaidmdi = idemp;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtApellido1.Text == "" || txtApellido2.Text == "" || txtApellido3.Text == "" || txtAumento.Text == "" || txtDireccion.Text == "" || txtDireccion.Text == "" || txtIdentificacion.Text == "" || txtJornada.Text == "" || txtNacionalidad.Text == "" || txtnombre1.Text == "" || txtnombre2.Text == "" || txtSueldo.Text == "" || txtTelefono.Text == "")
                {
                    MessageBox.Show("Existe uno o mas campos Vacios");
                }
                else
                {
                        #region llena variables
                    int Estado = 0;
                    if (radioButton1.Checked == true){ Estado = 1; }
                    if (radioButton2.Checked == true){ Estado = 2; }
                    if (radioButton3.Checked == true){ Estado = 3; }
                    int CodUsuario =1;
                    int Empresa = empresaidmdi;

                    int rol = Convert.ToInt32(comboBox1.SelectedValue);
                    string sueldo = txtSueldo.Text;
                    string aumento = txtAumento.Text;
                    puesto = cmbPuesto.SelectedValue.ToString();
                    string jornada = txtJornada.Text;
                    string feciniciolaboral = dateTimePicker1.Text;
                    string nombre1 = txtnombre1.Text;
                    string nombre2 = txtnombre2.Text;
                    string apellido1 = txtApellido1.Text;
                    string apellido2 = txtApellido2.Text;
                    string apellido3 = txtApellido3.Text;
                    string nacionalidad = txtNacionalidad.Text;
                    string sexo = cmbSexo.Text;
                    string fechanacimiento = dateTimePicker2.Text;
                    string direccion = txtDireccion.Text;
                    int telefono= Convert.ToInt32(txtTelefono.Text);
                    string identificacion = txtIdentificacion.Text;
                    int? experiencia = 1;
                    int? estudio = 1;
                            #endregion
                        if (MessageBox.Show("Desea crear el Empleado: " + nombre1 + " ?", "Empleado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            int result = new capa_negocio_Empleado().InsertaEmpleado(experiencia, estudio, Estado, CodUsuario, Empresa, rol, sueldo, aumento, puesto, jornada, feciniciolaboral, nombre1, nombre2, apellido1, apellido2, apellido3, nacionalidad, sexo, fechanacimiento, direccion, telefono, identificacion, arr);
                            if (result > 0)
                            {
                                MessageBox.Show("Empleado " + nombre1 + " Creado Correctamente", "Empleado");
                            }
                            else
                            {
                                MessageBox.Show("Ocurrio un error al crear el Empleado " + nombre1, "Empleado");
                            }
                        }
                        else
                        {

                        }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error en el Software o BD:" +ex.ToString(), "Empleado");
            }
        }


        private void btnAyuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"c:\ayuda.pdf");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void frmnuevoempleado_Load(object sender, EventArgs e)
        {
            cmbSexo.Text = "Seleccione";
            cmbDepto.Text = "Seleccione";
            cmbPuesto.Text = "Seleccione";
            comboBox1.Text = "Seleccione";
            radioButton1.Checked = true;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            label9.Text = empresamdi;
            DataTable data = new capa_negocio_Empleado().obtieneRol();
            comboBox1.DataSource = data;
            comboBox1.ValueMember = "idrol";
            comboBox1.DisplayMember = "rol";
            DataTable dataDepto = new capa_negocio_Empleado().obtieneDepto();
            cmbDepto.DataSource = dataDepto;
            cmbDepto.DisplayMember = "nombredeptoempresa";
            cmbDepto.ValueMember = "id";
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
            txtApellido1.Clear();
            txtApellido2.Clear();
            txtApellido2.Clear();
            txtAumento.Clear();
            txtDireccion.Clear();
            txtIdentificacion.Clear();
            txtJornada.Clear();
            txtNacionalidad.Clear();
            txtnombre1.Clear();
            txtnombre2.Clear();
            cmbSexo.Text = "Seleccione";
            cmbDepto.Text = "Seleccione";
            cmbPuesto.Text = "Seleccione";
            comboBox1.Text = "Seleccione";
            txtSueldo.Clear();
            txtTelefono.Clear();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters
            open.Filter = "Image Files(*.jpeg;)|*.jpeg;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image =  Image.FromFile(open.FileName);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();

                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                arr = ms.GetBuffer();

            }
        }

    }
}
