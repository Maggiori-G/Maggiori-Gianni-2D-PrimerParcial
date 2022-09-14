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
		}
		private void login_Load(object sender,EventArgs e) {
			Sistema.PrecargarUsuario();
			musicaLogin.URL = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"All_Aboard.wav");
			musicaLogin.controls.play();
		}
		private void btn_salir_Click(object sender,EventArgs e) {
			this.Close();
		}
		private void btn_iniciarSesion_Click(object sender,EventArgs e) {
			Usuario usuarioParaVerificar=new Usuario(txt_usuario.Text.Trim(),txt_contraseña.Text.Trim());
			if(ValidarTextBox(this)) {
				if(Sistema.ValidarDatosUsuarioExistente(usuarioParaVerificar)) {
				frmPantallaPrincipal pantallaPrincipal=new frmPantallaPrincipal(usuarioParaVerificar);
				pantallaPrincipal.Show();
				this.Hide();
				}
				else {
					MessageBox.Show("Usuario o clave incorrecto");
				}
			}
			else {
				MessageBox.Show("Debe ingresar usuario y contraseña para poder iniciar sesión");
			}
		}
		private void btn_autocompletar_Click(object sender,EventArgs e) {
			this.txt_usuario.Text="admin";
			this.txt_contraseña.Text="1234";
		}
		private void btn_nuevoUsuario_Click(object sender,EventArgs e) {
			frmNuevoUsuario nuevoUsuario=new frmNuevoUsuario();
			this.Hide();
			nuevoUsuario.Show();

		}
		internal static bool ValidarTextBox(Form form) {
			bool retorno=true;
			foreach(Control	control in form.Controls) {
				if(control is TextBox && string.IsNullOrEmpty(control.Text)) {
					retorno=false;
					break;
				}
			}
			return retorno;
		}
	}
}