namespace WindowsFormsApplication1
{
    partial class frmabcmetrica
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
            this.lbnombremetrica = new System.Windows.Forms.Label();
            this.cbdepartamento = new System.Windows.Forms.ComboBox();
            this.txtnombremetrica = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdescripcionmetrica = new System.Windows.Forms.TextBox();
            this.lbdepartamento = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbnombremetrica
            // 
            this.lbnombremetrica.AutoSize = true;
            this.lbnombremetrica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnombremetrica.Location = new System.Drawing.Point(53, 138);
            this.lbnombremetrica.Name = "lbnombremetrica";
            this.lbnombremetrica.Size = new System.Drawing.Size(121, 20);
            this.lbnombremetrica.TabIndex = 0;
            this.lbnombremetrica.Text = "Nombre Metrica";
            // 
            // cbdepartamento
            // 
            this.cbdepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdepartamento.FormattingEnabled = true;
            this.cbdepartamento.Location = new System.Drawing.Point(204, 283);
            this.cbdepartamento.Name = "cbdepartamento";
            this.cbdepartamento.Size = new System.Drawing.Size(250, 28);
            this.cbdepartamento.TabIndex = 1;
            // 
            // txtnombremetrica
            // 
            this.txtnombremetrica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombremetrica.Location = new System.Drawing.Point(204, 135);
            this.txtnombremetrica.Name = "txtnombremetrica";
            this.txtnombremetrica.Size = new System.Drawing.Size(250, 26);
            this.txtnombremetrica.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descripcion Metrica";
            // 
            // txtdescripcionmetrica
            // 
            this.txtdescripcionmetrica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcionmetrica.Location = new System.Drawing.Point(204, 191);
            this.txtdescripcionmetrica.Multiline = true;
            this.txtdescripcionmetrica.Name = "txtdescripcionmetrica";
            this.txtdescripcionmetrica.Size = new System.Drawing.Size(250, 70);
            this.txtdescripcionmetrica.TabIndex = 4;
            // 
            // lbdepartamento
            // 
            this.lbdepartamento.AutoSize = true;
            this.lbdepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdepartamento.Location = new System.Drawing.Point(53, 291);
            this.lbdepartamento.Name = "lbdepartamento";
            this.lbdepartamento.Size = new System.Drawing.Size(112, 20);
            this.lbdepartamento.TabIndex = 5;
            this.lbdepartamento.Text = "Departamento";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnAyuda);
            this.panel1.Controls.Add(this.btnBorrar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Location = new System.Drawing.Point(105, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 57);
            this.panel1.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.guardar;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(8, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(56, 51);
            this.btnGuardar.TabIndex = 0;
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
            this.btnAyuda.TabIndex = 3;
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.eliminar;
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrar.Location = new System.Drawing.Point(132, 3);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(56, 51);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.editar;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Location = new System.Drawing.Point(70, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(56, 51);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // frmabcmetrica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 399);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbdepartamento);
            this.Controls.Add(this.txtdescripcionmetrica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnombremetrica);
            this.Controls.Add(this.cbdepartamento);
            this.Controls.Add(this.lbnombremetrica);
            this.Name = "frmabcmetrica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmabcmetrica";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmabcmetrica_FormClosed);
            this.Load += new System.EventHandler(this.frmabcmetrica_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnombremetrica;
        private System.Windows.Forms.ComboBox cbdepartamento;
        private System.Windows.Forms.TextBox txtnombremetrica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdescripcionmetrica;
        private System.Windows.Forms.Label lbdepartamento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
    }
}