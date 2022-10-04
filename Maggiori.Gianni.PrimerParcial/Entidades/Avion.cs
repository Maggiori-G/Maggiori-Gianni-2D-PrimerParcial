using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
	public class Avion {
		private string patente;
		private int capacidadMaximaDeAsientos;
		private int asientosComercial;
		private int asientosPrimerClase;
		private int cantidadDeBaños;
		private double pesoMaximo;
		private bool estaEnVuelo;
		private int cantidadHorasDeVuelo;
		public Avion(string patente,int capacidadMaximaDeAsientos,int cantidadDeBaños,double pesoMaximo,bool estaEnVuelo, int cantidadHorasDeVuelo) {
			this.patente=patente;
			this.capacidadMaximaDeAsientos=capacidadMaximaDeAsientos;
			this.cantidadDeBaños=cantidadDeBaños;
			this.pesoMaximo=pesoMaximo;
			this.estaEnVuelo=estaEnVuelo;
			this.cantidadHorasDeVuelo=cantidadHorasDeVuelo;
			CalcularAsientosPrimeraClase();
			CalcularAsientosComercial();
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
		public int AsientosComercial {
			set {
				if(value>0 && value<=this.asientosComercial) {
					this.asientosComercial-=value;
				}
			}
			get {
				return this.asientosComercial;
			}
		}
		public int AsientosPrimerClase {
			set {
				if(value>0 && value<=this.asientosPrimerClase) {
					this.asientosPrimerClase-=value;
				}
			}
			get {
				return this.asientosPrimerClase;
			}
		}
		public int HorasDeVuelo {
			set {
				this.cantidadHorasDeVuelo=value;
			}
			get {
				return this.cantidadHorasDeVuelo;
			}
		}
		private void CalcularAsientosPrimeraClase() {
			this.asientosPrimerClase=this.CapacidadDeAsientos-(this.CapacidadDeAsientos*80/100);
		}
		private void CalcularAsientosComercial() {
			this.asientosComercial=this.capacidadMaximaDeAsientos-this.asientosPrimerClase;
		}
		public override string ToString() {
			return this.Patente;
		}

	}
}