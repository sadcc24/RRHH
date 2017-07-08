namespace WindowsFormsApplication1
{
    partial class asignacion_capacitaciones
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
            this.cbmetodo_asignacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_depto_emp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fecha_inicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.fecha_fin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.horario_ = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbcapacitaciones = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbmetodo_asignacion
            // 
            this.cbmetodo_asignacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbmetodo_asignacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbmetodo_asignacion.FormattingEnabled = true;
            this.cbmetodo_asignacion.Items.AddRange(new object[] {
            "Seleccionar",
            "Empleado",
            "Departamento"});
            this.cbmetodo_asignacion.Location = new System.Drawing.Point(243, 135);
            this.cbmetodo_asignacion.Margin = new System.Windows.Forms.Padding(4);
            this.cbmetodo_asignacion.Name = "cbmetodo_asignacion";
            this.cbmetodo_asignacion.Size = new System.Drawing.Size(282, 27);
            this.cbmetodo_asignacion.TabIndex = 0;
            this.cbmetodo_asignacion.SelectedIndexChanged += new System.EventHandler(this.cbmetodo_asignacion_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Metodo Asignacion";
            // 
            // cb_depto_emp
            // 
            this.cb_depto_emp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb_depto_emp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_depto_emp.FormattingEnabled = true;
            this.cb_depto_emp.Location = new System.Drawing.Point(243, 189);
            this.cb_depto_emp.Margin = new System.Windows.Forms.Padding(4);
            this.cb_depto_emp.Name = "cb_depto_emp";
            this.cb_depto_emp.Size = new System.Drawing.Size(282, 27);
            this.cb_depto_emp.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Departamento/empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 263);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Inicio";
            // 
            // fecha_inicio
            // 
            this.fecha_inicio.Location = new System.Drawing.Point(243, 263);
            this.fecha_inicio.Name = "fecha_inicio";
            this.fecha_inicio.Size = new System.Drawing.Size(282, 27);
            this.fecha_inicio.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 319);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha Fin";
            // 
            // fecha_fin
            // 
            this.fecha_fin.Location = new System.Drawing.Point(243, 313);
            this.fecha_fin.Name = "fecha_fin";
            this.fecha_fin.Size = new System.Drawing.Size(282, 27);
            this.fecha_fin.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 375);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Horario";
            // 
            // horario_
            // 
            this.horario_.Location = new System.Drawing.Point(243, 375);
            this.horario_.Name = "horario_";
            this.horario_.Size = new System.Drawing.Size(282, 27);
            this.horario_.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAyuda);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Location = new System.Drawing.Point(193, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 57);
            this.panel1.TabIndex = 10;
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.help;
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAyuda.Location = new System.Drawing.Point(123, 3);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(56, 51);
            this.btnAyuda.TabIndex = 2;
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Location = new System.Drawing.Point(65, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(56, 51);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.guardar;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(3, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(56, 51);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Capacitacion";
            // 
            // cbcapacitaciones
            // 
            this.cbcapacitaciones.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbcapacitaciones.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbcapacitaciones.FormattingEnabled = true;
            this.cbcapacitaciones.Items.AddRange(new object[] {
            "Seleccionar",
            "Empleado",
            "Departamento"});
            this.cbcapacitaciones.Location = new System.Drawing.Point(243, 89);
            this.cbcapacitaciones.Margin = new System.Windows.Forms.Padding(4);
            this.cbcapacitaciones.Name = "cbcapacitaciones";
            this.cbcapacitaciones.Size = new System.Drawing.Size(282, 27);
            this.cbcapacitaciones.TabIndex = 12;
            // 
            // asignacion_capacitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 450);
            this.Controls.Add(this.cbcapacitaciones);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.horario_);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fecha_fin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fecha_inicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_depto_emp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbmetodo_asignacion);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "asignacion_capacitaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "asignacion_capacitaciones";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbmetodo_asignacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_depto_emp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fecha_inicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker fecha_fin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox horario_;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbcapacitaciones;
    }
}