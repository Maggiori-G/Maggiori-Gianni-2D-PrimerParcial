using System.Text;

namespace Entidades {
	
	public class Pasajero:Cliente {
		
		private string codigoTicket;
		private double pesoValijas;
		private int cantidadMaximaTickets;
		private bool contratoWifi;
		private Comida tipoComida;
		private bool primeraClase;
		private bool contratoPeliculas;
		private bool tieneBolsoDeMano;

		public Pasajero(double pesoValijas,int cantidadMaximaTickets,bool contratoWifi,bool primeraClase,bool contratoPeliculas, string nombre, string apellido, string edad, string dni, string email, string numeroTelefono,Comida tipoComida, bool tieneBolsoDeMano)
			:base(nombre, apellido, edad, email, dni, numeroTelefono){
			this.codigoTicket=Sistema.GenerarCodigoTicket();
			this.pesoValijas=pesoValijas;
			this.cantidadMaximaTickets=cantidadMaximaTickets;
			this.contratoWifi=contratoWifi;
			this.tipoComida=tipoComida;
			this.primeraClase=primeraClase;
			this.contratoPeliculas=contratoPeliculas;
			this.tieneBolsoDeMano=tieneBolsoDeMano;
		}
		public Pasajero(double pesoValijas,int cantidadMaximaTickets,bool contratoWifi,Comida tipoComida,bool primeraClase,bool contratoPeliculas, Cliente cliente, bool tieneBolsoDeMano)
			:this(pesoValijas, cantidadMaximaTickets, contratoWifi, primeraClase, contratoPeliculas, cliente.Nombre, cliente.Apellido, cliente.Edad, cliente.Email, cliente.Dni, cliente.NumeroTelefono,tipoComida, tieneBolsoDeMano){		
		}
		
	}
}