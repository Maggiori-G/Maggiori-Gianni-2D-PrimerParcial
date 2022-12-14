namespace VistaAerolinea {
	partial class FrmInformesClientes {
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
			this.dgw_dataClientes = new System.Windows.Forms.DataGridView();
			this.lbl_listaDeClientes = new System.Windows.Forms.Label();
			this.lbl_buscar = new System.Windows.Forms.Label();
			this.txt_buscar = new System.Windows.Forms.TextBox();
			this.btn_limpiar = new System.Windows.Forms.Button();
			this.btn_nuevoCliente = new System.Windows.Forms.Button();
			this.btn_eliminarCliente = new System.Windows.Forms.Button();
			this.btn_modificar = new System.Windows.Forms.Button();
			this.btn_seleccionarCliente = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgw_dataClientes)).BeginInit();
			this.SuspendLayout();
			// 
			// dgw_dataClientes
			// 
			this.dgw_dataClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgw_dataClientes.BackgroundColor = System.Drawing.Color.LightSkyBlue;
			this.dgw_dataClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgw_dataClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgw_dataClientes.Location = new System.Drawing.Point(12, 77);
			this.dgw_dataClientes.MultiSelect = false;
			this.dgw_dataClientes.Name = "dgw_dataClientes";
			this.dgw_dataClientes.RowHeadersVisible = false;
			this.dgw_dataClientes.RowTemplate.Height = 25;
			this.dgw_dataClientes.Size = new System.Drawing.Size(956, 436);
			this.dgw_dataClientes.TabIndex = 0;
			// 
			// lbl_listaDeClientes
			// 
			this.lbl_listaDeClientes.AutoSize = true;
			this.lbl_listaDeClientes.Location = new System.Drawing.Point(12, 9);
			this.lbl_listaDeClientes.Name = "lbl_listaDeClientes";
			this.lbl_listaDeClientes.Size = new System.Drawing.Size(139, 18);
			this.lbl_listaDeClientes.TabIndex = 1;
			this.lbl_listaDeClientes.Text = "Lista de Clientes";
			// 
			// lbl_buscar
			// 
			this.lbl_buscar.AutoSize = true;
			this.lbl_buscar.Location = new System.Drawing.Point(12, 47);
			this.lbl_buscar.Name = "lbl_buscar";
			this.lbl_buscar.Size = new System.Drawing.Size(72, 18);
			this.lbl_buscar.TabIndex = 2;
			this.lbl_buscar.Text = "Buscar: ";
			// 
			// txt_buscar
			// 
			this.txt_buscar.Location = new System.Drawing.Point(79, 44);
			this.txt_buscar.Name = "txt_buscar";
			this.txt_buscar.PlaceholderText = "Ingrese un dni";
			this.txt_buscar.Size = new System.Drawing.Size(181, 26);
			this.txt_buscar.TabIndex = 3;
			this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
			// 
			// btn_limpiar
			// 
			this.btn_limpiar.BackColor = System.Drawing.Color.Salmon;
			this.btn_limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_limpiar.Location = new System.Drawing.Point(266, 42);
			this.btn_limpiar.Name = "btn_limpiar";
			this.btn_limpiar.Size = new System.Drawing.Size(89, 29);
			this.btn_limpiar.TabIndex = 4;
			this.btn_limpiar.Text = "Limpiar";
			this.btn_limpiar.UseVisualStyleBackColor = false;
			this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
			// 
			// btn_nuevoCliente
			// 
			this.btn_nuevoCliente.BackColor = System.Drawing.Color.Salmon;
			this.btn_nuevoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_nuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_nuevoCliente.Location = new System.Drawing.Point(361, 42);
			this.btn_nuevoCliente.Name = "btn_nuevoCliente";
			this.btn_nuevoCliente.Size = new System.Drawing.Size(134, 29);
			this.btn_nuevoCliente.TabIndex = 5;
			this.btn_nuevoCliente.Text = "Añadir Cliente";
			this.btn_nuevoCliente.UseVisualStyleBackColor = false;
			this.btn_nuevoCliente.Click += new System.EventHandler(this.btn_nuevoCliente_Click);
			// 
			// btn_eliminarCliente
			// 
			this.btn_eliminarCliente.BackColor = System.Drawing.Color.Salmon;
			this.btn_eliminarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_eliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_eliminarCliente.Location = new System.Drawing.Point(664, 42);
			this.btn_eliminarCliente.Name = "btn_eliminarCliente";
			this.btn_eliminarCliente.Size = new System.Drawing.Size(147, 29);
			this.btn_eliminarCliente.TabIndex = 6;
			this.btn_eliminarCliente.Text = "Eliminar Cliente";
			this.btn_eliminarCliente.UseVisualStyleBackColor = false;
			this.btn_eliminarCliente.Click += new System.EventHandler(this.btn_eliminarCliente_Click);
			// 
			// btn_modificar
			// 
			this.btn_modificar.BackColor = System.Drawing.Color.Salmon;
			this.btn_modificar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_modificar.Location = new System.Drawing.Point(501, 42);
			this.btn_modificar.Name = "btn_modificar";
			this.btn_modificar.Size = new System.Drawing.Size(157, 29);
			this.btn_modificar.TabIndex = 7;
			this.btn_modificar.Text = "Modificar Cliente";
			this.btn_modificar.UseVisualStyleBackColor = false;
			this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
			// 
			// btn_seleccionarCliente
			// 
			this.btn_seleccionarCliente.BackColor = System.Drawing.Color.Salmon;
			this.btn_seleccionarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_seleccionarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_seleccionarCliente.Location = new System.Drawing.Point(817, 41);
			this.btn_seleccionarCliente.Name = "btn_seleccionarCliente";
			this.btn_seleccionarCliente.Size = new System.Drawing.Size(147, 29);
			this.btn_seleccionarCliente.TabIndex = 8;
			this.btn_seleccionarCliente.Text = "Seleccionar";
			this.btn_seleccionarCliente.UseVisualStyleBackColor = false;
			this.btn_seleccionarCliente.Click += new System.EventHandler(this.btn_seleccionarCliente_Click);
			// 
			// FrmInformesClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSkyBlue;
			this.ClientSize = new System.Drawing.Size(980, 525);
			this.Controls.Add(this.btn_seleccionarCliente);
			this.Controls.Add(this.btn_modificar);
			this.Controls.Add(this.btn_eliminarCliente);
			this.Controls.Add(this.btn_nuevoCliente);
			this.Controls.Add(this.btn_limpiar);
			this.Controls.Add(this.txt_buscar);
			this.Controls.Add(this.lbl_buscar);
			this.Controls.Add(this.lbl_listaDeClientes);
			this.Controls.Add(this.dgw_dataClientes);
			this.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmInformesClientes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmClientes";
			this.Load += new System.EventHandler(this.FrmInformesClientes_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgw_dataClientes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataGridView dgw_dataClientes;
		private Label lbl_listaDeClientes;
		private Label lbl_buscar;
		private TextBox txt_buscar;
		private Button btn_limpiar;
		private Button btn_nuevoCliente;
		private Button btn_eliminarCliente;
		private Button btn_modificar;
		private Button btn_seleccionarCliente;
	}
}