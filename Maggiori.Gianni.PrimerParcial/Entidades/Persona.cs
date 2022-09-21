using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
	public abstract class Persona {

		protected string nombre;
		protected string apellido;
		protected string edad;
		protected string email;
		protected string dni;
		private string numeroTelefono;

		public Persona(string nombre,string apellido,string edad,string email,string dni, string numeroTelefono) {
			this.nombre=nombre;
			this.apellido=apellido;
			this.edad=edad;
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

		public string NumeroTelefono {
			get {
				return this.numeroTelefono;
			}
		}
		public string Edad {
			get {
				return this.edad;
			}
		}
	}
}
