namespace VistaAerolinea {
	partial class FrmDatosHistoricos {
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
			this.grp_datosFacturacion = new System.Windows.Forms.GroupBox();
			this.lbl_mostrarRecaudacion = new System.Windows.Forms.Label();
			this.lbl_recaudacion = new System.Windows.Forms.Label();
			this.rdb_facturacionInternacional = new System.Windows.Forms.RadioButton();
			this.rdb_facturacionNacional = new System.Windows.Forms.RadioButton();
			this.rdb_FacturacionHistoricaTotal = new System.Windows.Forms.RadioButton();
			this.btn_cerrar = new System.Windows.Forms.Button();
			this.grp_datosFacturacion.SuspendLayout();
			this.SuspendLayout();
			// 
			// grp_datosFacturacion
			// 
			this.grp_datosFacturacion.Controls.Add(this.lbl_mostrarRecaudacion);
			this.grp_datosFacturacion.Controls.Add(this.lbl_recaudacion);
			this.grp_datosFacturacion.Controls.Add(this.rdb_facturacionInternacional);
			this.grp_datosFacturacion.Controls.Add(this.rdb_facturacionNacional);
			this.grp_datosFacturacion.Controls.Add(this.rdb_FacturacionHistoricaTotal);
			this.grp_datosFacturacion.Location = new System.Drawing.Point(13, 13);
			this.grp_datosFacturacion.Margin = new System.Windows.Forms.Padding(4);
			this.grp_datosFacturacion.Name = "grp_datosFacturacion";
			this.grp_datosFacturacion.Padding = new System.Windows.Forms.Padding(4);
			this.grp_datosFacturacion.Size = new System.Drawing.Size(406, 299);
			this.grp_datosFacturacion.TabIndex = 0;
			this.grp_datosFacturacion.TabStop = false;
			this.grp_datosFacturacion.Text = "Datos de Facturacion:";
			// 
			// lbl_mostrarRecaudacion
			// 
			this.lbl_mostrarRecaudacion.AutoSize = true;
			this.lbl_mostrarRecaudacion.Location = new System.Drawing.Point(130, 148);
			this.lbl_mostrarRecaudacion.Name = "lbl_mostrarRecaudacion";
			this.lbl_mostrarRecaudacion.Size = new System.Drawing.Size(56, 18);
			this.lbl_mostrarRecaudacion.TabIndex = 4;
			this.lbl_mostrarRecaudacion.Text = "label1";
			// 
			// lbl_recaudacion
			// 
			this.lbl_recaudacion.AutoSize = true;
			this.lbl_recaudacion.Location = new System.Drawing.Point(7, 148);
			this.lbl_recaudacion.Name = "lbl_recaudacion";
			this.lbl_recaudacion.Size = new System.Drawing.Size(117, 18);
			this.lbl_recaudacion.TabIndex = 3;
			this.lbl_recaudacion.Text = "Recaudación:";
			// 
			// rdb_facturacionInternacional
			// 
			this.rdb_facturacionInternacional.AutoSize = true;
			this.rdb_facturacionInternacional.Location = new System.Drawing.Point(7, 96);
			this.rdb_facturacionInternacional.Name = "rdb_facturacionInternacional";
			this.rdb_facturacionInternacional.Size = new System.Drawing.Size(387, 22);
			this.rdb_facturacionInternacional.TabIndex = 2;
			this.rdb_facturacionInternacional.TabStop = true;
			this.rdb_facturacionInternacional.Text = "Facturación Histórica Vuelos Internacionales";
			this.rdb_facturacionInternacional.UseVisualStyleBackColor = true;
			this.rdb_facturacionInternacional.CheckedChanged += new System.EventHandler(this.rdb_facturacionInternacional_CheckedChanged);
			// 
			// rdb_facturacionNacional
			// 
			this.rdb_facturacionNacional.AutoSize = true;
			this.rdb_facturacionNacional.Location = new System.Drawing.Point(7, 68);
			this.rdb_facturacionNacional.Name = "rdb_facturacionNacional";
			this.rdb_facturacionNacional.Size = new System.Drawing.Size(349, 22);
			this.rdb_facturacionNacional.TabIndex = 1;
			this.rdb_facturacionNacional.TabStop = true;
			this.rdb_facturacionNacional.Text = "Facturación Histórica Vuelos Nacionales";
			this.rdb_facturacionNacional.UseVisualStyleBackColor = true;
			this.rdb_facturacionNacional.CheckedChanged += new System.EventHandler(this.rdb_facturacionNacional_CheckedChanged);
			// 
			// rdb_FacturacionHistoricaTotal
			// 
			this.rdb_FacturacionHistoricaTotal.AutoSize = true;
			this.rdb_FacturacionHistoricaTotal.Location = new System.Drawing.Point(7, 40);
			this.rdb_FacturacionHistoricaTotal.Name = "rdb_FacturacionHistoricaTotal";
			this.rdb_FacturacionHistoricaTotal.Size = new System.Drawing.Size(244, 22);
			this.rdb_FacturacionHistoricaTotal.TabIndex = 0;
			this.rdb_FacturacionHistoricaTotal.TabStop = true;
			this.rdb_FacturacionHistoricaTotal.Text = "Facturacion Historica Total";
			this.rdb_FacturacionHistoricaTotal.UseVisualStyleBackColor = true;
			this.rdb_FacturacionHistoricaTotal.CheckedChanged += new System.EventHandler(this.rdb_FacturacionHistoricaTotal_CheckedChanged);
			// 
			// btn_cerrar
			// 
			this.btn_cerrar.BackColor = System.Drawing.Color.Salmon;
			this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_cerrar.Location = new System.Drawing.Point(150, 319);
			this.btn_cerrar.Name = "btn_cerrar";
			this.btn_cerrar.Size = new System.Drawing.Size(114, 32);
			this.btn_cerrar.TabIndex = 1;
			this.btn_cerrar.Text = "Cerrar";
			this.btn_cerrar.UseVisualStyleBackColor = false;
			this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
			// 
			// FrmDatosHistoricos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSkyBlue;
			this.ClientSize = new System.Drawing.Size(433, 360);
			this.Controls.Add(this.btn_cerrar);
			this.Controls.Add(this.grp_datosFacturacion);
			this.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmDatosHistoricos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmDatosHistoricos";
			this.Load += new System.EventHandler(this.FrmDatosHistoricos_Load);
			this.grp_datosFacturacion.ResumeLayout(false);
			this.grp_datosFacturacion.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox grp_datosFacturacion;
		private Label lbl_recaudacion;
		private RadioButton rdb_facturacionInternacional;
		private RadioButton rdb_facturacionNacional;
		private RadioButton rdb_FacturacionHistoricaTotal;
		private Button btn_cerrar;
		private Label lbl_mostrarRecaudacion;
	}
}