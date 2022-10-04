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
			this.informaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.informaciónVuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.informaciónAvionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.informaciónClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.destinosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.venderPasajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.venderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modificarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lbl_usuarioIngresado = new System.Windows.Forms.Label();
			this.lbl_nombreUsuario = new System.Windows.Forms.Label();
			this.lbl_fechaActual = new System.Windows.Forms.Label();
			this.datosHistorialesDeFacturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.informaciónToolStripMenuItem,
            this.venderPasajesToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.salirToolStripMenuItem});
			menuStrip1.Location = new System.Drawing.Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
			menuStrip1.Size = new System.Drawing.Size(1000, 26);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			// 
			// informaciónToolStripMenuItem
			// 
			this.informaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaciónVuelosToolStripMenuItem,
            this.informaciónAvionesToolStripMenuItem,
            this.informaciónClientesToolStripMenuItem,
            this.destinosToolStripMenuItem,
            this.datosHistorialesDeFacturacionToolStripMenuItem});
			this.informaciónToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
			this.informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
			this.informaciónToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.informaciónToolStripMenuItem.Text = "Informes y Modificaciones";
			// 
			// informaciónVuelosToolStripMenuItem
			// 
			this.informaciónVuelosToolStripMenuItem.Name = "informaciónVuelosToolStripMenuItem";
			this.informaciónVuelosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.informaciónVuelosToolStripMenuItem.Text = "Vuelos";
			this.informaciónVuelosToolStripMenuItem.Click += new System.EventHandler(this.informaciónVuelosToolStripMenuItem_Click_1);
			// 
			// informaciónAvionesToolStripMenuItem
			// 
			this.informaciónAvionesToolStripMenuItem.Name = "informaciónAvionesToolStripMenuItem";
			this.informaciónAvionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.informaciónAvionesToolStripMenuItem.Text = "Aviones";
			this.informaciónAvionesToolStripMenuItem.Click += new System.EventHandler(this.informaciónAvionesToolStripMenuItem_Click);
			// 
			// informaciónClientesToolStripMenuItem
			// 
			this.informaciónClientesToolStripMenuItem.Name = "informaciónClientesToolStripMenuItem";
			this.informaciónClientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.informaciónClientesToolStripMenuItem.Text = "Clientes";
			this.informaciónClientesToolStripMenuItem.Click += new System.EventHandler(this.informaciónClientesToolStripMenuItem_Click);
			// 
			// destinosToolStripMenuItem
			// 
			this.destinosToolStripMenuItem.Name = "destinosToolStripMenuItem";
			this.destinosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.destinosToolStripMenuItem.Text = "Destinos";
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
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(55, 22);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
			// 
			// lbl_usuarioIngresado
			// 
			this.lbl_usuarioIngresado.AutoSize = true;
			this.lbl_usuarioIngresado.BackColor = System.Drawing.Color.LightSkyBlue;
			this.lbl_usuarioIngresado.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_usuarioIngresado.ForeColor = System.Drawing.Color.Black;
			this.lbl_usuarioIngresado.Location = new System.Drawing.Point(305, 659);
			this.lbl_usuarioIngresado.Name = "lbl_usuarioIngresado";
			this.lbl_usuarioIngresado.Size = new System.Drawing.Size(96, 32);
			this.lbl_usuarioIngresado.TabIndex = 2;
			this.lbl_usuarioIngresado.Text = "label1";
			// 
			// lbl_nombreUsuario
			// 
			this.lbl_nombreUsuario.AutoSize = true;
			this.lbl_nombreUsuario.BackColor = System.Drawing.Color.LightSkyBlue;
			this.lbl_nombreUsuario.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_nombreUsuario.ForeColor = System.Drawing.Color.Black;
			this.lbl_nombreUsuario.Location = new System.Drawing.Point(175, 659);
			this.lbl_nombreUsuario.Name = "lbl_nombreUsuario";
			this.lbl_nombreUsuario.Size = new System.Drawing.Size(128, 32);
			this.lbl_nombreUsuario.TabIndex = 3;
			this.lbl_nombreUsuario.Text = "Usuario:";
			// 
			// lbl_fechaActual
			// 
			this.lbl_fechaActual.AutoSize = true;
			this.lbl_fechaActual.BackColor = System.Drawing.Color.LightSkyBlue;
			this.lbl_fechaActual.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lbl_fechaActual.ForeColor = System.Drawing.Color.Black;
			this.lbl_fechaActual.Location = new System.Drawing.Point(12, 659);
			this.lbl_fechaActual.Name = "lbl_fechaActual";
			this.lbl_fechaActual.Size = new System.Drawing.Size(96, 32);
			this.lbl_fechaActual.TabIndex = 4;
			this.lbl_fechaActual.Text = "label1";
			// 
			// datosHistorialesDeFacturacionToolStripMenuItem
			// 
			this.datosHistorialesDeFacturacionToolStripMenuItem.Name = "datosHistorialesDeFacturacionToolStripMenuItem";
			this.datosHistorialesDeFacturacionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.datosHistorialesDeFacturacionToolStripMenuItem.Text = "Facturacion";
			// 
			// FrmPantallaPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1000, 700);
			this.Controls.Add(this.lbl_fechaActual);
			this.Controls.Add(this.lbl_nombreUsuario);
			this.Controls.Add(this.lbl_usuarioIngresado);
			this.Controls.Add(menuStrip1);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "FrmPantallaPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Label lbl_usuarioIngresado;
		private Label lbl_nombreUsuario;
		private Label lbl_fechaActual;
		private ToolStripMenuItem informaciónToolStripMenuItem;
		private ToolStripMenuItem informaciónVuelosToolStripMenuItem;
		private ToolStripMenuItem informaciónAvionesToolStripMenuItem;
		private ToolStripMenuItem informaciónClientesToolStripMenuItem;
		private ToolStripMenuItem venderPasajesToolStripMenuItem;
		private ToolStripMenuItem venderToolStripMenuItem;
		private ToolStripMenuItem modificarToolStripMenuItem;
		private ToolStripMenuItem configuraciónToolStripMenuItem;
		private ToolStripMenuItem modificarUsuarioToolStripMenuItem;
		private ToolStripMenuItem cerrarSesiónToolStripMenuItem;
		private ToolStripMenuItem salirToolStripMenuItem;
		private ToolStripMenuItem destinosToolStripMenuItem;
		private ToolStripMenuItem datosHistorialesDeFacturacionToolStripMenuItem;
	}
}