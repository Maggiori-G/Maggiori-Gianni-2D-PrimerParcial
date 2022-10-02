namespace VistaAerolinea {
	partial class FrmNuevoCliente {
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
			this.lbl_nombre = new System.Windows.Forms.Label();
			this.lbl_apellido = new System.Windows.Forms.Label();
			this.lbl_edad = new System.Windows.Forms.Label();
			this.lbl_email = new System.Windows.Forms.Label();
			this.lbl_dni = new System.Windows.Forms.Label();
			this.lbl_telefono = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_cancelar = new System.Windows.Forms.Button();
			this.btn_aceptar = new System.Windows.Forms.Button();
			this.txt_telefono = new System.Windows.Forms.TextBox();
			this.txt_dni = new System.Windows.Forms.TextBox();
			this.txt_email = new System.Windows.Forms.TextBox();
			this.txt_edad = new System.Windows.Forms.TextBox();
			this.txt_apellido = new System.Windows.Forms.TextBox();
			this.txt_nombre = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbl_nombre
			// 
			this.lbl_nombre.AutoSize = true;
			this.lbl_nombre.Location = new System.Drawing.Point(6, 36);
			this.lbl_nombre.Name = "lbl_nombre";
			this.lbl_nombre.Size = new System.Drawing.Size(82, 18);
			this.lbl_nombre.TabIndex = 0;
			this.lbl_nombre.Text = "Nombre: ";
			// 
			// lbl_apellido
			// 
			this.lbl_apellido.AutoSize = true;
			this.lbl_apellido.Location = new System.Drawing.Point(6, 68);
			this.lbl_apellido.Name = "lbl_apellido";
			this.lbl_apellido.Size = new System.Drawing.Size(85, 18);
			this.lbl_apellido.TabIndex = 1;
			this.lbl_apellido.Text = "Apellido: ";
			// 
			// lbl_edad
			// 
			this.lbl_edad.AutoSize = true;
			this.lbl_edad.Location = new System.Drawing.Point(6, 102);
			this.lbl_edad.Name = "lbl_edad";
			this.lbl_edad.Size = new System.Drawing.Size(58, 18);
			this.lbl_edad.TabIndex = 2;
			this.lbl_edad.Text = "Edad: ";
			// 
			// lbl_email
			// 
			this.lbl_email.AutoSize = true;
			this.lbl_email.Location = new System.Drawing.Point(6, 131);
			this.lbl_email.Name = "lbl_email";
			this.lbl_email.Size = new System.Drawing.Size(63, 18);
			this.lbl_email.TabIndex = 3;
			this.lbl_email.Text = "E-mail:";
			// 
			// lbl_dni
			// 
			this.lbl_dni.AutoSize = true;
			this.lbl_dni.Location = new System.Drawing.Point(6, 166);
			this.lbl_dni.Name = "lbl_dni";
			this.lbl_dni.Size = new System.Drawing.Size(43, 18);
			this.lbl_dni.TabIndex = 4;
			this.lbl_dni.Text = "DNI:";
			// 
			// lbl_telefono
			// 
			this.lbl_telefono.AutoSize = true;
			this.lbl_telefono.Location = new System.Drawing.Point(6, 198);
			this.lbl_telefono.Name = "lbl_telefono";
			this.lbl_telefono.Size = new System.Drawing.Size(85, 18);
			this.lbl_telefono.TabIndex = 5;
			this.lbl_telefono.Text = "Teléfono:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_cancelar);
			this.groupBox1.Controls.Add(this.btn_aceptar);
			this.groupBox1.Controls.Add(this.txt_telefono);
			this.groupBox1.Controls.Add(this.txt_dni);
			this.groupBox1.Controls.Add(this.txt_email);
			this.groupBox1.Controls.Add(this.txt_edad);
			this.groupBox1.Controls.Add(this.txt_apellido);
			this.groupBox1.Controls.Add(this.txt_nombre);
			this.groupBox1.Controls.Add(this.lbl_nombre);
			this.groupBox1.Controls.Add(this.lbl_telefono);
			this.groupBox1.Controls.Add(this.lbl_apellido);
			this.groupBox1.Controls.Add(this.lbl_dni);
			this.groupBox1.Controls.Add(this.lbl_edad);
			this.groupBox1.Controls.Add(this.lbl_email);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(364, 286);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Cliente";
			// 
			// btn_cancelar
			// 
			this.btn_cancelar.BackColor = System.Drawing.Color.Salmon;
			this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_cancelar.Location = new System.Drawing.Point(182, 242);
			this.btn_cancelar.Name = "btn_cancelar";
			this.btn_cancelar.Size = new System.Drawing.Size(114, 35);
			this.btn_cancelar.TabIndex = 7;
			this.btn_cancelar.Text = "Cancelar";
			this.btn_cancelar.UseVisualStyleBackColor = false;
			this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
			// 
			// btn_aceptar
			// 
			this.btn_aceptar.BackColor = System.Drawing.Color.Salmon;
			this.btn_aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_aceptar.Location = new System.Drawing.Point(62, 242);
			this.btn_aceptar.Name = "btn_aceptar";
			this.btn_aceptar.Size = new System.Drawing.Size(114, 35);
			this.btn_aceptar.TabIndex = 6;
			this.btn_aceptar.Text = "Aceptar";
			this.btn_aceptar.UseVisualStyleBackColor = false;
			this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
			// 
			// txt_telefono
			// 
			this.txt_telefono.Location = new System.Drawing.Point(103, 195);
			this.txt_telefono.Name = "txt_telefono";
			this.txt_telefono.Size = new System.Drawing.Size(244, 26);
			this.txt_telefono.TabIndex = 5;
			// 
			// txt_dni
			// 
			this.txt_dni.Location = new System.Drawing.Point(103, 163);
			this.txt_dni.Name = "txt_dni";
			this.txt_dni.Size = new System.Drawing.Size(244, 26);
			this.txt_dni.TabIndex = 4;
			// 
			// txt_email
			// 
			this.txt_email.Location = new System.Drawing.Point(103, 131);
			this.txt_email.Name = "txt_email";
			this.txt_email.Size = new System.Drawing.Size(244, 26);
			this.txt_email.TabIndex = 3;
			// 
			// txt_edad
			// 
			this.txt_edad.Location = new System.Drawing.Point(103, 99);
			this.txt_edad.Name = "txt_edad";
			this.txt_edad.Size = new System.Drawing.Size(244, 26);
			this.txt_edad.TabIndex = 2;
			// 
			// txt_apellido
			// 
			this.txt_apellido.Location = new System.Drawing.Point(103, 65);
			this.txt_apellido.Name = "txt_apellido";
			this.txt_apellido.Size = new System.Drawing.Size(244, 26);
			this.txt_apellido.TabIndex = 1;
			// 
			// txt_nombre
			// 
			this.txt_nombre.Location = new System.Drawing.Point(103, 33);
			this.txt_nombre.Name = "txt_nombre";
			this.txt_nombre.Size = new System.Drawing.Size(244, 26);
			this.txt_nombre.TabIndex = 0;
			// 
			// FrmNuevoCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSkyBlue;
			this.ClientSize = new System.Drawing.Size(385, 317);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmNuevoCliente";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmNuevoCliente";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Label lbl_nombre;
		private Label lbl_apellido;
		private Label lbl_edad;
		private Label lbl_email;
		private Label lbl_dni;
		private Label lbl_telefono;
		private GroupBox groupBox1;
		private TextBox txt_telefono;
		private TextBox txt_dni;
		private TextBox txt_email;
		private TextBox txt_edad;
		private TextBox txt_apellido;
		private TextBox txt_nombre;
		private Button btn_cancelar;
		private Button btn_aceptar;
	}
}