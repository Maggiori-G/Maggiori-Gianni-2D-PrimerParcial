using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
	public class Avion {
		private string patente;
		private int capacidadDeAsientos;
		private int cantidadDeBaños;
		private double pesoMaximo;
		private bool estaEnVuelo;

		public Avion(string patente,int capacidadDeAsientos,int cantidadDeBaños,double pesoMaximo,bool estaEnVuelo) {
			this.patente=patente;
			this.capacidadDeAsientos=capacidadDeAsientos;
			this.cantidadDeBaños=cantidadDeBaños;
			this.pesoMaximo=pesoMaximo;
			this.estaEnVuelo=estaEnVuelo;
		}
	}
}