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
		private List<Vuelo>? vuelosParaMostrar;
		private Avion? avionMostrar;

		public FrmInformesAviones() {
			InitializeComponent();
			vuelosParaMostrar=new List<Vuelo>();
		}
		private void FrmInformesAviones_Load(object sender,EventArgs e) {
			cb_seleccionarAvion.DataSource=Sistema.ListaDeAviones;
			GenerarHistorialVuelos();
		}

		private void GenerarHistorialVuelos() {
			vuelosParaMostrar=Sistema.ListarHistorialDeVuelos((Avion)cb_seleccionarAvion.SelectedItem);
			dgw_listaPasajerosDeUnVuelo.DataSource=null;
			dgw_listaPasajerosDeUnVuelo.DataSource=vuelosParaMostrar;
		}

		private void cb_seleccionarAvion_SelectedIndexChanged(object sender,EventArgs e) {
			avionMostrar=Sistema.EncontrarAvionPorPatente(cb_seleccionarAvion.Text);
			if(avionMostrar is not null) {
				lbl_mostrarPatente.Text=avionMostrar.Patente;
				lbl_mostrarEstadoAvion.Text=avionMostrar.EstaEnVuelo;
				lbl_mostrarCapacidadMaximaDeAsientos.Text=avionMostrar.CapacidadDeAsientos.ToString();
				lbl_mostrarPesoMaximoBodega.Text=avionMostrar.PesoMaximo.ToString()+" Kg";
				lbl_mostrarCantidadBaños.Text=avionMostrar.CantidadDeBaños.ToString();
				GenerarHistorialVuelos();
			}
		}
	}
}
