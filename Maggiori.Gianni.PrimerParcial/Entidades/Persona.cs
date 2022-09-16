using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
	public abstract class Persona {

		protected string nombre;
		protected string apellido;
		protected string email;
		protected string dni;
		protected string numeroTelefono;
		
		protected Persona(string nombre,string apellido,string email,string dni, string numeroTelefono) {
			this.nombre=nombre;
			this.apellido=apellido;
			this.email=email;
			this.dni=dni;
			this.numeroTelefono=numeroTelefono;
		}
		public string Nombre {
			get {
				return this.nombre;
			}
		}
		public string Apellido {
			get {
				return this.apellido;
			}
		}
		public string Email {
			get {
				return this.email;
			}
		}
		public string Dni {
			get {
				return this.dni;
			}
		}
	}
}
