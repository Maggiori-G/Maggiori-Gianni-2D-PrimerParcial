namespace Entidades {
	public class Pasajero {
		
		private string codigoTicket;
		private double pesoValijas;
		private bool premium;

		public Pasajero(string codigoTicket,double pesoValijas,bool premium) {
			this.codigoTicket=codigoTicket;
			this.pesoValijas=pesoValijas;
			this.premium=premium;
		}
	}
}