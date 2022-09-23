namespace Entidades {
	public enum Destinos {
		Santa_Rosa,
		Bariloche,
		Corrientes,
		Córdoba,
		Jujuy,
		Mendoza,
		Neuquén,
		Posadas,
		Iguazú,
		Salta,
		Santiago_Del_Estero,
		Trelew,
		Tucumán,
		Puerto_Madryn,
		Ushuaia,
		Recife,
		Roma,
		Acapulco,
		Miami
	}
	public class Pasajero:Cliente {
		
		private string codigoTicket;
		private double pesoValijas;
		

		public Pasajero(string nombre,string apellido,string edad,string email,string dni,string numeroTelefono, string codigoTicket, double pesoValijas) 
			:base(nombre,apellido,edad,email,dni,numeroTelefono) {
			this.codigoTicket = codigoTicket;
			this.pesoValijas=pesoValijas;
		}
	}
}