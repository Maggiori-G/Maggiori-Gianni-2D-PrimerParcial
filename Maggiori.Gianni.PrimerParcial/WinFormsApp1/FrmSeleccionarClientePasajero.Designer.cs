namespace VistaAerolinea {
	partial class FrmSeleccionarClientePasajero {
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
			this.btn_seleccionarCliente = new System.Windows.Forms.Button();
			this.btn_cancelar = new System.Windows.Forms.Button();
			this.btn_venderVuelo = new System.Windows.Forms.Button();
			this.dgw_mostrarClientes = new System.Windows.Forms.DataGridView();
			this.grp_datosDelVuelo = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lbl_esInternacional = new System.Windows.Forms.Label();
			this.grp_equipaje = new System.Windows.Forms.GroupBox();
			this.rdb_tieneBolsoDeMano = new System.Windows.Forms.RadioButton();
			this.lbl_mostrarPeso = new System.Windows.Forms.Label();
			this.btn_repotarPeso = new System.Windows.Forms.Button();
			this.lbl_cantidadValijas = new System.Windows.Forms.Label();
			this.nud_cantidadValijas = new System.Windows.Forms.NumericUpDown();
			this.grp_servicioPeliculas = new System.Windows.Forms.GroupBox();
			this.rdb_noPeliculas = new System.Windows.Forms.RadioButton();
			this.rdb_siPeliculas = new System.Windows.Forms.RadioButton();
			this.grp_comida = new System.Windows.Forms.GroupBox();
			this.chk_comida = new System.Windows.Forms.CheckBox();
			this.cmb_comidas = new System.Windows.Forms.ComboBox();
			this.gb_wifi = new System.Windows.Forms.GroupBox();
			this.chk_wifi = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rtb_datosPaquete = new System.Windows.Forms.RichTextBox();
			this.btn_confirmarPasajero = new System.Windows.Forms.Button();
			this.dgw_pasajerosVuelo = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgw_mostrarClientes)).BeginInit();
			this.grp_datosDelVuelo.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.grp_equipaje.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_cantidadValijas)).BeginInit();
			this.grp_servicioPeliculas.SuspendLayout();
			this.grp_comida.SuspendLayout();
			this.gb_wifi.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgw_pasajerosVuelo)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_seleccionarCliente
			// 
			this.btn_seleccionarCliente.BackColor = System.Drawing.Color.Salmon;
			this.btn_seleccionarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_seleccionarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_seleccionarCliente.Location = new System.Drawing.Point(12, 12);
			this.btn_seleccionarCliente.Name = "btn_seleccionarCliente";
			this.btn_seleccionarCliente.Size = new System.Drawing.Size(173, 33);
			this.btn_seleccionarCliente.TabIndex = 0;
			this.btn_seleccionarCliente.Text = "Seleccionar Cliente";
			this.btn_seleccionarCliente.UseVisualStyleBackColor = false;
			this.btn_seleccionarCliente.Click += new System.EventHandler(this.btn_seleccionarCliente_Click);
			// 
			// btn_cancelar
			// 
			this.btn_cancelar.BackColor = System.Drawing.Color.Salmon;
			this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_cancelar.Location = new System.Drawing.Point(969, 464);
			this.btn_cancelar.Name = "btn_cancelar";
			this.btn_cancelar.Size = new System.Drawing.Size(146, 34);
			this.btn_cancelar.TabIndex = 9;
			this.btn_cancelar.Text = "Cancelar";
			this.btn_cancelar.UseVisualStyleBackColor = false;
			this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
			// 
			// btn_venderVuelo
			// 
			this.btn_venderVuelo.BackColor = System.Drawing.Color.Salmon;
			this.btn_venderVuelo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_venderVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_venderVuelo.Location = new System.Drawing.Point(969, 424);
			this.btn_venderVuelo.Name = "btn_venderVuelo";
			this.btn_venderVuelo.Size = new System.Drawing.Size(146, 34);
			this.btn_venderVuelo.TabIndex = 8;
			this.btn_venderVuelo.Text = "Vender Vuelo";
			this.btn_venderVuelo.UseVisualStyleBackColor = false;
			this.btn_venderVuelo.Click += new System.EventHandler(this.btn_venderVuelo_Click);
			// 
			// dgw_mostrarClientes
			// 
			this.dgw_mostrarClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgw_mostrarClientes.BackgroundColor = System.Drawing.Color.LightSkyBlue;
			this.dgw_mostrarClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgw_mostrarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgw_mostrarClientes.GridColor = System.Drawing.SystemColors.ControlDarkDark;
			this.dgw_mostrarClientes.Location = new System.Drawing.Point(12, 51);
			this.dgw_mostrarClientes.Name = "dgw_mostrarClientes";
			this.dgw_mostrarClientes.RowHeadersVisible = false;
			this.dgw_mostrarClientes.RowTemplate.Height = 25;
			this.dgw_mostrarClientes.Size = new System.Drawing.Size(1106, 152);
			this.dgw_mostrarClientes.TabIndex = 3;
			// 
			// grp_datosDelVuelo
			// 
			this.grp_datosDelVuelo.Controls.Add(this.groupBox2);
			this.grp_datosDelVuelo.Controls.Add(this.grp_equipaje);
			this.grp_datosDelVuelo.Controls.Add(this.grp_servicioPeliculas);
			this.grp_datosDelVuelo.Controls.Add(this.grp_comida);
			this.grp_datosDelVuelo.Controls.Add(this.gb_wifi);
			this.grp_datosDelVuelo.Location = new System.Drawing.Point(12, 365);
			this.grp_datosDelVuelo.Name = "grp_datosDelVuelo";
			this.grp_datosDelVuelo.Size = new System.Drawing.Size(585, 198);
			this.grp_datosDelVuelo.TabIndex = 4;
			this.grp_datosDelVuelo.TabStop = false;
			this.grp_datosDelVuelo.Text = "Informacion del Pasajero";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lbl_esInternacional);
			this.groupBox2.Location = new System.Drawing.Point(393, 25);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(184, 66);
			this.groupBox2.TabIndex = 22;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Tipo de Destino";
			// 
			// lbl_esInternacional
			// 
			this.lbl_esInternacional.AutoSize = true;
			this.lbl_esInternacional.Location = new System.Drawing.Point(0, 25);
			this.lbl_esInternacional.Name = "lbl_esInternacional";
			this.lbl_esInternacional.Size = new System.Drawing.Size(13, 18);
			this.lbl_esInternacional.TabIndex = 0;
			this.lbl_esInternacional.Text = ".";
			// 
			// grp_equipaje
			// 
			this.grp_equipaje.Controls.Add(this.rdb_tieneBolsoDeMano);
			this.grp_equipaje.Controls.Add(this.lbl_mostrarPeso);
			this.grp_equipaje.Controls.Add(this.btn_repotarPeso);
			this.grp_equipaje.Controls.Add(this.lbl_cantidadValijas);
			this.grp_equipaje.Controls.Add(this.nud_cantidadValijas);
			this.grp_equipaje.Location = new System.Drawing.Point(6, 97);
			this.grp_equipaje.Name = "grp_equipaje";
			this.grp_equipaje.Size = new System.Drawing.Size(381, 92);
			this.grp_equipaje.TabIndex = 20;
			this.grp_equipaje.TabStop = false;
			this.grp_equipaje.Text = "Datos Del Equipaje";
			// 
			// rdb_tieneBolsoDeMano
			// 
			this.rdb_tieneBolsoDeMano.AutoSize = true;
			this.rdb_tieneBolsoDeMano.Checked = true;
			this.rdb_tieneBolsoDeMano.Location = new System.Drawing.Point(15, 68);
			this.rdb_tieneBolsoDeMano.Name = "rdb_tieneBolsoDeMano";
			this.rdb_tieneBolsoDeMano.Size = new System.Drawing.Size(143, 22);
			this.rdb_tieneBolsoDeMano.TabIndex = 4;
			this.rdb_tieneBolsoDeMano.TabStop = true;
			this.rdb_tieneBolsoDeMano.Text = "Bolso de Mano";
			this.rdb_tieneBolsoDeMano.UseVisualStyleBackColor = true;
			// 
			// lbl_mostrarPeso
			// 
			this.lbl_mostrarPeso.AutoSize = true;
			this.lbl_mostrarPeso.Location = new System.Drawing.Point(173, 18);
			this.lbl_mostrarPeso.Name = "lbl_mostrarPeso";
			this.lbl_mostrarPeso.Size = new System.Drawing.Size(13, 18);
			this.lbl_mostrarPeso.TabIndex = 5;
			this.lbl_mostrarPeso.Text = ".";
			// 
			// btn_repotarPeso
			// 
			this.btn_repotarPeso.BackColor = System.Drawing.Color.Salmon;
			this.btn_repotarPeso.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_repotarPeso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_repotarPeso.Location = new System.Drawing.Point(210, 29);
			this.btn_repotarPeso.Name = "btn_repotarPeso";
			this.btn_repotarPeso.Size = new System.Drawing.Size(129, 46);
			this.btn_repotarPeso.TabIndex = 5;
			this.btn_repotarPeso.Text = "Reportar Peso de Valijas";
			this.btn_repotarPeso.UseVisualStyleBackColor = false;
			this.btn_repotarPeso.Click += new System.EventHandler(this.btn_repotarPeso_Click);
			// 
			// lbl_cantidadValijas
			// 
			this.lbl_cantidadValijas.AutoSize = true;
			this.lbl_cantidadValijas.Location = new System.Drawing.Point(15, 33);
			this.lbl_cantidadValijas.Name = "lbl_cantidadValijas";
			this.lbl_cantidadValijas.Size = new System.Drawing.Size(118, 18);
			this.lbl_cantidadValijas.TabIndex = 3;
			this.lbl_cantidadValijas.Text = "Cant. Valijas: ";
			// 
			// nud_cantidadValijas
			// 
			this.nud_cantidadValijas.Location = new System.Drawing.Point(129, 31);
			this.nud_cantidadValijas.Name = "nud_cantidadValijas";
			this.nud_cantidadValijas.Size = new System.Drawing.Size(38, 26);
			this.nud_cantidadValijas.TabIndex = 3;
			this.nud_cantidadValijas.ValueChanged += new System.EventHandler(this.nud_cantidadValijas_ValueChanged);
			// 
			// grp_servicioPeliculas
			// 
			this.grp_servicioPeliculas.Controls.Add(this.rdb_noPeliculas);
			this.grp_servicioPeliculas.Controls.Add(this.rdb_siPeliculas);
			this.grp_servicioPeliculas.Location = new System.Drawing.Point(393, 97);
			this.grp_servicioPeliculas.Name = "grp_servicioPeliculas";
			this.grp_servicioPeliculas.Size = new System.Drawing.Size(184, 77);
			this.grp_servicioPeliculas.TabIndex = 19;
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
			this.rdb_siPeliculas.TabIndex = 6;
			this.rdb_siPeliculas.TabStop = true;
			this.rdb_siPeliculas.Text = "Si";
			this.rdb_siPeliculas.UseVisualStyleBackColor = true;
			// 
			// grp_comida
			// 
			this.grp_comida.Controls.Add(this.chk_comida);
			this.grp_comida.Controls.Add(this.cmb_comidas);
			this.grp_comida.Location = new System.Drawing.Point(6, 25);
			this.grp_comida.Name = "grp_comida";
			this.grp_comida.Size = new System.Drawing.Size(204, 66);
			this.grp_comida.TabIndex = 17;
			this.grp_comida.TabStop = false;
			this.grp_comida.Text = "Desea Incluir Comida";
			// 
			// chk_comida
			// 
			this.chk_comida.AutoSize = true;
			this.chk_comida.Location = new System.Drawing.Point(6, 25);
			this.chk_comida.Name = "chk_comida";
			this.chk_comida.Size = new System.Drawing.Size(41, 22);
			this.chk_comida.TabIndex = 1;
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
			// gb_wifi
			// 
			this.gb_wifi.Controls.Add(this.chk_wifi);
			this.gb_wifi.Location = new System.Drawing.Point(216, 25);
			this.gb_wifi.Name = "gb_wifi";
			this.gb_wifi.Size = new System.Drawing.Size(171, 66);
			this.gb_wifi.TabIndex = 16;
			this.gb_wifi.TabStop = false;
			this.gb_wifi.Text = "Desea Incluir Wifi";
			// 
			// chk_wifi
			// 
			this.chk_wifi.AutoSize = true;
			this.chk_wifi.Location = new System.Drawing.Point(6, 25);
			this.chk_wifi.Name = "chk_wifi";
			this.chk_wifi.Size = new System.Drawing.Size(41, 22);
			this.chk_wifi.TabIndex = 2;
			this.chk_wifi.Text = "Si";
			this.chk_wifi.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rtb_datosPaquete);
			this.groupBox1.Location = new System.Drawing.Point(603, 365);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(363, 198);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Datos de la Facturación";
			// 
			// rtb_datosPaquete
			// 
			this.rtb_datosPaquete.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtb_datosPaquete.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtb_datosPaquete.Location = new System.Drawing.Point(3, 22);
			this.rtb_datosPaquete.Name = "rtb_datosPaquete";
			this.rtb_datosPaquete.ReadOnly = true;
			this.rtb_datosPaquete.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.rtb_datosPaquete.Size = new System.Drawing.Size(357, 173);
			this.rtb_datosPaquete.TabIndex = 0;
			this.rtb_datosPaquete.Text = "";
			// 
			// btn_confirmarPasajero
			// 
			this.btn_confirmarPasajero.BackColor = System.Drawing.Color.Salmon;
			this.btn_confirmarPasajero.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_confirmarPasajero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_confirmarPasajero.Location = new System.Drawing.Point(969, 374);
			this.btn_confirmarPasajero.Name = "btn_confirmarPasajero";
			this.btn_confirmarPasajero.Size = new System.Drawing.Size(146, 44);
			this.btn_confirmarPasajero.TabIndex = 7;
			this.btn_confirmarPasajero.Text = "Confirmar Pasajero";
			this.btn_confirmarPasajero.UseVisualStyleBackColor = false;
			this.btn_confirmarPasajero.Click += new System.EventHandler(this.btn_confirmarPasajero_Click);
			// 
			// dgw_pasajerosVuelo
			// 
			this.dgw_pasajerosVuelo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgw_pasajerosVuelo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgw_pasajerosVuelo.BackgroundColor = System.Drawing.Color.LightSkyBlue;
			this.dgw_pasajerosVuelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgw_pasajerosVuelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgw_pasajerosVuelo.GridColor = System.Drawing.SystemColors.ControlDarkDark;
			this.dgw_pasajerosVuelo.Location = new System.Drawing.Point(12, 209);
			this.dgw_pasajerosVuelo.Name = "dgw_pasajerosVuelo";
			this.dgw_pasajerosVuelo.RowHeadersVisible = false;
			this.dgw_pasajerosVuelo.RowTemplate.Height = 25;
			this.dgw_pasajerosVuelo.Size = new System.Drawing.Size(1106, 150);
			this.dgw_pasajerosVuelo.TabIndex = 7;
			// 
			// FrmSeleccionarClientePasajero
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSkyBlue;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(1127, 572);
			this.Controls.Add(this.dgw_pasajerosVuelo);
			this.Controls.Add(this.btn_confirmarPasajero);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.grp_datosDelVuelo);
			this.Controls.Add(this.dgw_mostrarClientes);
			this.Controls.Add(this.btn_venderVuelo);
			this.Controls.Add(this.btn_cancelar);
			this.Controls.Add(this.btn_seleccionarCliente);
			this.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmSeleccionarClientePasajero";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmSeleccionarClientePasajero";
			this.Load += new System.EventHandler(this.FrmSeleccionarClientePasajero_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgw_mostrarClientes)).EndInit();
			this.grp_datosDelVuelo.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.grp_equipaje.ResumeLayout(false);
			this.grp_equipaje.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_cantidadValijas)).EndInit();
			this.grp_servicioPeliculas.ResumeLayout(false);
			this.grp_servicioPeliculas.PerformLayout();
			this.grp_comida.ResumeLayout(false);
			this.grp_comida.PerformLayout();
			this.gb_wifi.ResumeLayout(false);
			this.gb_wifi.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgw_pasajerosVuelo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Button btn_seleccionarCliente;
		private Button btn_cancelar;
		private Button btn_venderVuelo;
		private DataGridView dgw_mostrarClientes;
		private GroupBox grp_datosDelVuelo;
		private GroupBox grp_servicioPeliculas;
		private RadioButton rdb_noPeliculas;
		private RadioButton rdb_siPeliculas;
		private GroupBox grp_comida;
		private CheckBox chk_comida;
		private ComboBox cmb_comidas;
		private GroupBox gb_wifi;
		private CheckBox chk_wifi;
		private GroupBox grp_equipaje;
		private GroupBox groupBox1;
		private Button btn_confirmarPasajero;
		private DataGridView dgw_pasajerosVuelo;
		private Label lbl_cantidadValijas;
		private NumericUpDown nud_cantidadValijas;
		private Button btn_repotarPeso;
		private Label lbl_mostrarPeso;
		private RadioButton rdb_tieneBolsoDeMano;
		private GroupBox groupBox2;
		private Label lbl_esInternacional;
		private RichTextBox rtb_datosPaquete;
	}
}