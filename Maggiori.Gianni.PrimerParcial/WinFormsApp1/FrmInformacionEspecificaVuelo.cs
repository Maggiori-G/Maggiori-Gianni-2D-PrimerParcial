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
	public partial class FrmInformacionEspecificaVuelo:Form {
		Vuelo? vuelo;
		Pasajero? pasajero;
		public FrmInformacionEspecificaVuelo(Vuelo vuelo) {
			InitializeComponent();
			this.vuelo = vuelo;
		}

		private void FrmInformacionEspecificaVuelo_Load(object sender,EventArgs e) {
			dgw_listaPasajeros.DataSource=null;
			dgw_listaPasajeros.DataSource=vuelo!.PasajerosAbordo;
			OcultarColumnas();
			gb_listaPasajeros.Text="Lista de pasajeros del vuelo: "+vuelo.Patente;
			OcultarLabelsInfoPasajero();
		}

		private void MostrarLabelsInfoPasajero() {
			lbl_bolsoDeMano.Visible=true;
			lbl_comidaOrdenada.Visible=true;
			lbl_contratoWifi.Visible=true;
			lbl_pesoValijas.Visible=true;
			lbl_tipoPasajero.Visible=true;
		}

		private void OcultarLabelsInfoPasajero() {
			lbl_bolsoDeMano.Visible=false;
			lbl_comidaOrdenada.Visible=false;
			lbl_contratoWifi.Visible=false;
			lbl_pesoValijas.Visible=false;
			lbl_tipoPasajero.Visible=false;
		}

		private void dgw_listaPasajeros_CellContentClick(object sender,DataGridViewCellEventArgs e) {
			pasajero=(Pasajero)dgw_listaPasajeros.CurrentRow.DataBoundItem;
			if(pasajero is not null) {
				gb_informacionPasajero.Text="Información de: "+pasajero.Nombre+", "+pasajero.Apellido;
				this.CargarLabelsParaMostrarInfoPasajero();
				this.MostrarLabelsInfoPasajero();
			}
		}

		private void CargarLabelsParaMostrarInfoPasajero() {
			if(pasajero is not null){
				if(pasajero.TieneBolsoDeMano) {
					lbl_bolsoDeMano.Text="Si";
				}
				else {
					lbl_bolsoDeMano.Text="No";
				}
				lbl_comidaOrdenada.Text=pasajero.TipoComida.ToString();
				if(pasajero.ContratoWifi) {
					lbl_contratoWifi.Text="Si";
				}
				else {
					lbl_contratoWifi.Text="No";
				}
				lbl_pesoValijas.Text=pasajero.PesoValijas.ToString();
				rtb_mostrarDatosFacturacion.Text=pasajero.ToString();
				if(pasajero.PrimeraClase) {
					lbl_clase.Text="Primera Clase";
				}
				else {
					lbl_clase.Text="Primera Clase";
				}
				if(pasajero.PrimeraClase) {
					lbl_tipoPasajero.Text="Primera Clase";
				}
				else {
					lbl_tipoPasajero.Text="Clase Comercial";
				}

			}
		}

		private void OcultarColumnas() {
			dgw_listaPasajeros.Columns["PesoValijas"].Visible=false;
			dgw_listaPasajeros.Columns["CantidadMaximaTickets"].Visible=false;
			dgw_listaPasajeros.Columns["ContratoWifi"].Visible=false;
			dgw_listaPasajeros.Columns["TipoComida"].Visible=false;
			dgw_listaPasajeros.Columns["TieneBolsoDeMano"].Visible=false;
			dgw_listaPasajeros.Columns["Precio"].Visible=false;
			dgw_listaPasajeros.Columns["Id"].Visible=false;
			dgw_listaPasajeros.Columns["PrimeraClase"].Visible=false;
			dgw_listaPasajeros.Columns["ContratoPeliculas"].Visible=false;
		}

		private void btn_volver_Click(object sender,EventArgs e) {
			this.DialogResult=DialogResult.OK;
		}

	}
}
