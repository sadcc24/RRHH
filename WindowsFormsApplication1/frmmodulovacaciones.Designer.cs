namespace WindowsFormsApplication1
{
    partial class frmmodulovacaciones
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
            this.nombreempleado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fechainicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.fechafin = new System.Windows.Forms.DateTimePicker();
            this.Motivo = new System.Windows.Forms.Label();
            this.combomotivo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnretorno = new System.Windows.Forms.Button();
            this.btnayuda = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.grdvaciones = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAdelantefin = new System.Windows.Forms.Button();
            this.btnAtrasfin = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnAdelante = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdvaciones)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombreempleado
            // 
            this.nombreempleado.AutoSize = true;
            this.nombreempleado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreempleado.Location = new System.Drawing.Point(152, 128);
            this.nombreempleado.Name = "nombreempleado";
            this.nombreempleado.Size = new System.Drawing.Size(128, 19);
            this.nombreempleado.TabIndex = 0;
            this.nombreempleado.Text = "Nombre Empleado";
            this.nombreempleado.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F);
            this.label1.Location = new System.Drawing.Point(152, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha Inicio";
            // 
            // fechainicio
            // 
            this.fechainicio.Enabled = false;
            this.fechainicio.Font = new System.Drawing.Font("Calibri", 12F);
            this.fechainicio.Location = new System.Drawing.Point(265, 169);
            this.fechainicio.Name = "fechainicio";
            this.fechainicio.Size = new System.Drawing.Size(200, 27);
            this.fechainicio.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F);
            this.label2.Location = new System.Drawing.Point(152, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Fin";
            // 
            // fechafin
            // 
            this.fechafin.Enabled = false;
            this.fechafin.Font = new System.Drawing.Font("Calibri", 12F);
            this.fechafin.Location = new System.Drawing.Point(265, 222);
            this.fechafin.Name = "fechafin";
            this.fechafin.Size = new System.Drawing.Size(200, 27);
            this.fechafin.TabIndex = 4;
            // 
            // Motivo
            // 
            this.Motivo.AutoSize = true;
            this.Motivo.Font = new System.Drawing.Font("Calibri", 12F);
            this.Motivo.Location = new System.Drawing.Point(152, 265);
            this.Motivo.Name = "Motivo";
            this.Motivo.Size = new System.Drawing.Size(54, 19);
            this.Motivo.TabIndex = 5;
            this.Motivo.Text = "Motivo";
            // 
            // combomotivo
            // 
            this.combomotivo.Enabled = false;
            this.combomotivo.Font = new System.Drawing.Font("Calibri", 12F);
            this.combomotivo.FormattingEnabled = true;
            this.combomotivo.Location = new System.Drawing.Point(265, 263);
            this.combomotivo.Name = "combomotivo";
            this.combomotivo.Size = new System.Drawing.Size(200, 27);
            this.combomotivo.TabIndex = 6;
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
            this.groupBox1.Location = new System.Drawing.Point(47, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 99);
            this.groupBox1.TabIndex = 10;
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
            this.btnretorno.Click += new System.EventHandler(this.btnretorno_Click);
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
            // grdvaciones
            // 
            this.grdvaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdvaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Nombre,
            this.Column2,
            this.Column3,
            this.Column4});
            this.grdvaciones.Location = new System.Drawing.Point(12, 364);
            this.grdvaciones.Name = "grdvaciones";
            this.grdvaciones.Size = new System.Drawing.Size(541, 135);
            this.grdvaciones.TabIndex = 11;
            this.grdvaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "cod solicitud";
            this.Column1.Name = "Column1";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fecha Inicio";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fecha Final";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Motivo";
            this.Column4.Name = "Column4";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnAdelantefin);
            this.panel1.Controls.Add(this.btnAtrasfin);
            this.panel1.Controls.Add(this.btnAtras);
            this.panel1.Controls.Add(this.btnAdelante);
            this.panel1.Location = new System.Drawing.Point(146, 318);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 40);
            this.panel1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.help;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(203, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 34);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.refresh;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(2, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 34);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = true;
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
            // frmmodulovacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(561, 524);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grdvaciones);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.combomotivo);
            this.Controls.Add(this.Motivo);
            this.Controls.Add(this.fechafin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fechainicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombreempleado);
            this.Name = "frmmodulovacaciones";
            this.Text = "Solicitud Vacaciones";
            this.Load += new System.EventHandler(this.modulovacaciones_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdvaciones)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombreempleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fechainicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fechafin;
        private System.Windows.Forms.Label Motivo;
        private System.Windows.Forms.ComboBox combomotivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnayuda;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.DataGridView grdvaciones;
        private System.Windows.Forms.Button btnretorno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAdelantefin;
        private System.Windows.Forms.Button btnAtrasfin;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnAdelante;
    }
}