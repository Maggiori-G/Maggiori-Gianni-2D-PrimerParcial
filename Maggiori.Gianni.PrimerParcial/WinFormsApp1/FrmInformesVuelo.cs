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
	public partial class FrmInformesVuelo:Form {
		List<Vuelo> vuelos;
		public FrmInformesVuelo() {
			InitializeComponent();
			vuelos=new List<Vuelo>();
		}
		private void FrmInformesVuelo_Load(object sender,EventArgs e) {
			rdb_historialCompleto.Checked=true;
			vuelos=Sistema.ListaDeVuelos;
			dgw_vuelosMostrar.DataSource=null;
			dgw_vuelosMostrar.DataSource=vuelos;
			this.OcultarColumnas();
		}

		private void OcultarColumnas() {
			if(dgw_vuelosMostrar.Columns["Patente"] is not null) {
				dgw_vuelosMostrar.Columns["EsInternacional"].Visible=false;
				dgw_vuelosMostrar.Columns["Patente"].Visible=false;
			}
		}

		private void rdb_historialCompleto_CheckedChanged(object sender,EventArgs e) {
			dgw_vuelosMostrar.DataSource=null;
			dgw_vuelosMostrar.DataSource=vuelos;
			this.OcultarColumnas();
		}

		private void rdb_vuelosAntiguos_CheckedChanged(object sender,EventArgs e) {
			dgw_vuelosMostrar.DataSource=null;
			dgw_vuelosMostrar.DataSource=Sistema.BuscarVuelosPorFecha(true);
			this.OcultarColumnas();
		}

		private void rdb_vuelosActuales_CheckedChanged(object sender,EventArgs e) {
			dgw_vuelosMostrar.DataSource=null;
			dgw_vuelosMostrar.DataSource=Sistema.BuscarVuelosPorFecha(false);
			this.OcultarColumnas();
		}

		private void dgw_vuelosMostrar_CellContentClick(object sender,DataGridViewCellEventArgs e) {
			new FrmInformacionEspecificaVuelo((Vuelo)dgw_vuelosMostrar.CurrentRow.DataBoundItem).ShowDialog();
		}
	}
}
