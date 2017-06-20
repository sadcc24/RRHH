namespace WindowsFormsApplication1
{
    partial class frmmotivo
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
            this.btnretorno = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.nombreempleado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdmotivo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtmotivo = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.btnayuda = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdmotivo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnretorno);
            this.groupBox1.Controls.Add(this.btnayuda);
            this.groupBox1.Controls.Add(this.btnactualizar);
            this.groupBox1.Controls.Add(this.btncancelar);
            this.groupBox1.Controls.Add(this.btneliminar);
            this.groupBox1.Controls.Add(this.btnmodificar);
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Controls.Add(this.btnnuevo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 99);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // btnretorno
            // 
            this.btnretorno.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.menu_principal;
            this.btnretorno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnretorno.Location = new System.Drawing.Point(407, 27);
            this.btnretorno.Name = "btnretorno";
            this.btnretorno.Size = new System.Drawing.Size(50, 50);
            this.btnretorno.TabIndex = 7;
            this.btnretorno.UseVisualStyleBackColor = true;
            this.btnretorno.Click += new System.EventHandler(this.button8_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.Location = new System.Drawing.Point(239, 27);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(50, 50);
            this.btncancelar.TabIndex = 4;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // nombreempleado
            // 
            this.nombreempleado.AutoSize = true;
            this.nombreempleado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreempleado.Location = new System.Drawing.Point(105, 134);
            this.nombreempleado.Name = "nombreempleado";
            this.nombreempleado.Size = new System.Drawing.Size(54, 19);
            this.nombreempleado.TabIndex = 12;
            this.nombreempleado.Text = "Motivo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Descripción";
            // 
            // grdmotivo
            // 
            this.grdmotivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdmotivo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.grdmotivo.Location = new System.Drawing.Point(83, 226);
            this.grdmotivo.Name = "grdmotivo";
            this.grdmotivo.Size = new System.Drawing.Size(345, 150);
            this.grdmotivo.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "cod motivo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Motivo";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Descripcion";
            this.Column3.Name = "Column3";
            // 
            // txtmotivo
            // 
            this.txtmotivo.Enabled = false;
            this.txtmotivo.Location = new System.Drawing.Point(201, 135);
            this.txtmotivo.Name = "txtmotivo";
            this.txtmotivo.Size = new System.Drawing.Size(187, 20);
            this.txtmotivo.TabIndex = 15;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Enabled = false;
            this.txtdescripcion.Location = new System.Drawing.Point(201, 164);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(187, 48);
            this.txtdescripcion.TabIndex = 16;
            // 
            // btnayuda
            // 
            this.btnayuda.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.help;
            this.btnayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnayuda.Location = new System.Drawing.Point(351, 27);
            this.btnayuda.Name = "btnayuda";
            this.btnayuda.Size = new System.Drawing.Size(50, 50);
            this.btnayuda.TabIndex = 6;
            this.btnayuda.UseVisualStyleBackColor = true;
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.refresh;
            this.btnactualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnactualizar.Location = new System.Drawing.Point(295, 27);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(50, 50);
            this.btnactualizar.TabIndex = 5;
            this.btnactualizar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.eliminar;
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneliminar.Location = new System.Drawing.Point(183, 27);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(50, 50);
            this.btneliminar.TabIndex = 3;
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.editar;
            this.btnmodificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmodificar.Location = new System.Drawing.Point(127, 27);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(50, 50);
            this.btnmodificar.TabIndex = 2;
            this.btnmodificar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.guardar;
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguardar.Location = new System.Drawing.Point(71, 27);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(50, 50);
            this.btnguardar.TabIndex = 1;
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.nuevo;
            this.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnuevo.Location = new System.Drawing.Point(15, 27);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(50, 50);
            this.btnnuevo.TabIndex = 0;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // frmmotivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 388);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtmotivo);
            this.Controls.Add(this.grdmotivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombreempleado);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmmotivo";
            this.Text = "frmmotivo";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdmotivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnretorno;
        private System.Windows.Forms.Button btnayuda;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Label nombreempleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdmotivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox txtmotivo;
        private System.Windows.Forms.TextBox txtdescripcion;
    }
}