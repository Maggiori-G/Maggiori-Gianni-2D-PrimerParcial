namespace VistaAerolinea {
	partial class FrmInformacionEspecificaVuelo {
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
			this.gb_listaPasajeros = new System.Windows.Forms.GroupBox();
			this.dgw_listaPasajeros = new System.Windows.Forms.DataGridView();
			this.btn_volver = new System.Windows.Forms.Button();
			this.gb_informacionPasajero = new System.Windows.Forms.GroupBox();
			this.lbl_tipoPasajero = new System.Windows.Forms.Label();
			this.lbl_clase = new System.Windows.Forms.Label();
			this.lbl_contratoWifi = new System.Windows.Forms.Label();
			this.lbl_wifi = new System.Windows.Forms.Label();
			this.lbl_peso = new System.Windows.Forms.Label();
			this.lbl_comidaOrdenada = new System.Windows.Forms.Label();
			this.lbl_pesoValijas = new System.Windows.Forms.Label();
			this.lbl_tipo = new System.Windows.Forms.Label();
			this.lbl_bolso = new System.Windows.Forms.Label();
			this.lbl_bolsoDeMano = new System.Windows.Forms.Label();
			this.gb_informacionFacturacion = new System.Windows.Forms.GroupBox();
			this.rtb_mostrarDatosFacturacion = new System.Windows.Forms.RichTextBox();
			this.gb_listaPasajeros.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgw_listaPasajeros)).BeginInit();
			this.gb_informacionPasajero.SuspendLayout();
			this.gb_informacionFacturacion.SuspendLayout();
			this.SuspendLayout();
			// 
			// gb_listaPasajeros
			// 
			this.gb_listaPasajeros.Controls.Add(this.dgw_listaPasajeros);
			this.gb_listaPasajeros.Location = new System.Drawing.Point(11, 12);
			this.gb_listaPasajeros.Name = "gb_listaPasajeros";
			this.gb_listaPasajeros.Size = new System.Drawing.Size(957, 263);
			this.gb_listaPasajeros.TabIndex = 0;
			this.gb_listaPasajeros.TabStop = false;
			this.gb_listaPasajeros.Text = "Lista de pasajeros:";
			// 
			// dgw_listaPasajeros
			// 
			this.dgw_listaPasajeros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgw_listaPasajeros.BackgroundColor = System.Drawing.Color.LightSkyBlue;
			this.dgw_listaPasajeros.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgw_listaPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgw_listaPasajeros.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgw_listaPasajeros.Location = new System.Drawing.Point(3, 22);
			this.dgw_listaPasajeros.Name = "dgw_listaPasajeros";
			this.dgw_listaPasajeros.RowHeadersVisible = false;
			this.dgw_listaPasajeros.RowTemplate.Height = 25;
			this.dgw_listaPasajeros.Size = new System.Drawing.Size(951, 238);
			this.dgw_listaPasajeros.TabIndex = 0;
			this.dgw_listaPasajeros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_listaPasajeros_CellContentClick);
			// 
			// btn_volver
			// 
			this.btn_volver.BackColor = System.Drawing.Color.Salmon;
			this.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_volver.Location = new System.Drawing.Point(893, 490);
			this.btn_volver.Name = "btn_volver";
			this.btn_volver.Size = new System.Drawing.Size(75, 23);
			this.btn_volver.TabIndex = 1;
			this.btn_volver.Text = "Volver";
			this.btn_volver.UseVisualStyleBackColor = false;
			this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
			// 
			// gb_informacionPasajero
			// 
			this.gb_informacionPasajero.Controls.Add(this.lbl_tipoPasajero);
			this.gb_informacionPasajero.Controls.Add(this.lbl_clase);
			this.gb_informacionPasajero.Controls.Add(this.lbl_contratoWifi);
			this.gb_informacionPasajero.Controls.Add(this.lbl_wifi);
			this.gb_informacionPasajero.Controls.Add(this.lbl_peso);
			this.gb_informacionPasajero.Controls.Add(this.lbl_comidaOrdenada);
			this.gb_informacionPasajero.Controls.Add(this.lbl_pesoValijas);
			this.gb_informacionPasajero.Controls.Add(this.lbl_tipo);
			this.gb_informacionPasajero.Controls.Add(this.lbl_bolso);
			this.gb_informacionPasajero.Controls.Add(this.lbl_bolsoDeMano);
			this.gb_informacionPasajero.Location = new System.Drawing.Point(11, 281);
			this.gb_informacionPasajero.Name = "gb_informacionPasajero";
			this.gb_informacionPasajero.Size = new System.Drawing.Size(421, 232);
			this.gb_informacionPasajero.TabIndex = 2;
			this.gb_informacionPasajero.TabStop = false;
			this.gb_informacionPasajero.Text = "Información del Pasajero:";
			// 
			// lbl_tipoPasajero
			// 
			this.lbl_tipoPasajero.AutoSize = true;
			this.lbl_tipoPasajero.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbl_tipoPasajero.Location = new System.Drawing.Point(202, 171);
			this.lbl_tipoPasajero.Name = "lbl_tipoPasajero";
			this.lbl_tipoPasajero.Size = new System.Drawing.Size(61, 18);
			this.lbl_tipoPasajero.TabIndex = 14;
			this.lbl_tipoPasajero.Text = "label2";
			// 
			// lbl_clase
			// 
			this.lbl_clase.AutoSize = true;
			this.lbl_clase.Location = new System.Drawing.Point(47, 171);
			this.lbl_clase.Name = "lbl_clase";
			this.lbl_clase.Size = new System.Drawing.Size(149, 18);
			this.lbl_clase.TabIndex = 13;
			this.lbl_clase.Text = "Tipo de pasajero:";
			// 
			// lbl_contratoWifi
			// 
			this.lbl_contratoWifi.AutoSize = true;
			this.lbl_contratoWifi.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbl_contratoWifi.Location = new System.Drawing.Point(202, 139);
			this.lbl_contratoWifi.Name = "lbl_contratoWifi";
			this.lbl_contratoWifi.Size = new System.Drawing.Size(61, 18);
			this.lbl_contratoWifi.TabIndex = 12;
			this.lbl_contratoWifi.Text = "label9";
			// 
			// lbl_wifi
			// 
			this.lbl_wifi.AutoSize = true;
			this.lbl_wifi.Location = new System.Drawing.Point(76, 139);
			this.lbl_wifi.Name = "lbl_wifi";
			this.lbl_wifi.Size = new System.Drawing.Size(120, 18);
			this.lbl_wifi.TabIndex = 11;
			this.lbl_wifi.Text = "Contrato Wifi:";
			// 
			// lbl_peso
			// 
			this.lbl_peso.AutoSize = true;
			this.lbl_peso.Location = new System.Drawing.Point(65, 45);
			this.lbl_peso.Name = "lbl_peso";
			this.lbl_peso.Size = new System.Drawing.Size(131, 18);
			this.lbl_peso.TabIndex = 3;
			this.lbl_peso.Text = "Peso de valijas:";
			// 
			// lbl_comidaOrdenada
			// 
			this.lbl_comidaOrdenada.AutoSize = true;
			this.lbl_comidaOrdenada.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbl_comidaOrdenada.Location = new System.Drawing.Point(202, 105);
			this.lbl_comidaOrdenada.Name = "lbl_comidaOrdenada";
			this.lbl_comidaOrdenada.Size = new System.Drawing.Size(61, 18);
			this.lbl_comidaOrdenada.TabIndex = 10;
			this.lbl_comidaOrdenada.Text = "label7";
			// 
			// lbl_pesoValijas
			// 
			this.lbl_pesoValijas.AutoSize = true;
			this.lbl_pesoValijas.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbl_pesoValijas.Location = new System.Drawing.Point(202, 45);
			this.lbl_pesoValijas.Name = "lbl_pesoValijas";
			this.lbl_pesoValijas.Size = new System.Drawing.Size(61, 18);
			this.lbl_pesoValijas.TabIndex = 4;
			this.lbl_pesoValijas.Text = "label2";
			// 
			// lbl_tipo
			// 
			this.lbl_tipo.AutoSize = true;
			this.lbl_tipo.Location = new System.Drawing.Point(39, 105);
			this.lbl_tipo.Name = "lbl_tipo";
			this.lbl_tipo.Size = new System.Drawing.Size(157, 18);
			this.lbl_tipo.TabIndex = 9;
			this.lbl_tipo.Text = "Comida ordenada:";
			// 
			// lbl_bolso
			// 
			this.lbl_bolso.AutoSize = true;
			this.lbl_bolso.Location = new System.Drawing.Point(14, 75);
			this.lbl_bolso.Name = "lbl_bolso";
			this.lbl_bolso.Size = new System.Drawing.Size(182, 18);
			this.lbl_bolso.TabIndex = 7;
			this.lbl_bolso.Text = "Tiene bolso de mano:";
			// 
			// lbl_bolsoDeMano
			// 
			this.lbl_bolsoDeMano.AutoSize = true;
			this.lbl_bolsoDeMano.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbl_bolsoDeMano.Location = new System.Drawing.Point(202, 75);
			this.lbl_bolsoDeMano.Name = "lbl_bolsoDeMano";
			this.lbl_bolsoDeMano.Size = new System.Drawing.Size(61, 18);
			this.lbl_bolsoDeMano.TabIndex = 8;
			this.lbl_bolsoDeMano.Text = "label5";
			// 
			// gb_informacionFacturacion
			// 
			this.gb_informacionFacturacion.Controls.Add(this.rtb_mostrarDatosFacturacion);
			this.gb_informacionFacturacion.Location = new System.Drawing.Point(438, 281);
			this.gb_informacionFacturacion.Name = "gb_informacionFacturacion";
			this.gb_informacionFacturacion.Size = new System.Drawing.Size(282, 232);
			this.gb_informacionFacturacion.TabIndex = 3;
			this.gb_informacionFacturacion.TabStop = false;
			this.gb_informacionFacturacion.Text = "Facturación:";
			// 
			// rtb_mostrarDatosFacturacion
			// 
			this.rtb_mostrarDatosFacturacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtb_mostrarDatosFacturacion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtb_mostrarDatosFacturacion.Location = new System.Drawing.Point(3, 22);
			this.rtb_mostrarDatosFacturacion.Name = "rtb_mostrarDatosFacturacion";
			this.rtb_mostrarDatosFacturacion.ReadOnly = true;
			this.rtb_mostrarDatosFacturacion.Size = new System.Drawing.Size(276, 207);
			this.rtb_mostrarDatosFacturacion.TabIndex = 0;
			this.rtb_mostrarDatosFacturacion.Text = "";
			// 
			// FrmInformacionEspecificaVuelo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSkyBlue;
			this.ClientSize = new System.Drawing.Size(980, 525);
			this.Controls.Add(this.gb_informacionPasajero);
			this.Controls.Add(this.gb_informacionFacturacion);
			this.Controls.Add(this.btn_volver);
			this.Controls.Add(this.gb_listaPasajeros);
			this.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmInformacionEspecificaVuelo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmInformacionEspecificaVuelo";
			this.Load += new System.EventHandler(this.FrmInformacionEspecificaVuelo_Load);
			this.gb_listaPasajeros.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgw_listaPasajeros)).EndInit();
			this.gb_informacionPasajero.ResumeLayout(false);
			this.gb_informacionPasajero.PerformLayout();
			this.gb_informacionFacturacion.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox gb_listaPasajeros;
		private DataGridView dgw_listaPasajeros;
		private Button btn_volver;
		private GroupBox gb_informacionPasajero;
		private GroupBox gb_informacionFacturacion;
		private Label lbl_peso;
		private Label lbl_pesoValijas;
		private Label lbl_bolsoDeMano;
		private Label lbl_bolso;
		private Label lbl_comidaOrdenada;
		private Label lbl_tipo;
		private Label lbl_contratoWifi;
		private Label lbl_wifi;
		private RichTextBox rtb_mostrarDatosFacturacion;
		private Label lbl_clase;
		private Label lbl_tipoPasajero;
	}
}