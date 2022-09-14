using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaAerolinea {
	public partial class frmNuevoUsuario:Form {
		private Usuario usuario;
		public frmNuevoUsuario() {
			InitializeComponent();
		}

		public Usuario Usuario {
			get {
				return usuario;
			}
		}
		private void frmNuevoUsuario_Load(object sender,EventArgs e) {
			
		}
		private void btn_confirmar_Click(object sender,EventArgs e) {
			if(frmLogin.ValidarTextBox(this)) {
				usuario = new Usuario(txt_nombre.Text.Trim(),txt_apellido.Text.Trim(),txt_nombreUsuario.Text.Trim(),txt_contraseña.Text.Trim(),txt_email.Text.Trim(),txt_dni.Text.Trim());
			}
		}
		
		private void btn_cancelar_Click(object sender,EventArgs e) {
			this.Close();
		}

		
	}
}
