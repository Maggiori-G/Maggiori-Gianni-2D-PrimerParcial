using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
	public class Cliente:Persona {
		private int id;
		private static int ultimoId;
		private int cantidadDeViajes;
		static Cliente() {
			ultimoId=0;
		}
		public Cliente(string nombre,string apellido,string edad,string email,string dni,string numeroTelefono)
			: base(nombre,apellido,edad,email,dni,numeroTelefono) {
			ultimoId++;
			
			this.id=ultimoId;
		}
		public int Id {
			get {
				return id;
			}
		}
	}
}