namespace VistaAerolinea {
	partial class FrmInformesVuelo {
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
			this.gb_historialVuelos = new System.Windows.Forms.GroupBox();
			this.gb_filtros = new System.Windows.Forms.GroupBox();
			this.rdb_historialCompleto = new System.Windows.Forms.RadioButton();
			this.rdb_vuelosActuales = new System.Windows.Forms.RadioButton();
			this.rdb_vuelosAntiguos = new System.Windows.Forms.RadioButton();
			this.dgw_vuelosMostrar = new System.Windows.Forms.DataGridView();
			this.gb_historialVuelos.SuspendLayout();
			this.gb_filtros.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgw_vuelosMostrar)).BeginInit();
			this.SuspendLayout();
			// 
			// gb_historialVuelos
			// 
			this.gb_historialVuelos.Controls.Add(this.gb_filtros);
			this.gb_historialVuelos.Controls.Add(this.dgw_vuelosMostrar);
			this.gb_historialVuelos.Location = new System.Drawing.Point(12, 12);
			this.gb_historialVuelos.Name = "gb_historialVuelos";
			this.gb_historialVuelos.Size = new System.Drawing.Size(956, 501);
			this.gb_historialVuelos.TabIndex = 0;
			this.gb_historialVuelos.TabStop = false;
			this.gb_historialVuelos.Text = "Información Vuelos:";
			// 
			// gb_filtros
			// 
			this.gb_filtros.Controls.Add(this.rdb_historialCompleto);
			this.gb_filtros.Controls.Add(this.rdb_vuelosActuales);
			this.gb_filtros.Controls.Add(this.rdb_vuelosAntiguos);
			this.gb_filtros.Location = new System.Drawing.Point(6, 25);
			this.gb_filtros.Name = "gb_filtros";
			this.gb_filtros.Size = new System.Drawing.Size(509, 64);
			this.gb_filtros.TabIndex = 1;
			this.gb_filtros.TabStop = false;
			this.gb_filtros.Text = "Filtros: ";
			// 
			// rdb_historialCompleto
			// 
			this.rdb_historialCompleto.AutoSize = true;
			this.rdb_historialCompleto.Location = new System.Drawing.Point(6, 25);
			this.rdb_historialCompleto.Name = "rdb_historialCompleto";
			this.rdb_historialCompleto.Size = new System.Drawing.Size(177, 22);
			this.rdb_historialCompleto.TabIndex = 2;
			this.rdb_historialCompleto.TabStop = true;
			this.rdb_historialCompleto.Text = "Historial Completo";
			this.rdb_historialCompleto.UseVisualStyleBackColor = true;
			this.rdb_historialCompleto.CheckedChanged += new System.EventHandler(this.rdb_historialCompleto_CheckedChanged);
			// 
			// rdb_vuelosActuales
			// 
			this.rdb_vuelosActuales.AutoSize = true;
			this.rdb_vuelosActuales.Location = new System.Drawing.Point(352, 25);
			this.rdb_vuelosActuales.Name = "rdb_vuelosActuales";
			this.rdb_vuelosActuales.Size = new System.Drawing.Size(153, 22);
			this.rdb_vuelosActuales.TabIndex = 1;
			this.rdb_vuelosActuales.TabStop = true;
			this.rdb_vuelosActuales.Text = "Vuelos Actuales";
			this.rdb_vuelosActuales.UseVisualStyleBackColor = true;
			this.rdb_vuelosActuales.CheckedChanged += new System.EventHandler(this.rdb_vuelosActuales_CheckedChanged);
			// 
			// rdb_vuelosAntiguos
			// 
			this.rdb_vuelosAntiguos.AutoSize = true;
			this.rdb_vuelosAntiguos.Location = new System.Drawing.Point(189, 25);
			this.rdb_vuelosAntiguos.Name = "rdb_vuelosAntiguos";
			this.rdb_vuelosAntiguos.Size = new System.Drawing.Size(157, 22);
			this.rdb_vuelosAntiguos.TabIndex = 0;
			this.rdb_vuelosAntiguos.TabStop = true;
			this.rdb_vuelosAntiguos.Text = "Vuelos Antiguos";
			this.rdb_vuelosAntiguos.UseVisualStyleBackColor = true;
			this.rdb_vuelosAntiguos.CheckedChanged += new System.EventHandler(this.rdb_vuelosAntiguos_CheckedChanged);
			// 
			// dgw_vuelosMostrar
			// 
			this.dgw_vuelosMostrar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgw_vuelosMostrar.BackgroundColor = System.Drawing.Color.LightSkyBlue;
			this.dgw_vuelosMostrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgw_vuelosMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgw_vuelosMostrar.Location = new System.Drawing.Point(6, 95);
			this.dgw_vuelosMostrar.MultiSelect = false;
			this.dgw_vuelosMostrar.Name = "dgw_vuelosMostrar";
			this.dgw_vuelosMostrar.RowHeadersVisible = false;
			this.dgw_vuelosMostrar.RowTemplate.Height = 25;
			this.dgw_vuelosMostrar.Size = new System.Drawing.Size(944, 400);
			this.dgw_vuelosMostrar.TabIndex = 0;
			this.dgw_vuelosMostrar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_vuelosMostrar_CellContentClick);
			// 
			// FrmInformesVuelo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSkyBlue;
			this.ClientSize = new System.Drawing.Size(980, 525);
			this.Controls.Add(this.gb_historialVuelos);
			this.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmInformesVuelo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmInformesVuelo";
			this.Load += new System.EventHandler(this.FrmInformesVuelo_Load);
			this.gb_historialVuelos.ResumeLayout(false);
			this.gb_filtros.ResumeLayout(false);
			this.gb_filtros.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgw_vuelosMostrar)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox gb_historialVuelos;
		private DataGridView dgw_vuelosMostrar;
		private GroupBox gb_filtros;
		private RadioButton rdb_historialCompleto;
		private RadioButton rdb_vuelosActuales;
		private RadioButton rdb_vuelosAntiguos;
	}
}