using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaAerolinea {
	public partial class FrmPantallaPrincipal:Form {
		private Usuario? usuario;
		public FrmPantallaPrincipal(Usuario usuarioRecibido) {
			InitializeComponent();
			this.IsMdiContainer=true;
			this.usuario=usuarioRecibido;
			lbl_usuarioIngresado.Text=usuario.NombreDeUsuario;
			lbl_fechaActual.Text=DateTime.Now.ToShortDateString();
		}
		private void cerrarSesiónToolStripMenuItem_Click(object sender,EventArgs e) {
			this.DialogResult=DialogResult.OK;
		}
		private void informaciónVuelosToolStripMenuItem_Click_1(object sender,EventArgs e) {
			ControlVista.AbrirForm(this, new FrmInformesVuelo());
		}
		private void informaciónAvionesToolStripMenuItem_Click(object sender,EventArgs e) {
			ControlVista.AbrirForm(this, new FrmInformesAviones());
		}
		private void informaciónClientesToolStripMenuItem_Click(object sender,EventArgs e) {
			ControlVista.AbrirForm(this, new FrmInformesClientes());
		}
		private void venderToolStripMenuItem_Click(object sender,EventArgs e) {
			ControlVista.AbrirForm(this, new frmVentasDePasajes());
		}
		private void modificarUsuarioToolStripMenuItem_Click(object sender,EventArgs e) {
			if(usuario is not null) {
				frmNuevoUsuario usuarioParaModificar= new frmNuevoUsuario(usuario);
				usuarioParaModificar.ShowDialog();
				if(usuarioParaModificar.DialogResult==DialogResult.OK) {
					usuario=usuarioParaModificar.UsuarioAuxiliar;
					lbl_usuarioIngresado.Text=usuario!.NombreDeUsuario;
				}
			}
		}
		private void datosHistorialesDeFacturacionToolStripMenuItem_Click(object sender,EventArgs e) {
			new FrmDatosHistoricos().ShowDialog();
		}
		private void salirToolStripMenuItem_Click(object sender,EventArgs e) {
			ControlVista.Salir(this);
		}

		private void destinosToolStripMenuItem_Click(object sender,EventArgs e) {

		}
	}
}
