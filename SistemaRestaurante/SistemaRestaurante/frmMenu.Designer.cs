namespace SistemaRestaurante
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
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesFrecuentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarClienteFrecuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarClienteFrecuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarMesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distribuccionDeLasMesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.administrarMesasToolStripMenuItem,
            this.ordenesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1039, 24);
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
            this.eliminarToolStripMenuItem});
            this.administrarUsuariosToolStripMenuItem.Name = "administrarUsuariosToolStripMenuItem";
            this.administrarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.administrarUsuariosToolStripMenuItem.Text = "Administrar usuarios";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // clientesFrecuentesToolStripMenuItem
            // 
            this.clientesFrecuentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarClienteFrecuenteToolStripMenuItem,
            this.eliminarClienteFrecuenteToolStripMenuItem});
            this.clientesFrecuentesToolStripMenuItem.Name = "clientesFrecuentesToolStripMenuItem";
            this.clientesFrecuentesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.clientesFrecuentesToolStripMenuItem.Text = "Clientes frecuentes";
            // 
            // agregarClienteFrecuenteToolStripMenuItem
            // 
            this.agregarClienteFrecuenteToolStripMenuItem.Name = "agregarClienteFrecuenteToolStripMenuItem";
            this.agregarClienteFrecuenteToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.agregarClienteFrecuenteToolStripMenuItem.Text = "Agregar Cliente Frecuente";
            this.agregarClienteFrecuenteToolStripMenuItem.Click += new System.EventHandler(this.agregarClienteFrecuenteToolStripMenuItem_Click);
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
            this.distribuccionDeLasMesasToolStripMenuItem});
            this.administrarMesasToolStripMenuItem.Name = "administrarMesasToolStripMenuItem";
            this.administrarMesasToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.administrarMesasToolStripMenuItem.Text = "Administrar Mesas";
            // 
            // distribuccionDeLasMesasToolStripMenuItem
            // 
            this.distribuccionDeLasMesasToolStripMenuItem.Name = "distribuccionDeLasMesasToolStripMenuItem";
            this.distribuccionDeLasMesasToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.distribuccionDeLasMesasToolStripMenuItem.Text = "Distribucion de las Mesas";
            this.distribuccionDeLasMesasToolStripMenuItem.Click += new System.EventHandler(this.distribuccionDeLasMesasToolStripMenuItem_Click);
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
            this.ordenarToolStripMenuItem.Click += new System.EventHandler(this.ordenarToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 534);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu ";
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
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesFrecuentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarClienteFrecuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarClienteFrecuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarMesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distribuccionDeLasMesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenarToolStripMenuItem;
    }
}