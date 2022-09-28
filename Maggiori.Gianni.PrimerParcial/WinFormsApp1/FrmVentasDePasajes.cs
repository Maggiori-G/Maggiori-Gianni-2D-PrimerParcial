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
			cmb_comidas.Visible=false;
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
			if(Sistema.BuscarVuelo(cmb_origen.Text,cmb_destino.Text,(int)nud_asientos.Value,rdb_ejecutiva.Checked).Count>0) {
				dgw_vuelosDisponibles.DataSource=Sistema.BuscarVuelo(cmb_origen.Text,cmb_destino.Text,(int)nud_asientos.Value,rdb_ejecutiva.Checked);
			}
			else {
				MessageBox.Show("Puto");
			}
		}

		private void chk_comida_CheckedChanged(object sender,EventArgs e) {
			if(chk_comida.Checked) {
				cmb_comidas.Visible=true;
				cmb_comidas.DataSource = Enum.GetValues(typeof(Comida));
				//levanta el contenido del combo box -> Enum.TryParse<Comida>(cmb_comidas.SelectedValue.ToString(), out Comida comidaSeleccionada);
			}
			else {
				cmb_comidas.Visible=false;
			}
		}
		private void dgw_vuelosDisponibles_CellContentClick(object sender,DataGridViewCellEventArgs e) {
			//disparar el form para seleccionar el/los clientes asociados al vuelo
		}
	}
}