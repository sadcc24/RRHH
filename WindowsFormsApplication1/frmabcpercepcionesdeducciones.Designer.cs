namespace WindowsFormsApplication1
{
    partial class ABCPercepcionesDeducciones
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
            this.txt_porcentaje = new System.Windows.Forms.NumericUpDown();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_tipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_help = new System.Windows.Forms.Button();
            this.btn_righttop = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_lefttop = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.grid_percepciones = new System.Windows.Forms.DataGridView();
            this.txt_filtro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_empresa = new System.Windows.Forms.ComboBox();
            this.txt_tipoPago = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grid_deducciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.txt_porcentaje)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_percepciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_deducciones)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_porcentaje
            // 
            this.txt_porcentaje.Location = new System.Drawing.Point(129, 230);
            this.txt_porcentaje.Name = "txt_porcentaje";
            this.txt_porcentaje.Size = new System.Drawing.Size(120, 20);
            this.txt_porcentaje.TabIndex = 34;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(129, 200);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(121, 20);
            this.txt_descripcion.TabIndex = 33;
            // 
            // txt_tipo
            // 
            this.txt_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_tipo.FormattingEnabled = true;
            this.txt_tipo.Location = new System.Drawing.Point(129, 136);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.Size = new System.Drawing.Size(121, 21);
            this.txt_tipo.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Porcentaje:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Tipo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Descripción:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_eliminar);
            this.groupBox3.Controls.Add(this.btn_editar);
            this.groupBox3.Controls.Add(this.btn_guardar);
            this.groupBox3.Controls.Add(this.btn_help);
            this.groupBox3.Controls.Add(this.btn_righttop);
            this.groupBox3.Controls.Add(this.btn_right);
            this.groupBox3.Controls.Add(this.btn_left);
            this.groupBox3.Controls.Add(this.btn_lefttop);
            this.groupBox3.Controls.Add(this.btn_nuevo);
            this.groupBox3.Location = new System.Drawing.Point(2, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(435, 68);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Menú";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.eliminar;
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar.Location = new System.Drawing.Point(151, 12);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(40, 40);
            this.btn_eliminar.TabIndex = 33;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_editar
            // 
            this.btn_editar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.editar;
            this.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_editar.Location = new System.Drawing.Point(104, 12);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(40, 40);
            this.btn_editar.TabIndex = 32;
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.guardar;
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.Location = new System.Drawing.Point(58, 12);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(40, 40);
            this.btn_guardar.TabIndex = 31;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_help
            // 
            this.btn_help.Image = global::WindowsFormsApplication1.Properties.Resources.help;
            this.btn_help.Location = new System.Drawing.Point(381, 12);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(40, 40);
            this.btn_help.TabIndex = 30;
            this.btn_help.UseVisualStyleBackColor = true;
            // 
            // btn_righttop
            // 
            this.btn_righttop.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.go_to_last;
            this.btn_righttop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_righttop.Location = new System.Drawing.Point(335, 12);
            this.btn_righttop.Name = "btn_righttop";
            this.btn_righttop.Size = new System.Drawing.Size(40, 40);
            this.btn_righttop.TabIndex = 29;
            this.btn_righttop.UseVisualStyleBackColor = true;
            // 
            // btn_right
            // 
            this.btn_right.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.go_next;
            this.btn_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_right.Location = new System.Drawing.Point(289, 12);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(40, 40);
            this.btn_right.TabIndex = 28;
            this.btn_right.UseVisualStyleBackColor = true;
            // 
            // btn_left
            // 
            this.btn_left.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.anterior;
            this.btn_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_left.Location = new System.Drawing.Point(243, 12);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(40, 40);
            this.btn_left.TabIndex = 27;
            this.btn_left.UseVisualStyleBackColor = true;
            // 
            // btn_lefttop
            // 
            this.btn_lefttop.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.go_to_first;
            this.btn_lefttop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_lefttop.Location = new System.Drawing.Point(197, 12);
            this.btn_lefttop.Name = "btn_lefttop";
            this.btn_lefttop.Size = new System.Drawing.Size(40, 40);
            this.btn_lefttop.TabIndex = 26;
            this.btn_lefttop.UseVisualStyleBackColor = true;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.nuevo;
            this.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo.Location = new System.Drawing.Point(12, 14);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(40, 40);
            this.btn_nuevo.TabIndex = 24;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // grid_percepciones
            // 
            this.grid_percepciones.AllowUserToAddRows = false;
            this.grid_percepciones.AllowUserToDeleteRows = false;
            this.grid_percepciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_percepciones.Location = new System.Drawing.Point(24, 306);
            this.grid_percepciones.Name = "grid_percepciones";
            this.grid_percepciones.ReadOnly = true;
            this.grid_percepciones.Size = new System.Drawing.Size(461, 177);
            this.grid_percepciones.TabIndex = 38;
            this.grid_percepciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_percepciones_CellContentClick);
            // 
            // txt_filtro
            // 
            this.txt_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_filtro.FormattingEnabled = true;
            this.txt_filtro.Items.AddRange(new object[] {
            "Percepciones",
            "Deducciones"});
            this.txt_filtro.Location = new System.Drawing.Point(365, 265);
            this.txt_filtro.Name = "txt_filtro";
            this.txt_filtro.Size = new System.Drawing.Size(121, 21);
            this.txt_filtro.TabIndex = 39;
            this.txt_filtro.SelectedIndexChanged += new System.EventHandler(this.txt_filtro_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Filtrar Por:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Empresa:";
            // 
            // txt_empresa
            // 
            this.txt_empresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_empresa.FormattingEnabled = true;
            this.txt_empresa.Location = new System.Drawing.Point(129, 74);
            this.txt_empresa.Name = "txt_empresa";
            this.txt_empresa.Size = new System.Drawing.Size(121, 21);
            this.txt_empresa.TabIndex = 42;
            // 
            // txt_tipoPago
            // 
            this.txt_tipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_tipoPago.FormattingEnabled = true;
            this.txt_tipoPago.Items.AddRange(new object[] {
            "[1,Percepción]",
            "Deducción"});
            this.txt_tipoPago.Location = new System.Drawing.Point(129, 168);
            this.txt_tipoPago.Name = "txt_tipoPago";
            this.txt_tipoPago.Size = new System.Drawing.Size(121, 21);
            this.txt_tipoPago.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Tipo de Pago:";
            // 
            // grid_deducciones
            // 
            this.grid_deducciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_deducciones.Location = new System.Drawing.Point(24, 306);
            this.grid_deducciones.Name = "grid_deducciones";
            this.grid_deducciones.Size = new System.Drawing.Size(462, 177);
            this.grid_deducciones.TabIndex = 45;
            this.grid_deducciones.Visible = false;
            this.grid_deducciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_deducciones_CellContentClick);
            // 
            // ABCPercepcionesDeducciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 495);
            this.Controls.Add(this.grid_deducciones);
            this.Controls.Add(this.txt_tipoPago);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_empresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_filtro);
            this.Controls.Add(this.grid_percepciones);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txt_porcentaje);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_tipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Name = "ABCPercepcionesDeducciones";
            this.Text = "ABCPercepcionesDeducciones";
            ((System.ComponentModel.ISupportInitialize)(this.txt_porcentaje)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_percepciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_deducciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown txt_porcentaje;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.ComboBox txt_tipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Button btn_righttop;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_lefttop;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.DataGridView grid_percepciones;
        private System.Windows.Forms.ComboBox txt_filtro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txt_empresa;
        private System.Windows.Forms.ComboBox txt_tipoPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grid_deducciones;
    }
}