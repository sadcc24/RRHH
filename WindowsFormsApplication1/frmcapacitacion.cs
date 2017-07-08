using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Detalle_Capacitacion : Form
    {
        string id_capacitacion;
        string usuario;
        public Detalle_Capacitacion(string valor, string nombre, string descripcion, string expositor, string tipo, string costo,string user)
        {

            
            usuario = user;
            id_capacitacion = valor;
            InitializeComponent();
            List<capa_presentacion_formaciones.infotipocapacitacion> info_tipocapacitaciones = capa_negocio_formaciones.infotipocapacitacion();
            if (valor != "0")
            {
                txtnombre.Text = nombre;
                txtDescripcion.Text = descripcion;
                txtexpositor.Text = expositor;
                txtcosto.Text = costo;

                cbarea.DataSource = info_tipocapacitaciones;
                cbarea.DisplayMember = "tipo";
                cbarea.ValueMember = "idtipo";
                statuscapacitacion.Text = "Activo";
            }
            else {
                cbarea.DataSource = info_tipocapacitaciones;
                cbarea.DisplayMember = "tipo";
                cbarea.ValueMember = "idtipo";
                statuscapacitacion.Enabled = false;
                statuscapacitacion.Text = "Activo";

            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            string descripcion = txtDescripcion.Text;
            string expositor = txtexpositor.Text;
            string costo = txtcosto.Text;
            string area = cbarea.SelectedValue.ToString();
            DialogResult result;
            result = MessageBox.Show("Los Datos se Modificaran, Esta Seguro de continuar con esta accion?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                int resultado = capa_negocio_formaciones.modificar_capacitacion(id_capacitacion, nombre, descripcion, expositor, costo, area);
                if (resultado == 1)
                {
                    MessageBox.Show("Modificacion Exitosa", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Se Produjo un Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }


        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            List<capa_presentacion_formaciones.infotipocapacitacion> info_tipocapacitaciones = capa_negocio_formaciones.infotipocapacitacion();
            cbarea.DataSource = info_tipocapacitaciones;
            cbarea.DisplayMember = "tipo";
            cbarea.ValueMember = "idtipo";

            string nombre = txtnombre.Text;
            string descripcion = txtDescripcion.Text;
            string expositor = txtexpositor.Text;
            string costo = txtcosto.Text;
            string area = cbarea.SelectedValue.ToString();
            int resultado = capa_negocio_formaciones.nueva_capacitacion(nombre, descripcion, expositor, costo, area,usuario);
            if (resultado == 1)
            {

               DialogResult respuesta= MessageBox.Show("Capacitacion Creada Con Exito, Desea Realizar Asignacion de Personal a esta Capacitacion?","Creacion",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (respuesta == System.Windows.Forms.DialogResult.Yes)
                {
                    asignacion_capacitaciones ventanaP = new asignacion_capacitaciones (nombre,descripcion,usuario);
                    ventanaP.MdiParent = this.MdiParent;
                    this.Close();
                    ventanaP.Show();
                    
                }
                else {
                    txtnombre.Clear();
                    txtDescripcion.Clear();
                    txtexpositor.Clear();
                    txtcosto.Clear();
                }

            }

           
            

        }

        

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("La Capacitacion se Eliminara, Esta Seguro de continuar con esta accion?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                int resultado = capa_negocio_formaciones.eliminar_capacitacion(id_capacitacion);
                if (resultado == 1)
                {
                    MessageBox.Show("Eliminacion Exitosa", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   

                }
                else
                {
                    MessageBox.Show("Se Produjo un Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void Detalle_Capacitacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmcapacitaciones ventanaP = new frmcapacitaciones(usuario);
            ventanaP.MdiParent = this.MdiParent;
            ventanaP.Show();

        }

        private void Detalle_Capacitacion_Load(object sender, EventArgs e)
        {

        }
    }
}