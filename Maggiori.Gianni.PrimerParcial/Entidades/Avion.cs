using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
	public class Avion {
		private string patente;
		private int capacidadMaximaDeAsientos;
		private int cantidadDeBaños;
		private double pesoMaximo;
		private bool estaEnVuelo;

		public Avion(string patente,int capacidadMaximaDeAsientos,int cantidadDeBaños,double pesoMaximo,bool estaEnVuelo) {
			this.patente=patente;
			this.capacidadMaximaDeAsientos=capacidadMaximaDeAsientos;
			this.cantidadDeBaños=cantidadDeBaños;
			this.pesoMaximo=pesoMaximo;
			this.estaEnVuelo=estaEnVuelo;
		}

		public string Patente {
			get {
				return patente;
			}
		}

		public int CapacidadDeAsientos {
			get {
				return capacidadMaximaDeAsientos;
			}
		}

		public int CantidadDeBaños {
			get {
				return cantidadDeBaños;
			}
		}

		public double PesoMaximo {
			get{
				return pesoMaximo;
			}
		}

		public string EstaEnVuelo {
			get {
				if(this.estaEnVuelo) {
					return "Volando";
				}
				return "Aún no despegó";
			}
		}
	}
}