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
	public partial class FrmSeleccionarClientePasajero:Form {
		private Cliente? cliente;
		private Vuelo vuelo;
		private int cantidadDeTickets;
		private bool esPremium;
		private DateTime fechaDePartida;
		private double pesoValijas;
		public FrmSeleccionarClientePasajero(Vuelo vuelo, int cantidadMaximaTickets,bool esPremium, DateTime fechaDePartida) {
			InitializeComponent();
			this.vuelo = vuelo;
			this.cantidadDeTickets = cantidadMaximaTickets;
			this.esPremium=esPremium;
			this.fechaDePartida=fechaDePartida;
		}
		private void FrmSeleccionarClientePasajero_Load(object sender,EventArgs e) {
			btn_repotarPeso.Visible=true;
			lbl_mostrarPeso.Visible=false;
		}
		private void btn_seleccionarCliente_Click(object sender,EventArgs e) {
			FrmInformesClientes seleccionarCliente =new FrmInformesClientes(this.cantidadDeTickets);
			seleccionarCliente.ShowDialog();
			if(seleccionarCliente.DialogResult==DialogResult.OK) {
				dtg_mostrarClientes.DataSource=seleccionarCliente.ClienteSeleccionado;
			}
		}

		private void btn_cancelar_Click(object sender,EventArgs e) {
			this.DialogResult=DialogResult.Cancel;
		}

		private void dtg_mostrarClientes_CellContentClick(object sender,DataGridViewCellEventArgs e) {
			//este va a mostrar calculos de cada cliente del vuelo
			cliente=(Cliente)dtg_mostrarClientes.CurrentRow.DataBoundItem;

		}

		

		private void btn_venderVuelo_Click(object sender,EventArgs e) {

		}

		private void chk_comida_CheckedChanged(object sender,EventArgs e) {
			if(chk_comida.Checked) {
				cmb_comidas.Visible=true;
				cmb_comidas.DataSource = Enum.GetValues(typeof(Comida));
			}
			else {
				cmb_comidas.Visible=false;
			}
		}

		private void btn_confirmarPasajero_Click(object sender,EventArgs e) {
			btn_repotarPeso.Visible=true;
			lbl_mostrarPeso.Visible=false;
			
			
			
			
			
			
			
			
			
			//Pasajero nuevoPasajero=new Pasajero()
		}

		private void nud_cantidadValijas_ValueChanged(object sender,EventArgs e) {
			nud_cantidadValijas.Minimum=1;
			
			if(esPremium) {
				nud_cantidadValijas.Maximum=2;
			}
			else {
				nud_cantidadValijas.Maximum=1;
			}
		}

		private void button1_Click(object sender,EventArgs e) {
			pesoValijas=Sistema.CalcularPesoValijas(this.esPremium);
			btn_repotarPeso.Visible=false;
			lbl_mostrarPeso.Visible=true;
			lbl_mostrarPeso.Text=Sistema.MostrarDatosEquipajeReportado(rdb_tieneBolsoDeMano.Checked,esPremium, pesoValijas);
		}

	}
}
