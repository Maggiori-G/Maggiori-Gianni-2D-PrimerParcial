namespace VistaAerolinea {
	partial class frmLogin {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			this.txt_usuario = new System.Windows.Forms.TextBox();
			this.txt_contraseña = new System.Windows.Forms.TextBox();
			this.btn_iniciarSesion = new System.Windows.Forms.Button();
			this.btn_nuevoUsuario = new System.Windows.Forms.Button();
			this.lbl_nombreUsuario = new System.Windows.Forms.Label();
			this.lbl_contraseña = new System.Windows.Forms.Label();
			this.lbl_nuevoUsuario = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lbl_divisor = new System.Windows.Forms.Label();
			this.btn_salir = new System.Windows.Forms.Button();
			this.btn_autocompletar = new System.Windows.Forms.Button();
			this.lbl_nombreApp = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txt_usuario
			// 
			this.txt_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txt_usuario.BackColor = System.Drawing.SystemColors.Window;
			this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_usuario.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.txt_usuario.ForeColor = System.Drawing.Color.Black;
			this.txt_usuario.Location = new System.Drawing.Point(10, 262);
			this.txt_usuario.Name = "txt_usuario";
			this.txt_usuario.Size = new System.Drawing.Size(200, 26);
			this.txt_usuario.TabIndex = 0;
			// 
			// txt_contraseña
			// 
			this.txt_contraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_contraseña.BackColor = System.Drawing.SystemColors.Window;
			this.txt_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_contraseña.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.txt_contraseña.ForeColor = System.Drawing.Color.Black;
			this.txt_contraseña.Location = new System.Drawing.Point(10, 318);
			this.txt_contraseña.Name = "txt_contraseña";
			this.txt_contraseña.PasswordChar = '*';
			this.txt_contraseña.Size = new System.Drawing.Size(200, 26);
			this.txt_contraseña.TabIndex = 1;
			// 
			// btn_iniciarSesion
			// 
			this.btn_iniciarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_iniciarSesion.BackColor = System.Drawing.Color.Salmon;
			this.btn_iniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_iniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_iniciarSesion.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btn_iniciarSesion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btn_iniciarSesion.Location = new System.Drawing.Point(10, 350);
			this.btn_iniciarSesion.Name = "btn_iniciarSesion";
			this.btn_iniciarSesion.Size = new System.Drawing.Size(200, 34);
			this.btn_iniciarSesion.TabIndex = 2;
			this.btn_iniciarSesion.Text = "Iniciar Sesión";
			this.btn_iniciarSesion.UseVisualStyleBackColor = false;
			this.btn_iniciarSesion.Click += new System.EventHandler(this.btn_iniciarSesion_Click);
			// 
			// btn_nuevoUsuario
			// 
			this.btn_nuevoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_nuevoUsuario.BackColor = System.Drawing.Color.Salmon;
			this.btn_nuevoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_nuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_nuevoUsuario.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btn_nuevoUsuario.Location = new System.Drawing.Point(371, 532);
			this.btn_nuevoUsuario.Name = "btn_nuevoUsuario";
			this.btn_nuevoUsuario.Size = new System.Drawing.Size(147, 34);
			this.btn_nuevoUsuario.TabIndex = 4;
			this.btn_nuevoUsuario.Text = "Nuevo Usuario";
			this.btn_nuevoUsuario.UseVisualStyleBackColor = false;
			this.btn_nuevoUsuario.Click += new System.EventHandler(this.btn_nuevoUsuario_Click);
			// 
			// lbl_nombreUsuario
			// 
			this.lbl_nombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbl_nombreUsuario.AutoSize = true;
			this.lbl_nombreUsuario.BackColor = System.Drawing.Color.Transparent;
			this.lbl_nombreUsuario.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbl_nombreUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lbl_nombreUsuario.Location = new System.Drawing.Point(10, 235);
			this.lbl_nombreUsuario.Name = "lbl_nombreUsuario";
			this.lbl_nombreUsuario.Size = new System.Drawing.Size(95, 24);
			this.lbl_nombreUsuario.TabIndex = 5;
			this.lbl_nombreUsuario.Text = "Usuario";
			// 
			// lbl_contraseña
			// 
			this.lbl_contraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbl_contraseña.AutoSize = true;
			this.lbl_contraseña.BackColor = System.Drawing.Color.Transparent;
			this.lbl_contraseña.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbl_contraseña.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lbl_contraseña.Location = new System.Drawing.Point(10, 291);
			this.lbl_contraseña.Name = "lbl_contraseña";
			this.lbl_contraseña.Size = new System.Drawing.Size(135, 24);
			this.lbl_contraseña.TabIndex = 6;
			this.lbl_contraseña.Text = "Contraseña";
			// 
			// lbl_nuevoUsuario
			// 
			this.lbl_nuevoUsuario.AutoSize = true;
			this.lbl_nuevoUsuario.BackColor = System.Drawing.Color.Transparent;
			this.lbl_nuevoUsuario.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbl_nuevoUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lbl_nuevoUsuario.Location = new System.Drawing.Point(259, 502);
			this.lbl_nuevoUsuario.Name = "lbl_nuevoUsuario";
			this.lbl_nuevoUsuario.Size = new System.Drawing.Size(384, 27);
			this.lbl_nuevoUsuario.TabIndex = 8;
			this.lbl_nuevoUsuario.Text = "¿Sos nuevo en la plataforma?";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(190, 487);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(497, 15);
			this.label1.TabIndex = 9;
			this.label1.Text = "---------------------------------------------------------------------------------" +
    "-----------------";
			// 
			// lbl_divisor
			// 
			this.lbl_divisor.AutoSize = true;
			this.lbl_divisor.BackColor = System.Drawing.Color.Transparent;
			this.lbl_divisor.ForeColor = System.Drawing.SystemColors.Window;
			this.lbl_divisor.Location = new System.Drawing.Point(188, 569);
			this.lbl_divisor.Name = "lbl_divisor";
			this.lbl_divisor.Size = new System.Drawing.Size(497, 15);
			this.lbl_divisor.TabIndex = 10;
			this.lbl_divisor.Text = "---------------------------------------------------------------------------------" +
    "-----------------";
			// 
			// btn_salir
			// 
			this.btn_salir.BackColor = System.Drawing.Color.Salmon;
			this.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_salir.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btn_salir.Location = new System.Drawing.Point(793, 625);
			this.btn_salir.Name = "btn_salir";
			this.btn_salir.Size = new System.Drawing.Size(75, 37);
			this.btn_salir.TabIndex = 11;
			this.btn_salir.Text = "Salir";
			this.btn_salir.UseVisualStyleBackColor = false;
			this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
			// 
			// btn_autocompletar
			// 
			this.btn_autocompletar.BackColor = System.Drawing.Color.Salmon;
			this.btn_autocompletar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_autocompletar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_autocompletar.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btn_autocompletar.Location = new System.Drawing.Point(10, 390);
			this.btn_autocompletar.Name = "btn_autocompletar";
			this.btn_autocompletar.Size = new System.Drawing.Size(200, 34);
			this.btn_autocompletar.TabIndex = 12;
			this.btn_autocompletar.Text = "Test";
			this.btn_autocompletar.UseVisualStyleBackColor = false;
			this.btn_autocompletar.Click += new System.EventHandler(this.btn_autocompletar_Click);
			// 
			// lbl_nombreApp
			// 
			this.lbl_nombreApp.AutoSize = true;
			this.lbl_nombreApp.BackColor = System.Drawing.Color.Transparent;
			this.lbl_nombreApp.Font = new System.Drawing.Font("Lucida Handwriting", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lbl_nombreApp.Location = new System.Drawing.Point(251, 38);
			this.lbl_nombreApp.Name = "lbl_nombreApp";
			this.lbl_nombreApp.Size = new System.Drawing.Size(392, 48);
			this.lbl_nombreApp.TabIndex = 13;
			this.lbl_nombreApp.Text = "Bazinga Airlines";
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.WindowText;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(880, 674);
			this.Controls.Add(this.lbl_nombreApp);
			this.Controls.Add(this.btn_autocompletar);
			this.Controls.Add(this.btn_salir);
			this.Controls.Add(this.lbl_divisor);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbl_nuevoUsuario);
			this.Controls.Add(this.lbl_contraseña);
			this.Controls.Add(this.lbl_nombreUsuario);
			this.Controls.Add(this.btn_nuevoUsuario);
			this.Controls.Add(this.btn_iniciarSesion);
			this.Controls.Add(this.txt_contraseña);
			this.Controls.Add(this.txt_usuario);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.Load += new System.EventHandler(this.login_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox txt_usuario;
		private TextBox txt_contraseña;
		private Button btn_iniciarSesion;
		private Button btn_nuevoUsuario;
		private Label lbl_nombreUsuario;
		private Label lbl_contraseña;
		private Label lbl_nuevoUsuario;
		private Label label1;
		private Label lbl_divisor;
		private Button btn_salir;
		private Button btn_autocompletar;
		private Label lbl_nombreApp;
	}
}