namespace VistaAerolinea {
	partial class frmPantallaPrincipal {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing&&(components!=null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modificarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.informaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.informaciónVuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.informaciónAvionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.disponibilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.venderPasajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.venderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.añadirAvionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nuevoAvionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modificarAvionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónToolStripMenuItem,
            this.informaciónToolStripMenuItem,
            this.venderPasajesToolStripMenuItem,
            this.añadirAvionToolStripMenuItem,
            this.salirToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(101, 580);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// configuraciónToolStripMenuItem
			// 
			this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarUsuarioToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
			this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
			this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(88, 19);
			this.configuraciónToolStripMenuItem.Text = "Configuración";
			// 
			// modificarUsuarioToolStripMenuItem
			// 
			this.modificarUsuarioToolStripMenuItem.Name = "modificarUsuarioToolStripMenuItem";
			this.modificarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.modificarUsuarioToolStripMenuItem.Text = "Modificar Usuario";
			this.modificarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.modificarUsuarioToolStripMenuItem_Click);
			// 
			// cerrarSesiónToolStripMenuItem
			// 
			this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
			this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
			// 
			// informaciónToolStripMenuItem
			// 
			this.informaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaciónVuelosToolStripMenuItem,
            this.informaciónAvionesToolStripMenuItem,
            this.disponibilidadToolStripMenuItem});
			this.informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
			this.informaciónToolStripMenuItem.Size = new System.Drawing.Size(88, 19);
			this.informaciónToolStripMenuItem.Text = "Información";
			// 
			// informaciónVuelosToolStripMenuItem
			// 
			this.informaciónVuelosToolStripMenuItem.Name = "informaciónVuelosToolStripMenuItem";
			this.informaciónVuelosToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.informaciónVuelosToolStripMenuItem.Text = "Información Vuelos";
			// 
			// informaciónAvionesToolStripMenuItem
			// 
			this.informaciónAvionesToolStripMenuItem.Name = "informaciónAvionesToolStripMenuItem";
			this.informaciónAvionesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.informaciónAvionesToolStripMenuItem.Text = "Información Aviones";
			// 
			// disponibilidadToolStripMenuItem
			// 
			this.disponibilidadToolStripMenuItem.Name = "disponibilidadToolStripMenuItem";
			this.disponibilidadToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.disponibilidadToolStripMenuItem.Text = "Disponibilidad Asientos";
			// 
			// venderPasajesToolStripMenuItem
			// 
			this.venderPasajesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.venderToolStripMenuItem,
            this.modificarToolStripMenuItem});
			this.venderPasajesToolStripMenuItem.Name = "venderPasajesToolStripMenuItem";
			this.venderPasajesToolStripMenuItem.Size = new System.Drawing.Size(88, 19);
			this.venderPasajesToolStripMenuItem.Text = "Pasajes";
			// 
			// venderToolStripMenuItem
			// 
			this.venderToolStripMenuItem.Name = "venderToolStripMenuItem";
			this.venderToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.venderToolStripMenuItem.Text = "Vender";
			this.venderToolStripMenuItem.Click += new System.EventHandler(this.venderToolStripMenuItem_Click);
			// 
			// modificarToolStripMenuItem
			// 
			this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
			this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.modificarToolStripMenuItem.Text = "Modificar";
			// 
			// añadirAvionToolStripMenuItem
			// 
			this.añadirAvionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoAvionToolStripMenuItem,
            this.modificarAvionToolStripMenuItem});
			this.añadirAvionToolStripMenuItem.Name = "añadirAvionToolStripMenuItem";
			this.añadirAvionToolStripMenuItem.Size = new System.Drawing.Size(88, 19);
			this.añadirAvionToolStripMenuItem.Text = "Aviones";
			// 
			// nuevoAvionToolStripMenuItem
			// 
			this.nuevoAvionToolStripMenuItem.Name = "nuevoAvionToolStripMenuItem";
			this.nuevoAvionToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.nuevoAvionToolStripMenuItem.Text = "Nuevo Avion";
			this.nuevoAvionToolStripMenuItem.Click += new System.EventHandler(this.nuevoAvionToolStripMenuItem_Click);
			// 
			// modificarAvionToolStripMenuItem
			// 
			this.modificarAvionToolStripMenuItem.Name = "modificarAvionToolStripMenuItem";
			this.modificarAvionToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.modificarAvionToolStripMenuItem.Text = "Modificar Avion";
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(88, 19);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
			// 
			// frmPantallaPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(850, 580);
			this.ControlBox = false;
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximumSize = new System.Drawing.Size(850, 580);
			this.MinimumSize = new System.Drawing.Size(850, 580);
			this.Name = "frmPantallaPrincipal";
			this.Text = "Pantalla Principal";
			this.Load += new System.EventHandler(this.frmPantallaPrincipal_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem configuraciónToolStripMenuItem;
		private ToolStripMenuItem modificarUsuarioToolStripMenuItem;
		private ToolStripMenuItem cerrarSesiónToolStripMenuItem;
		private ToolStripMenuItem informaciónToolStripMenuItem;
		private ToolStripMenuItem informaciónVuelosToolStripMenuItem;
		private ToolStripMenuItem informaciónAvionesToolStripMenuItem;
		private ToolStripMenuItem disponibilidadToolStripMenuItem;
		private ToolStripMenuItem venderPasajesToolStripMenuItem;
		private ToolStripMenuItem venderToolStripMenuItem;
		private ToolStripMenuItem modificarToolStripMenuItem;
		private ToolStripMenuItem añadirAvionToolStripMenuItem;
		private ToolStripMenuItem nuevoAvionToolStripMenuItem;
		private ToolStripMenuItem salirToolStripMenuItem;
		private ToolStripMenuItem modificarAvionToolStripMenuItem;
	}
}