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
            this.btnretorno = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvbuscar = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtmotivo = new System.Windows.Forms.TextBox();
            this.nombreempleado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnretorno
            // 
            this.btnretorno.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.menu_principal;
            this.btnretorno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnretorno.Location = new System.Drawing.Point(331, 219);
            this.btnretorno.Name = "btnretorno";
            this.btnretorno.Size = new System.Drawing.Size(50, 50);
            this.btnretorno.TabIndex = 27;
            this.btnretorno.UseVisualStyleBackColor = true;
            this.btnretorno.Click += new System.EventHandler(this.btnretorno_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(51, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 50);
            this.button2.TabIndex = 26;
            this.button2.Text = "aceptar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // dgvbuscar
            // 
            this.dgvbuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbuscar.Location = new System.Drawing.Point(51, 82);
            this.dgvbuscar.Name = "dgvbuscar";
            this.dgvbuscar.Size = new System.Drawing.Size(330, 131);
            this.dgvbuscar.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtmotivo
            // 
            this.txtmotivo.Location = new System.Drawing.Point(162, 27);
            this.txtmotivo.Name = "txtmotivo";
            this.txtmotivo.Size = new System.Drawing.Size(187, 20);
            this.txtmotivo.TabIndex = 23;
            // 
            // nombreempleado
            // 
            this.nombreempleado.AutoSize = true;
            this.nombreempleado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreempleado.Location = new System.Drawing.Point(66, 26);
            this.nombreempleado.Name = "nombreempleado";
            this.nombreempleado.Size = new System.Drawing.Size(54, 19);
            this.nombreempleado.TabIndex = 22;
            this.nombreempleado.Text = "Motivo";
            // 
            // frmconsultarmotivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(435, 307);
            this.Controls.Add(this.btnretorno);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvbuscar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtmotivo);
            this.Controls.Add(this.nombreempleado);
            this.Name = "frmconsultarmotivo";
            this.Text = "frmconsultarmotivo";
            this.Load += new System.EventHandler(this.frmconsultarmotivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnretorno;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvbuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtmotivo;
        private System.Windows.Forms.Label nombreempleado;
    }
}