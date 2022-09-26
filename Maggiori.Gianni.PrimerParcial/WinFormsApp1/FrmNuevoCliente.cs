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
	public partial class FrmNuevoCliente:Form {
		private Cliente? nuevoCliente;

		public Cliente? NuevoCliente {
			get {
				return nuevoCliente;
			}
		}

		public FrmNuevoCliente() {
			InitializeComponent();
		}
		public FrmNuevoCliente(Cliente clienteModificar) {
			InitializeComponent();
			txt_dni.Enabled=false;
			txt_nombre.Text=clienteModificar.Nombre;
			txt_apellido.Text=clienteModificar.Apellido;
			txt_edad.Text=clienteModificar.Edad;
			txt_email.Text=clienteModificar.Email;
			txt_dni.Text=clienteModificar.Dni;
			txt_telefono.Text=clienteModificar.NumeroTelefono;
			nuevoCliente=clienteModificar;
		}
		private void btn_cancelar_Click(object sender,EventArgs e) {
			this.Close();
		}

		private void btn_aceptar_Click(object sender,EventArgs e) {
			if(ControlVista.ValidarTextBox(this)) {
				if(nuevoCliente==null) {
					nuevoCliente= new Cliente(txt_nombre.Text.Trim(), txt_apellido.Text.Trim(), txt_edad.Text.Trim(), txt_email.Text.Trim(), txt_dni.Text.Trim(),txt_telefono.Text.Trim());	
				}
				else {
					nuevoCliente.Nombre=txt_nombre.Text.Trim();
					nuevoCliente.Apellido=txt_apellido.Text.Trim();
					nuevoCliente.Edad=txt_edad.Text.Trim();
					nuevoCliente.Email=txt_email.Text.Trim();
					nuevoCliente.NumeroTelefono=txt_telefono.Text.Trim();
				}
				this.DialogResult=DialogResult.OK;
			}
		}

	}
}
