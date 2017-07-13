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
    public partial class asignacion_capacitaciones : Form
    {
        string usuario = "";
        public asignacion_capacitaciones(string nombre, string descripcion, string user)
        {
            usuario = user;
          
            InitializeComponent();

            if (nombre != "0" && descripcion != "0" && usuario != "0")
            {
                string idcapacitacion = capa_negocio_formaciones.busqueda_asignacion(nombre, usuario, descripcion);
                List<capa_presentacion_formaciones.info_capa> info_capacitaciones = capa_negocio_formaciones.capacitaciones(usuario);
                cbcapacitaciones.DataSource = info_capacitaciones;
                cbcapacitaciones.DisplayMember = "nombre_capa";
                cbcapacitaciones.ValueMember = "idcapacitacion";
                cbmetodo_asignacion.Text = "Seleccionar";
                cbcapacitaciones.SelectedValue = idcapacitacion;
            }
            else {
                List<capa_presentacion_formaciones.info_capa> info_capacitaciones = capa_negocio_formaciones.capacitaciones(usuario);
                cbcapacitaciones.DataSource = info_capacitaciones;
                cbcapacitaciones.DisplayMember = "nombre_capa";
                cbcapacitaciones.ValueMember = "idcapacitacion";
                cbmetodo_asignacion.Text = "Seleccionar";
            }
        }

        private void cbmetodo_asignacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmetodo_asignacion.Text == "Departamento")
            {
                List<capa_presentacion_formaciones.departamento> depto = capa_negocio_formaciones.departamentos(usuario);
                cb_depto_emp.DataSource = depto;
                cb_depto_emp.DisplayMember = "nombredepartamento";
                cb_depto_emp.ValueMember = "iddepartamento";

            }
            else if (cbmetodo_asignacion.Text == "Empleado") {
                List<capa_presentacion_formaciones.empleados> emp = capa_negocio_formaciones.empleados(usuario);
                cb_depto_emp.DataSource = emp;
                cb_depto_emp.DisplayMember = "empleado";
                cb_depto_emp.ValueMember = "idempleado";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string idcapacitacion=cbcapacitaciones.SelectedValue.ToString();
            string metodoasignacion=cbmetodo_asignacion.Text;
            string empleado=cb_depto_emp.SelectedValue.ToString();
            string departamento=cb_depto_emp.SelectedValue.ToString();
            string fechainicio = fecha_inicio.Value.Date.ToString("yyyy-MM-dd");
            string fechafin = fecha_fin.Value.Date.ToString("yyyy-MM-dd");
            string horario = horario_.Text;

            int asignacion = 0;
            string metodo = "";
            if (cbmetodo_asignacion.Text == "Empleado")
            {
                metodo = "1";

                asignacion = capa_negocio_formaciones.asignar(idcapacitacion, metodoasignacion, empleado, departamento, fechainicio, fechafin, horario,metodo,usuario);

                if (asignacion == 1)
                {
                    MessageBox.Show("Asignacion Exitosa", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnGuardar.Enabled=false;
                }
                else
                {
                    MessageBox.Show("Asignacion Fallida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (cbmetodo_asignacion.Text == "Departamento") {
                metodo = "2";

                asignacion = capa_negocio_formaciones.asignar(idcapacitacion, metodoasignacion, empleado, departamento, fechainicio, fechafin, horario, metodo,usuario);

                if (asignacion == 1)
                {
                    MessageBox.Show("Asignacion Exitosa", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Asignacion Fallida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            


        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\AsignacionCapacitacion-mike.pdf");

        }
    }
}
