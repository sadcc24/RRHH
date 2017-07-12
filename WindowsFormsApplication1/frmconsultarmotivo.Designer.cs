namespace WindowsFormsApplication1
{
    partial class frmconsultarmotivo
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
            this.txtmotivo = new System.Windows.Forms.TextBox();
            this.nombreempleado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvbuscar = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btnretorno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmotivo
            // 
            this.txtmotivo.Location = new System.Drawing.Point(191, 34);
            this.txtmotivo.Name = "txtmotivo";
            this.txtmotivo.Size = new System.Drawing.Size(187, 20);
            this.txtmotivo.TabIndex = 17;
            this.txtmotivo.TextChanged += new System.EventHandler(this.txtmotivo_TextChanged);
            // 
            // nombreempleado
            // 
            this.nombreempleado.AutoSize = true;
            this.nombreempleado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreempleado.Location = new System.Drawing.Point(95, 33);
            this.nombreempleado.Name = "nombreempleado";
            this.nombreempleado.Size = new System.Drawing.Size(54, 19);
            this.nombreempleado.TabIndex = 16;
            this.nombreempleado.Text = "Motivo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvbuscar
            // 
            this.dgvbuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbuscar.Location = new System.Drawing.Point(80, 89);
            this.dgvbuscar.Name = "dgvbuscar";
            this.dgvbuscar.Size = new System.Drawing.Size(330, 131);
            this.dgvbuscar.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(80, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 50);
            this.button2.TabIndex = 20;
            this.button2.Text = "aceptar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnretorno
            // 
            this.btnretorno.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.menu_principal;
            this.btnretorno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnretorno.Location = new System.Drawing.Point(360, 226);
            this.btnretorno.Name = "btnretorno";
            this.btnretorno.Size = new System.Drawing.Size(50, 50);
            this.btnretorno.TabIndex = 21;
            this.btnretorno.UseVisualStyleBackColor = true;
            this.btnretorno.Click += new System.EventHandler(this.btnretorno_Click);
            // 
            // frmconsultarmotivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(451, 288);
            this.Controls.Add(this.btnretorno);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvbuscar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtmotivo);
            this.Controls.Add(this.nombreempleado);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmconsultarmotivo";
            this.Text = "Consulta Motivo";
            this.Load += new System.EventHandler(this.frmconsultarmotivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmotivo;
        private System.Windows.Forms.Label nombreempleado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvbuscar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnretorno;
    }
}