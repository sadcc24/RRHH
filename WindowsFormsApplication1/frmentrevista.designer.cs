namespace WindowsFormsApplication1
{
    partial class frmentrevista
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
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtpuesto = new System.Windows.Forms.TextBox();
            this.txtnombrecandidato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.txtidpuestodetrabajo = new System.Windows.Forms.TextBox();
            this.txtidcandidato = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTimehora = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimefecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.txtidempleado2 = new System.Windows.Forms.TextBox();
            this.txtetapaentrevista = new System.Windows.Forms.TextBox();
            this.txtidentrevista = new System.Windows.Forms.TextBox();
            this.txtestadocandidato = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Puesto de Trabajo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtpuesto);
            this.groupBox1.Controls.Add(this.txtnombrecandidato);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Location = new System.Drawing.Point(13, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 170);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            // 
            // txtpuesto
            // 
            this.txtpuesto.Enabled = false;
            this.txtpuesto.Location = new System.Drawing.Point(123, 124);
            this.txtpuesto.Name = "txtpuesto";
            this.txtpuesto.Size = new System.Drawing.Size(217, 20);
            this.txtpuesto.TabIndex = 50;
            // 
            // txtnombrecandidato
            // 
            this.txtnombrecandidato.Enabled = false;
            this.txtnombrecandidato.Location = new System.Drawing.Point(124, 89);
            this.txtnombrecandidato.Name = "txtnombrecandidato";
            this.txtnombrecandidato.Size = new System.Drawing.Size(217, 20);
            this.txtnombrecandidato.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Nombre de Candidato";
            // 
            // button8
            // 
            this.button8.Image = global::WindowsFormsApplication1.Properties.Resources.buscar;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(12, 19);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(136, 41);
            this.button8.TabIndex = 46;
            this.button8.Text = "Buscar Candidato";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // txtidpuestodetrabajo
            // 
            this.txtidpuestodetrabajo.Location = new System.Drawing.Point(297, 300);
            this.txtidpuestodetrabajo.Name = "txtidpuestodetrabajo";
            this.txtidpuestodetrabajo.Size = new System.Drawing.Size(19, 20);
            this.txtidpuestodetrabajo.TabIndex = 47;
            this.txtidpuestodetrabajo.Visible = false;
            this.txtidpuestodetrabajo.TextChanged += new System.EventHandler(this.txtidpuestodetrabajo_TextChanged);
            // 
            // txtidcandidato
            // 
            this.txtidcandidato.Location = new System.Drawing.Point(247, 300);
            this.txtidcandidato.Name = "txtidcandidato";
            this.txtidcandidato.Size = new System.Drawing.Size(19, 20);
            this.txtidcandidato.TabIndex = 46;
            this.txtidcandidato.Visible = false;
            this.txtidcandidato.TextChanged += new System.EventHandler(this.txtidcandidato_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 88);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menú";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dateTimehora);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.comboBox2);
            this.groupBox4.Controls.Add(this.dateTimefecha);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.comboBox9);
            this.groupBox4.Location = new System.Drawing.Point(12, 316);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(411, 157);
            this.groupBox4.TabIndex = 44;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos de Entrevista";
            // 
            // dateTimehora
            // 
            this.dateTimehora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimehora.Location = new System.Drawing.Point(123, 121);
            this.dateTimehora.Name = "dateTimehora";
            this.dateTimehora.Size = new System.Drawing.Size(78, 20);
            this.dateTimehora.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Entrevistador";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(123, 56);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(136, 21);
            this.comboBox2.TabIndex = 47;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // dateTimefecha
            // 
            this.dateTimefecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimefecha.Location = new System.Drawing.Point(123, 92);
            this.dateTimefecha.Name = "dateTimefecha";
            this.dateTimefecha.Size = new System.Drawing.Size(78, 20);
            this.dateTimefecha.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Fecha de Entrevista";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Hora de Entrevista";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Etapa Entrevista";
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(123, 25);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(136, 21);
            this.comboBox9.TabIndex = 36;
            this.comboBox9.SelectedIndexChanged += new System.EventHandler(this.comboBox9_SelectedIndexChanged);
            // 
            // txtidempleado2
            // 
            this.txtidempleado2.Location = new System.Drawing.Point(247, 479);
            this.txtidempleado2.Name = "txtidempleado2";
            this.txtidempleado2.Size = new System.Drawing.Size(19, 20);
            this.txtidempleado2.TabIndex = 49;
            this.txtidempleado2.Visible = false;
            // 
            // txtetapaentrevista
            // 
            this.txtetapaentrevista.Location = new System.Drawing.Point(209, 479);
            this.txtetapaentrevista.Name = "txtetapaentrevista";
            this.txtetapaentrevista.Size = new System.Drawing.Size(19, 20);
            this.txtetapaentrevista.TabIndex = 48;
            this.txtetapaentrevista.Visible = false;
            this.txtetapaentrevista.TextChanged += new System.EventHandler(this.txtetapaentrevista_TextChanged);
            // 
            // txtidentrevista
            // 
            this.txtidentrevista.Location = new System.Drawing.Point(135, 105);
            this.txtidentrevista.Name = "txtidentrevista";
            this.txtidentrevista.Size = new System.Drawing.Size(40, 20);
            this.txtidentrevista.TabIndex = 48;
            this.txtidentrevista.Visible = false;
            // 
            // txtestadocandidato
            // 
            this.txtestadocandidato.Location = new System.Drawing.Point(272, 300);
            this.txtestadocandidato.Name = "txtestadocandidato";
            this.txtestadocandidato.Size = new System.Drawing.Size(19, 20);
            this.txtestadocandidato.TabIndex = 50;
            this.txtestadocandidato.Visible = false;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.cancelar;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(247, 38);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 44;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.refresh;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Location = new System.Drawing.Point(303, 38);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 50);
            this.button6.TabIndex = 43;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.help;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Location = new System.Drawing.Point(359, 38);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 50);
            this.button7.TabIndex = 42;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.eliminar;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(135, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 41;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Image = global::WindowsFormsApplication1.Properties.Resources.nuevo;
            this.button1.Location = new System.Drawing.Point(23, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 38;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.guardar;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(191, 38);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 40;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.editar;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(79, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 39;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmentrevista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 500);
            this.Controls.Add(this.txtestadocandidato);
            this.Controls.Add(this.txtidpuestodetrabajo);
            this.Controls.Add(this.txtidempleado2);
            this.Controls.Add(this.txtidentrevista);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtetapaentrevista);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtidcandidato);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmentrevista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrevista";
            this.Load += new System.EventHandler(this.PrimeraEtapa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox9;
        public System.Windows.Forms.DateTimePicker dateTimefecha;
        public System.Windows.Forms.TextBox txtidpuestodetrabajo;
        public System.Windows.Forms.TextBox txtidcandidato;
        public System.Windows.Forms.TextBox txtidempleado2;
        public System.Windows.Forms.DateTimePicker dateTimehora;
        public System.Windows.Forms.TextBox txtetapaentrevista;
        public System.Windows.Forms.TextBox txtidentrevista;
        public System.Windows.Forms.TextBox txtnombrecandidato;
        public System.Windows.Forms.TextBox txtestadocandidato;
        public System.Windows.Forms.TextBox txtpuesto;
    }
}