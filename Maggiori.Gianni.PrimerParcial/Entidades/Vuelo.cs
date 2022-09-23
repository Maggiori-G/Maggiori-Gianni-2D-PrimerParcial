using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
	public class Vuelo {
		private Avion avion;
		private List<Pasajero> pasajeros;
		private Destinos destino;
		private DateTime horaDeSalida;
		private DateTime horaDeLlegada;

		public Vuelo(Avion avion,List<Pasajero> pasajeros,Destinos destino,DateTime horaDeSalida,DateTime horaDeLlegada) {
			this.avion=avion;
			this.pasajeros=pasajeros;
			this.destino=destino;
			this.horaDeSalida=horaDeSalida;
			this.horaDeLlegada=horaDeLlegada;
		}
	}
}
