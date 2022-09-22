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
		public FrmPantallaPrincipal(Usuario usuario) {
			InitializeComponent();
			this.IsMdiContainer=true;
		}

		private void modificarUsuarioToolStripMenuItem_Click(object sender,EventArgs e) {
			ControlVista.AbrirForm(this, new FrmModificarUsuario());
		}

		private void cerrarSesiónToolStripMenuItem_Click(object sender,EventArgs e) {

		}

		private void informaciónVuelosToolStripMenuItem_Click(object sender,EventArgs e) {
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

		private void modificarToolStripMenuItem_Click(object sender,EventArgs e) {
			ControlVista.AbrirForm(this, new FrmModificarUsuario());
		}

		private void nuevoAvionToolStripMenuItem_Click(object sender,EventArgs e) {
			ControlVista.AbrirForm(this, new frmNuevoAvion());
		}

		private void modificarAvionToolStripMenuItem_Click(object sender,EventArgs e) {
			ControlVista.AbrirForm(this, new FrmModificarAvion());
		}

		private void salirToolStripMenuItem_Click(object sender,EventArgs e) {
			ControlVista.Salir(this);
		}
	}
}
