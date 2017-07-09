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
            cmb_bondesc();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        public void cmb_bondesc()
        {
            List<capa_presentacion_planillas.cbx_bondesc> list_bondesc = capa_negocio_planillas.cbx_bondesc();

            cbx_bondesc.DataSource = list_bondesc;
            cbx_bondesc.DisplayMember = "descripcion";
            cbx_bondesc.ValueMember = "idbondesc";
        }

        private void cbx_bondesc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbx_bondesc.SelectedValue.ToString() == "1")//Nomina Aplicada
            {
                btn_findEmp_Click(null, null);
                btn_applyNomina.Hide();
                btn_undoNomina.Show();
            }
            if (cbx_bondesc.SelectedValue.ToString() == "2")//Nomina sin Aplicar
            {
                dataGridAllEmpleados();
                btn_applyNomina.Show();
                btn_undoNomina.Hide();
            }
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

        private void dataGridAllEmpleados()
        {
            List<capa_presentacion_planillas.showEmpleadosSinNomina> showEmpleados = capa_negocio_planillas.showEmpleadosSinNomina();

            grid_empleados.DataSource = showEmpleados;
            grid_empleados.Columns["idempleado"].Visible = false;
        }

        private void btn_findEmp_Click(object sender, EventArgs e)
        {
            List<capa_presentacion_planillas.ListPercepciones> percepciones = capa_negocio_planillas.showListPercepciones();
            List<capa_presentacion_planillas.ListDeducciones> deducciones = capa_negocio_planillas.showListDeducciones();

            List<capa_presentacion_planillas.showEmpleados> showEmpleados = capa_negocio_planillas.showEmpleados();
            List<string[]> empleados = new List<string[]>();
            List<string> empList = new List<string>();
            string empleadoAux = "";

            empleadoAux = showEmpleados[0].idempleado;
            empList.Add(showEmpleados[0].idempleado);
            empList.Add(showEmpleados[0].nombre1);
            empList.Add(showEmpleados[0].nombre2);
            empList.Add(showEmpleados[0].apellido1);
            empList.Add(showEmpleados[0].apellido2);
            empList.Add(showEmpleados[0].nombre_empresa);

            //Se reserevan las posiciones para ser utilizadas por percepciones y deducciones
            int posP = 6;
            foreach (var p in percepciones)
            {
                empList.Add("");
            }
            int posD = percepciones.Count + posP;
            foreach (var d in deducciones)
            {
                empList.Add("");
            }

            foreach (var empleado in showEmpleados)
            {
                if (empleadoAux == empleado.idempleado)
                {
                    //Percepciones
                    int pos = posP;
                    foreach (var p in percepciones)
                    {
                        if (p.idbonificacion == empleado.cuenta && empleado.tipo == "1")
                        {
                            empList[pos] = empleado.descripcion;
                            break;
                        }
                        pos++;
                    }
                    //Deducciones
                    pos = posD;
                    foreach (var d in deducciones)
                    {
                        if (d.iddescuento == empleado.cuenta && empleado.tipo == "2")
                        {
                            empList[pos] = empleado.descripcion;
                            break;
                        }
                        pos++;
                    }
                }
                else
                {
                    empleados.Add(empList.ToArray());
                    empList.Clear();

                    empleadoAux = empleado.idempleado;
                    empList.Add(empleado.idempleado);
                    empList.Add(empleado.nombre1);
                    empList.Add(empleado.nombre2);
                    empList.Add(empleado.apellido1);
                    empList.Add(empleado.apellido2);
                    empList.Add(empleado.nombre_empresa);

                    //Se reserevan las posiciones para ser utilizadas por percepciones y deducciones
                    posP = 6;
                    foreach (var p in percepciones)
                    {
                        empList.Add("");
                    }
                    posD = percepciones.Count + posP;
                    foreach (var d in deducciones)
                    {
                        empList.Add("");
                    }

                    //Percepciones
                    int pos = posP;
                    foreach (var p in percepciones)
                    {
                        if (p.idbonificacion == empleado.cuenta && empleado.tipo == "1")
                        {
                            empList[pos] = empleado.descripcion;
                            break;
                        }
                        pos++;
                    }
                    //Deducciones
                    pos = posD;
                    foreach (var d in deducciones)
                    {
                        if (d.iddescuento == empleado.cuenta && empleado.tipo == "2")
                        {
                            empList[pos] = empleado.descripcion;
                            break;
                        }
                        pos++;
                    }
                }
            }

            empleados.Add(empList.ToArray());

            DataTable table = ConvertListToDataTable(empleados);

            foreach (var p in percepciones)
            {
                table.Columns[posP].ColumnName = p.descripcion;
                posP++;
            }
            foreach (var d in deducciones)
            {
                table.Columns[posP].ColumnName = d.descripcion;
                posP++;
            }

            grid_empleados.DataSource = table;
            grid_empleados.Columns["idempleado"].Visible = false;
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

            table.Columns[0].ColumnName = "idempleado";
            table.Columns[1].ColumnName = "Primer Nombre";
            table.Columns[2].ColumnName = "Segundo Nombre";
            table.Columns[3].ColumnName = "Primer Apellido";
            table.Columns[4].ColumnName = "Segundo Apellido";
            table.Columns[5].ColumnName = "Empresa";

            // Add rows.
            foreach (var array in list)
            {
                table.Rows.Add(array);
            }

            return table;
        }

        private void btn_applyNomina_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Realmente desea aplicar la Nomina a los empleados Seleccionados?", "Aplicación de Nomina", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

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
            isChecked = false;
            foreach (DataGridViewRow row in grid_empleados.Rows)
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
                            empleadoPerDedc.Add(new capa_presentacion_planillas.empleadoPerDedc() { idempleado = cell.Value.ToString() });
                            isChecked = false;
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

        private void btn_undoNomina_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Realmente desea desaplicar la Nomina a los empleados Seleccionados?", "Desaplicación de Nomina", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            int resultado = 0;
            List<capa_presentacion_planillas.empleadoPerDedc> empleadoPerDedc = new List<capa_presentacion_planillas.empleadoPerDedc>();
            //Empleados
            bool isChecked = false;
            foreach (DataGridViewRow row in grid_empleados.Rows)
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
                            empleadoPerDedc.Add(new capa_presentacion_planillas.empleadoPerDedc() { idempleado = cell.Value.ToString() });
                            isChecked = false;
                        }
                    }
                }
            }

            if (empleadoPerDedc.Count > 0)
            {
                resultado = capa_negocio_planillas.undoEmpleadosNomina(empleadoPerDedc);
            }else
            {
                MessageBox.Show("Debe seleccionar al menos un Empleado");
            }

            if (resultado > 0)
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
