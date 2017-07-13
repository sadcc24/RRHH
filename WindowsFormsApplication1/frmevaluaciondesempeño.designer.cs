namespace WindowsFormsApplication1
{
    partial class evaluacion_desempeño
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.Departamento = new System.Windows.Forms.Label();
            this.txtfechaeva = new System.Windows.Forms.TextBox();
            this.cbdepartamento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbperiodo = new System.Windows.Forms.ComboBox();
            this.cbempleado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpfechainicio = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpfechafin = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txttotalevaluacion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txttotalmetrica = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtrrhh = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtsup = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtemp = new System.Windows.Forms.TextBox();
            this.cbmetrica = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnAyuda);
            this.panel1.Controls.Add(this.btnBorrar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Location = new System.Drawing.Point(274, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 57);
            this.panel1.TabIndex = 15;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.guardar;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(8, 0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(56, 51);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.help;
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAyuda.Location = new System.Drawing.Point(191, 3);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(56, 51);
            this.btnAyuda.TabIndex = 2;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.eliminar;
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrar.Location = new System.Drawing.Point(132, 3);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(56, 51);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.editar;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Location = new System.Drawing.Point(70, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(56, 51);
            this.btnModificar.TabIndex = 0;
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // Departamento
            // 
            this.Departamento.AutoSize = true;
            this.Departamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Departamento.Location = new System.Drawing.Point(5, 115);
            this.Departamento.Name = "Departamento";
            this.Departamento.Size = new System.Drawing.Size(112, 20);
            this.Departamento.TabIndex = 16;
            this.Departamento.Text = "Departamento";
            // 
            // txtfechaeva
            // 
            this.txtfechaeva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfechaeva.Location = new System.Drawing.Point(146, 206);
            this.txtfechaeva.Name = "txtfechaeva";
            this.txtfechaeva.Size = new System.Drawing.Size(214, 26);
            this.txtfechaeva.TabIndex = 17;
            // 
            // cbdepartamento
            // 
            this.cbdepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdepartamento.FormattingEnabled = true;
            this.cbdepartamento.Location = new System.Drawing.Point(146, 112);
            this.cbdepartamento.Name = "cbdepartamento";
            this.cbdepartamento.Size = new System.Drawing.Size(214, 28);
            this.cbdepartamento.TabIndex = 18;
            this.cbdepartamento.SelectedIndexChanged += new System.EventHandler(this.cbdepartamento_SelectedIndexChanged);
            this.cbdepartamento.DisplayMemberChanged += new System.EventHandler(this.cbdepartamento_DisplayMemberChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(386, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Fecha Inicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Fecha Evaluacion";
            // 
            // cbperiodo
            // 
            this.cbperiodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbperiodo.FormattingEnabled = true;
            this.cbperiodo.Location = new System.Drawing.Point(536, 112);
            this.cbperiodo.Name = "cbperiodo";
            this.cbperiodo.Size = new System.Drawing.Size(214, 28);
            this.cbperiodo.TabIndex = 24;
            // 
            // cbempleado
            // 
            this.cbempleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbempleado.FormattingEnabled = true;
            this.cbempleado.Location = new System.Drawing.Point(146, 154);
            this.cbempleado.Name = "cbempleado";
            this.cbempleado.Size = new System.Drawing.Size(214, 28);
            this.cbempleado.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(386, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Periodo Evaluacion";
            // 
            // dtpfechainicio
            // 
            this.dtpfechainicio.CustomFormat = "dd-MM-yyyy";
            this.dtpfechainicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfechainicio.Location = new System.Drawing.Point(536, 157);
            this.dtpfechainicio.Name = "dtpfechainicio";
            this.dtpfechainicio.Size = new System.Drawing.Size(215, 26);
            this.dtpfechainicio.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(386, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Fecha Fin";
            // 
            // dtpfechafin
            // 
            this.dtpfechafin.CustomFormat = "dd-MM-yyyy";
            this.dtpfechafin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfechafin.Location = new System.Drawing.Point(535, 206);
            this.dtpfechafin.Name = "dtpfechafin";
            this.dtpfechafin.Size = new System.Drawing.Size(215, 26);
            this.dtpfechafin.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.txttotalevaluacion);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txttotalmetrica);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtrrhh);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtsup);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtemp);
            this.groupBox1.Controls.Add(this.cbmetrica);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(5, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 329);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metricas";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(169, 278);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(251, 40);
            this.label12.TabIndex = 54;
            this.label12.Text = "*1-100 punteo ordinario\r\n100-200 punteo extraordinario\r\n";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Location = new System.Drawing.Point(430, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 57);
            this.panel2.TabIndex = 53;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.guardar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(8, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 51);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.help;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(128, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 51);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.editar;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(68, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 51);
            this.button4.TabIndex = 0;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txttotalevaluacion
            // 
            this.txttotalevaluacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalevaluacion.Location = new System.Drawing.Point(675, 286);
            this.txttotalevaluacion.Name = "txttotalevaluacion";
            this.txttotalevaluacion.Size = new System.Drawing.Size(71, 26);
            this.txttotalevaluacion.TabIndex = 52;
            this.txttotalevaluacion.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(544, 289);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 20);
            this.label11.TabIndex = 51;
            this.label11.Text = "Total Evaluacion";
            // 
            // txttotalmetrica
            // 
            this.txttotalmetrica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalmetrica.Location = new System.Drawing.Point(109, 286);
            this.txttotalmetrica.Name = "txttotalmetrica";
            this.txttotalmetrica.Size = new System.Drawing.Size(54, 26);
            this.txttotalmetrica.TabIndex = 50;
            this.txttotalmetrica.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 49;
            this.label10.Text = "Total Metrica";
            // 
            // txtrrhh
            // 
            this.txtrrhh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrrhh.Location = new System.Drawing.Point(547, 99);
            this.txtrrhh.Multiline = true;
            this.txtrrhh.Name = "txtrrhh";
            this.txtrrhh.Size = new System.Drawing.Size(248, 163);
            this.txtrrhh.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(543, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 20);
            this.label9.TabIndex = 47;
            this.label9.Text = "Comentario RRHH";
            // 
            // txtsup
            // 
            this.txtsup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsup.Location = new System.Drawing.Point(265, 99);
            this.txtsup.Multiline = true;
            this.txtsup.Name = "txtsup";
            this.txtsup.Size = new System.Drawing.Size(266, 163);
            this.txtsup.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(261, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "Comentario Supervisor";
            // 
            // txtemp
            // 
            this.txtemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemp.Location = new System.Drawing.Point(0, 99);
            this.txtemp.Multiline = true;
            this.txtemp.Name = "txtemp";
            this.txtemp.Size = new System.Drawing.Size(248, 163);
            this.txtemp.TabIndex = 44;
            // 
            // cbmetrica
            // 
            this.cbmetrica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmetrica.FormattingEnabled = true;
            this.cbmetrica.Location = new System.Drawing.Point(91, 30);
            this.cbmetrica.Name = "cbmetrica";
            this.cbmetrica.Size = new System.Drawing.Size(273, 28);
            this.cbmetrica.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-4, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Comentario Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Metrica ";
            // 
            // evaluacion_desempeño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 596);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpfechafin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpfechainicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbempleado);
            this.Controls.Add(this.cbperiodo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbdepartamento);
            this.Controls.Add(this.txtfechaeva);
            this.Controls.Add(this.Departamento);
            this.Controls.Add(this.panel1);
            this.Name = "evaluacion_desempeño";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "evaluacion_desempeño";
            this.Load += new System.EventHandler(this.evaluacion_desempeño_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label Departamento;
        private System.Windows.Forms.TextBox txtfechaeva;
        private System.Windows.Forms.ComboBox cbdepartamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbperiodo;
        private System.Windows.Forms.ComboBox cbempleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpfechainicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpfechafin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txttotalevaluacion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txttotalmetrica;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtrrhh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtsup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtemp;
        private System.Windows.Forms.ComboBox cbmetrica;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
    }
}