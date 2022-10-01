using Entidades;

namespace VistaAerolinea {
	public partial class FrmSeleccionarClientePasajero:Form {

		private Cliente? cliente;
		private Vuelo vuelo;
		private int cantidadDeTickets;
		private bool esPremium;
		//private DateTime fechaDePartida;
		private double pesoValijas;
		private List<Cliente> listaClientes;
		private List<Pasajero> listaPasajeros;

		public List<Pasajero> Pasajeros {
			get {
				return listaPasajeros;
			}
		}

		public FrmSeleccionarClientePasajero(Vuelo vuelo,int cantidadMaximaTickets,bool esPremium,DateTime fechaDePartida) {
			InitializeComponent();
			this.vuelo=vuelo;
			this.cantidadDeTickets=cantidadMaximaTickets;
			this.esPremium=esPremium;
			//this.fechaDePartida=fechaDePartida;
			listaPasajeros=new List<Pasajero>();
		}
		private void FrmSeleccionarClientePasajero_Load(object sender,EventArgs e) {
			btn_repotarPeso.Visible=true;
			lbl_mostrarPeso.Visible=false;
			lbl_esInternacional.Text=vuelo.Tipo;
		}
		private void btn_seleccionarCliente_Click(object sender,EventArgs e) {
			listaClientes=new List<Cliente>();
			FrmInformesClientes seleccionarCliente = new FrmInformesClientes(this.cantidadDeTickets);
			seleccionarCliente.ShowDialog();
			if(seleccionarCliente.DialogResult==DialogResult.OK) {
				listaClientes=seleccionarCliente.ClienteSeleccionado;
				dgw_mostrarClientes.DataSource=listaClientes;
			}
		}

		private void btn_cancelar_Click(object sender,EventArgs e) {
			this.DialogResult=DialogResult.Cancel;
		}

		private void btn_venderVuelo_Click(object sender,EventArgs e) {
			vuelo.PasajerosAbordo.AddRange(listaPasajeros);
			if(esPremium) {
				vuelo.Avion.AsientosPrimerClase=cantidadDeTickets;
			}
			else {
				vuelo.Avion.AsientosComercial=cantidadDeTickets;
			}
			this.DialogResult=DialogResult.OK;
		}

		private void chk_comida_CheckedChanged(object sender,EventArgs e) {
			if(chk_comida.Checked) {
				cmb_comidas.Visible=true;
				cmb_comidas.DataSource=Enum.GetValues(typeof(Comida));
			}
			else {
				cmb_comidas.Visible=false;
			}
		}

		private void btn_confirmarPasajero_Click(object sender,EventArgs e) {
			btn_repotarPeso.Visible=true;
			lbl_mostrarPeso.Visible=false;
			cliente=(Cliente)dgw_mostrarClientes.CurrentRow.DataBoundItem;
			ConfirmarPasajero();
		}

		private void ConfirmarPasajero() {
			if(cliente is not null) {
				Pasajero nuevoPasajero = new Pasajero(pesoValijas,cantidadDeTickets,chk_wifi.Checked,(Comida)cmb_comidas.SelectedItem,esPremium,rdb_siPeliculas.Checked,this.cliente,rdb_tieneBolsoDeMano.Checked);
				Sistema.CalcularPrecioPasaje(vuelo.Precio,nuevoPasajero);
				CargarNuevoPasajero(nuevoPasajero);
				ActualizarDataGridClientes();
				chk_comida.Checked=false;
				chk_wifi.Checked=false;
				ResetearControlesOpcionesDelCliente();
			}
			else {
				MessageBox.Show("No se seleccionó ningun pasajero");
			}
		}

		private void ActualizarDataGridClientes() {
			dgw_mostrarClientes.DataSource=null;
			listaClientes.Remove(this.cliente);
			dgw_mostrarClientes.DataSource=listaClientes;
		}

		private void CargarNuevoPasajero(Pasajero nuevoPasajero) {
			listaPasajeros.Add(nuevoPasajero);
			dgw_pasajerosVuelo.DataSource=null;
			dgw_pasajerosVuelo.DataSource=listaPasajeros;
			OcultarColumnas();
		}

		private void ResetearControlesOpcionesDelCliente() {
			foreach(Control item in this.Controls) {
				if(item is CheckBox) {
					((CheckBox)item).Checked=false;
				}
				else if(item is RadioButton) {
					((RadioButton)item).Checked=false;
				}
				else if(item is NumericUpDown) {
					((NumericUpDown)item).Value=0;
				}
			}
		}

		private void OcultarColumnas() {
			dgw_pasajerosVuelo.Columns["CantidadMaximaTickets"].Visible=false;
			dgw_pasajerosVuelo.Columns["ContratoWifi"].Visible=false;
			dgw_pasajerosVuelo.Columns["PrimeraClase"].Visible=false;
			dgw_pasajerosVuelo.Columns["ContratoPeliculas"].Visible=false;
			dgw_pasajerosVuelo.Columns["TieneBolsoDeMano"].Visible=false;
			dgw_pasajerosVuelo.Columns["TipoComida"].Visible=false;
			dgw_pasajerosVuelo.Columns["Id"].Visible=false;
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
		private void btn_repotarPeso_Click(object sender,EventArgs e) {
			pesoValijas=Sistema.CalcularPesoValijas(this.esPremium);
			btn_repotarPeso.Visible=false;
			lbl_mostrarPeso.Visible=true;
			lbl_mostrarPeso.Text=Sistema.MostrarDatosEquipajeReportado(rdb_tieneBolsoDeMano.Checked,esPremium,pesoValijas);
		}
	}
}
