namespace Entidades {
	
	public class Pasajero:Cliente {
		
		private string codigoTicket;
		private double pesoValijas;
		private int cantidadMaximaTickets;
		private bool contratoWifi;
		private Comida tipoComida;
		private bool primeraClase;
		private bool contratoPeliculas;

		public Pasajero(string codigoTicket,double pesoValijas,int cantidadMaximaTickets,bool contratoWifi,Comida tipoComida,bool primeraClase,bool contratoPeliculas, string nombre, string apellido, string edad, string dni, string email, string numeroTelefono)
			:base(nombre, apellido, edad, email, dni, numeroTelefono){
			this.codigoTicket=codigoTicket;
			this.pesoValijas=pesoValijas;
			this.cantidadMaximaTickets=cantidadMaximaTickets;
			this.contratoWifi=contratoWifi;
			this.tipoComida=tipoComida;
			this.primeraClase=primeraClase;
			this.contratoPeliculas=contratoPeliculas;
		}
	}
}