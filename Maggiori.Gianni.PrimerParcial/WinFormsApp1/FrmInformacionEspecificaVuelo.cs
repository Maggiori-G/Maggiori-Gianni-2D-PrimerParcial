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
		public FrmInformacionEspecificaVuelo(Vuelo vuelo) {
			InitializeComponent();
		}

		private void FrmInformacionEspecificaVuelo_Load(object sender,EventArgs e) {
			
		}

		private void btn_volver_Click(object sender,EventArgs e) {
			this.DialogResult=DialogResult.OK;
		}
	}
}
