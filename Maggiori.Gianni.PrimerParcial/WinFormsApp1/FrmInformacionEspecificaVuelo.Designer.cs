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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btn_volver = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.gb_listaPasajeros.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// gb_listaPasajeros
			// 
			this.gb_listaPasajeros.Controls.Add(this.dataGridView1);
			this.gb_listaPasajeros.Location = new System.Drawing.Point(11, 21);
			this.gb_listaPasajeros.Name = "gb_listaPasajeros";
			this.gb_listaPasajeros.Size = new System.Drawing.Size(957, 254);
			this.gb_listaPasajeros.TabIndex = 0;
			this.gb_listaPasajeros.TabStop = false;
			this.gb_listaPasajeros.Text = "L";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(6, 19);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 25;
			this.dataGridView1.Size = new System.Drawing.Size(945, 229);
			this.dataGridView1.TabIndex = 0;
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
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(11, 281);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(457, 191);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Información del Pasajero: ";
			// 
			// FrmInformacionEspecificaVuelo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSkyBlue;
			this.ClientSize = new System.Drawing.Size(980, 525);
			this.Controls.Add(this.groupBox1);
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
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox gb_listaPasajeros;
		private DataGridView dataGridView1;
		private Button btn_volver;
		private GroupBox groupBox1;
	}
}