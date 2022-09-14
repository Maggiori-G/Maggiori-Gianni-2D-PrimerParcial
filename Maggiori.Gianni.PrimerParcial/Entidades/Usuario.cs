using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
	public class Usuario {
		private string nombre;
		private string apellido;
		private string nombreDeUsuario;
		private string contraseña;
		private string email;
		private string dni;

		public Usuario(string nombreDeUsuario, string contraseña) {
			this.nombreDeUsuario = nombreDeUsuario;
			this.contraseña=contraseña;
		}
		public Usuario(string nombre, string apellido, string nombreDeUsuario, string contraseña, string email, string dni)
			:this(nombreDeUsuario,contraseña) {
			this.nombre = nombre;
			this.apellido = apellido;
			this.email=email;
			this.dni=dni;
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
		public string NombreDeUsuario {
			get {
				return this.nombreDeUsuario;	
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

		internal string Contraseña {
			get {
				return this.contraseña;
			}
			set{
				this.contraseña=value;
			}
		}

		public override bool Equals(object obj) {
			Usuario usuario1 = obj as Usuario;
			return usuario1 is not null && this==usuario1;
		}

		public override int GetHashCode() {
			return HashCode.Combine(nombre,apellido,nombreDeUsuario,contraseña);
		}

		public static bool operator ==(Usuario u1, Usuario u2) {
			return u1 is not null && u2 is not null &&  u1.nombreDeUsuario==u2.nombreDeUsuario && u1.contraseña==u2.contraseña;
		}
		public static bool operator !=(Usuario u1, Usuario u2) {
			return !(u1 == u2);
		}

		
	}
}
