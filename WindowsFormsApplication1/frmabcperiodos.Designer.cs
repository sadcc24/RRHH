namespace WindowsFormsApplication1
{
    partial class frmabcperiodos
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
            this.Periodo = new System.Windows.Forms.Label();
            this.txtperiodo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Periodo
            // 
            this.Periodo.AutoSize = true;
            this.Periodo.Location = new System.Drawing.Point(83, 120);
            this.Periodo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Periodo.Name = "Periodo";
            this.Periodo.Size = new System.Drawing.Size(63, 20);
            this.Periodo.TabIndex = 0;
            this.Periodo.Text = "Periodo";
            // 
            // txtperiodo
            // 
            this.txtperiodo.Location = new System.Drawing.Point(154, 117);
            this.txtperiodo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtperiodo.Name = "txtperiodo";
            this.txtperiodo.Size = new System.Drawing.Size(148, 26);
            this.txtperiodo.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnAyuda);
            this.panel1.Controls.Add(this.btnBorrar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Location = new System.Drawing.Point(64, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 57);
            this.panel1.TabIndex = 9;
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
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
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
            // frmabcperiodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 220);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtperiodo);
            this.Controls.Add(this.Periodo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmabcperiodos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmabcperiodos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmabcperiodos_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Periodo;
        private System.Windows.Forms.TextBox txtperiodo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
    }
}