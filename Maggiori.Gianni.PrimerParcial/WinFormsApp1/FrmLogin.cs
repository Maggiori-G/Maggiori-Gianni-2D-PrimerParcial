using System.Media;
using System.IO;
using Entidades;
using WMPLib;

namespace VistaAerolinea {
	public partial class frmLogin:Form {
		private WindowsMediaPlayer musicaLogin;
		
		public frmLogin() {
			InitializeComponent();
			musicaLogin = new WindowsMediaPlayer();
			Sistema.PrecargarUsuario();
		}
		private void login_Load(object sender,EventArgs e) {
			musicaLogin.URL = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"All_Aboard.wav");
			musicaLogin.controls.play();
		}
		private void btn_salir_Click(object sender,EventArgs e) {
			this.Close();
		}
		private void btn_iniciarSesion_Click(object sender,EventArgs e) {
			Usuario? usuarioIngresado;
			if(ControlVista.ValidarTextBox(this)) {
				usuarioIngresado=Sistema.ValidarDatosUsuarioExistente(txt_usuario.Text.Trim(),txt_contraseņa.Text.Trim());
				if(usuarioIngresado is not null) {
					FrmPantallaPrincipal pantallaPrincipal=new FrmPantallaPrincipal(usuarioIngresado);
					this.Hide();
					DialogResult resultado=pantallaPrincipal.ShowDialog();
					if(resultado==DialogResult.OK) {
						this.Show();
					}
				}
				else {
					MessageBox.Show("No se encontrķ el usuario");
				}
			}
			else {
				MessageBox.Show("Debe ingresar nombre de usuario y contraseņa");
			}
		}
		private void btn_autocompletar_Click(object sender,EventArgs e) {
			this.txt_usuario.Text="PepePeposo";
			this.txt_contraseņa.Text="pepe1";
		}
		private void btn_nuevoUsuario_Click(object sender,EventArgs e) {
			this.Hide();
			new frmNuevoUsuario().ShowDialog();
			this.Show();
		}
	}
}