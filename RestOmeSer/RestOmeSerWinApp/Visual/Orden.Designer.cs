﻿namespace RestOmeSerWinApp.Visual
{
    partial class Orden
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtTotalOrden = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgwMenu = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgwOrden = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMenu)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrden)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 48);
            this.button1.TabIndex = 16;
            this.button1.Text = "Hacer Orden";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtTotalOrden
            // 
            this.txtTotalOrden.Enabled = false;
            this.txtTotalOrden.Location = new System.Drawing.Point(370, 350);
            this.txtTotalOrden.Name = "txtTotalOrden";
            this.txtTotalOrden.Size = new System.Drawing.Size(143, 20);
            this.txtTotalOrden.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(624, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Categoria";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(574, 93);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbCategoria.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(653, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Men de Productos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Monto Total";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgwMenu);
            this.panel3.Location = new System.Drawing.Point(701, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(472, 270);
            this.panel3.TabIndex = 10;
            // 
            // dgwMenu
            // 
            this.dgwMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMenu.Location = new System.Drawing.Point(3, 15);
            this.dgwMenu.Name = "dgwMenu";
            this.dgwMenu.Size = new System.Drawing.Size(451, 229);
            this.dgwMenu.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgwOrden);
            this.panel1.Location = new System.Drawing.Point(103, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 270);
            this.panel1.TabIndex = 9;
            // 
            // dgwOrden
            // 
            this.dgwOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOrden.Location = new System.Drawing.Point(3, 15);
            this.dgwOrden.Name = "dgwOrden";
            this.dgwOrden.Size = new System.Drawing.Size(418, 229);
            this.dgwOrden.TabIndex = 2;
            // 
            // Orden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 479);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTotalOrden);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Orden";
            this.Text = "Orden";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMenu)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTotalOrden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgwMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgwOrden;
    }
}