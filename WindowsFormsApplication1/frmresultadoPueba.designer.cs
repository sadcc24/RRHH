namespace WindowsFormsApplication1
{
    partial class Resultado_Pueba
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
            this.txtiddetalle = new System.Windows.Forms.TextBox();
            this.txtidentrevista = new System.Windows.Forms.TextBox();
            this.txtetapaentrevista = new System.Windows.Forms.TextBox();
            this.txtidcandidato = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtnombrecandidato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtresultadoT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtresultado1 = new System.Windows.Forms.TextBox();
            this.lblresultado1 = new System.Windows.Forms.Label();
            this.txtresultado2 = new System.Windows.Forms.TextBox();
            this.lblresultado2 = new System.Windows.Forms.Label();
            this.txtresultado3 = new System.Windows.Forms.TextBox();
            this.lblresultado3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtcomentario = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtiddetalle);
            this.groupBox1.Controls.Add(this.txtidentrevista);
            this.groupBox1.Controls.Add(this.txtetapaentrevista);
            this.groupBox1.Controls.Add(this.txtidcandidato);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.txtnombrecandidato);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 179);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrevista";
            // 
            // txtiddetalle
            // 
            this.txtiddetalle.Location = new System.Drawing.Point(279, 127);
            this.txtiddetalle.Name = "txtiddetalle";
            this.txtiddetalle.Size = new System.Drawing.Size(22, 20);
            this.txtiddetalle.TabIndex = 70;
            this.txtiddetalle.Visible = false;
            // 
            // txtidentrevista
            // 
            this.txtidentrevista.Location = new System.Drawing.Point(279, 153);
            this.txtidentrevista.Name = "txtidentrevista";
            this.txtidentrevista.Size = new System.Drawing.Size(22, 20);
            this.txtidentrevista.TabIndex = 69;
            this.txtidentrevista.Visible = false;
            // 
            // txtetapaentrevista
            // 
            this.txtetapaentrevista.Location = new System.Drawing.Point(234, 136);
            this.txtetapaentrevista.Name = "txtetapaentrevista";
            this.txtetapaentrevista.Size = new System.Drawing.Size(22, 20);
            this.txtetapaentrevista.TabIndex = 68;
            this.txtetapaentrevista.Visible = false;
            this.txtetapaentrevista.TextChanged += new System.EventHandler(this.txtetapaentrevista_TextChanged);
            // 
            // txtidcandidato
            // 
            this.txtidcandidato.Location = new System.Drawing.Point(235, 93);
            this.txtidcandidato.Name = "txtidcandidato";
            this.txtidcandidato.Size = new System.Drawing.Size(22, 20);
            this.txtidcandidato.TabIndex = 67;
            this.txtidcandidato.Visible = false;
            this.txtidcandidato.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(115, 136);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(114, 20);
            this.textBox6.TabIndex = 66;
            // 
            // txtnombrecandidato
            // 
            this.txtnombrecandidato.Enabled = false;
            this.txtnombrecandidato.Location = new System.Drawing.Point(93, 93);
            this.txtnombrecandidato.Name = "txtnombrecandidato";
            this.txtnombrecandidato.Size = new System.Drawing.Size(135, 20);
            this.txtnombrecandidato.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Candidato";
            // 
            // button8
            // 
            this.button8.Image = global::WindowsFormsApplication1.Properties.Resources.buscar;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(11, 22);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(87, 50);
            this.button8.TabIndex = 46;
            this.button8.Text = "Buscar";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Etapa de Entrevista";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Location = new System.Drawing.Point(44, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 88);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menú";
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.guardar;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(123, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 48;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.cancelar;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(179, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 53;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.refresh;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Location = new System.Drawing.Point(235, 22);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 50);
            this.button6.TabIndex = 51;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.help;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Location = new System.Drawing.Point(291, 22);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 50);
            this.button7.TabIndex = 50;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Nota Total";
            // 
            // txtresultadoT
            // 
            this.txtresultadoT.Enabled = false;
            this.txtresultadoT.Location = new System.Drawing.Point(96, 405);
            this.txtresultadoT.Name = "txtresultadoT";
            this.txtresultadoT.Size = new System.Drawing.Size(44, 20);
            this.txtresultadoT.TabIndex = 55;
            this.txtresultadoT.TextChanged += new System.EventHandler(this.txtresultadoT_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Resultado";
            // 
            // txtresultado1
            // 
            this.txtresultado1.Location = new System.Drawing.Point(190, 309);
            this.txtresultado1.MaxLength = 3;
            this.txtresultado1.Name = "txtresultado1";
            this.txtresultado1.Size = new System.Drawing.Size(50, 20);
            this.txtresultado1.TabIndex = 58;
            this.txtresultado1.TextChanged += new System.EventHandler(this.txtresultado1_TextChanged);
            this.txtresultado1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtresultado1_KeyPress);
            // 
            // lblresultado1
            // 
            this.lblresultado1.AutoSize = true;
            this.lblresultado1.Location = new System.Drawing.Point(20, 316);
            this.lblresultado1.Name = "lblresultado1";
            this.lblresultado1.Size = new System.Drawing.Size(0, 13);
            this.lblresultado1.TabIndex = 57;
            // 
            // txtresultado2
            // 
            this.txtresultado2.Location = new System.Drawing.Point(188, 339);
            this.txtresultado2.MaxLength = 3;
            this.txtresultado2.Name = "txtresultado2";
            this.txtresultado2.Size = new System.Drawing.Size(52, 20);
            this.txtresultado2.TabIndex = 60;
            this.txtresultado2.TextChanged += new System.EventHandler(this.txtresultado2_TextChanged);
            this.txtresultado2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtresultado2_KeyPress);
            // 
            // lblresultado2
            // 
            this.lblresultado2.AutoSize = true;
            this.lblresultado2.Location = new System.Drawing.Point(20, 346);
            this.lblresultado2.Name = "lblresultado2";
            this.lblresultado2.Size = new System.Drawing.Size(0, 13);
            this.lblresultado2.TabIndex = 59;
            // 
            // txtresultado3
            // 
            this.txtresultado3.Location = new System.Drawing.Point(190, 373);
            this.txtresultado3.MaxLength = 3;
            this.txtresultado3.Name = "txtresultado3";
            this.txtresultado3.Size = new System.Drawing.Size(50, 20);
            this.txtresultado3.TabIndex = 62;
            this.txtresultado3.TextChanged += new System.EventHandler(this.txtresultado3_TextChanged);
            this.txtresultado3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtresultado3_KeyPress);
            // 
            // lblresultado3
            // 
            this.lblresultado3.AutoSize = true;
            this.lblresultado3.Location = new System.Drawing.Point(20, 376);
            this.lblresultado3.Name = "lblresultado3";
            this.lblresultado3.Size = new System.Drawing.Size(0, 13);
            this.lblresultado3.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 63;
            this.label8.Text = "Comentario";
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(401, 405);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(22, 20);
            this.txtresultado.TabIndex = 70;
            this.txtresultado.Visible = false;
            this.txtresultado.TextChanged += new System.EventHandler(this.txtresultado_TextChanged);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(288, 410);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(0, 15);
            this.lblresultado.TabIndex = 71;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(261, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 72;
            this.label9.Text = "*Escala de 0 - 100";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(261, 346);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 73;
            this.label10.Text = "*Escala de 0 - 100";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(261, 380);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 74;
            this.label11.Text = "*Escala de 0 - 100";
            // 
            // txtcomentario
            // 
            this.txtcomentario.Location = new System.Drawing.Point(96, 442);
            this.txtcomentario.MaxLength = 300;
            this.txtcomentario.Multiline = true;
            this.txtcomentario.Name = "txtcomentario";
            this.txtcomentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtcomentario.Size = new System.Drawing.Size(313, 58);
            this.txtcomentario.TabIndex = 75;
            // 
            // button1
            // 
            this.button1.Image = global::WindowsFormsApplication1.Properties.Resources.nuevo;
            this.button1.Location = new System.Drawing.Point(55, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 46;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.editar;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(111, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 47;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Resultado_Pueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 512);
            this.Controls.Add(this.txtcomentario);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtresultado3);
            this.Controls.Add(this.lblresultado3);
            this.Controls.Add(this.txtresultado2);
            this.Controls.Add(this.lblresultado2);
            this.Controls.Add(this.txtresultado1);
            this.Controls.Add(this.lblresultado1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtresultadoT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "Resultado_Pueba";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultado de Prueba";
            this.Load += new System.EventHandler(this.Resultado_Pueba_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtresultadoT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblresultado1;
        private System.Windows.Forms.Label lblresultado2;
        private System.Windows.Forms.Label lblresultado3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txtnombrecandidato;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtidcandidato;
        public System.Windows.Forms.TextBox txtidentrevista;
        public System.Windows.Forms.TextBox txtetapaentrevista;
        public System.Windows.Forms.TextBox txtiddetalle;
        public System.Windows.Forms.TextBox txtresultado1;
        public System.Windows.Forms.TextBox txtresultado2;
        public System.Windows.Forms.TextBox txtresultado3;
        public System.Windows.Forms.TextBox txtcomentario;
    }
}