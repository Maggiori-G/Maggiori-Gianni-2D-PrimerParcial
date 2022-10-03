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
	public partial class FrmInformesClientes:Form {
		private List<Cliente>? listaClienteSeleccionado;
		private int cantidadDeSelecciones;
		public List<Cliente> ClienteSeleccionado {
			get {
				return listaClienteSeleccionado!;
			}
		}
		public FrmInformesClientes() {
			InitializeComponent();
			btn_seleccionarCliente.Visible=false;
		}
		public FrmInformesClientes(int cantidad):this() {
			listaClienteSeleccionado = new List<Cliente>();
			btn_seleccionarCliente.Visible=true;
			cantidadDeSelecciones=cantidad;
		}
		private void FrmInformesClientes_Load(object sender,EventArgs e) {
			dgw1_dataClientes.DataSource=Sistema.ListaClientes;
		}
		private void btn_limpiar_Click(object sender,EventArgs e) {
			Limpiar();

		}
		private void Limpiar() {
			txt_buscar.Text=string.Empty;
			dgw1_dataClientes.DataSource=null;
			dgw1_dataClientes.DataSource=Sistema.ListaClientes;
		}
		private void btn_nuevoCliente_Click(object sender,EventArgs e) {
			FrmNuevoCliente frmNuevoCliente = new FrmNuevoCliente();
			frmNuevoCliente.ShowDialog();
			if(frmNuevoCliente.DialogResult==DialogResult.OK) {
				if(frmNuevoCliente.NuevoCliente is not null) {
					Sistema.ListaClientes.Add(frmNuevoCliente.NuevoCliente);
					Limpiar();
				}
			}
		}
		private void btn_modificar_Click(object sender,EventArgs e) {
			
			FrmNuevoCliente frmNuevoCliente=new FrmNuevoCliente((Cliente)dgw1_dataClientes.CurrentRow.DataBoundItem);
			frmNuevoCliente.ShowDialog();
			if( frmNuevoCliente.DialogResult==DialogResult.OK) {
				if(frmNuevoCliente.NuevoCliente is not null) {
					int index=Sistema.ObtenerIndiceClientePorDni(frmNuevoCliente.NuevoCliente.Dni);
					Sistema.ListaClientes[index]=frmNuevoCliente.NuevoCliente;
					Limpiar();
				}
			}
		}
		private void txt_buscar_TextChanged(object sender,EventArgs e) {
			List<Cliente> auxListaClientes = new List<Cliente>();
			foreach(Cliente cliente in Sistema.ListaClientes) {
				if(cliente.Dni.StartsWith(txt_buscar.Text)) {
					auxListaClientes.Add(cliente);
				}
			}
			dgw1_dataClientes.DataSource=auxListaClientes;
		}

		private void btn_eliminarCliente_Click(object sender,EventArgs e) {
			Cliente? auxCliente = dgw1_dataClientes.CurrentRow.DataBoundItem as Cliente;
			if(auxCliente is not null) {
				MessageBox.Show($"Se eliminó a {auxCliente.Nombre}, {auxCliente.Apellido} con DNI: {auxCliente.Dni}");
				Sistema.ListaClientes.Remove(auxCliente);
				Limpiar();
			}
		}

		private void btn_seleccionarCliente_Click(object sender,EventArgs e) {
			listaClienteSeleccionado!.Add((Cliente)dgw1_dataClientes.CurrentRow.DataBoundItem);
			if(listaClienteSeleccionado.Count==cantidadDeSelecciones) {
				this.DialogResult=DialogResult.OK;
			}
		}
	}
}
