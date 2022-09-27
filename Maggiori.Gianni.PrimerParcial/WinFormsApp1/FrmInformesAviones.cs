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
		private List<string> patentesParaMostrar;
		private Avion? avionMostrar;
		public FrmInformesAviones() {
			InitializeComponent();
			patentesParaMostrar=new List<string>();
		}
		private void FrmInformesAviones_Load(object sender,EventArgs e) {
			CargarLaListaDePatentesParaMostrarEnComboBox();
			cb_seleccionarAvion.DataSource=patentesParaMostrar;
		}
		
		private void CargarLaListaDePatentesParaMostrarEnComboBox() {
			foreach(Avion item in Sistema.ListaDeAviones) {
				patentesParaMostrar.Add(item.Patente);
			}
		}
		private void cb_seleccionarAvion_SelectedIndexChanged(object sender,EventArgs e) {
			avionMostrar=Sistema.EncontrarAvionPorPatente(cb_seleccionarAvion.Text);
			if(avionMostrar is not null) {
				lbl_mostrarPatente.Text=avionMostrar.Patente;
				lbl_mostrarEstadoAvion.Text=avionMostrar.EstaEnVuelo;
				lbl_mostrarCapacidadMaximaDeAsientos.Text=avionMostrar.CapacidadDeAsientos.ToString();
				lbl_mostrarPesoMaximoBodega.Text=avionMostrar.PesoMaximo.ToString()+" Kg";
				lbl_mostrarCantidadBaños.Text=avionMostrar.CantidadDeBaños.ToString();
			}
		}
	}
}
