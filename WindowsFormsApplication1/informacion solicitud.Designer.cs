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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dfechainicio = new System.Windows.Forms.DateTimePicker();
            this.dfechafin = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnrechazar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.combosolicitud = new System.Windows.Forms.ComboBox();
            this.Motivo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Empleado";
            // 
            // txttd
            // 
            this.txttd.Enabled = false;
            this.txttd.Location = new System.Drawing.Point(353, 76);
            this.txttd.Name = "txttd";
            this.txttd.Size = new System.Drawing.Size(100, 20);
            this.txttd.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F);
            this.label7.Location = new System.Drawing.Point(209, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Total de dias";
            // 
            // txtdiast
            // 
            this.txtdiast.Enabled = false;
            this.txtdiast.Location = new System.Drawing.Point(353, 43);
            this.txtdiast.Name = "txtdiast";
            this.txtdiast.Size = new System.Drawing.Size(100, 20);
            this.txtdiast.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F);
            this.label6.Location = new System.Drawing.Point(209, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Dias Tomados";
            // 
            // txtdiasl
            // 
            this.txtdiasl.Enabled = false;
            this.txtdiasl.Location = new System.Drawing.Point(353, 16);
            this.txtdiasl.Name = "txtdiasl";
            this.txtdiasl.Size = new System.Drawing.Size(100, 20);
            this.txtdiasl.TabIndex = 8;
            this.txtdiasl.TextChanged += new System.EventHandler(this.txtdiasl_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F);
            this.label5.Location = new System.Drawing.Point(209, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Dias Libres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F);
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F);
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F);
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dfechainicio);
            this.groupBox2.Controls.Add(this.dfechafin);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnrechazar);
            this.groupBox2.Controls.Add(this.btnaceptar);
            this.groupBox2.Controls.Add(this.combosolicitud);
            this.groupBox2.Controls.Add(this.Motivo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(28, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 160);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Solicitud";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dfechainicio
            // 
            this.dfechainicio.Enabled = false;
            this.dfechainicio.Font = new System.Drawing.Font("Calibri", 12F);
            this.dfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dfechainicio.Location = new System.Drawing.Point(98, 28);
            this.dfechainicio.Name = "dfechainicio";
            this.dfechainicio.Size = new System.Drawing.Size(159, 27);
            this.dfechainicio.TabIndex = 29;
            this.dfechainicio.TabStop = false;
            // 
            // dfechafin
            // 
            this.dfechafin.Enabled = false;
            this.dfechafin.Font = new System.Drawing.Font("Calibri", 12F);
            this.dfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dfechafin.Location = new System.Drawing.Point(98, 60);
            this.dfechafin.Name = "dfechafin";
            this.dfechafin.Size = new System.Drawing.Size(159, 27);
            this.dfechafin.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F);
            this.label8.Location = new System.Drawing.Point(124, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "-";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F);
            this.label4.Location = new System.Drawing.Point(6, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Dias Solicitados";
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
            // combosolicitud
            // 
            this.combosolicitud.Enabled = false;
            this.combosolicitud.Font = new System.Drawing.Font("Calibri", 12F);
            this.combosolicitud.FormattingEnabled = true;
            this.combosolicitud.Location = new System.Drawing.Point(98, 92);
            this.combosolicitud.Name = "combosolicitud";
            this.combosolicitud.Size = new System.Drawing.Size(159, 27);
            this.combosolicitud.TabIndex = 18;
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F);
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(504, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 19);
            this.label11.TabIndex = 15;
            this.label11.Text = "-";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F);
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(674, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 19);
            this.label12.TabIndex = 16;
            this.label12.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F);
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(504, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 19);
            this.label13.TabIndex = 17;
            this.label13.Text = "-";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(351, 92);
            this.dataGridView1.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 28);
            this.button1.TabIndex = 19;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(385, 176);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(144, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Mostrar personas aprovadas ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(385, 192);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "en ese rango de fechas ";
            // 
            // informacion_solicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(530, 428);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "informacion_solicitud";
            this.Text = "Información de solicitud";
            this.Load += new System.EventHandler(this.informacion_solicitud_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdiast;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdiasl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Motivo;
        private System.Windows.Forms.Button btnrechazar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.ComboBox combosolicitud;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dfechainicio;
        private System.Windows.Forms.DateTimePicker dfechafin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}