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
		
		public frmNuevoUsuario() {
			InitializeComponent();
		}
		private void frmNuevoUsuario_Load(object sender,EventArgs e) {
			
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
	}
}
