﻿namespace WindowsFormsApplication1
{
    partial class frmcapacitaciones
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
            this.dgvCapacitaciones = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapacitaciones)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCapacitaciones
            // 
            this.dgvCapacitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCapacitaciones.Location = new System.Drawing.Point(12, 80);
            this.dgvCapacitaciones.Name = "dgvCapacitaciones";
            this.dgvCapacitaciones.Size = new System.Drawing.Size(732, 319);
            this.dgvCapacitaciones.TabIndex = 0;
            this.dgvCapacitaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 40);
            this.panel1.TabIndex = 8;
            // 
            // button7
            // 
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Location = new System.Drawing.Point(245, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(41, 34);
            this.button7.TabIndex = 9;
            this.button7.Text = "Cancelar";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.refresh;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Location = new System.Drawing.Point(2, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(41, 34);
            this.button6.TabIndex = 8;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.nuevo;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(202, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(41, 34);
            this.button5.TabIndex = 7;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.go_to_last;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(162, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(41, 34);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.go_to_first;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(42, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 34);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.anterior;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(82, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 34);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.go_next;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(122, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 34);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmcapacitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCapacitaciones);
            this.Name = "frmcapacitaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capacitaciones";
            this.Load += new System.EventHandler(this.frmcapacitaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapacitaciones)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCapacitaciones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}