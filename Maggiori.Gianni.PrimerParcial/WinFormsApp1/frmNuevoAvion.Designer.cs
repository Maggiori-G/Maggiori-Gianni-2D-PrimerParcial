namespace VistaAerolinea {
	partial class frmNuevoAvion {
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
			this.gb_datosNuevoAvion = new System.Windows.Forms.GroupBox();
			this.lbl_asientos = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_ingresoMaxAsientos = new System.Windows.Forms.TextBox();
			this.txt_ingresoCapacidadBodega = new System.Windows.Forms.TextBox();
			this.txt_ingresoCantidadBaños = new System.Windows.Forms.TextBox();
			this.btn_Aceptar = new System.Windows.Forms.Button();
			this.btn_cancelar = new System.Windows.Forms.Button();
			this.gb_datosNuevoAvion.SuspendLayout();
			this.SuspendLayout();
			// 
			// gb_datosNuevoAvion
			// 
			this.gb_datosNuevoAvion.Controls.Add(this.btn_cancelar);
			this.gb_datosNuevoAvion.Controls.Add(this.txt_ingresoCantidadBaños);
			this.gb_datosNuevoAvion.Controls.Add(this.btn_Aceptar);
			this.gb_datosNuevoAvion.Controls.Add(this.txt_ingresoCapacidadBodega);
			this.gb_datosNuevoAvion.Controls.Add(this.txt_ingresoMaxAsientos);
			this.gb_datosNuevoAvion.Controls.Add(this.label6);
			this.gb_datosNuevoAvion.Controls.Add(this.label5);
			this.gb_datosNuevoAvion.Controls.Add(this.lbl_asientos);
			this.gb_datosNuevoAvion.Location = new System.Drawing.Point(12, 12);
			this.gb_datosNuevoAvion.Name = "gb_datosNuevoAvion";
			this.gb_datosNuevoAvion.Size = new System.Drawing.Size(426, 293);
			this.gb_datosNuevoAvion.TabIndex = 1;
			this.gb_datosNuevoAvion.TabStop = false;
			this.gb_datosNuevoAvion.Text = "Ingrese los Datos del Nuevo Avion";
			// 
			// lbl_asientos
			// 
			this.lbl_asientos.AutoSize = true;
			this.lbl_asientos.Location = new System.Drawing.Point(6, 46);
			this.lbl_asientos.Name = "lbl_asientos";
			this.lbl_asientos.Size = new System.Drawing.Size(251, 18);
			this.lbl_asientos.TabIndex = 0;
			this.lbl_asientos.Text = "Cantidad Maxima de Asientos:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(93, 74);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(164, 18);
			this.label5.TabIndex = 4;
			this.label5.Text = "Cantidad de Baños:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(51, 102);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(206, 18);
			this.label6.TabIndex = 5;
			this.label6.Text = "Capacidad de la Bodega:";
			// 
			// txt_ingresoMaxAsientos
			// 
			this.txt_ingresoMaxAsientos.Location = new System.Drawing.Point(263, 43);
			this.txt_ingresoMaxAsientos.Name = "txt_ingresoMaxAsientos";
			this.txt_ingresoMaxAsientos.Size = new System.Drawing.Size(147, 26);
			this.txt_ingresoMaxAsientos.TabIndex = 6;
			// 
			// txt_ingresoCapacidadBodega
			// 
			this.txt_ingresoCapacidadBodega.Location = new System.Drawing.Point(263, 99);
			this.txt_ingresoCapacidadBodega.Name = "txt_ingresoCapacidadBodega";
			this.txt_ingresoCapacidadBodega.Size = new System.Drawing.Size(147, 26);
			this.txt_ingresoCapacidadBodega.TabIndex = 7;
			// 
			// txt_ingresoCantidadBaños
			// 
			this.txt_ingresoCantidadBaños.Location = new System.Drawing.Point(263, 71);
			this.txt_ingresoCantidadBaños.Name = "txt_ingresoCantidadBaños";
			this.txt_ingresoCantidadBaños.Size = new System.Drawing.Size(147, 26);
			this.txt_ingresoCantidadBaños.TabIndex = 8;
			// 
			// btn_Aceptar
			// 
			this.btn_Aceptar.BackColor = System.Drawing.Color.Salmon;
			this.btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Aceptar.Location = new System.Drawing.Point(77, 225);
			this.btn_Aceptar.Name = "btn_Aceptar";
			this.btn_Aceptar.Size = new System.Drawing.Size(122, 53);
			this.btn_Aceptar.TabIndex = 2;
			this.btn_Aceptar.Text = "Comprar Avion";
			this.btn_Aceptar.UseVisualStyleBackColor = false;
			this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
			// 
			// btn_cancelar
			// 
			this.btn_cancelar.BackColor = System.Drawing.Color.Salmon;
			this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_cancelar.Location = new System.Drawing.Point(205, 225);
			this.btn_cancelar.Name = "btn_cancelar";
			this.btn_cancelar.Size = new System.Drawing.Size(122, 53);
			this.btn_cancelar.TabIndex = 3;
			this.btn_cancelar.Text = "Cancelar Compra";
			this.btn_cancelar.UseVisualStyleBackColor = false;
			this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
			// 
			// frmNuevoAvion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSkyBlue;
			this.ClientSize = new System.Drawing.Size(453, 318);
			this.Controls.Add(this.gb_datosNuevoAvion);
			this.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmNuevoAvion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmNuevoAvion";
			this.gb_datosNuevoAvion.ResumeLayout(false);
			this.gb_datosNuevoAvion.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private GroupBox gb_datosNuevoAvion;
		private Label label6;
		private Label label5;
		private Label lbl_asientos;
		private TextBox txt_ingresoCantidadBaños;
		private TextBox txt_ingresoCapacidadBodega;
		private TextBox txt_ingresoMaxAsientos;
		private Button btn_cancelar;
		private Button btn_Aceptar;
	}
}