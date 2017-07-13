namespace WindowsFormsApplication1
{
    partial class frmplanilla
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbx_periodo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_empleados = new System.Windows.Forms.DataGridView();
            this.chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdelantefin = new System.Windows.Forms.Button();
            this.btnAtrasfin = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnAdelante = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btn_applyNomina = new System.Windows.Forms.Button();
            this.btn_findEmp = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_findDept = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_sapellido = new System.Windows.Forms.TextBox();
            this.btn_findByEmp = new System.Windows.Forms.Button();
            this.txt_papellido = new System.Windows.Forms.TextBox();
            this.txt_snombre = new System.Windows.Forms.TextBox();
            this.txt_pnombre = new System.Windows.Forms.TextBox();
            this.txt_idempleado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_findComp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_totalPlanilla = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_empleados)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_periodo
            // 
            this.cbx_periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_periodo.FormattingEnabled = true;
            this.cbx_periodo.Items.AddRange(new object[] {
            "junio 2017"});
            this.cbx_periodo.Location = new System.Drawing.Point(577, 12);
            this.cbx_periodo.Name = "cbx_periodo";
            this.cbx_periodo.Size = new System.Drawing.Size(121, 21);
            this.cbx_periodo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Periodo de Pago:";
            // 
            // grid_empleados
            // 
            this.grid_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_empleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk,
            this.total});
            this.grid_empleados.Location = new System.Drawing.Point(12, 221);
            this.grid_empleados.Name = "grid_empleados";
            this.grid_empleados.Size = new System.Drawing.Size(690, 199);
            this.grid_empleados.TabIndex = 4;
            // 
            // chk
            // 
            this.chk.HeaderText = "Check";
            this.chk.Name = "chk";
            this.chk.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chk.Width = 50;
            // 
            // total
            // 
            this.total.HeaderText = "Total Devengado";
            this.total.Name = "total";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdelantefin);
            this.groupBox2.Controls.Add(this.btnAtrasfin);
            this.groupBox2.Controls.Add(this.btnAtras);
            this.groupBox2.Controls.Add(this.btnAdelante);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 61);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menú";
            // 
            // btnAdelantefin
            // 
            this.btnAdelantefin.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.go_to_last;
            this.btnAdelantefin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdelantefin.Location = new System.Drawing.Point(126, 19);
            this.btnAdelantefin.Name = "btnAdelantefin";
            this.btnAdelantefin.Size = new System.Drawing.Size(41, 34);
            this.btnAdelantefin.TabIndex = 34;
            this.btnAdelantefin.UseVisualStyleBackColor = true;
            this.btnAdelantefin.Click += new System.EventHandler(this.btnAdelantefin_Click);
            // 
            // btnAtrasfin
            // 
            this.btnAtrasfin.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.go_to_first;
            this.btnAtrasfin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAtrasfin.Location = new System.Drawing.Point(6, 19);
            this.btnAtrasfin.Name = "btnAtrasfin";
            this.btnAtrasfin.Size = new System.Drawing.Size(41, 34);
            this.btnAtrasfin.TabIndex = 31;
            this.btnAtrasfin.UseVisualStyleBackColor = true;
            // 
            // btnAtras
            // 
            this.btnAtras.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.anterior;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtras.Location = new System.Drawing.Point(46, 19);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(41, 34);
            this.btnAtras.TabIndex = 32;
            this.btnAtras.UseVisualStyleBackColor = true;
            // 
            // btnAdelante
            // 
            this.btnAdelante.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.go_next;
            this.btnAdelante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdelante.Location = new System.Drawing.Point(86, 19);
            this.btnAdelante.Name = "btnAdelante";
            this.btnAdelante.Size = new System.Drawing.Size(41, 34);
            this.btnAdelante.TabIndex = 33;
            this.btnAdelante.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Image = global::WindowsFormsApplication1.Properties.Resources.help;
            this.button9.Location = new System.Drawing.Point(166, 19);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(40, 34);
            this.button9.TabIndex = 30;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btn_applyNomina
            // 
            this.btn_applyNomina.BackColor = System.Drawing.SystemColors.Control;
            this.btn_applyNomina.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.refresh;
            this.btn_applyNomina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_applyNomina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_applyNomina.Location = new System.Drawing.Point(616, 426);
            this.btn_applyNomina.Name = "btn_applyNomina";
            this.btn_applyNomina.Size = new System.Drawing.Size(86, 40);
            this.btn_applyNomina.TabIndex = 33;
            this.btn_applyNomina.Text = "Generar";
            this.btn_applyNomina.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_applyNomina.UseVisualStyleBackColor = false;
            this.btn_applyNomina.Click += new System.EventHandler(this.btn_applyNomina_Click);
            // 
            // btn_findEmp
            // 
            this.btn_findEmp.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.buscar;
            this.btn_findEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_findEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_findEmp.Location = new System.Drawing.Point(520, 59);
            this.btn_findEmp.Name = "btn_findEmp";
            this.btn_findEmp.Size = new System.Drawing.Size(178, 39);
            this.btn_findEmp.TabIndex = 35;
            this.btn_findEmp.Text = "Mostrar todos los Empleados";
            this.btn_findEmp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_findEmp.UseVisualStyleBackColor = true;
            this.btn_findEmp.Click += new System.EventHandler(this.btn_findEmp_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(690, 133);
            this.tabControl1.TabIndex = 34;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage1.Controls.Add(this.btn_findDept);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.comboBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(682, 107);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Departamento";
            // 
            // btn_findDept
            // 
            this.btn_findDept.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.buscar;
            this.btn_findDept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_findDept.Location = new System.Drawing.Point(635, 61);
            this.btn_findDept.Name = "btn_findDept";
            this.btn_findDept.Size = new System.Drawing.Size(40, 40);
            this.btn_findDept.TabIndex = 31;
            this.btn_findDept.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(235, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Departamentos:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(339, 45);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage2.Controls.Add(this.txt_sapellido);
            this.tabPage2.Controls.Add(this.btn_findByEmp);
            this.tabPage2.Controls.Add(this.txt_papellido);
            this.tabPage2.Controls.Add(this.txt_snombre);
            this.tabPage2.Controls.Add(this.txt_pnombre);
            this.tabPage2.Controls.Add(this.txt_idempleado);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(682, 107);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Empleado";
            // 
            // txt_sapellido
            // 
            this.txt_sapellido.Location = new System.Drawing.Point(369, 79);
            this.txt_sapellido.Name = "txt_sapellido";
            this.txt_sapellido.Size = new System.Drawing.Size(121, 20);
            this.txt_sapellido.TabIndex = 9;
            // 
            // btn_findByEmp
            // 
            this.btn_findByEmp.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.buscar;
            this.btn_findByEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_findByEmp.Location = new System.Drawing.Point(635, 61);
            this.btn_findByEmp.Name = "btn_findByEmp";
            this.btn_findByEmp.Size = new System.Drawing.Size(40, 40);
            this.btn_findByEmp.TabIndex = 33;
            this.btn_findByEmp.UseVisualStyleBackColor = true;
            // 
            // txt_papellido
            // 
            this.txt_papellido.Location = new System.Drawing.Point(369, 52);
            this.txt_papellido.Name = "txt_papellido";
            this.txt_papellido.Size = new System.Drawing.Size(121, 20);
            this.txt_papellido.TabIndex = 8;
            // 
            // txt_snombre
            // 
            this.txt_snombre.Location = new System.Drawing.Point(112, 79);
            this.txt_snombre.Name = "txt_snombre";
            this.txt_snombre.Size = new System.Drawing.Size(121, 20);
            this.txt_snombre.TabIndex = 7;
            // 
            // txt_pnombre
            // 
            this.txt_pnombre.Location = new System.Drawing.Point(112, 52);
            this.txt_pnombre.Name = "txt_pnombre";
            this.txt_pnombre.Size = new System.Drawing.Size(121, 20);
            this.txt_pnombre.TabIndex = 6;
            // 
            // txt_idempleado
            // 
            this.txt_idempleado.Location = new System.Drawing.Point(112, 12);
            this.txt_idempleado.Name = "txt_idempleado";
            this.txt_idempleado.Size = new System.Drawing.Size(121, 20);
            this.txt_idempleado.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(267, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Segundo Apellido:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(267, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Primer Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Segundo Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Primer Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Codigo:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.btn_findComp);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(682, 107);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Empresas";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(275, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 21);
            this.comboBox1.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(205, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Empresas:";
            // 
            // btn_findComp
            // 
            this.btn_findComp.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.buscar;
            this.btn_findComp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_findComp.Location = new System.Drawing.Point(635, 61);
            this.btn_findComp.Name = "btn_findComp";
            this.btn_findComp.Size = new System.Drawing.Size(40, 40);
            this.btn_findComp.TabIndex = 32;
            this.btn_findComp.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(352, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 18);
            this.label5.TabIndex = 36;
            this.label5.Text = "Total de Planilla:";
            // 
            // txt_totalPlanilla
            // 
            this.txt_totalPlanilla.AutoSize = true;
            this.txt_totalPlanilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalPlanilla.Location = new System.Drawing.Point(473, 436);
            this.txt_totalPlanilla.Name = "txt_totalPlanilla";
            this.txt_totalPlanilla.Size = new System.Drawing.Size(44, 18);
            this.txt_totalPlanilla.TabIndex = 37;
            this.txt_totalPlanilla.Text = "00.00";
            // 
            // frmplanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 471);
            this.Controls.Add(this.txt_totalPlanilla);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_findEmp);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_applyNomina);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grid_empleados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_periodo);
            this.Name = "frmplanilla";
            this.Text = "Planillas y Polizas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_empleados)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_periodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_empleados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btn_applyNomina;
        private System.Windows.Forms.Button btn_findEmp;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_findDept;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_sapellido;
        private System.Windows.Forms.Button btn_findByEmp;
        private System.Windows.Forms.TextBox txt_papellido;
        private System.Windows.Forms.TextBox txt_snombre;
        private System.Windows.Forms.TextBox txt_pnombre;
        private System.Windows.Forms.TextBox txt_idempleado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_findComp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txt_totalPlanilla;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Button btnAdelantefin;
        private System.Windows.Forms.Button btnAtrasfin;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnAdelante;
    }
}

