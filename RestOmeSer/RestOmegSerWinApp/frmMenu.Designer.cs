namespace RestOmegSerWinApp
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesFrecuentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarClienteFrecuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarClienteFrecuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarMesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distribucionDeMesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.almacenDeIngredientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.administrarMesasToolStripMenuItem,
            this.ordenesToolStripMenuItem,
            this.administrarProductosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(896, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarUsuariosToolStripMenuItem,
            this.clientesFrecuentesToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // administrarUsuariosToolStripMenuItem
            // 
            this.administrarUsuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.borrarToolStripMenuItem});
            this.administrarUsuariosToolStripMenuItem.Name = "administrarUsuariosToolStripMenuItem";
            this.administrarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.administrarUsuariosToolStripMenuItem.Text = "Administrar Usuarios";
            // 
            // clientesFrecuentesToolStripMenuItem
            // 
            this.clientesFrecuentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarClienteFrecuenteToolStripMenuItem,
            this.eliminarClienteFrecuenteToolStripMenuItem});
            this.clientesFrecuentesToolStripMenuItem.Name = "clientesFrecuentesToolStripMenuItem";
            this.clientesFrecuentesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.clientesFrecuentesToolStripMenuItem.Text = "Clientes Frecuentes";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.borrarToolStripMenuItem.Text = "Borrar";
            // 
            // agregarClienteFrecuenteToolStripMenuItem
            // 
            this.agregarClienteFrecuenteToolStripMenuItem.Name = "agregarClienteFrecuenteToolStripMenuItem";
            this.agregarClienteFrecuenteToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.agregarClienteFrecuenteToolStripMenuItem.Text = "Agregar Cliente Frecuente";
            // 
            // eliminarClienteFrecuenteToolStripMenuItem
            // 
            this.eliminarClienteFrecuenteToolStripMenuItem.Name = "eliminarClienteFrecuenteToolStripMenuItem";
            this.eliminarClienteFrecuenteToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.eliminarClienteFrecuenteToolStripMenuItem.Text = "Eliminar Cliente Frecuente";
            // 
            // administrarMesasToolStripMenuItem
            // 
            this.administrarMesasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.distribucionDeMesasToolStripMenuItem});
            this.administrarMesasToolStripMenuItem.Name = "administrarMesasToolStripMenuItem";
            this.administrarMesasToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.administrarMesasToolStripMenuItem.Text = "Administrar Mesas";
            // 
            // distribucionDeMesasToolStripMenuItem
            // 
            this.distribucionDeMesasToolStripMenuItem.Name = "distribucionDeMesasToolStripMenuItem";
            this.distribucionDeMesasToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.distribucionDeMesasToolStripMenuItem.Text = "Distribucion de las Mesas";
            // 
            // ordenesToolStripMenuItem
            // 
            this.ordenesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenarToolStripMenuItem});
            this.ordenesToolStripMenuItem.Name = "ordenesToolStripMenuItem";
            this.ordenesToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ordenesToolStripMenuItem.Text = "Ordenes";
            // 
            // ordenarToolStripMenuItem
            // 
            this.ordenarToolStripMenuItem.Name = "ordenarToolStripMenuItem";
            this.ordenarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ordenarToolStripMenuItem.Text = "Ordenar";
            // 
            // administrarProductosToolStripMenuItem
            // 
            this.administrarProductosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.almacenDeIngredientesToolStripMenuItem});
            this.administrarProductosToolStripMenuItem.Name = "administrarProductosToolStripMenuItem";
            this.administrarProductosToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.administrarProductosToolStripMenuItem.Text = "Administrar Productos";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // almacenDeIngredientesToolStripMenuItem
            // 
            this.almacenDeIngredientesToolStripMenuItem.Name = "almacenDeIngredientesToolStripMenuItem";
            this.almacenDeIngredientesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.almacenDeIngredientesToolStripMenuItem.Text = "Almacen de Ingredientes";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 451);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesFrecuentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarClienteFrecuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarClienteFrecuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarMesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distribucionDeMesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem almacenDeIngredientesToolStripMenuItem;
    }
}