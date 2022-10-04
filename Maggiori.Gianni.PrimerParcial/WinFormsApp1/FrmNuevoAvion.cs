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
	public partial class frmNuevoAvion:Form {
		private Avion? avionNuevo;
		private int cantidadBaños;
		private int cantidadMaximaAsientos;
		private double capacidadBodega;
		public frmNuevoAvion() {
			InitializeComponent();
		}

		public Avion? AvionNuevo {
			get {
				return avionNuevo;
			}
		}

		private void btn_cancelar_Click(object sender,EventArgs e) {
			this.DialogResult=DialogResult.Cancel;
		}

		private void btn_Aceptar_Click(object sender,EventArgs e) {
			if(!string.IsNullOrEmpty(txt_ingresoCantidadBaños.Text) && !string.IsNullOrEmpty(txt_ingresoCapacidadBodega.Text) &&!string.IsNullOrEmpty(txt_ingresoMaxAsientos.Text)) {
				if(int.TryParse(txt_ingresoCantidadBaños.Text.Trim(), out cantidadBaños) && double.TryParse(txt_ingresoCapacidadBodega.Text.Trim(), out capacidadBodega) &&int.TryParse(txt_ingresoMaxAsientos.Text.Trim(), out cantidadMaximaAsientos)){
					avionNuevo=new Avion(Sistema.GenerarCodigoAlfanumericoRandom(),cantidadMaximaAsientos,cantidadBaños,capacidadBodega,false,0);
					MessageBox.Show(Sistema.MostrarDatosDeUnAvion(avionNuevo)+"\n\nEstá seguro que desea confirmar?","Confirmar",MessageBoxButtons.YesNo);
					this.DialogResult=DialogResult.OK;
				}
				else {
					MessageBox.Show("Ingreso de datos incorrecto");
				}
			}
			else {
				MessageBox.Show("Debe ingresar datos del nuevo avion");
			}
		}
	}
}
