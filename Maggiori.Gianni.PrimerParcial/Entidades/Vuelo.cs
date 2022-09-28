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
		private List<Pasajero> pasajerosAbordo;
		private string destinoDeSalida;
		private string destinoDeLlegada;
		private double precioVuelo;

		public Vuelo(Avion avion,List<Pasajero> pasajerosAbordo,string destinoDeSalida,string destinoDeLlegada) {
			this.avion=avion;
			this.pasajerosAbordo=pasajerosAbordo;
			this.destinoDeSalida=destinoDeSalida;
			this.destinoDeLlegada=destinoDeLlegada;
			//aca va calcular precio;
		}

		public Avion Avion {
			get {
				return avion;
			}
		}
		public List<Pasajero> PasajerosAbordo {
			get {
				return pasajerosAbordo;
			}
		}
		public string DestinoDeSalida {
			get {
				return destinoDeSalida;
			}
		}
		public string DestinoDeLlegada {
			get {
				return destinoDeLlegada;
			}
		}
		public double PrecioVuelo {
			get {
				return precioVuelo;
			}
		}
	}
}
