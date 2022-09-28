namespace VistaAerolinea {
	partial class frmVentasDePasajes {
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
			this.dgw_vuelosDisponibles = new System.Windows.Forms.DataGridView();
			this.cmb_origen = new System.Windows.Forms.ComboBox();
			this.gb_origen = new System.Windows.Forms.GroupBox();
			this.gb_wifi = new System.Windows.Forms.GroupBox();
			this.chk_wifi = new System.Windows.Forms.CheckBox();
			this.grp_comida = new System.Windows.Forms.GroupBox();
			this.chk_comida = new System.Windows.Forms.CheckBox();
			this.cmb_comidas = new System.Windows.Forms.ComboBox();
			this.gb_destino = new System.Windows.Forms.GroupBox();
			this.cmb_destino = new System.Windows.Forms.ComboBox();
			this.nud_asientos = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_buscarVuelo = new System.Windows.Forms.Button();
			this.grp_categoriaPasajero = new System.Windows.Forms.GroupBox();
			this.rdb_ejecutiva = new System.Windows.Forms.RadioButton();
			this.rdb_comercial = new System.Windows.Forms.RadioButton();
			this.grp_servicioPeliculas = new System.Windows.Forms.GroupBox();
			this.rdb_noPeliculas = new System.Windows.Forms.RadioButton();
			this.rdb_siPeliculas = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.dgw_vuelosDisponibles)).BeginInit();
			this.gb_origen.SuspendLayout();
			this.gb_wifi.SuspendLayout();
			this.grp_comida.SuspendLayout();
			this.gb_destino.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_asientos)).BeginInit();
			this.grp_categoriaPasajero.SuspendLayout();
			this.grp_servicioPeliculas.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgw_vuelosDisponibles
			// 
			this.dgw_vuelosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgw_vuelosDisponibles.Location = new System.Drawing.Point(12, 262);
			this.dgw_vuelosDisponibles.Name = "dgw_vuelosDisponibles";
			this.dgw_vuelosDisponibles.RowTemplate.Height = 25;
			this.dgw_vuelosDisponibles.Size = new System.Drawing.Size(956, 251);
			this.dgw_vuelosDisponibles.TabIndex = 3;
			this.dgw_vuelosDisponibles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_vuelosDisponibles_CellContentClick);
			// 
			// cmb_origen
			// 
			this.cmb_origen.FormattingEnabled = true;
			this.cmb_origen.Location = new System.Drawing.Point(6, 25);
			this.cmb_origen.Name = "cmb_origen";
			this.cmb_origen.Size = new System.Drawing.Size(188, 26);
			this.cmb_origen.TabIndex = 4;
			this.cmb_origen.SelectedIndexChanged += new System.EventHandler(this.cmb_origen_SelectedIndexChanged);
			// 
			// gb_origen
			// 
			this.gb_origen.Controls.Add(this.cmb_origen);
			this.gb_origen.Location = new System.Drawing.Point(12, 12);
			this.gb_origen.Name = "gb_origen";
			this.gb_origen.Size = new System.Drawing.Size(200, 66);
			this.gb_origen.TabIndex = 5;
			this.gb_origen.TabStop = false;
			this.gb_origen.Text = "Origen: ";
			// 
			// gb_wifi
			// 
			this.gb_wifi.Controls.Add(this.chk_wifi);
			this.gb_wifi.Location = new System.Drawing.Point(630, 12);
			this.gb_wifi.Name = "gb_wifi";
			this.gb_wifi.Size = new System.Drawing.Size(171, 66);
			this.gb_wifi.TabIndex = 8;
			this.gb_wifi.TabStop = false;
			this.gb_wifi.Text = "Desea Incluir Wifi";
			// 
			// chk_wifi
			// 
			this.chk_wifi.AutoSize = true;
			this.chk_wifi.Checked = true;
			this.chk_wifi.CheckState = System.Windows.Forms.CheckState.Indeterminate;
			this.chk_wifi.Location = new System.Drawing.Point(6, 25);
			this.chk_wifi.Name = "chk_wifi";
			this.chk_wifi.Size = new System.Drawing.Size(41, 22);
			this.chk_wifi.TabIndex = 0;
			this.chk_wifi.Text = "Si";
			this.chk_wifi.UseVisualStyleBackColor = true;
			// 
			// grp_comida
			// 
			this.grp_comida.Controls.Add(this.chk_comida);
			this.grp_comida.Controls.Add(this.cmb_comidas);
			this.grp_comida.Location = new System.Drawing.Point(424, 12);
			this.grp_comida.Name = "grp_comida";
			this.grp_comida.Size = new System.Drawing.Size(200, 66);
			this.grp_comida.TabIndex = 9;
			this.grp_comida.TabStop = false;
			this.grp_comida.Text = "Desea Incluir Comida";
			// 
			// chk_comida
			// 
			this.chk_comida.AutoSize = true;
			this.chk_comida.Checked = true;
			this.chk_comida.CheckState = System.Windows.Forms.CheckState.Indeterminate;
			this.chk_comida.Location = new System.Drawing.Point(6, 25);
			this.chk_comida.Name = "chk_comida";
			this.chk_comida.Size = new System.Drawing.Size(41, 22);
			this.chk_comida.TabIndex = 14;
			this.chk_comida.Text = "Si";
			this.chk_comida.UseVisualStyleBackColor = true;
			this.chk_comida.CheckedChanged += new System.EventHandler(this.chk_comida_CheckedChanged);
			// 
			// cmb_comidas
			// 
			this.cmb_comidas.FormattingEnabled = true;
			this.cmb_comidas.Location = new System.Drawing.Point(53, 23);
			this.cmb_comidas.Name = "cmb_comidas";
			this.cmb_comidas.Size = new System.Drawing.Size(121, 26);
			this.cmb_comidas.TabIndex = 13;
			// 
			// gb_destino
			// 
			this.gb_destino.Controls.Add(this.cmb_destino);
			this.gb_destino.Location = new System.Drawing.Point(218, 12);
			this.gb_destino.Name = "gb_destino";
			this.gb_destino.Size = new System.Drawing.Size(200, 66);
			this.gb_destino.TabIndex = 10;
			this.gb_destino.TabStop = false;
			this.gb_destino.Text = "Destino: ";
			// 
			// cmb_destino
			// 
			this.cmb_destino.FormattingEnabled = true;
			this.cmb_destino.Location = new System.Drawing.Point(6, 25);
			this.cmb_destino.Name = "cmb_destino";
			this.cmb_destino.Size = new System.Drawing.Size(188, 26);
			this.cmb_destino.TabIndex = 4;
			// 
			// nud_asientos
			// 
			this.nud_asientos.Location = new System.Drawing.Point(187, 92);
			this.nud_asientos.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
			this.nud_asientos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nud_asientos.Name = "nud_asientos";
			this.nud_asientos.Size = new System.Drawing.Size(120, 26);
			this.nud_asientos.TabIndex = 11;
			this.nud_asientos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 94);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(169, 18);
			this.label1.TabIndex = 12;
			this.label1.Text = "Cantidad de Tickets";
			// 
			// btn_buscarVuelo
			// 
			this.btn_buscarVuelo.Location = new System.Drawing.Point(833, 146);
			this.btn_buscarVuelo.Name = "btn_buscarVuelo";
			this.btn_buscarVuelo.Size = new System.Drawing.Size(135, 38);
			this.btn_buscarVuelo.TabIndex = 13;
			this.btn_buscarVuelo.Text = "Buscar Vuelo";
			this.btn_buscarVuelo.UseVisualStyleBackColor = true;
			this.btn_buscarVuelo.Click += new System.EventHandler(this.btn_buscarVuelo_Click);
			// 
			// grp_categoriaPasajero
			// 
			this.grp_categoriaPasajero.Controls.Add(this.rdb_ejecutiva);
			this.grp_categoriaPasajero.Controls.Add(this.rdb_comercial);
			this.grp_categoriaPasajero.Location = new System.Drawing.Point(424, 84);
			this.grp_categoriaPasajero.Name = "grp_categoriaPasajero";
			this.grp_categoriaPasajero.Size = new System.Drawing.Size(204, 100);
			this.grp_categoriaPasajero.TabIndex = 14;
			this.grp_categoriaPasajero.TabStop = false;
			this.grp_categoriaPasajero.Text = "Categoria de Pasajero: ";
			// 
			// rdb_ejecutiva
			// 
			this.rdb_ejecutiva.AutoSize = true;
			this.rdb_ejecutiva.Location = new System.Drawing.Point(21, 53);
			this.rdb_ejecutiva.Name = "rdb_ejecutiva";
			this.rdb_ejecutiva.Size = new System.Drawing.Size(100, 22);
			this.rdb_ejecutiva.TabIndex = 1;
			this.rdb_ejecutiva.Text = "Ejecutiva";
			this.rdb_ejecutiva.UseVisualStyleBackColor = true;
			// 
			// rdb_comercial
			// 
			this.rdb_comercial.AutoSize = true;
			this.rdb_comercial.Checked = true;
			this.rdb_comercial.Location = new System.Drawing.Point(21, 25);
			this.rdb_comercial.Name = "rdb_comercial";
			this.rdb_comercial.Size = new System.Drawing.Size(107, 22);
			this.rdb_comercial.TabIndex = 0;
			this.rdb_comercial.TabStop = true;
			this.rdb_comercial.Text = "Comercial";
			this.rdb_comercial.UseVisualStyleBackColor = true;
			// 
			// grp_servicioPeliculas
			// 
			this.grp_servicioPeliculas.Controls.Add(this.rdb_noPeliculas);
			this.grp_servicioPeliculas.Controls.Add(this.rdb_siPeliculas);
			this.grp_servicioPeliculas.Location = new System.Drawing.Point(636, 84);
			this.grp_servicioPeliculas.Name = "grp_servicioPeliculas";
			this.grp_servicioPeliculas.Size = new System.Drawing.Size(190, 100);
			this.grp_servicioPeliculas.TabIndex = 15;
			this.grp_servicioPeliculas.TabStop = false;
			this.grp_servicioPeliculas.Text = "Desea Ver Peliculas:";
			// 
			// rdb_noPeliculas
			// 
			this.rdb_noPeliculas.AutoSize = true;
			this.rdb_noPeliculas.Location = new System.Drawing.Point(23, 53);
			this.rdb_noPeliculas.Name = "rdb_noPeliculas";
			this.rdb_noPeliculas.Size = new System.Drawing.Size(48, 22);
			this.rdb_noPeliculas.TabIndex = 3;
			this.rdb_noPeliculas.Text = "No";
			this.rdb_noPeliculas.UseVisualStyleBackColor = true;
			// 
			// rdb_siPeliculas
			// 
			this.rdb_siPeliculas.AutoSize = true;
			this.rdb_siPeliculas.Checked = true;
			this.rdb_siPeliculas.Location = new System.Drawing.Point(23, 25);
			this.rdb_siPeliculas.Name = "rdb_siPeliculas";
			this.rdb_siPeliculas.Size = new System.Drawing.Size(40, 22);
			this.rdb_siPeliculas.TabIndex = 2;
			this.rdb_siPeliculas.TabStop = true;
			this.rdb_siPeliculas.Text = "Si";
			this.rdb_siPeliculas.UseVisualStyleBackColor = true;
			// 
			// frmVentasDePasajes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(980, 525);
			this.Controls.Add(this.grp_servicioPeliculas);
			this.Controls.Add(this.grp_categoriaPasajero);
			this.Controls.Add(this.btn_buscarVuelo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nud_asientos);
			this.Controls.Add(this.gb_destino);
			this.Controls.Add(this.grp_comida);
			this.Controls.Add(this.gb_wifi);
			this.Controls.Add(this.gb_origen);
			this.Controls.Add(this.dgw_vuelosDisponibles);
			this.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "frmVentasDePasajes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmVentasDePasajes";
			this.Load += new System.EventHandler(this.frmVentasDePasajes_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgw_vuelosDisponibles)).EndInit();
			this.gb_origen.ResumeLayout(false);
			this.gb_wifi.ResumeLayout(false);
			this.gb_wifi.PerformLayout();
			this.grp_comida.ResumeLayout(false);
			this.grp_comida.PerformLayout();
			this.gb_destino.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nud_asientos)).EndInit();
			this.grp_categoriaPasajero.ResumeLayout(false);
			this.grp_categoriaPasajero.PerformLayout();
			this.grp_servicioPeliculas.ResumeLayout(false);
			this.grp_servicioPeliculas.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private DataGridView dgw_vuelosDisponibles;
		private ComboBox cmb_origen;
		private GroupBox gb_origen;
		private GroupBox gb_wifi;
		private GroupBox grp_comida;
		private GroupBox gb_destino;
		private ComboBox cmb_destino;
		private NumericUpDown nud_asientos;
		private Label label1;
		private ComboBox cmb_comidas;
		private CheckBox chk_comida;
		private CheckBox chk_wifi;
		private Button btn_buscarVuelo;
		private GroupBox grp_categoriaPasajero;
		private RadioButton rdb_ejecutiva;
		private RadioButton rdb_comercial;
		private GroupBox grp_servicioPeliculas;
		private RadioButton rdb_noPeliculas;
		private RadioButton rdb_siPeliculas;
	}
}