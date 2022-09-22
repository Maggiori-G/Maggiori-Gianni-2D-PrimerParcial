using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
	public class Avion {
		private string patente;
		private int capacidadDePasajeros;
		private int cantidadDeBaños;
		private double pesoMaximo;
		private bool estaEnVuelo;

		public Avion(string patente,int capacidadDePasajeros,int cantidadDeBaños,double pesoMaximo,bool estaEnVuelo) {
			this.patente=patente;
			this.capacidadDePasajeros=capacidadDePasajeros;
			this.cantidadDeBaños=cantidadDeBaños;
			this.pesoMaximo=pesoMaximo;
			this.estaEnVuelo=estaEnVuelo;
		}
	}
}