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
		private double precioPasaje;

		public Pasajero(double pesoValijas,int cantidadMaximaTickets,bool contratoWifi,bool primeraClase,bool contratoPeliculas, string nombre, string apellido, string edad, string dni, string email, string numeroTelefono,Comida tipoComida, bool tieneBolsoDeMano)
			:this(pesoValijas,cantidadMaximaTickets,contratoWifi,tipoComida,primeraClase,contratoPeliculas, new Cliente(nombre,apellido,edad,email,dni,numeroTelefono),tieneBolsoDeMano){
		}
		public Pasajero(double pesoValijas,int cantidadMaximaTickets,bool contratoWifi,Comida tipoComida,bool primeraClase,bool contratoPeliculas, Cliente cliente, bool tieneBolsoDeMano)
			:base(cliente.Nombre, cliente.Apellido, cliente.Edad, cliente.Email, cliente.Dni, cliente.NumeroTelefono){
			this.codigoTicket=Sistema.GenerarCodigoAlfanumericoRandom();
			this.pesoValijas=pesoValijas;
			this.cantidadMaximaTickets=cantidadMaximaTickets;
			this.contratoWifi=contratoWifi;
			this.tipoComida=tipoComida;
			this.primeraClase=primeraClase;
			this.contratoPeliculas=contratoPeliculas;
			this.tieneBolsoDeMano=tieneBolsoDeMano;
		}
		public string CodigoTicket {
			get {
				return codigoTicket;
			}
		}
		public double PesoValijas {
			get {
				return pesoValijas;
			}
		}
		public int CantidadMaximaTickets {
			get {
				return cantidadMaximaTickets;
			}
		}
		public bool ContratoWifi {
			get {
				return contratoWifi;
			}
		}
		public Comida TipoComida {
			get {
				return tipoComida;
			}
		}
		public bool PrimeraClase {
			get {
				return primeraClase;
			}
		}
		public bool ContratoPeliculas {
			get {
				return this.contratoPeliculas;
			}
		}
		public bool TieneBolsoDeMano {
			get {
				return tieneBolsoDeMano;
			}
		}

		public double Precio {
			set {
				if(this.PesoValijas>0) {
					this.precioPasaje=value;
				}
			}
			get {
				return this.precioPasaje;
			}
		}
		protected override string MostrarDatos() {
			StringBuilder sb=new StringBuilder();
			sb.AppendLine(base.MostrarDatos());
			sb.AppendLine($"Código de Ticket: {this.CodigoTicket}");
			sb.AppendLine($"Precio a pagar: {this.Precio.ToString("0.00")}");
			sb.AppendLine("***************************************");
			return sb.ToString();
		}
		public override string ToString() {
			return this.MostrarDatos();
		}
	}
}