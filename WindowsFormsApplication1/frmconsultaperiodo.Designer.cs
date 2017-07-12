namespace WindowsFormsApplication1
{
    partial class frmconsultaperiodo
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
            this.nombreempleado = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnretorno
            // 
            this.btnretorno.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.menu_principal;
            this.btnretorno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnretorno.Location = new System.Drawing.Point(376, 215);
            this.btnretorno.Name = "btnretorno";
            this.btnretorno.Size = new System.Drawing.Size(50, 50);
            this.btnretorno.TabIndex = 27;
            this.btnretorno.UseVisualStyleBackColor = true;
            this.btnretorno.Click += new System.EventHandler(this.btnretorno_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 50);
            this.button2.TabIndex = 26;
            this.button2.Text = "aceptar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvbuscar
            // 
            this.dgvbuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbuscar.Location = new System.Drawing.Point(96, 78);
            this.dgvbuscar.Name = "dgvbuscar";
            this.dgvbuscar.Size = new System.Drawing.Size(330, 131);
            this.dgvbuscar.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nombreempleado
            // 
            this.nombreempleado.AutoSize = true;
            this.nombreempleado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreempleado.Location = new System.Drawing.Point(136, 23);
            this.nombreempleado.Name = "nombreempleado";
            this.nombreempleado.Size = new System.Drawing.Size(57, 19);
            this.nombreempleado.TabIndex = 22;
            this.nombreempleado.Text = "Estatus";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Activado ",
            "Desactivo"});
            this.comboBox1.Location = new System.Drawing.Point(217, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 28;
            // 
            // frmconsultaperiodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 282);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnretorno);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvbuscar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nombreempleado);
            this.Name = "frmconsultaperiodo";
            this.Text = "frmconsultaperiodo";
            this.Load += new System.EventHandler(this.frmconsultaperiodo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnretorno;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvbuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label nombreempleado;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}