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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.lbl_seleccionAvion = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(12, 92);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(389, 367);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Información del Avion";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(200, 59);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(201, 26);
			this.comboBox1.TabIndex = 2;
			// 
			// lbl_seleccionAvion
			// 
			this.lbl_seleccionAvion.AutoSize = true;
			this.lbl_seleccionAvion.Location = new System.Drawing.Point(12, 62);
			this.lbl_seleccionAvion.Name = "lbl_seleccionAvion";
			this.lbl_seleccionAvion.Size = new System.Drawing.Size(182, 18);
			this.lbl_seleccionAvion.TabIndex = 3;
			this.lbl_seleccionAvion.Text = "Seleccione un Avion: ";
			// 
			// FrmInformesAviones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(980, 525);
			this.Controls.Add(this.lbl_seleccionAvion);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmInformesAviones";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmInformesAviones";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private GroupBox groupBox1;
		private ComboBox comboBox1;
		private Label lbl_seleccionAvion;
	}
}