namespace WindowsFormsApplication1
{
    partial class frmplantillaplanillas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.list_deducciones = new System.Windows.Forms.CheckedListBox();
            this.grid_empleados = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.list_percepciones = new System.Windows.Forms.CheckedListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_findDept = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_findEmp = new System.Windows.Forms.Button();
            this.txt_sapellido = new System.Windows.Forms.TextBox();
            this.txt_papellido = new System.Windows.Forms.TextBox();
            this.txt_snombre = new System.Windows.Forms.TextBox();
            this.txt_pnombre = new System.Windows.Forms.TextBox();
            this.txt_idempleado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_findComp = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_help = new System.Windows.Forms.Button();
            this.btn_topRight = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_topLeft = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_applyNomina = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_empleados)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.list_deducciones);
            this.groupBox1.Location = new System.Drawing.Point(12, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 178);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deducciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Seleccione Deducciones  a Aplicar:";
            // 
            // list_deducciones
            // 
            this.list_deducciones.FormattingEnabled = true;
            this.list_deducciones.Location = new System.Drawing.Point(33, 45);
            this.list_deducciones.Name = "list_deducciones";
            this.list_deducciones.Size = new System.Drawing.Size(250, 109);
            this.list_deducciones.TabIndex = 16;
            // 
            // grid_empleados
            // 
            this.grid_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_empleados.Location = new System.Drawing.Point(12, 401);
            this.grid_empleados.Name = "grid_empleados";
            this.grid_empleados.Size = new System.Drawing.Size(682, 150);
            this.grid_empleados.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.list_percepciones);
            this.groupBox2.Location = new System.Drawing.Point(367, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 178);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Percepciones:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Seleccione Percepciones a Aplicar:";
            // 
            // list_percepciones
            // 
            this.list_percepciones.FormattingEnabled = true;
            this.list_percepciones.Location = new System.Drawing.Point(46, 45);
            this.list_percepciones.Name = "list_percepciones";
            this.list_percepciones.Size = new System.Drawing.Size(250, 109);
            this.list_percepciones.TabIndex = 16;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(8, 78);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(690, 133);
            this.tabControl1.TabIndex = 27;
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
            this.tabPage2.Controls.Add(this.btn_findEmp);
            this.tabPage2.Controls.Add(this.txt_sapellido);
            this.tabPage2.Controls.Add(this.txt_papellido);
            this.tabPage2.Controls.Add(this.txt_snombre);
            this.tabPage2.Controls.Add(this.txt_pnombre);
            this.tabPage2.Controls.Add(this.txt_idempleado);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(682, 107);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Empleado";
            // 
            // btn_findEmp
            // 
            this.btn_findEmp.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.buscar;
            this.btn_findEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_findEmp.Location = new System.Drawing.Point(635, 59);
            this.btn_findEmp.Name = "btn_findEmp";
            this.btn_findEmp.Size = new System.Drawing.Size(40, 40);
            this.btn_findEmp.TabIndex = 32;
            this.btn_findEmp.UseVisualStyleBackColor = true;
            this.btn_findEmp.Click += new System.EventHandler(this.btn_findEmp_Click);
            // 
            // txt_sapellido
            // 
            this.txt_sapellido.Location = new System.Drawing.Point(369, 79);
            this.txt_sapellido.Name = "txt_sapellido";
            this.txt_sapellido.Size = new System.Drawing.Size(121, 20);
            this.txt_sapellido.TabIndex = 9;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_update);
            this.groupBox3.Controls.Add(this.btn_help);
            this.groupBox3.Controls.Add(this.btn_topRight);
            this.groupBox3.Controls.Add(this.btn_right);
            this.groupBox3.Controls.Add(this.btn_left);
            this.groupBox3.Controls.Add(this.btn_topLeft);
            this.groupBox3.Controls.Add(this.btn_nuevo);
            this.groupBox3.Location = new System.Drawing.Point(8, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 68);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Menú";
            // 
            // btn_update
            // 
            this.btn_update.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.refresh;
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update.Location = new System.Drawing.Point(58, 14);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(40, 40);
            this.btn_update.TabIndex = 26;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_help
            // 
            this.btn_help.Image = global::WindowsFormsApplication1.Properties.Resources.help;
            this.btn_help.Location = new System.Drawing.Point(288, 14);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(40, 40);
            this.btn_help.TabIndex = 30;
            this.btn_help.UseVisualStyleBackColor = true;
            // 
            // btn_topRight
            // 
            this.btn_topRight.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.go_to_last;
            this.btn_topRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_topRight.Location = new System.Drawing.Point(242, 14);
            this.btn_topRight.Name = "btn_topRight";
            this.btn_topRight.Size = new System.Drawing.Size(40, 40);
            this.btn_topRight.TabIndex = 29;
            this.btn_topRight.UseVisualStyleBackColor = true;
            // 
            // btn_right
            // 
            this.btn_right.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.go_next;
            this.btn_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_right.Location = new System.Drawing.Point(196, 14);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(40, 40);
            this.btn_right.TabIndex = 28;
            this.btn_right.UseVisualStyleBackColor = true;
            // 
            // btn_left
            // 
            this.btn_left.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.anterior;
            this.btn_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_left.Location = new System.Drawing.Point(150, 14);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(40, 40);
            this.btn_left.TabIndex = 27;
            this.btn_left.UseVisualStyleBackColor = true;
            // 
            // btn_topLeft
            // 
            this.btn_topLeft.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.go_to_first;
            this.btn_topLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_topLeft.Location = new System.Drawing.Point(104, 14);
            this.btn_topLeft.Name = "btn_topLeft";
            this.btn_topLeft.Size = new System.Drawing.Size(40, 40);
            this.btn_topLeft.TabIndex = 26;
            this.btn_topLeft.UseVisualStyleBackColor = true;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.nuevo;
            this.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo.Location = new System.Drawing.Point(12, 14);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(40, 40);
            this.btn_nuevo.TabIndex = 24;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(491, 571);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "0 Empleados";
            // 
            // btn_applyNomina
            // 
            this.btn_applyNomina.BackColor = System.Drawing.SystemColors.Control;
            this.btn_applyNomina.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.refresh;
            this.btn_applyNomina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_applyNomina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_applyNomina.Location = new System.Drawing.Point(581, 557);
            this.btn_applyNomina.Name = "btn_applyNomina";
            this.btn_applyNomina.Size = new System.Drawing.Size(113, 40);
            this.btn_applyNomina.TabIndex = 32;
            this.btn_applyNomina.Text = "Aplicar Nomina";
            this.btn_applyNomina.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_applyNomina.UseVisualStyleBackColor = false;
            // 
            // frmplantillaplanillas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 605);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btn_applyNomina);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grid_empleados);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmplantillaplanillas";
            this.Text = "Percepciones y Deducciones";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_empleados)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grid_empleados;
        private System.Windows.Forms.CheckedListBox list_deducciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox list_percepciones;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Button btn_topRight;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_topLeft;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_findDept;
        private System.Windows.Forms.Button btn_findEmp;
        private System.Windows.Forms.TextBox txt_sapellido;
        private System.Windows.Forms.TextBox txt_papellido;
        private System.Windows.Forms.TextBox txt_snombre;
        private System.Windows.Forms.TextBox txt_pnombre;
        private System.Windows.Forms.TextBox txt_idempleado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_findComp;
        private System.Windows.Forms.Button btn_applyNomina;
        private System.Windows.Forms.Label label14;
    }
}