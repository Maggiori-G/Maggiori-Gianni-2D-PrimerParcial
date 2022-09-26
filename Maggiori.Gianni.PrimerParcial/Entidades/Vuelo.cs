using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
	public class Vuelo {
		private Avion avion;
		private List<Pasajero> pasajerosAbordo;
		private Destinos destino;
		private DateTime horaDeSalida;
		private DateTime horaDeLlegada;

		public Vuelo(Avion avion,List<Pasajero> pasajerosAbordo,Destinos destino,DateTime horaDeSalida,DateTime horaDeLlegada) {
			this.avion=avion;
			this.pasajerosAbordo=pasajerosAbordo;
			this.destino=destino;
			this.horaDeSalida=horaDeSalida;
			this.horaDeLlegada=horaDeLlegada;
		}
	}
}
