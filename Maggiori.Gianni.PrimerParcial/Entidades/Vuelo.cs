using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
	public class Vuelo {
		private Avion avion;
		private List<Pasajero> pasajerosAbordo;
		private List<string> destino;
		private DateTime horaDeSalida;
		private DateTime horaDeLlegada;
		private decimal precioVuelo;
		private bool tieneWifi;
		private bool tieneComida;

		public Vuelo(Avion avion,List<Pasajero> pasajerosAbordo,List<string> destino,DateTime horaDeSalida,DateTime horaDeLlegada, decimal precioVuelo) {
			this.avion=avion;
			this.pasajerosAbordo=pasajerosAbordo;
			this.destino=destino;
			this.horaDeSalida=horaDeSalida;
			this.horaDeLlegada=horaDeLlegada;
			this.precioVuelo=precioVuelo;
		}
		public Vuelo(Avion avion,List<Pasajero> pasajerosAbordo,List<string> destino,DateTime horaDeSalida,DateTime horaDeLlegada, decimal precioVuelo, bool comida, bool tieneWifi)
			:this (avion,pasajerosAbordo,destino,horaDeSalida,horaDeLlegada,precioVuelo){
			this.tieneComida=comida;
			this.tieneWifi=tieneWifi;
		}
		
	}
}
