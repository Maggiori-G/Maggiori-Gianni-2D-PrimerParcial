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
	public partial class frmPantallaPrincipal:Form {
		public frmPantallaPrincipal(Usuario nuevoUsuario) {
			InitializeComponent();
			this.IsMdiContainer = true;
		}
		private void frmPantallaPrincipal_Load(object sender,EventArgs e) {
			
		}
		private void nuevoAvionToolStripMenuItem_Click(object sender,EventArgs e) {
			ControlVista.AbrirForm(this, new frmNuevoAvion());
		}
		private void venderToolStripMenuItem_Click(object sender,EventArgs e) {
			ControlVista.AbrirForm(this, new frmVentasDePasajes());
		}
		private void modificarUsuarioToolStripMenuItem_Click(object sender,EventArgs e) {
			ControlVista.AbrirForm(this, new FrmModificarUsuario());
		}
		private void salirToolStripMenuItem_Click(object sender,EventArgs e) {
			ControlVista.Salir(this);
		}

	}
}
