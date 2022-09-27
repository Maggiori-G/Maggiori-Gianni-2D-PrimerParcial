namespace VistaAerolinea {
	partial class FrmInformesAviones {
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lbl_mostrarEstadoAvion = new System.Windows.Forms.Label();
			this.lbl_estadoVuelo = new System.Windows.Forms.Label();
			this.lbl_mostrarPesoMaximoBodega = new System.Windows.Forms.Label();
			this.lbl_pesoMaximoBodega = new System.Windows.Forms.Label();
			this.lbl_mostrarCantidadBaños = new System.Windows.Forms.Label();
			this.lbl_cantidadDebaños = new System.Windows.Forms.Label();
			this.lbl_mostrarCapacidadMaximaDeAsientos = new System.Windows.Forms.Label();
			this.lbl_capacidadMaximaDeAsientos = new System.Windows.Forms.Label();
			this.lbl_mostrarPatente = new System.Windows.Forms.Label();
			this.lbl_patente = new System.Windows.Forms.Label();
			this.cb_seleccionarAvion = new System.Windows.Forms.ComboBox();
			this.lbl_seleccionAvion = new System.Windows.Forms.Label();
			this.dgw_listaPasajerosDeUnVuelo = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgw_listaPasajerosDeUnVuelo)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lbl_mostrarEstadoAvion);
			this.groupBox1.Controls.Add(this.lbl_estadoVuelo);
			this.groupBox1.Controls.Add(this.lbl_mostrarPesoMaximoBodega);
			this.groupBox1.Controls.Add(this.lbl_pesoMaximoBodega);
			this.groupBox1.Controls.Add(this.lbl_mostrarCantidadBaños);
			this.groupBox1.Controls.Add(this.lbl_cantidadDebaños);
			this.groupBox1.Controls.Add(this.lbl_mostrarCapacidadMaximaDeAsientos);
			this.groupBox1.Controls.Add(this.lbl_capacidadMaximaDeAsientos);
			this.groupBox1.Controls.Add(this.lbl_mostrarPatente);
			this.groupBox1.Controls.Add(this.lbl_patente);
			this.groupBox1.Location = new System.Drawing.Point(12, 38);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(875, 114);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Información del Avion";
			// 
			// lbl_mostrarEstadoAvion
			// 
			this.lbl_mostrarEstadoAvion.AutoSize = true;
			this.lbl_mostrarEstadoAvion.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbl_mostrarEstadoAvion.Location = new System.Drawing.Point(105, 70);
			this.lbl_mostrarEstadoAvion.Name = "lbl_mostrarEstadoAvion";
			this.lbl_mostrarEstadoAvion.Size = new System.Drawing.Size(61, 18);
			this.lbl_mostrarEstadoAvion.TabIndex = 9;
			this.lbl_mostrarEstadoAvion.Text = "label7";
			// 
			// lbl_estadoVuelo
			// 
			this.lbl_estadoVuelo.AutoSize = true;
			this.lbl_estadoVuelo.Location = new System.Drawing.Point(31, 70);
			this.lbl_estadoVuelo.Name = "lbl_estadoVuelo";
			this.lbl_estadoVuelo.Size = new System.Drawing.Size(71, 18);
			this.lbl_estadoVuelo.TabIndex = 8;
			this.lbl_estadoVuelo.Text = "Estado: ";
			// 
			// lbl_mostrarPesoMaximoBodega
			// 
			this.lbl_mostrarPesoMaximoBodega.AutoSize = true;
			this.lbl_mostrarPesoMaximoBodega.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbl_mostrarPesoMaximoBodega.Location = new System.Drawing.Point(511, 70);
			this.lbl_mostrarPesoMaximoBodega.Name = "lbl_mostrarPesoMaximoBodega";
			this.lbl_mostrarPesoMaximoBodega.Size = new System.Drawing.Size(61, 18);
			this.lbl_mostrarPesoMaximoBodega.TabIndex = 7;
			this.lbl_mostrarPesoMaximoBodega.Text = "label6";
			// 
			// lbl_pesoMaximoBodega
			// 
			this.lbl_pesoMaximoBodega.AutoSize = true;
			this.lbl_pesoMaximoBodega.Location = new System.Drawing.Point(278, 70);
			this.lbl_pesoMaximoBodega.Name = "lbl_pesoMaximoBodega";
			this.lbl_pesoMaximoBodega.Size = new System.Drawing.Size(230, 18);
			this.lbl_pesoMaximoBodega.TabIndex = 6;
			this.lbl_pesoMaximoBodega.Text = "Peso Máximo en la Bodega: ";
			// 
			// lbl_mostrarCantidadBaños
			// 
			this.lbl_mostrarCantidadBaños.AutoSize = true;
			this.lbl_mostrarCantidadBaños.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbl_mostrarCantidadBaños.Location = new System.Drawing.Point(790, 39);
			this.lbl_mostrarCantidadBaños.Name = "lbl_mostrarCantidadBaños";
			this.lbl_mostrarCantidadBaños.Size = new System.Drawing.Size(61, 18);
			this.lbl_mostrarCantidadBaños.TabIndex = 5;
			this.lbl_mostrarCantidadBaños.Text = "label1";
			// 
			// lbl_cantidadDebaños
			// 
			this.lbl_cantidadDebaños.AutoSize = true;
			this.lbl_cantidadDebaños.Location = new System.Drawing.Point(620, 39);
			this.lbl_cantidadDebaños.Name = "lbl_cantidadDebaños";
			this.lbl_cantidadDebaños.Size = new System.Drawing.Size(164, 18);
			this.lbl_cantidadDebaños.TabIndex = 4;
			this.lbl_cantidadDebaños.Text = "Cantidad de Baños:";
			// 
			// lbl_mostrarCapacidadMaximaDeAsientos
			// 
			this.lbl_mostrarCapacidadMaximaDeAsientos.AutoSize = true;
			this.lbl_mostrarCapacidadMaximaDeAsientos.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbl_mostrarCapacidadMaximaDeAsientos.Location = new System.Drawing.Point(547, 39);
			this.lbl_mostrarCapacidadMaximaDeAsientos.Name = "lbl_mostrarCapacidadMaximaDeAsientos";
			this.lbl_mostrarCapacidadMaximaDeAsientos.Size = new System.Drawing.Size(61, 18);
			this.lbl_mostrarCapacidadMaximaDeAsientos.TabIndex = 3;
			this.lbl_mostrarCapacidadMaximaDeAsientos.Text = "label4";
			// 
			// lbl_capacidadMaximaDeAsientos
			// 
			this.lbl_capacidadMaximaDeAsientos.AutoSize = true;
			this.lbl_capacidadMaximaDeAsientos.Location = new System.Drawing.Point(278, 39);
			this.lbl_capacidadMaximaDeAsientos.Name = "lbl_capacidadMaximaDeAsientos";
			this.lbl_capacidadMaximaDeAsientos.Size = new System.Drawing.Size(263, 18);
			this.lbl_capacidadMaximaDeAsientos.TabIndex = 2;
			this.lbl_capacidadMaximaDeAsientos.Text = "Capacidad Maxima de Asientos:";
			// 
			// lbl_mostrarPatente
			// 
			this.lbl_mostrarPatente.AutoSize = true;
			this.lbl_mostrarPatente.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbl_mostrarPatente.Location = new System.Drawing.Point(108, 39);
			this.lbl_mostrarPatente.Name = "lbl_mostrarPatente";
			this.lbl_mostrarPatente.Size = new System.Drawing.Size(61, 18);
			this.lbl_mostrarPatente.TabIndex = 1;
			this.lbl_mostrarPatente.Text = "label2";
			// 
			// lbl_patente
			// 
			this.lbl_patente.AutoSize = true;
			this.lbl_patente.Location = new System.Drawing.Point(30, 39);
			this.lbl_patente.Name = "lbl_patente";
			this.lbl_patente.Size = new System.Drawing.Size(72, 18);
			this.lbl_patente.TabIndex = 0;
			this.lbl_patente.Text = "Patente:";
			// 
			// cb_seleccionarAvion
			// 
			this.cb_seleccionarAvion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_seleccionarAvion.FormattingEnabled = true;
			this.cb_seleccionarAvion.Location = new System.Drawing.Point(200, 6);
			this.cb_seleccionarAvion.Name = "cb_seleccionarAvion";
			this.cb_seleccionarAvion.Size = new System.Drawing.Size(201, 26);
			this.cb_seleccionarAvion.TabIndex = 2;
			this.cb_seleccionarAvion.SelectedIndexChanged += new System.EventHandler(this.cb_seleccionarAvion_SelectedIndexChanged);
			// 
			// lbl_seleccionAvion
			// 
			this.lbl_seleccionAvion.AutoSize = true;
			this.lbl_seleccionAvion.Location = new System.Drawing.Point(12, 9);
			this.lbl_seleccionAvion.Name = "lbl_seleccionAvion";
			this.lbl_seleccionAvion.Size = new System.Drawing.Size(182, 18);
			this.lbl_seleccionAvion.TabIndex = 3;
			this.lbl_seleccionAvion.Text = "Seleccione un Avion: ";
			// 
			// dgw_listaPasajerosDeUnVuelo
			// 
			this.dgw_listaPasajerosDeUnVuelo.BackgroundColor = System.Drawing.Color.LightSkyBlue;
			this.dgw_listaPasajerosDeUnVuelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgw_listaPasajerosDeUnVuelo.Location = new System.Drawing.Point(6, 25);
			this.dgw_listaPasajerosDeUnVuelo.Name = "dgw_listaPasajerosDeUnVuelo";
			this.dgw_listaPasajerosDeUnVuelo.RowTemplate.Height = 25;
			this.dgw_listaPasajerosDeUnVuelo.Size = new System.Drawing.Size(944, 317);
			this.dgw_listaPasajerosDeUnVuelo.TabIndex = 4;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.dgw_listaPasajerosDeUnVuelo);
			this.groupBox2.Location = new System.Drawing.Point(12, 158);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(956, 355);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Lista de Pasajeros";
			// 
			// FrmInformesAviones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSkyBlue;
			this.ClientSize = new System.Drawing.Size(980, 525);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.lbl_seleccionAvion);
			this.Controls.Add(this.cb_seleccionarAvion);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmInformesAviones";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmInformesAviones";
			this.Load += new System.EventHandler(this.FrmInformesAviones_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgw_listaPasajerosDeUnVuelo)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private GroupBox groupBox1;
		private ComboBox cb_seleccionarAvion;
		private Label lbl_seleccionAvion;
		private Label lbl_cantidadDebaños;
		private Label lbl_mostrarCapacidadMaximaDeAsientos;
		private Label lbl_capacidadMaximaDeAsientos;
		private Label lbl_mostrarPatente;
		private Label lbl_patente;
		private Label lbl_mostrarCantidadBaños;
		private Label lbl_mostrarPesoMaximoBodega;
		private Label lbl_pesoMaximoBodega;
		private Label lbl_mostrarEstadoAvion;
		private Label lbl_estadoVuelo;
		private DataGridView dgw_listaPasajerosDeUnVuelo;
		private GroupBox groupBox2;
	}
}