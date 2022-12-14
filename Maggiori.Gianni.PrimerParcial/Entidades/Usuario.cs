using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
	public class Usuario:Persona {
		
		private string nombreDeUsuario;
		private string contraseña;
		

		public Usuario(string nombreDeUsuario, string contraseña, string nombre, string apellido,string edad, string email, string dni, string numeroTelefono)
			:base(nombre, apellido,edad, email, dni, numeroTelefono) {
			this.nombreDeUsuario = nombreDeUsuario;
			this.contraseña=contraseña;
		}
		public string NombreDeUsuario {
			get {
				return this.nombreDeUsuario;	
			}
		}
		public string Contraseña {
			get {
				return this.contraseña;
			}
		}
		public override bool Equals(object? obj) {
			Usuario? usuario1 = obj as Usuario;
			return usuario1 is not null && this==usuario1;
		}
		public override int GetHashCode() {
			return HashCode.Combine(nombreDeUsuario,contraseña);
		}
		internal bool CompararUsuario(string usuario, string contraseñaUsuario) {
			if(usuario is not null && contraseñaUsuario is not null) {
				return this.nombreDeUsuario==usuario && this.contraseña==contraseñaUsuario;
			}
			return false;
		}
		public static bool operator ==(Usuario u1, Usuario u2) {
			return u1 is not null && u2 is not null &&  u1.nombreDeUsuario==u2.nombreDeUsuario && u1.contraseña==u2.contraseña;
		}
		public static bool operator !=(Usuario u1, Usuario u2) {
			return !(u1 == u2);
		}
	}
}
