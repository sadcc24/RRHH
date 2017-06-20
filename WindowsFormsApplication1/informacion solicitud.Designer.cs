namespace WindowsFormsApplication1
{
    partial class informacion_solicitud
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
            this.txttd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdiast = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdiasl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtperiodo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsolicitudes = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnrechazar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.combomotivo = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.fechainicio = new System.Windows.Forms.DateTimePicker();
            this.Motivo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtdiast);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtdiasl);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtperiodo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Empleado";
            // 
            // txttd
            // 
            this.txttd.Enabled = false;
            this.txttd.Location = new System.Drawing.Point(353, 120);
            this.txttd.Name = "txttd";
            this.txttd.Size = new System.Drawing.Size(100, 20);
            this.txttd.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F);
            this.label7.Location = new System.Drawing.Point(209, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Total de dias";
            // 
            // txtdiast
            // 
            this.txtdiast.Enabled = false;
            this.txtdiast.Location = new System.Drawing.Point(353, 87);
            this.txtdiast.Name = "txtdiast";
            this.txtdiast.Size = new System.Drawing.Size(100, 20);
            this.txtdiast.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F);
            this.label6.Location = new System.Drawing.Point(209, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Dias Tomados";
            // 
            // txtdiasl
            // 
            this.txtdiasl.Enabled = false;
            this.txtdiasl.Location = new System.Drawing.Point(353, 60);
            this.txtdiasl.Name = "txtdiasl";
            this.txtdiasl.Size = new System.Drawing.Size(100, 20);
            this.txtdiasl.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F);
            this.label5.Location = new System.Drawing.Point(209, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Dias Libres";
            // 
            // txtperiodo
            // 
            this.txtperiodo.Enabled = false;
            this.txtperiodo.Location = new System.Drawing.Point(353, 32);
            this.txtperiodo.Name = "txtperiodo";
            this.txtperiodo.Size = new System.Drawing.Size(100, 20);
            this.txtperiodo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F);
            this.label4.Location = new System.Drawing.Point(209, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Periodo vacaciones ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F);
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F);
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Puesto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F);
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre Empleado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F);
            this.label8.Location = new System.Drawing.Point(24, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(240, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Solicitudes Aprovadas en el Periodo";
            // 
            // txtsolicitudes
            // 
            this.txtsolicitudes.Enabled = false;
            this.txtsolicitudes.Location = new System.Drawing.Point(275, 188);
            this.txtsolicitudes.Name = "txtsolicitudes";
            this.txtsolicitudes.Size = new System.Drawing.Size(107, 20);
            this.txtsolicitudes.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnrechazar);
            this.groupBox2.Controls.Add(this.btnaceptar);
            this.groupBox2.Controls.Add(this.combomotivo);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.fechainicio);
            this.groupBox2.Controls.Add(this.Motivo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(28, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 150);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Solicitud";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnrechazar
            // 
            this.btnrechazar.Location = new System.Drawing.Point(353, 75);
            this.btnrechazar.Name = "btnrechazar";
            this.btnrechazar.Size = new System.Drawing.Size(110, 50);
            this.btnrechazar.TabIndex = 20;
            this.btnrechazar.Text = "Rechazar";
            this.btnrechazar.UseVisualStyleBackColor = true;
            this.btnrechazar.Click += new System.EventHandler(this.btnrechazar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(353, 19);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(110, 50);
            this.btnaceptar.TabIndex = 19;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // combomotivo
            // 
            this.combomotivo.Enabled = false;
            this.combomotivo.Font = new System.Drawing.Font("Calibri", 12F);
            this.combomotivo.FormattingEnabled = true;
            this.combomotivo.Location = new System.Drawing.Point(98, 92);
            this.combomotivo.Name = "combomotivo";
            this.combomotivo.Size = new System.Drawing.Size(200, 27);
            this.combomotivo.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(98, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // fechainicio
            // 
            this.fechainicio.Enabled = false;
            this.fechainicio.Font = new System.Drawing.Font("Calibri", 12F);
            this.fechainicio.Location = new System.Drawing.Point(98, 26);
            this.fechainicio.Name = "fechainicio";
            this.fechainicio.Size = new System.Drawing.Size(200, 27);
            this.fechainicio.TabIndex = 16;
            // 
            // Motivo
            // 
            this.Motivo.AutoSize = true;
            this.Motivo.Font = new System.Drawing.Font("Calibri", 12F);
            this.Motivo.Location = new System.Drawing.Point(6, 95);
            this.Motivo.Name = "Motivo";
            this.Motivo.Size = new System.Drawing.Size(54, 19);
            this.Motivo.TabIndex = 15;
            this.Motivo.Text = "Motivo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F);
            this.label10.Location = new System.Drawing.Point(6, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 19);
            this.label10.TabIndex = 14;
            this.label10.Text = "Fecha Fin";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F);
            this.label9.Location = new System.Drawing.Point(6, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "Fecha Inicio";
            // 
            // informacion_solicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 428);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtsolicitudes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Name = "informacion_solicitud";
            this.Text = "Información de solicitud";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtperiodo;
        private System.Windows.Forms.TextBox txttd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdiast;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdiasl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtsolicitudes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Motivo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker fechainicio;
        private System.Windows.Forms.Button btnrechazar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.ComboBox combomotivo;
    }
}