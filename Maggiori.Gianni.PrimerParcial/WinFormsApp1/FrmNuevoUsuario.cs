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
		private Usuario? usuarioAuxiliar;

		public Usuario? UsuarioAuxiliar {
			get {
				return usuarioAuxiliar;
			}
		}

		public frmNuevoUsuario() {
			InitializeComponent();
			btn_modificarUsuario.Visible=false;
		}
		public frmNuevoUsuario(Usuario usuario) {
			InitializeComponent();
			this.usuarioAuxiliar=usuario;
			btn_confirmar.Visible=false;
			ConfigurarLabelsParaModificar();
		}

		private void ConfigurarLabelsParaModificar() {
			if(usuarioAuxiliar is not null) {
				txt_nombre.Text=usuarioAuxiliar.Nombre;
				txt_nombre.ReadOnly=true;
				txt_apellido.Text=usuarioAuxiliar.Apellido;
				txt_apellido.ReadOnly=true;
				txt_dni.Text=usuarioAuxiliar.Dni;
				txt_dni.ReadOnly=true;
				txt_edad.Text=usuarioAuxiliar.Edad;
				txt_edad.ReadOnly=true;
				txt_nombreUsuario.Text=usuarioAuxiliar.NombreDeUsuario;
				txt_email.Text=usuarioAuxiliar.Email;
				txt_email.ReadOnly=true;
				txt_numeroTelefono.Text=usuarioAuxiliar.NumeroTelefono;
				txt_contraseña.Text=usuarioAuxiliar.Contraseña;				
			}
		}

		private void btn_confirmar_Click(object sender,EventArgs e) {
			if(ControlVista.ValidarTextBox(this)) {
				if(Sistema.AgregarNuevoUsuario(txt_nombre.Text,txt_apellido.Text,txt_nombreUsuario.Text,txt_contraseña.Text,txt_email.Text,txt_dni.Text, txt_numeroTelefono.Text,txt_edad.Text)) {
					this.DialogResult = DialogResult.OK;
				}
			}
		}
		private void btn_cancelar_Click(object sender,EventArgs e) {
			this.DialogResult=DialogResult.Cancel;
		}

		private void btn_modificarUsuario_Click(object sender,EventArgs e) {
			if(usuarioAuxiliar is not null) {
				if(ControlVista.ValidarTextBox(this)) {
					Usuario usuarioModificado=new Usuario(txt_nombreUsuario.Text.Trim(),txt_contraseña.Text.Trim(),usuarioAuxiliar.Nombre,usuarioAuxiliar.Apellido,usuarioAuxiliar.Edad,usuarioAuxiliar.Email,usuarioAuxiliar.Dni,lbl_numeroTelefono.Text.Trim());
					Sistema.ModificarUsuario(usuarioModificado);
					usuarioAuxiliar=usuarioModificado;
					this.DialogResult=DialogResult.OK;
				}
				else {
					MessageBox.Show("Los campos no pueden quedar vacios");
				}
			}			
		}
	}
}
