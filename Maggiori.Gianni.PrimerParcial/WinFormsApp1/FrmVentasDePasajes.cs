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
	public partial class frmVentasDePasajes:Form {
		public frmVentasDePasajes() {
			InitializeComponent();
		}
		private void frmVentasDePasajes_Load(object sender,EventArgs e) {
			CargarCMB(cmb_origen,Sistema.DiccionarioDestinos, true);
			
		}
		private void cmb_origen_SelectedIndexChanged(object sender,EventArgs e) {
			if(cmb_origen.SelectedItem.ToString()=="Buenos Aires") {
				CargarCMB(cmb_destino,Sistema.DiccionarioDestinos, true);
				cmb_destino.Items.Remove(cmb_origen.SelectedItem);
			}
			else {
				if(Sistema.EsInternacional(cmb_origen.Text)) {
					cmb_destino.Items.Clear();
					cmb_destino.Items.Add("Buenos Aires");
				}
				else {
					CargarCMB(cmb_destino,Sistema.DiccionarioDestinos, false);
					cmb_destino.Items.Remove(cmb_origen.SelectedItem);
				}
			}
		}
		private static void CargarCMB(ComboBox combo, Dictionary<string,bool> dic, bool boleano) {
			combo.Items.Clear();
			if(boleano) {
				foreach(KeyValuePair<string, bool> item in dic) {
					combo.Items.Add(item.Key);
				}
			}
			else {
				foreach(KeyValuePair<string, bool> item in dic) {
					if(!item.Value) {
						combo.Items.Add(item.Key);
					}
				}
			}
		}
		private void btn_buscarVuelo_Click(object sender,EventArgs e) {
			if(Sistema.BuscarVueloDisponible(cmb_origen.Text,cmb_destino.Text,(int)nud_asientos.Value,rdb_ejecutiva.Checked).Count>0) {
				dgw_vuelosDisponibles.DataSource=Sistema.BuscarVueloDisponible(cmb_origen.Text,cmb_destino.Text,(int)nud_asientos.Value,rdb_ejecutiva.Checked);
				dgw_vuelosDisponibles.Columns["Avion"].Visible=false;
				dgw_vuelosDisponibles.Columns["Recaudacion"].Visible=false;
				dgw_vuelosDisponibles.Columns["EsInternacional"].Visible=false;

			}
		}
		private void dgw_vuelosDisponibles_CellContentClick(object sender,DataGridViewCellEventArgs e) {
			int cantidadMaximaTickets=(int)nud_asientos.Value;
			Vuelo vuelo=(Vuelo)dgw_vuelosDisponibles.CurrentRow.DataBoundItem;
			bool esPremium=rdb_ejecutiva.Checked;
			new FrmSeleccionarClientePasajero(vuelo, cantidadMaximaTickets, esPremium).ShowDialog();
		}
	}
}