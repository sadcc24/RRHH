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
    public partial class frmplantillaplanillas : Form
    {
        public frmplantillaplanillas()
        {
            InitializeComponent();
            showPagoDescuentos();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        public void showPagoDescuentos()
        {
            List<capa_presentacion_planillas.ListPercepciones> showListPercepciones = capa_negocio_planillas.showListPercepciones();
            List<capa_presentacion_planillas.ListDeducciones> showListDeducciones = capa_negocio_planillas.showListDeducciones();

            grid_deducciones.DataSource = showListDeducciones;
            grid_deducciones.Columns["iddescuento"].Visible = false;

            grid_percepciones.DataSource = showListPercepciones;
            grid_percepciones.Columns["idbonificacion"].Visible = false;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            ABCPercepcionesDeducciones a = new ABCPercepcionesDeducciones();
            a.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            showPagoDescuentos();
        }

        private void btn_findEmp_Click(object sender, EventArgs e)
        {
            List<capa_presentacion_planillas.showEmpleados> showEmpleados = capa_negocio_planillas.showEmpleados();
            List<string[]> empleados = new List<string[]>();
            List<string> empList = new List<string>();
            string[] em = { };
            string empleadoAux = "";

            empleadoAux = showEmpleados[0].idempleado;
            empList.Add(showEmpleados[0].idempleado);
            empList.Add(showEmpleados[0].nombre1);
            empList.Add(showEmpleados[0].nombre2);
            empList.Add(showEmpleados[0].apellido1);
            empList.Add(showEmpleados[0].apellido2);
            foreach (var empleado in showEmpleados)
            {
                if (empleadoAux == empleado.idempleado)
                {
                    empList.Add(empleado.cuenta);
                }
                else
                {
                    empleadoAux = empleado.idempleado;
                    em = empList.ToArray();
                    empleados.Add(em);
                }
            }

            em = empList.ToArray();
            empleados.Add(em);

            DataTable table = ConvertListToDataTable(empleados);
            grid_empleados.DataSource = table;
        }

        static DataTable ConvertListToDataTable(List<string[]> list)
        {
            // New table.
            DataTable table = new DataTable();

            // Get max columns.
            int columns = 0;
            foreach (var array in list)
            {
                if (array.Length > columns)
                {
                    columns = array.Length;
                }
            }

            // Add columns.
            for (int i = 0; i < columns; i++)
            {
                table.Columns.Add();
            }

            // Add rows.
            foreach (var array in list)
            {
                table.Rows.Add(array);
            }

            return table;
        }

        private void btn_applyNomina_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            List<capa_presentacion_planillas.percepcionEmpleado> listPercepiones = new List<capa_presentacion_planillas.percepcionEmpleado>();
            List<capa_presentacion_planillas.deduccionEmpleado> listDeducciones = new List<capa_presentacion_planillas.deduccionEmpleado>();
            List<capa_presentacion_planillas.empleadoPerDedc> empleadoPerDedc = new List<capa_presentacion_planillas.empleadoPerDedc>();

            //PERCEPCIONES
            bool isChecked = false;
            foreach (DataGridViewRow row in grid_percepciones.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    int index = cell.ColumnIndex;
                    if (index == 0)
                    {
                        if (cell.Value != null)
                        {
                            if ((bool)cell.Value)
                            {
                                isChecked = true;
                            }
                        }
                    }
                    if (index == 1)
                    {
                        if (isChecked)
                        {
                            listPercepiones.Add(new capa_presentacion_planillas.percepcionEmpleado() { idpercepcion = cell.Value.ToString() });
                            isChecked = false;
                        }
                    }
                }
            }

            //DEDUCCIONES
            isChecked = false;
            foreach (DataGridViewRow row in grid_deducciones.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    int index = cell.ColumnIndex;
                    if (index == 0)
                    {
                        if (cell.Value != null)
                        {
                            if ((bool)cell.Value)
                            {
                                isChecked = true;
                            }
                        }
                    }
                    if (index == 1)
                    {
                        if (isChecked)
                        {
                            listDeducciones.Add(new capa_presentacion_planillas.deduccionEmpleado() { iddeduccion = cell.Value.ToString() });
                            isChecked = false;
                        }
                    }
                }
            }

            //Empleados
            foreach (DataGridViewRow row in grid_empleados.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    int index = cell.ColumnIndex;
                    if (index == 0)
                    {
                        if (cell.Value != null)
                        {
                            empleadoPerDedc.Add(new capa_presentacion_planillas.empleadoPerDedc() { idempleado = cell.Value.ToString() });
                        }
                    }
                }
            }

            if (listPercepiones.Count > 0)
            {
                resultado = capa_negocio_planillas.saveEmpleadoPercepcion(listPercepiones, empleadoPerDedc);
            }
            if (listDeducciones.Count > 0)
            {
                resultado = capa_negocio_planillas.saveEmpleadoDeduccion(listDeducciones, empleadoPerDedc);
            }

            if (resultado == 1)
            {
                MessageBox.Show("Transacción Exitosa");
                btn_findEmp_Click(null, null);
            }
            else
            {
                MessageBox.Show("Transacción Fallida, intente Nuevamente");
            }
        }
    }
}
