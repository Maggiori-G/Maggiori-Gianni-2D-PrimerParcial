using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
	public static class Sistema {
		
		private static List<Usuario> listaUsuarios = new List<Usuario>();

		public static List<Usuario> ListaUsuarios {
			get {
				return listaUsuarios;
			} 
		}
		public static void PrecargarUsuario() {
			Sistema.listaUsuarios.Add(new Usuario("Gianni","Maggiori","Tanito","maggiori2d","taniitoo@gmail.com","94.270.046"));
			Sistema.listaUsuarios.Add(new Usuario("admin","1234"));
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
		
	}
}
