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
	public partial class FrmDatosHistoricos:Form {
		private double recaudacionNacional;
		public FrmDatosHistoricos() {
			InitializeComponent();
		}
		private void FrmDatosHistoricos_Load(object sender,EventArgs e) {
			rdb_FacturacionHistoricaTotal.Checked=true;
		}

		private void rdb_FacturacionHistoricaTotal_CheckedChanged(object sender,EventArgs e) {
			lbl_mostrarRecaudacion.Text=string.Empty;
			lbl_mostrarRecaudacion.Text=Sistema.CalcularRecaudacionTotal().ToString();
		}

		private void rdb_facturacionNacional_CheckedChanged(object sender,EventArgs e) {
			lbl_mostrarRecaudacion.Text=string.Empty;
			lbl_mostrarRecaudacion.Text=Sistema.CalcularRecaudacionNacional().ToString();
		}

		private void rdb_facturacionInternacional_CheckedChanged(object sender,EventArgs e) {
			lbl_mostrarRecaudacion.Text=string.Empty;
			lbl_mostrarRecaudacion.Text=Sistema.CalcularRecaudacionInternacional().ToString();
		}

		private void btn_cerrar_Click(object sender,EventArgs e) {
			this.DialogResult=DialogResult.OK;
		}
	}
}
