namespace VistaAerolinea {
	partial class frmNuevoUsuario {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevoUsuario));
			this.btn_confirmar = new System.Windows.Forms.Button();
			this.btn_cancelar = new System.Windows.Forms.Button();
			this.txt_nombreUsuario = new System.Windows.Forms.TextBox();
			this.txt_contraseña = new System.Windows.Forms.TextBox();
			this.lbl_nuevoUsario = new System.Windows.Forms.Label();
			this.lbl_contraseña = new System.Windows.Forms.Label();
			this.lbl_nombre = new System.Windows.Forms.Label();
			this.lbl_apellido = new System.Windows.Forms.Label();
			this.lbl_dni = new System.Windows.Forms.Label();
			this.lbl_email = new System.Windows.Forms.Label();
			this.txt_apellido = new System.Windows.Forms.TextBox();
			this.txt_email = new System.Windows.Forms.TextBox();
			this.txt_nombre = new System.Windows.Forms.TextBox();
			this.txt_dni = new System.Windows.Forms.TextBox();
			this.lbl_titulo = new System.Windows.Forms.Label();
			this.txt_numeroTelefono = new System.Windows.Forms.TextBox();
			this.lbl_numeroTelefono = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_confirmar
			// 
			this.btn_confirmar.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btn_confirmar.Location = new System.Drawing.Point(102, 416);
			this.btn_confirmar.Name = "btn_confirmar";
			this.btn_confirmar.Size = new System.Drawing.Size(118, 32);
			this.btn_confirmar.TabIndex = 6;
			this.btn_confirmar.Text = "Confirmar";
			this.btn_confirmar.UseVisualStyleBackColor = true;
			this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
			// 
			// btn_cancelar
			// 
			this.btn_cancelar.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btn_cancelar.Location = new System.Drawing.Point(226, 416);
			this.btn_cancelar.Name = "btn_cancelar";
			this.btn_cancelar.Size = new System.Drawing.Size(119, 32);
			this.btn_cancelar.TabIndex = 7;
			this.btn_cancelar.Text = "Cancelar";
			this.btn_cancelar.UseVisualStyleBackColor = true;
			this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
			// 
			// txt_nombreUsuario
			// 
			this.txt_nombreUsuario.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txt_nombreUsuario.Location = new System.Drawing.Point(101, 168);
			this.txt_nombreUsuario.Name = "txt_nombreUsuario";
			this.txt_nombreUsuario.Size = new System.Drawing.Size(243, 23);
			this.txt_nombreUsuario.TabIndex = 2;
			// 
			// txt_contraseña
			// 
			this.txt_contraseña.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txt_contraseña.Location = new System.Drawing.Point(102, 214);
			this.txt_contraseña.Name = "txt_contraseña";
			this.txt_contraseña.PasswordChar = '*';
			this.txt_contraseña.Size = new System.Drawing.Size(242, 23);
			this.txt_contraseña.TabIndex = 3;
			// 
			// lbl_nuevoUsario
			// 
			this.lbl_nuevoUsario.AutoSize = true;
			this.lbl_nuevoUsario.BackColor = System.Drawing.Color.Transparent;
			this.lbl_nuevoUsario.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.lbl_nuevoUsario.ForeColor = System.Drawing.SystemColors.Window;
			this.lbl_nuevoUsario.Location = new System.Drawing.Point(101, 148);
			this.lbl_nuevoUsario.Name = "lbl_nuevoUsario";
			this.lbl_nuevoUsario.Size = new System.Drawing.Size(167, 18);
			this.lbl_nuevoUsario.TabIndex = 4;
			this.lbl_nuevoUsario.Text = "Nombre de Usuario:";
			// 
			// lbl_contraseña
			// 
			this.lbl_contraseña.AutoSize = true;
			this.lbl_contraseña.BackColor = System.Drawing.Color.Transparent;
			this.lbl_contraseña.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.lbl_contraseña.ForeColor = System.Drawing.SystemColors.Window;
			this.lbl_contraseña.Location = new System.Drawing.Point(101, 194);
			this.lbl_contraseña.Name = "lbl_contraseña";
			this.lbl_contraseña.Size = new System.Drawing.Size(103, 18);
			this.lbl_contraseña.TabIndex = 5;
			this.lbl_contraseña.Text = "Contraseña:";
			// 
			// lbl_nombre
			// 
			this.lbl_nombre.AutoSize = true;
			this.lbl_nombre.BackColor = System.Drawing.Color.Transparent;
			this.lbl_nombre.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.lbl_nombre.ForeColor = System.Drawing.SystemColors.Window;
			this.lbl_nombre.Location = new System.Drawing.Point(102, 56);
			this.lbl_nombre.Name = "lbl_nombre";
			this.lbl_nombre.Size = new System.Drawing.Size(77, 18);
			this.lbl_nombre.TabIndex = 6;
			this.lbl_nombre.Text = "Nombre:";
			// 
			// lbl_apellido
			// 
			this.lbl_apellido.AutoSize = true;
			this.lbl_apellido.BackColor = System.Drawing.Color.Transparent;
			this.lbl_apellido.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.lbl_apellido.ForeColor = System.Drawing.SystemColors.Window;
			this.lbl_apellido.Location = new System.Drawing.Point(102, 102);
			this.lbl_apellido.Name = "lbl_apellido";
			this.lbl_apellido.Size = new System.Drawing.Size(77, 18);
			this.lbl_apellido.TabIndex = 7;
			this.lbl_apellido.Text = "Apellido:";
			// 
			// lbl_dni
			// 
			this.lbl_dni.AutoSize = true;
			this.lbl_dni.BackColor = System.Drawing.Color.Transparent;
			this.lbl_dni.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.lbl_dni.ForeColor = System.Drawing.SystemColors.Window;
			this.lbl_dni.Location = new System.Drawing.Point(102, 240);
			this.lbl_dni.Name = "lbl_dni";
			this.lbl_dni.Size = new System.Drawing.Size(52, 18);
			this.lbl_dni.TabIndex = 8;
			this.lbl_dni.Text = "D.N.I:";
			// 
			// lbl_email
			// 
			this.lbl_email.AutoSize = true;
			this.lbl_email.BackColor = System.Drawing.Color.Transparent;
			this.lbl_email.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.lbl_email.ForeColor = System.Drawing.SystemColors.Window;
			this.lbl_email.Location = new System.Drawing.Point(102, 286);
			this.lbl_email.Name = "lbl_email";
			this.lbl_email.Size = new System.Drawing.Size(61, 18);
			this.lbl_email.TabIndex = 9;
			this.lbl_email.Text = "E-Mail:";
			// 
			// txt_apellido
			// 
			this.txt_apellido.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txt_apellido.Location = new System.Drawing.Point(102, 122);
			this.txt_apellido.Name = "txt_apellido";
			this.txt_apellido.Size = new System.Drawing.Size(242, 23);
			this.txt_apellido.TabIndex = 1;
			// 
			// txt_email
			// 
			this.txt_email.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txt_email.Location = new System.Drawing.Point(102, 306);
			this.txt_email.Name = "txt_email";
			this.txt_email.Size = new System.Drawing.Size(242, 23);
			this.txt_email.TabIndex = 5;
			// 
			// txt_nombre
			// 
			this.txt_nombre.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txt_nombre.Location = new System.Drawing.Point(102, 76);
			this.txt_nombre.Name = "txt_nombre";
			this.txt_nombre.Size = new System.Drawing.Size(242, 23);
			this.txt_nombre.TabIndex = 0;
			// 
			// txt_dni
			// 
			this.txt_dni.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txt_dni.Location = new System.Drawing.Point(102, 260);
			this.txt_dni.Name = "txt_dni";
			this.txt_dni.Size = new System.Drawing.Size(242, 23);
			this.txt_dni.TabIndex = 4;
			// 
			// lbl_titulo
			// 
			this.lbl_titulo.AutoSize = true;
			this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
			this.lbl_titulo.Font = new System.Drawing.Font("Lucida Fax", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
			this.lbl_titulo.ForeColor = System.Drawing.SystemColors.Window;
			this.lbl_titulo.Location = new System.Drawing.Point(5, 9);
			this.lbl_titulo.Name = "lbl_titulo";
			this.lbl_titulo.Size = new System.Drawing.Size(419, 32);
			this.lbl_titulo.TabIndex = 14;
			this.lbl_titulo.Text = "Ingrese los siguientes datos";
			// 
			// txt_numeroTelefono
			// 
			this.txt_numeroTelefono.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txt_numeroTelefono.Location = new System.Drawing.Point(102, 353);
			this.txt_numeroTelefono.Name = "txt_numeroTelefono";
			this.txt_numeroTelefono.Size = new System.Drawing.Size(242, 23);
			this.txt_numeroTelefono.TabIndex = 6;
			// 
			// lbl_numeroTelefono
			// 
			this.lbl_numeroTelefono.AutoSize = true;
			this.lbl_numeroTelefono.BackColor = System.Drawing.Color.Transparent;
			this.lbl_numeroTelefono.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.lbl_numeroTelefono.ForeColor = System.Drawing.SystemColors.Window;
			this.lbl_numeroTelefono.Location = new System.Drawing.Point(101, 332);
			this.lbl_numeroTelefono.Name = "lbl_numeroTelefono";
			this.lbl_numeroTelefono.Size = new System.Drawing.Size(80, 18);
			this.lbl_numeroTelefono.TabIndex = 16;
			this.lbl_numeroTelefono.Text = "Telefono:";
			// 
			// frmNuevoUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(436, 493);
			this.Controls.Add(this.lbl_numeroTelefono);
			this.Controls.Add(this.txt_numeroTelefono);
			this.Controls.Add(this.lbl_titulo);
			this.Controls.Add(this.txt_dni);
			this.Controls.Add(this.txt_nombre);
			this.Controls.Add(this.txt_email);
			this.Controls.Add(this.txt_apellido);
			this.Controls.Add(this.lbl_email);
			this.Controls.Add(this.lbl_dni);
			this.Controls.Add(this.lbl_apellido);
			this.Controls.Add(this.lbl_nombre);
			this.Controls.Add(this.lbl_contraseña);
			this.Controls.Add(this.lbl_nuevoUsario);
			this.Controls.Add(this.txt_contraseña);
			this.Controls.Add(this.txt_nombreUsuario);
			this.Controls.Add(this.btn_cancelar);
			this.Controls.Add(this.btn_confirmar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmNuevoUsuario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NuevoUsuario";
			this.Load += new System.EventHandler(this.frmNuevoUsuario_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button btn_confirmar;
		private Button btn_cancelar;
		private TextBox txt_nombreUsuario;
		private TextBox txt_contraseña;
		private Label lbl_nuevoUsario;
		private Label lbl_contraseña;
		private Label lbl_nombre;
		private Label lbl_apellido;
		private Label lbl_dni;
		private Label lbl_email;
		private TextBox txt_apellido;
		private TextBox txt_email;
		private TextBox txt_nombre;
		private TextBox txt_dni;
		private Label lbl_titulo;
		private TextBox txt_numeroTelefono;
		private Label lbl_numeroTelefono;
	}
}