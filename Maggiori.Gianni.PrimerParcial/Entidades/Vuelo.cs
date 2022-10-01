using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
	
	public class Vuelo {
		private Avion avion;
		private List<Pasajero>? pasajerosAbordo;
		private string? destinoDeSalida;
		private string? destinoDeLlegada;
		private double precioVuelo;
		private DateTime fechaSalida;
		private bool esInternacional;
		private int duracionVuelo;
		private double recaudacion;
		private Vuelo() {
			this.pasajerosAbordo = new List<Pasajero>();
		}
		public Vuelo(Avion avion,string destinoDeSalida,string destinoDeLlegada, DateTime fechaSalida) : this() {
			this.avion=avion;
			this.destinoDeSalida=destinoDeSalida;
			this.destinoDeLlegada=destinoDeLlegada;
			this.fechaSalida=fechaSalida;
			this.esInternacional=VerificarSiEsInternacional();
			CalcularElTiempoDeVuelo();
			this.precioVuelo=Sistema.CalcularPrecioDeVuelo(this.EsInternacional,this.Duracion);
		}

		public Avion Avion {
			get {
				return this.avion;
			}
		}
		public string Patente {
			get {
				return this.avion.Patente;
			}
		}
		public List<Pasajero> PasajerosAbordo {
			get {
				return this.pasajerosAbordo;
			}
		}
		public string Origen {
			get {
				return this.destinoDeSalida;
			}
		}
		public string Destino {
			get {
				return this.destinoDeLlegada;
			}
		}
		public double Precio {
			set {
				if(this.pasajerosAbordo is not null) {
					if(this.pasajerosAbordo.Count>0) {
						this.precioVuelo = value;
					}
				}
			}
			get {
				return precioVuelo;
			}
		}

		public DateTime Fecha {
			get {
				return fechaSalida;
			}
		}

		public string Tipo {
			get {
				if(this.esInternacional) {
					return "Internacional";
				}
				else {
					return "Nacional";
				}
			}
		}

		public int Duracion {
			get {
				return duracionVuelo;
			}
		}

		public double Recaudacion {
			set {
				if(this.PasajerosAbordo is not null) {
					if(this.PasajerosAbordo.Count>0) {
						this.recaudacion=value;
					}
				}
			}
			get {
				return this.recaudacion;
			}
		}

		public bool EsInternacional {
			get {
				return esInternacional;
			}
		}

		private void CalcularElTiempoDeVuelo() {
			Random random=new Random();
			if(this.esInternacional) {
				this.duracionVuelo=random.Next(8,12);
			}
			else {
				this.duracionVuelo=random.Next(2,4);
			}
		}
		
		public bool VerificarSiEsInternacional() {
			if(this.destinoDeLlegada is not null) {
				if(this.destinoDeLlegada=="Buenos Aires" ||Sistema.EsInternacional(this.destinoDeLlegada)) {
					return true;
				}
			}
			return false;
		}
		private void CalcularRecaudacion() {
			if(this.pasajerosAbordo is not null) {
				if(pasajerosAbordo.Count>0) {
					this.recaudacion=pasajerosAbordo.Count*precioVuelo;
				}
			}
		}
		public override string ToString() {
			return "";
		}
	}
}
