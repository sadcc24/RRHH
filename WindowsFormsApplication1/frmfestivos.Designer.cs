﻿namespace WindowsFormsApplication1
{
    partial class frmfestivos
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
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbperiodo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreempleado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnretorno = new System.Windows.Forms.Button();
            this.btnayuda = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpfecha
            // 
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfecha.Location = new System.Drawing.Point(333, 271);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(100, 20);
            this.dtpfecha.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(236, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 34;
            this.label4.Text = "Fecha";
            // 
            // cmbperiodo
            // 
            this.cmbperiodo.FormattingEnabled = true;
            this.cmbperiodo.Location = new System.Drawing.Point(333, 299);
            this.cmbperiodo.Name = "cmbperiodo";
            this.cmbperiodo.Size = new System.Drawing.Size(100, 21);
            this.cmbperiodo.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "Empleado";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(333, 245);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(276, 20);
            this.txtdescripcion.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Periodo";
            // 
            // nombreempleado
            // 
            this.nombreempleado.AutoSize = true;
            this.nombreempleado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreempleado.Location = new System.Drawing.Point(236, 246);
            this.nombreempleado.Name = "nombreempleado";
            this.nombreempleado.Size = new System.Drawing.Size(81, 19);
            this.nombreempleado.TabIndex = 28;
            this.nombreempleado.Text = "Dia Festivo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnretorno);
            this.groupBox1.Controls.Add(this.btnayuda);
            this.groupBox1.Controls.Add(this.btncancelar);
            this.groupBox1.Controls.Add(this.btneliminar);
            this.groupBox1.Controls.Add(this.btnmodificar);
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Controls.Add(this.btnnuevo);
            this.groupBox1.Location = new System.Drawing.Point(124, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 99);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Image = global::WindowsFormsApplication1.Properties.Resources.buscar;
            this.button1.Location = new System.Drawing.Point(239, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnretorno
            // 
            this.btnretorno.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.menu_principal;
            this.btnretorno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnretorno.Location = new System.Drawing.Point(463, 27);
            this.btnretorno.Name = "btnretorno";
            this.btnretorno.Size = new System.Drawing.Size(50, 50);
            this.btnretorno.TabIndex = 7;
            this.btnretorno.UseVisualStyleBackColor = true;
            this.btnretorno.Click += new System.EventHandler(this.btnretorno_Click);
            // 
            // btnayuda
            // 
            this.btnayuda.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.help;
            this.btnayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnayuda.Location = new System.Drawing.Point(407, 27);
            this.btnayuda.Name = "btnayuda";
            this.btnayuda.Size = new System.Drawing.Size(50, 50);
            this.btnayuda.TabIndex = 6;
            this.btnayuda.UseVisualStyleBackColor = true;
            this.btnayuda.Click += new System.EventHandler(this.btnayuda_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.cancelar;
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.Location = new System.Drawing.Point(295, 27);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(50, 50);
            this.btncancelar.TabIndex = 4;
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.eliminar;
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneliminar.Location = new System.Drawing.Point(183, 27);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(50, 50);
            this.btneliminar.TabIndex = 3;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.editar;
            this.btnmodificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmodificar.Location = new System.Drawing.Point(127, 27);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(50, 50);
            this.btnmodificar.TabIndex = 2;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.guardar;
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguardar.Location = new System.Drawing.Point(71, 27);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(50, 50);
            this.btnguardar.TabIndex = 1;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.nuevo;
            this.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnuevo.Location = new System.Drawing.Point(15, 27);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(50, 50);
            this.btnnuevo.TabIndex = 0;
            this.btnnuevo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(236, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 32;
            this.label3.Text = "Empresa";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(333, 218);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 36;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(333, 191);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 37;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // frmfestivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 374);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbperiodo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombreempleado);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmfestivos";
            this.Text = "Dias Festivos";
            this.Load += new System.EventHandler(this.frmfestivos_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbperiodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nombreempleado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnretorno;
        private System.Windows.Forms.Button btnayuda;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}