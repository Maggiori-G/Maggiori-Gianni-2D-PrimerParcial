namespace VistaAerolinea {
	partial class FrmPantallaPrincipal {
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
			System.Windows.Forms.MenuStrip menuStrip1;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPantallaPrincipal));
			this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modificarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.informaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.informaciónVuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.informaciónAvionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.informaciónClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.venderPasajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.venderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.añadirAvionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nuevoAvionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modificarAvionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			menuStrip1 = new System.Windows.Forms.MenuStrip();
			menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
			menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			menuStrip1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónToolStripMenuItem,
            this.informaciónToolStripMenuItem,
            this.venderPasajesToolStripMenuItem,
            this.añadirAvionToolStripMenuItem,
            this.salirToolStripMenuItem});
			menuStrip1.Location = new System.Drawing.Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
			menuStrip1.Size = new System.Drawing.Size(920, 26);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			// 
			// configuraciónToolStripMenuItem
			// 
			this.configuraciónToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarUsuarioToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
			this.configuraciónToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
			this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
			this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.configuraciónToolStripMenuItem.Text = "Configuración";
			// 
			// modificarUsuarioToolStripMenuItem
			// 
			this.modificarUsuarioToolStripMenuItem.Name = "modificarUsuarioToolStripMenuItem";
			this.modificarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
			this.modificarUsuarioToolStripMenuItem.Text = "Modificar Usuario";
			this.modificarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.modificarUsuarioToolStripMenuItem_Click);
			// 
			// cerrarSesiónToolStripMenuItem
			// 
			this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
			this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
			this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
			this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
			// 
			// informaciónToolStripMenuItem
			// 
			this.informaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaciónVuelosToolStripMenuItem,
            this.informaciónAvionesToolStripMenuItem,
            this.informaciónClientesToolStripMenuItem});
			this.informaciónToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
			this.informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
			this.informaciónToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.informaciónToolStripMenuItem.Text = "Información";
			// 
			// informaciónVuelosToolStripMenuItem
			// 
			this.informaciónVuelosToolStripMenuItem.Name = "informaciónVuelosToolStripMenuItem";
			this.informaciónVuelosToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
			this.informaciónVuelosToolStripMenuItem.Text = "Información Vuelos";
			this.informaciónVuelosToolStripMenuItem.Click += new System.EventHandler(this.informaciónVuelosToolStripMenuItem_Click);
			// 
			// informaciónAvionesToolStripMenuItem
			// 
			this.informaciónAvionesToolStripMenuItem.Name = "informaciónAvionesToolStripMenuItem";
			this.informaciónAvionesToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
			this.informaciónAvionesToolStripMenuItem.Text = "Información Aviones";
			this.informaciónAvionesToolStripMenuItem.Click += new System.EventHandler(this.informaciónAvionesToolStripMenuItem_Click);
			// 
			// informaciónClientesToolStripMenuItem
			// 
			this.informaciónClientesToolStripMenuItem.Name = "informaciónClientesToolStripMenuItem";
			this.informaciónClientesToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
			this.informaciónClientesToolStripMenuItem.Text = "Información Clientes";
			this.informaciónClientesToolStripMenuItem.Click += new System.EventHandler(this.informaciónClientesToolStripMenuItem_Click);
			// 
			// venderPasajesToolStripMenuItem
			// 
			this.venderPasajesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.venderToolStripMenuItem,
            this.modificarToolStripMenuItem});
			this.venderPasajesToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
			this.venderPasajesToolStripMenuItem.Name = "venderPasajesToolStripMenuItem";
			this.venderPasajesToolStripMenuItem.Size = new System.Drawing.Size(78, 22);
			this.venderPasajesToolStripMenuItem.Text = "Pasajes";
			// 
			// venderToolStripMenuItem
			// 
			this.venderToolStripMenuItem.Name = "venderToolStripMenuItem";
			this.venderToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.venderToolStripMenuItem.Text = "Vender";
			this.venderToolStripMenuItem.Click += new System.EventHandler(this.venderToolStripMenuItem_Click);
			// 
			// modificarToolStripMenuItem
			// 
			this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
			this.modificarToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.modificarToolStripMenuItem.Text = "Modificar";
			this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
			// 
			// añadirAvionToolStripMenuItem
			// 
			this.añadirAvionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoAvionToolStripMenuItem,
            this.modificarAvionToolStripMenuItem});
			this.añadirAvionToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
			this.añadirAvionToolStripMenuItem.Name = "añadirAvionToolStripMenuItem";
			this.añadirAvionToolStripMenuItem.Size = new System.Drawing.Size(84, 22);
			this.añadirAvionToolStripMenuItem.Text = "Aviones";
			// 
			// nuevoAvionToolStripMenuItem
			// 
			this.nuevoAvionToolStripMenuItem.Name = "nuevoAvionToolStripMenuItem";
			this.nuevoAvionToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.nuevoAvionToolStripMenuItem.Text = "Nuevo Avion";
			this.nuevoAvionToolStripMenuItem.Click += new System.EventHandler(this.nuevoAvionToolStripMenuItem_Click);
			// 
			// modificarAvionToolStripMenuItem
			// 
			this.modificarAvionToolStripMenuItem.Name = "modificarAvionToolStripMenuItem";
			this.modificarAvionToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
			this.modificarAvionToolStripMenuItem.Text = "Modificar Avion";
			this.modificarAvionToolStripMenuItem.Click += new System.EventHandler(this.modificarAvionToolStripMenuItem_Click);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(55, 22);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
			// 
			// FrmPantallaPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(920, 617);
			this.Controls.Add(menuStrip1);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "FrmPantallaPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
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
		private ToolStripMenuItem informaciónClientesToolStripMenuItem;
		private ToolStripMenuItem venderPasajesToolStripMenuItem;
		private ToolStripMenuItem venderToolStripMenuItem;
		private ToolStripMenuItem modificarToolStripMenuItem;
		private ToolStripMenuItem añadirAvionToolStripMenuItem;
		private ToolStripMenuItem nuevoAvionToolStripMenuItem;
		private ToolStripMenuItem modificarAvionToolStripMenuItem;
		private ToolStripMenuItem salirToolStripMenuItem;
	}
}