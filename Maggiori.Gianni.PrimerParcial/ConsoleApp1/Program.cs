using Entidades;

namespace ConsoleApp1 {
	internal class Program {
		static void Main(string[] args) {
			for(int i=0; i<Sistema.ListaClientes.Count; i++) {
				for(int j=i+1; j<Sistema.ListaClientes.Count; j++) {
					if(Sistema.ListaClientes[i].Dni==Sistema.ListaClientes[j].Dni) {
						Console.WriteLine(true);
					}
				}
			}
		}
		
	}
}