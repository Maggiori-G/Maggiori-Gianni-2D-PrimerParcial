using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
	public static class Sistema {
		
		private static List<Usuario> listaUsuarios;
		private static List<Pasajero> listaPasajeros;

		static Sistema() {
			listaUsuarios = new List<Usuario>();
			listaPasajeros = new List<Pasajero>();
		}
		public static List<Usuario> ListaUsuarios {
			get {
				return listaUsuarios;
			} 
		}
		public static void PrecargarUsuario() {
			Sistema.listaUsuarios.Add(new Usuario("PepePeposo","pepe1","Lucas","Rodriguez","ejemplo@gmail.com","00.000.000","00-0000-0000"));
			Sistema.listaUsuarios.Add(new Usuario("Tanito","maggiori2d","Gianni","Maggiori","taniitoo@gmail.com","94.270.046","11-5220-6650"));
			Sistema.listaUsuarios.Add(new Usuario("Hoop","gatito11","Gatito Hooper","Felino","gatitoNaranjoso@gmail.com","54.158.199","11-5731-9086"));
			Sistema.listaUsuarios.Add(new Usuario("May","magia2008","Mayra","Maestu","mayra@estonoesunmail.com","37.788.155","11-3139-8410"));
			Sistema.listaUsuarios.Add(new Usuario("ezetabo","123contraseñajaja","Ezequiel","Taboada","estemailtampocoesreal@nomail.com","34.159.159","11-5555-9455"));
		}
		public static bool ValidarDatosUsuarioExistente(Usuario usuario) {
			bool retorno=false;
			if(usuario is not null) {
				foreach(Usuario item in listaUsuarios) {
					if(item==usuario) {
						retorno=true;
						break;
					}
				}
			}
			return retorno;
		}
		public static bool AgregarNuevoUsuario(string nombre, string apellido, string nombreDeUsuario, string contraseña, string email, string dni, string numeroTelefono) {
			if(!string.IsNullOrEmpty(nombre)&&!string.IsNullOrEmpty(apellido)&&!string.IsNullOrEmpty(nombreDeUsuario)&&!string.IsNullOrEmpty(contraseña)&&!string.IsNullOrEmpty(email)&&!string.IsNullOrEmpty(dni)&&!string.IsNullOrEmpty(numeroTelefono)) {
				listaUsuarios.Add(new Usuario(nombre.Trim(), apellido.Trim(), nombreDeUsuario.Trim(), contraseña.Trim(), email.Trim(), dni.Trim(), numeroTelefono.Trim()));
				return true;
			}
			return false;
		}
	}	
}
