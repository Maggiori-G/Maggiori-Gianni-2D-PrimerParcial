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
	public partial class FrmInformesAviones:Form {
		private List<Vuelo> vuelosParaMostrar;
		private Avion? avionMostrar;

		public FrmInformesAviones() {
			InitializeComponent();
			vuelosParaMostrar=new List<Vuelo>();
		}
		private void FrmInformesAviones_Load(object sender,EventArgs e) {
			vuelosParaMostrar=Sistema.ListaDeVuelos;
			cb_seleccionarAvion.DataSource=Sistema.ListaDeAviones;
		}

		private void GenerarHistorialVuelos(string patente) {
			List<Vuelo> auxLista =Sistema.GenerarHistorialDeVuelos(patente, vuelosParaMostrar!)!;
			if(auxLista.Count>0) {
				lbl_mensaje.Visible=false; 
				dgw_listaPasajerosDeUnVuelo.Visible=true;
				if(auxLista is not null && auxLista.Count>0) {
					LimpiarDataGrid(auxLista);
					if(dgw_listaPasajerosDeUnVuelo.Columns["Patente"] is not null) {
						dgw_listaPasajerosDeUnVuelo.Columns["EsInternacional"].Visible=false;
						dgw_listaPasajerosDeUnVuelo.Columns["Patente"].Visible=false;
						dgw_listaPasajerosDeUnVuelo.Columns["Avion"].Visible=false;
					}
				}
			}
			else {
				dgw_listaPasajerosDeUnVuelo.DataSource=null;
				dgw_listaPasajerosDeUnVuelo.Visible=false;
				lbl_mensaje.Visible=true;
			}
		}

		public void LimpiarDataGrid(List<Vuelo>? auxLista) {
			dgw_listaPasajerosDeUnVuelo.DataSource=null;
			dgw_listaPasajerosDeUnVuelo.DataSource=auxLista;
		}

		private void cb_seleccionarAvion_SelectedIndexChanged(object sender,EventArgs e) {
			avionMostrar=Sistema.EncontrarAvionPorPatente(cb_seleccionarAvion.Text);
			if(avionMostrar is not null) {
				GenerarHistorialVuelos(cb_seleccionarAvion.Text);
				lbl_mostrarPatente.Text=avionMostrar.Patente;
				lbl_mostrarEstadoAvion.Text=avionMostrar.EstaEnVuelo;
				lbl_mostrarCapacidadMaximaDeAsientos.Text=avionMostrar.CapacidadDeAsientos.ToString();
				lbl_mostrarPesoMaximoBodega.Text=avionMostrar.PesoMaximo.ToString()+" Kg";
				lbl_mostrarCantidadBaños.Text=avionMostrar.CantidadDeBaños.ToString();
			}
		}
	}
}
