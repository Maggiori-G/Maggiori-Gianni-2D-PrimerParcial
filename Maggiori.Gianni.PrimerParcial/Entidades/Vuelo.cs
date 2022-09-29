using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
	public enum Comida {
		Refrigerio,
		Vegana,
		Sin_TACC,
		Pollo,
		Carne
	}
	public class Vuelo {
		private Avion avion;
		private List<Pasajero>? pasajerosAbordo;
		private string? destinoDeSalida;
		private string? destinoDeLlegada;
		private double precioVuelo;
		private DateTime fechaSalida;

		private Vuelo() {
			this.pasajerosAbordo = new List<Pasajero>();
		}
		public Vuelo(Avion avion,string destinoDeSalida,string destinoDeLlegada, DateTime fechaSalida):this() {
			this.avion=avion;
			this.destinoDeSalida=destinoDeSalida;
			this.destinoDeLlegada=destinoDeLlegada;
			this.fechaSalida=fechaSalida;
			//aca va calcular precio;
		}

		public Avion Avion {
			get {
				return this.avion;
			}
		}
		public string PatenteAvion {
			get {
				return this.avion.Patente;
			}
		}
		public List<Pasajero> PasajerosAbordo {
			get {
				return this.pasajerosAbordo;
			}
		}
		public string DestinoDeSalida {
			get {
				return this.destinoDeSalida;
			}
		}
		public string DestinoDeLlegada {
			get {
				return this.destinoDeLlegada;
			}
		}
		public double PrecioVuelo {
			get {
				return precioVuelo;
			}
		}

		public DateTime FechaSalida {
			get {
				return fechaSalida;
			}
		}
	}
}
