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
			this.gb_destino = new System.Windows.Forms.GroupBox();
			this.cmb_destino = new System.Windows.Forms.ComboBox();
			this.nud_asientos = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_buscarVuelo = new System.Windows.Forms.Button();
			this.grp_categoriaPasajero = new System.Windows.Forms.GroupBox();
			this.rdb_ejecutiva = new System.Windows.Forms.RadioButton();
			this.rdb_comercial = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.dgw_vuelosDisponibles)).BeginInit();
			this.gb_origen.SuspendLayout();
			this.gb_destino.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_asientos)).BeginInit();
			this.grp_categoriaPasajero.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgw_vuelosDisponibles
			// 
			this.dgw_vuelosDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgw_vuelosDisponibles.BackgroundColor = System.Drawing.Color.LightSkyBlue;
			this.dgw_vuelosDisponibles.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgw_vuelosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgw_vuelosDisponibles.Location = new System.Drawing.Point(12, 146);
			this.dgw_vuelosDisponibles.Name = "dgw_vuelosDisponibles";
			this.dgw_vuelosDisponibles.RowHeadersVisible = false;
			this.dgw_vuelosDisponibles.RowTemplate.Height = 25;
			this.dgw_vuelosDisponibles.Size = new System.Drawing.Size(956, 367);
			this.dgw_vuelosDisponibles.TabIndex = 3;
			this.dgw_vuelosDisponibles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_vuelosDisponibles_CellContentClick);
			// 
			// cmb_origen
			// 
			this.cmb_origen.FormattingEnabled = true;
			this.cmb_origen.Location = new System.Drawing.Point(6, 25);
			this.cmb_origen.Name = "cmb_origen";
			this.cmb_origen.Size = new System.Drawing.Size(198, 26);
			this.cmb_origen.TabIndex = 4;
			this.cmb_origen.SelectedIndexChanged += new System.EventHandler(this.cmb_origen_SelectedIndexChanged);
			// 
			// gb_origen
			// 
			this.gb_origen.Controls.Add(this.cmb_origen);
			this.gb_origen.Location = new System.Drawing.Point(12, 12);
			this.gb_origen.Name = "gb_origen";
			this.gb_origen.Size = new System.Drawing.Size(210, 66);
			this.gb_origen.TabIndex = 5;
			this.gb_origen.TabStop = false;
			this.gb_origen.Text = "Origen: ";
			// 
			// gb_destino
			// 
			this.gb_destino.Controls.Add(this.cmb_destino);
			this.gb_destino.Location = new System.Drawing.Point(228, 12);
			this.gb_destino.Name = "gb_destino";
			this.gb_destino.Size = new System.Drawing.Size(210, 66);
			this.gb_destino.TabIndex = 10;
			this.gb_destino.TabStop = false;
			this.gb_destino.Text = "Destino: ";
			// 
			// cmb_destino
			// 
			this.cmb_destino.FormattingEnabled = true;
			this.cmb_destino.Location = new System.Drawing.Point(6, 25);
			this.cmb_destino.Name = "cmb_destino";
			this.cmb_destino.Size = new System.Drawing.Size(198, 26);
			this.cmb_destino.TabIndex = 4;
			// 
			// nud_asientos
			// 
			this.nud_asientos.Location = new System.Drawing.Point(626, 33);
			this.nud_asientos.Maximum = new decimal(new int[] {
            5,
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
			this.label1.Location = new System.Drawing.Point(451, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(169, 18);
			this.label1.TabIndex = 12;
			this.label1.Text = "Cantidad de Tickets";
			// 
			// btn_buscarVuelo
			// 
			this.btn_buscarVuelo.BackColor = System.Drawing.Color.Salmon;
			this.btn_buscarVuelo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_buscarVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_buscarVuelo.Location = new System.Drawing.Point(764, 25);
			this.btn_buscarVuelo.Name = "btn_buscarVuelo";
			this.btn_buscarVuelo.Size = new System.Drawing.Size(182, 38);
			this.btn_buscarVuelo.TabIndex = 13;
			this.btn_buscarVuelo.Text = "Buscar Vuelo";
			this.btn_buscarVuelo.UseVisualStyleBackColor = false;
			this.btn_buscarVuelo.Click += new System.EventHandler(this.btn_buscarVuelo_Click);
			// 
			// grp_categoriaPasajero
			// 
			this.grp_categoriaPasajero.Controls.Add(this.rdb_ejecutiva);
			this.grp_categoriaPasajero.Controls.Add(this.rdb_comercial);
			this.grp_categoriaPasajero.Location = new System.Drawing.Point(12, 84);
			this.grp_categoriaPasajero.Name = "grp_categoriaPasajero";
			this.grp_categoriaPasajero.Size = new System.Drawing.Size(237, 56);
			this.grp_categoriaPasajero.TabIndex = 19;
			this.grp_categoriaPasajero.TabStop = false;
			this.grp_categoriaPasajero.Text = "Categoria de Pasajero: ";
			// 
			// rdb_ejecutiva
			// 
			this.rdb_ejecutiva.AutoSize = true;
			this.rdb_ejecutiva.Location = new System.Drawing.Point(134, 25);
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
			// frmVentasDePasajes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSkyBlue;
			this.ClientSize = new System.Drawing.Size(980, 525);
			this.Controls.Add(this.grp_categoriaPasajero);
			this.Controls.Add(this.btn_buscarVuelo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nud_asientos);
			this.Controls.Add(this.gb_destino);
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
			this.gb_destino.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nud_asientos)).EndInit();
			this.grp_categoriaPasajero.ResumeLayout(false);
			this.grp_categoriaPasajero.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private DataGridView dgw_vuelosDisponibles;
		private ComboBox cmb_origen;
		private GroupBox gb_origen;
		private GroupBox gb_destino;
		private ComboBox cmb_destino;
		private NumericUpDown nud_asientos;
		private Label label1;
		private Button btn_buscarVuelo;
		private GroupBox grp_categoriaPasajero;
		private RadioButton rdb_ejecutiva;
		private RadioButton rdb_comercial;
	}
}