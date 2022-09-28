using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
	public class Destino {
		KeyValuePair<string, bool> destino;

		public Destino(string nombre,bool esInternacional) {
			this.destino=new KeyValuePair<string, bool>(nombre, esInternacional);
		}

		public string Ciudad {
			get {
				return this.destino.Key;
			}
		}
		public bool EsInternacional {
			get {
				return this.destino.Value;
			}
		}
		
	}
}
