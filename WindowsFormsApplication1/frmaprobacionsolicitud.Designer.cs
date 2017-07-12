namespace WindowsFormsApplication1
{
    partial class frmaprobacionsolicitud
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
            this.dgvsolicitud = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAdelantefin = new System.Windows.Forms.Button();
            this.btnAtrasfin = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnAdelante = new System.Windows.Forms.Button();
            this.btnretorno = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsolicitud)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvsolicitud
            // 
            this.dgvsolicitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsolicitud.Location = new System.Drawing.Point(12, 102);
            this.dgvsolicitud.Name = "dgvsolicitud";
            this.dgvsolicitud.Size = new System.Drawing.Size(1033, 290);
            this.dgvsolicitud.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pendiente",
            "Aprobado",
            "Rechazado"});
            this.comboBox1.Location = new System.Drawing.Point(73, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Busqueda";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAyuda);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.btnAdelantefin);
            this.panel1.Controls.Add(this.btnAtrasfin);
            this.panel1.Controls.Add(this.btnAtras);
            this.panel1.Controls.Add(this.btnAdelante);
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 40);
            this.panel1.TabIndex = 15;
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.help;
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAyuda.Location = new System.Drawing.Point(245, 3);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(41, 34);
            this.btnAyuda.TabIndex = 11;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.editar;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Location = new System.Drawing.Point(209, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(41, 34);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.refresh;
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizar.Location = new System.Drawing.Point(2, 3);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(41, 34);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnAdelantefin
            // 
            this.btnAdelantefin.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.go_to_last;
            this.btnAdelantefin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdelantefin.Location = new System.Drawing.Point(162, 3);
            this.btnAdelantefin.Name = "btnAdelantefin";
            this.btnAdelantefin.Size = new System.Drawing.Size(41, 34);
            this.btnAdelantefin.TabIndex = 6;
            this.btnAdelantefin.UseVisualStyleBackColor = true;
            // 
            // btnAtrasfin
            // 
            this.btnAtrasfin.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.go_to_first;
            this.btnAtrasfin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAtrasfin.Location = new System.Drawing.Point(42, 3);
            this.btnAtrasfin.Name = "btnAtrasfin";
            this.btnAtrasfin.Size = new System.Drawing.Size(41, 34);
            this.btnAtrasfin.TabIndex = 3;
            this.btnAtrasfin.UseVisualStyleBackColor = true;
            // 
            // btnAtras
            // 
            this.btnAtras.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.anterior;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtras.Location = new System.Drawing.Point(82, 3);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(41, 34);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.UseVisualStyleBackColor = true;
            // 
            // btnAdelante
            // 
            this.btnAdelante.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.go_next;
            this.btnAdelante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdelante.Location = new System.Drawing.Point(122, 3);
            this.btnAdelante.Name = "btnAdelante";
            this.btnAdelante.Size = new System.Drawing.Size(41, 34);
            this.btnAdelante.TabIndex = 5;
            this.btnAdelante.UseVisualStyleBackColor = true;
            // 
            // btnretorno
            // 
            this.btnretorno.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.menu_principal;
            this.btnretorno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnretorno.Location = new System.Drawing.Point(997, 398);
            this.btnretorno.Name = "btnretorno";
            this.btnretorno.Size = new System.Drawing.Size(50, 50);
            this.btnretorno.TabIndex = 20;
            this.btnretorno.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(938, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 50);
            this.button1.TabIndex = 19;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmaprobacionsolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 449);
            this.Controls.Add(this.btnretorno);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvsolicitud);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frmaprobacionsolicitud";
            this.Text = "Aprovacion Solicitud";
            this.Load += new System.EventHandler(this.frmaprobacionsolicitud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsolicitud)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvsolicitud;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAdelantefin;
        private System.Windows.Forms.Button btnAtrasfin;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnAdelante;
        private System.Windows.Forms.Button btnretorno;
        private System.Windows.Forms.Button button1;
    }
}