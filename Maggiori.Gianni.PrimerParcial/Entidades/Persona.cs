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
			set {
				if(!string.IsNullOrEmpty(value)) {
					this.nombre = value;
				}
			}
		}
		public string Apellido {
			get {
				return this.apellido;
			}
			set {
				if(!string.IsNullOrEmpty(value)) {
					this.apellido = value;
				}
			}
		}
		public string Email {
			get {
				return this.email;
			}
			set {
				if(!string.IsNullOrEmpty(value)) {
					this.email=value;
				}
			}
		}
		public string Dni {
			get {
				return this.dni;
			}
			set {
				if(!string.IsNullOrEmpty(value)) {
					this.dni=value;
				}
			}
		}
		public string NumeroTelefono {
			get {
				return this.numeroTelefono;
			}
			set {
				if(!string.IsNullOrEmpty(value)) {
					this.numeroTelefono=value;
				}
			}
		}
		public string Edad {
			get {
				return this.edad;
			}
			set {
				if(!string.IsNullOrEmpty(value)) {
					this.edad=value;
				}
			}
		}
		protected virtual string MostrarDatos() {
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("***************************************");
			sb.AppendLine($"Nombre: {this.Nombre}");
			sb.AppendLine($"Apellido: {this.Apellido}");
			sb.AppendLine($"Edad: {this.Edad} - D.N.I: {this.Dni}");
			sb.AppendLine($"Email: {this.Email}");
			sb.AppendLine($"Telefono: {this.NumeroTelefono}");
			return sb.ToString();
		}
	}
}
