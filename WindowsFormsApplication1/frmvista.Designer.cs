namespace WindowsFormsApplication1
{
    partial class frmvista
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dfechainicio = new System.Windows.Forms.DateTimePicker();
            this.dfechafin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnretorno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(529, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consulta:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.buscar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(409, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 41);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dfechainicio
            // 
            this.dfechainicio.Font = new System.Drawing.Font("Calibri", 12F);
            this.dfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dfechainicio.Location = new System.Drawing.Point(60, 62);
            this.dfechainicio.Name = "dfechainicio";
            this.dfechainicio.Size = new System.Drawing.Size(159, 27);
            this.dfechainicio.TabIndex = 29;
            this.dfechainicio.TabStop = false;
            // 
            // dfechafin
            // 
            this.dfechafin.Font = new System.Drawing.Font("Calibri", 12F);
            this.dfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dfechafin.Location = new System.Drawing.Point(244, 62);
            this.dfechafin.Name = "dfechafin";
            this.dfechafin.Size = new System.Drawing.Size(159, 27);
            this.dfechafin.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "De";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "a";
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.help;
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAyuda.Location = new System.Drawing.Point(458, 58);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(41, 41);
            this.btnAyuda.TabIndex = 33;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnretorno
            // 
            this.btnretorno.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.menu_principal;
            this.btnretorno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnretorno.Location = new System.Drawing.Point(505, 58);
            this.btnretorno.Name = "btnretorno";
            this.btnretorno.Size = new System.Drawing.Size(40, 41);
            this.btnretorno.TabIndex = 34;
            this.btnretorno.UseVisualStyleBackColor = true;
            this.btnretorno.Click += new System.EventHandler(this.btnretorno_Click);
            // 
            // frmvista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 267);
            this.Controls.Add(this.btnretorno);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dfechainicio);
            this.Controls.Add(this.dfechafin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmvista";
            this.Text = "Vista ";
            this.Load += new System.EventHandler(this.frmvista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dfechainicio;
        private System.Windows.Forms.DateTimePicker dfechafin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnretorno;
    }
}