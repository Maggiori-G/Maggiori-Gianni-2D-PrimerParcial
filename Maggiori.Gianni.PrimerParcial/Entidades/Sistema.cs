using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
	public static class Sistema {

		private static List<Usuario> listaUsuarios;
		private static List<Avion> listaDeAviones;
		private static List<Cliente> listaClientes;
		private static List<Vuelo> listaVuelos;
		private static Dictionary<string, bool> diccionarioDestinos;
		
		static Sistema() {
			listaUsuarios = new List<Usuario>();
			listaDeAviones= new List<Avion>();
			listaClientes= new List<Cliente>();
			listaVuelos= new List<Vuelo>();
			diccionarioDestinos=CargarDiccionarioDeDestinos(CargarTodosLosDestinos());
			Sistema.PrecargarAviones();
			Sistema.PrecargarVuelos();
			Sistema.PrecargarClientes();
			Sistema.PrecargarVuelosConPasajeros();
			
		}
		public static List<Usuario> ListaUsuarios {
			get {
				return listaUsuarios;
			}
		}
		public static List<Cliente> ListaClientes {
			get {
				return listaClientes;
			}
		}
		public static List<Avion> ListaDeAviones {
			get {
				return listaDeAviones;
			}
		}
		public static List<Vuelo> ListaDeVuelos {
			get {
				return listaVuelos;
			}
		}
		public static Dictionary<string,bool> DiccionarioDestinos {
			get {
				return diccionarioDestinos;
			}
		}
		public static List<Destino> CargarTodosLosDestinos() {
			return new List<Destino>(){
				new Destino("Recife, Brasil",true),
				new Destino("Roma, Italia",true),
				new Destino("Acapulco, México",true),
				new Destino("Miami, EEUU",true),
				new Destino("Buenos Aires", false),
				new Destino("Santa Rosa", false),
				new Destino("Bariloche", false),
				new Destino("Corrientes", false),
				new Destino("Córdoba", false),
				new Destino("Jujuy", false),
				new Destino("Mendoza", false),
				new Destino("Neuquén", false),
				new Destino("Posadas", false),
				new Destino("Iguazú", false),
				new Destino("Salta", false),
				new Destino("Santiago del Estero", false),
				new Destino("Trelew", false),
				new Destino("Tucumán", false),
				new Destino("Puerto Madryn", false),
				new Destino("Ushuaia", false)
			};	
		}
		public static void PrecargarClientes() {
			listaClientes.Add(new Cliente("Brana","Fayers","49","bfayers0@columbia.edu","10.019.212","04-5115-6916"));
			listaClientes.Add(new Cliente("Abel","Goodridge","88","agoodridge1@meetup.com","93.306.584","82-6598-8509"));
			listaClientes.Add(new Cliente("Jolynn","Pawson","34","jpawson2@eepurl.com","11.340.638","40-7854-0046"));
			listaClientes.Add(new Cliente("Haslett","Witts","35","hwitts3@etsy.com","98.831.153","07-5241-1235"));
			listaClientes.Add(new Cliente("Lana","Keward","69","lkeward4@oaic.gov.au","51.194.798","86-7639-1181"));
			listaClientes.Add(new Cliente("Keven","Varran","91","kvarran5@archive.org","72.695.894","13-1117-2954"));
			listaClientes.Add(new Cliente("Haydon","Gronous","42","hgronous6@barnesandnoble.com","76.011.910","07-0910-2659"));
			listaClientes.Add(new Cliente("Goddard","Bilofsky","12","gbilofsky7@nature.com","88.457.934","80-7852-6320"));
			listaClientes.Add(new Cliente("Minnie","Vernham","36","mvernham8@ihg.com","06.034.132","28-2525-2363"));
			listaClientes.Add(new Cliente("Solly","Webben","45","swebben9@irs.gov","34.536.766","79-1728-0006"));
			listaClientes.Add(new Cliente("Jose","Follos","87","jfollosa@foxnews.com","27.791.598","41-2851-7143"));
			listaClientes.Add(new Cliente("Glennie","Sowerby","58","gsowerbyb@zimbio.com","50.428.761","60-8187-1227"));
			listaClientes.Add(new Cliente("Ilario","Lemoir","15","ilemoirc@nature.com","97.915.358","78-5380-1424"));
			listaClientes.Add(new Cliente("Curran","Manklow","91","cmanklowd@apple.com","62.112.318","99-8929-7095"));
			listaClientes.Add(new Cliente("Lorrie","Naile","45","lnailee@arizona.edu","97.069.367","76-5321-1923"));
			listaClientes.Add(new Cliente("Danika","Brimley","53","dbrimleyf@ustream.tv","94.153.200","64-1875-9147"));
			listaClientes.Add(new Cliente("Tabatha","Bennedick","9","tbennedickg@techcrunch.com","04.654.991","71-1190-7322"));
			listaClientes.Add(new Cliente("Ephraim","Scragg","43","escraggh@plala.or.jp","51.044.609","81-7620-8129"));
			listaClientes.Add(new Cliente("Margarette","Allkins","18","mallkinsi@php.net","74.359.474","18-9469-3235"));
			listaClientes.Add(new Cliente("Sollie","Mant","73","smantj@slate.com","37.190.471","94-5070-7528"));
			listaClientes.Add(new Cliente("Daphne","Sambrok","66","dsambrokk@amazon.co.uk","72.733.193","49-3395-1162"));
			listaClientes.Add(new Cliente("Isidro","Hunston","9","ihunstonl@amazonaws.com","95.258.309","22-2114-2972"));
			listaClientes.Add(new Cliente("Hedda","Rowswell","12","hrowswellm@free.fr","74.347.157","30-7602-9370"));
			listaClientes.Add(new Cliente("Melisent","Baudry","24","mbaudryn@freewebs.com","37.834.125","86-4393-3171"));
			listaClientes.Add(new Cliente("Chad","Ulyat","98","culyato@sciencedirect.com","14.606.771","18-4160-2966"));
			listaClientes.Add(new Cliente("Boycey","Bilbery","62","bbilberyp@psu.edu","90.937.198","02-1930-3958"));
			listaClientes.Add(new Cliente("Taddeusz","Austwick","77","taustwickq@dropbox.com","23.789.578","85-4710-8920"));
			listaClientes.Add(new Cliente("Haskel","Giabuzzi","50","hgiabuzzir@wiley.com","24.135.067","63-2588-5332"));
			listaClientes.Add(new Cliente("Traver","Caig","12","tcaigs@fastcompany.com","12.177.171","04-6191-7582"));
			listaClientes.Add(new Cliente("Anastassia","Whitear","71","awhiteart@wordpress.org","97.577.546","06-6034-7303"));
			listaClientes.Add(new Cliente("Violetta","Cadding","98","vcaddingu@behance.net","87.471.546","86-7598-5040"));
			listaClientes.Add(new Cliente("Kamila","Snead","49","ksneadv@wikispaces.com","46.481.244","51-4511-3488"));
			listaClientes.Add(new Cliente("Mordy","Spratley","41","mspratleyw@reverbnation.com","96.282.315","82-6697-9102"));
			listaClientes.Add(new Cliente("Ameline","Arson","77","aarsonx@blog.com","59.721.674","44-6014-1836"));
			listaClientes.Add(new Cliente("Karolina","Silberschatz","56","ksilberschatzy@cbslocal.com","95.049.151","42-4833-2343"));
			listaClientes.Add(new Cliente("Vonnie","Boraston","52","vborastonz@biglobe.ne.jp","48.485.252","55-2946-1163"));
			listaClientes.Add(new Cliente("Malia","Koppe","87","mkoppe10@blog.com","14.861.737","71-5593-9707"));
			listaClientes.Add(new Cliente("Faun","Dorrity","35","fdorrity11@nih.gov","85.160.933","15-3814-2770"));
			listaClientes.Add(new Cliente("Louisette","Lukas","36","llukas12@forbes.com","74.118.075","44-6695-7925"));
			listaClientes.Add(new Cliente("Shelly","Cavendish","53","scavendish13@cnbc.com","68.595.201","50-5356-9010"));
			listaClientes.Add(new Cliente("Norri","Philot","45","nphilot14@cmu.edu","83.197.025","46-9441-8132"));
			listaClientes.Add(new Cliente("Morse","Chasmer","91","mchasmer15@printfriendly.com","98.009.369","44-7181-7640"));
			listaClientes.Add(new Cliente("Orson","Klas","18","oklas16@hostgator.com","19.653.688","20-3202-7374"));
			listaClientes.Add(new Cliente("Jarid","Tofpik","16","jtofpik17@purevolume.com","81.499.447","03-7231-9386"));
			listaClientes.Add(new Cliente("Olag","Worsall","81","oworsall18@jigsy.com","15.389.666","90-8594-4495"));
			listaClientes.Add(new Cliente("Kippy","Eckh","49","keckh19@state.tx.us","24.473.082","66-9886-6820"));
			listaClientes.Add(new Cliente("Jarvis","Jerred","13","jjerred1a@cam.ac.uk","92.992.415","90-9380-4940"));
			listaClientes.Add(new Cliente("Guillaume","Ketts","67","gketts1b@google.fr","56.918.934","18-9380-0632"));
			listaClientes.Add(new Cliente("Erna","Belchamber","69","ebelchamber1c@utexas.edu","52.067.889","54-2495-9045"));
			listaClientes.Add(new Cliente("Bathsheba","Provis","61","bprovis1d@epa.gov","86.147.618","70-6525-0012"));
			listaClientes.Add(new Cliente("Tallulah","Casbourne","59","tcasbourne1e@netscape.com","38.838.343","84-8739-7399"));
			listaClientes.Add(new Cliente("Lilyan","Murrthum","52","lmurrthum1f@myspace.com","46.132.955","41-5420-7096"));
			listaClientes.Add(new Cliente("Clari","Woolsey","25","cwoolsey1g@ehow.com","94.062.460","04-8448-5369"));
			listaClientes.Add(new Cliente("Sophia","McGeady","87","smcgeady1h@cargocollective.com","62.107.696","91-9812-2326"));
			listaClientes.Add(new Cliente("Shellie","Stern","26","sstern1i@youku.com","12.772.330","06-2668-0249"));
			listaClientes.Add(new Cliente("Xymenes","Spenceley","60","xspenceley1j@soup.io","41.907.874","62-9474-5888"));
			listaClientes.Add(new Cliente("Hoyt","Leguay","98","hleguay1k@simplemachines.org","16.329.435","89-8750-5914"));
			listaClientes.Add(new Cliente("Jena","Spears","54","jspears1l@squarespace.com","56.980.138","09-9411-0335"));
			listaClientes.Add(new Cliente("Margalit","Hurford","76","mhurford1m@odnoklassniki.ru","23.782.198","93-7877-5686"));
			listaClientes.Add(new Cliente("Louise","Bartosiak","37","lbartosiak1n@fema.gov","83.471.604","46-7681-0849"));
			listaClientes.Add(new Cliente("Clarance","Jane","73","cjane1o@diigo.com","69.192.511","19-1944-7792"));
			listaClientes.Add(new Cliente("Bellanca","Graysmark","67","bgraysmark1p@twitpic.com","22.144.738","25-3149-5429"));
			listaClientes.Add(new Cliente("Roddie","McDuff","26","rmcduff1q@networksolutions.com","94.563.861","90-6771-2689"));
			listaClientes.Add(new Cliente("Michelina","Poure","39","mpoure1r@g.co","94.279.917","77-8875-0226"));
			listaClientes.Add(new Cliente("Arley","Ughetti","91","aughetti1s@nba.com","45.646.062","20-7758-3626"));
			listaClientes.Add(new Cliente("Creighton","Aasaf","75","caasaf1t@cdbaby.com","51.233.977","60-5631-1251"));
			listaClientes.Add(new Cliente("Kristy","DeMetz","22","kdemetz1u@tinyurl.com","29.751.940","41-4677-7693"));
			listaClientes.Add(new Cliente("Elfrida","Minico","15","eminico1v@unesco.org","40.317.631","79-8768-8538"));
			listaClientes.Add(new Cliente("Donal","Arlow","18","darlow1w@ocn.ne.jp","82.692.643","85-4023-5148"));
			listaClientes.Add(new Cliente("Missy","Heckney","36","mheckney1x@issuu.com","82.586.697","86-7872-3934"));
			listaClientes.Add(new Cliente("Valentine","Parrot","51","vparrot1y@arstechnica.com","57.206.943","43-4484-4783"));
			listaClientes.Add(new Cliente("Archer","Wear","45","awear1z@businesswire.com","28.731.089","76-2986-3832"));
			listaClientes.Add(new Cliente("Rania","Kelleher","57","rkelleher20@globo.com","53.051.790","49-3696-8746"));
			listaClientes.Add(new Cliente("Torr","Cumo","24","tcumo21@huffingtonpost.com","12.147.366","08-1864-0545"));
			listaClientes.Add(new Cliente("Correna","Helsdon","40","chelsdon22@technorati.com","78.349.230","49-9722-6764"));
			listaClientes.Add(new Cliente("Otto","Rawll","62","orawll23@ustream.tv","67.838.780","72-5630-5515"));
			listaClientes.Add(new Cliente("Roddy","Cabera","99","rcabera24@vistaprint.com","63.660.679","33-6090-2080"));
			listaClientes.Add(new Cliente("Renata","Brent","89","rbrent25@photobucket.com","15.357.479","66-9936-0124"));
			listaClientes.Add(new Cliente("Viole","Pride","87","vpride26@fda.gov","17.300.467","59-7624-3022"));
			listaClientes.Add(new Cliente("Kit","Hurd","18","khurd27@dell.com","69.576.403","60-4062-3724"));
			listaClientes.Add(new Cliente("Nappie","Marsh","65","nmarsh28@reverbnation.com","08.477.218","60-5473-5150"));
			listaClientes.Add(new Cliente("Phil","Smallshaw","85","psmallshaw29@loc.gov","33.914.171","99-2719-9872"));
			listaClientes.Add(new Cliente("Ogdon","Olohan","37","oolohan2a@g.co","41.939.600","47-1598-0677"));
			listaClientes.Add(new Cliente("Dur","O'Giany","71","dogiany2b@hexun.com","32.652.861","26-6129-9539"));
			listaClientes.Add(new Cliente("Garry","Iannelli","45","giannelli2c@weebly.com","48.787.988","14-3608-7116"));
			listaClientes.Add(new Cliente("Marina","Cowles","57","mcowles2d@printfriendly.com","77.199.135","98-4557-1832"));
			listaClientes.Add(new Cliente("Beilul","LeBarr","47","blebarr2e@meetup.com","72.958.333","25-8860-5754"));
			listaClientes.Add(new Cliente("Ladonna","Adamowitz","72","ladamowitz2f@wisc.edu","69.520.818","63-5629-7169"));
			listaClientes.Add(new Cliente("Ynes","Greasty","11","ygreasty2g@usgs.gov","32.202.433","69-4785-5199"));
			listaClientes.Add(new Cliente("Isaiah","Tocque","77","itocque2h@salon.com","79.628.613","18-1915-4227"));
			listaClientes.Add(new Cliente("Mandel","Keysall","16","mkeysall2i@ox.ac.uk","51.907.249","57-6446-4103"));
			listaClientes.Add(new Cliente("Kristofer","Smurfitt","46","ksmurfitt2j@nps.gov","77.466.446","07-4152-5420"));
			listaClientes.Add(new Cliente("Bren","Pierrepont","25","bpierrepont2k@angelfire.com","06.563.577","95-8847-7920"));
			listaClientes.Add(new Cliente("Addie","Osanne","48","aosanne2l@printfriendly.com","67.962.809","57-3613-3908"));
			listaClientes.Add(new Cliente("Bailie","Persian","77","bpersian2m@prweb.com","20.888.985","03-6486-7667"));
			listaClientes.Add(new Cliente("Mady","Hamley","62","mhamley2n@constantcontact.com","63.368.598","51-7065-2366"));
			listaClientes.Add(new Cliente("Adrianna","Kamall","92","akamall2o@squarespace.com","20.155.918","25-5389-6285"));
			listaClientes.Add(new Cliente("Dimitry","Bergstrand","79","dbergstrand2p@indiatimes.com","97.721.727","05-6160-6119"));
			listaClientes.Add(new Cliente("Perl","Brechin","17","pbrechin2q@cbslocal.com","80.273.320","87-1193-3871"));
			listaClientes.Add(new Cliente("Allie","Woodman","34","awoodman2r@shop-pro.jp","38.139.034","00-9152-9389"));
			listaClientes.Add(new Cliente("Rica","Hairon","33","rhairon2s@jugem.jp","24.652.869","78-2026-3583"));
			listaClientes.Add(new Cliente("Bobbie","Idill","25","bidill2t@wordpress.com","24.885.492","51-2653-4895"));
			listaClientes.Add(new Cliente("Blondell","Brickstock","57","bbrickstock2u@github.io","04.022.990","68-8237-3511"));
			listaClientes.Add(new Cliente("Alix","Bolliver","33","abolliver2v@free.fr","10.257.049","66-5462-9803"));
			listaClientes.Add(new Cliente("Rourke","Edison","18","redison2w@marriott.com","46.490.625","28-7991-1042"));
			listaClientes.Add(new Cliente("Teressa","Georger","41","tgeorger2x@de.vu","65.002.967","14-2717-0128"));
			listaClientes.Add(new Cliente("Janeczka","Stannett","30","jstannett2y@goodreads.com","85.060.344","90-2029-0817"));
			listaClientes.Add(new Cliente("Laurie","Crossgrove","78","lcrossgrove2z@telegraph.co.uk","73.771.271","91-8963-6268"));
			listaClientes.Add(new Cliente("Latisha","Mara","97","lmara30@dailymotion.com","40.590.920","70-7332-3791"));
			listaClientes.Add(new Cliente("Sande","Proven","71","sproven31@reddit.com","53.592.106","98-2868-3461"));
			listaClientes.Add(new Cliente("Welch","Pipes","73","wpipes32@uiuc.edu","46.537.110","44-5626-8505"));
			listaClientes.Add(new Cliente("Taryn","Berndt","76","tberndt33@gnu.org","32.720.582","91-7075-2503"));
			listaClientes.Add(new Cliente("Lisa","Gullivan","46","lgullivan34@omniture.com","74.676.640","38-7917-3022"));
			listaClientes.Add(new Cliente("Perice","Duggen","97","pduggen35@barnesandnoble.com","75.176.972","92-4314-4810"));
			listaClientes.Add(new Cliente("Cleavland","Wolters","29","cwolters36@mapy.cz","81.502.196","94-5332-9026"));
			listaClientes.Add(new Cliente("Jarvis","LeBosse","20","jlebosse37@friendfeed.com","92.162.299","81-3987-2359"));
			listaClientes.Add(new Cliente("Brandice","Scadden","85","bscadden38@icq.com","19.605.456","56-0666-7445"));
			listaClientes.Add(new Cliente("Frieda","Gornar","57","fgornar39@who.int","10.134.017","32-6139-1307"));
			listaClientes.Add(new Cliente("Lari","Allderidge","19","lallderidge3a@cam.ac.uk","70.209.347","99-6564-3987"));
			listaClientes.Add(new Cliente("Gertrude","Blaiklock","62","gblaiklock3b@instagram.com","74.180.308","14-8064-9826"));
			listaClientes.Add(new Cliente("Antone","Olivazzi","97","aolivazzi3c@ihg.com","57.937.192","03-8460-3236"));
			listaClientes.Add(new Cliente("Dodi","Hawken","88","dhawken3d@shareasale.com","88.447.264","35-0991-5050"));
			listaClientes.Add(new Cliente("Lindsey","Alliband","24","lalliband3e@geocities.com","07.744.390","16-5619-9408"));
			listaClientes.Add(new Cliente("Lotte","Manhood","90","lmanhood3f@netscape.com","42.847.101","97-3371-9977"));
			listaClientes.Add(new Cliente("Torre","Linnell","42","tlinnell3g@webeden.co.uk","74.306.923","00-0380-9244"));
			listaClientes.Add(new Cliente("Charis","Roddie","42","croddie3h@craigslist.org","81.800.852","49-5800-8970"));
			listaClientes.Add(new Cliente("Kristen","Soffe","86","ksoffe3i@ezinearticles.com","63.781.025","86-6685-2063"));
			listaClientes.Add(new Cliente("Werner","Dedon","21","wdedon3j@istockphoto.com","23.366.242","16-8178-2633"));
			listaClientes.Add(new Cliente("Eleonora","Antonomoli","31","eantonomoli3k@tripadvisor.com","93.464.464","67-7611-4464"));
			listaClientes.Add(new Cliente("Melloney","Rollin","39","mrollin3l@smugmug.com","35.863.814","08-7491-5397"));
			listaClientes.Add(new Cliente("Elinor","Grinin","85","egrinin3m@icio.us","37.522.595","94-9080-7375"));
			listaClientes.Add(new Cliente("Joshia","Brockhouse","74","jbrockhouse3n@canalblog.com","64.398.072","51-8009-1080"));
			listaClientes.Add(new Cliente("Ashley","Eichmann","76","aeichmann3o@google.it","74.000.031","77-1657-4561"));
			listaClientes.Add(new Cliente("Hermon","Finlan","47","hfinlan3p@unicef.org","04.352.910","09-3064-4669"));
			listaClientes.Add(new Cliente("Reid","Rowdell","18","rrowdell3q@ca.gov","76.893.490","69-5598-3286"));
			listaClientes.Add(new Cliente("Pascale","Gleder","64","pgleder3r@amazon.co.uk","96.964.754","14-0367-8667"));
			listaClientes.Add(new Cliente("Jeannie","Schowenburg","68","jschowenburg3s@tinypic.com","93.266.842","01-5087-0691"));
			listaClientes.Add(new Cliente("Gerri","Dymoke","57","gdymoke3t@yelp.com","24.932.545","10-6771-1231"));
			listaClientes.Add(new Cliente("Phineas","Stailey","90","pstailey3u@elegantthemes.com","78.386.876","47-9395-7530"));
			listaClientes.Add(new Cliente("Winona","Baraclough","29","wbaraclough3v@arstechnica.com","41.075.504","24-3885-3846"));
			listaClientes.Add(new Cliente("Pinchas","Gillinghams","95","pgillinghams3w@gov.uk","59.864.030","71-0513-5569"));
			listaClientes.Add(new Cliente("Inga","Blethyn","43","iblethyn3x@sina.com.cn","42.084.063","33-7249-0199"));
			listaClientes.Add(new Cliente("Terence","Copeman","71","tdecopeman3y@nymag.com","04.129.907","24-4550-6930"));
			listaClientes.Add(new Cliente("Ilyssa","Orkney","80","iorkney3z@godaddy.com","52.915.481","18-6361-1274"));
			listaClientes.Add(new Cliente("Dorry","Vivians","42","dvivians40@yahoo.com","50.226.035","70-6074-2937"));
			listaClientes.Add(new Cliente("Benyamin","Fiddian","98","bfiddian41@tamu.edu","29.778.681","01-5878-8675"));
			listaClientes.Add(new Cliente("Hale","Parkhouse","51","hparkhouse42@phoca.cz","44.331.408","75-6635-0856"));
			listaClientes.Add(new Cliente("Rab","Truss","14","rtruss43@dropbox.com","42.197.285","91-7128-9997"));
			listaClientes.Add(new Cliente("Melanie","Firidolfi","91","mfiridolfi44@nsw.gov.au","24.817.431","73-6569-8018"));
			listaClientes.Add(new Cliente("Gwyn","McArdle","39","gmcardle45@answers.com","57.869.523","28-2395-9038"));
			listaClientes.Add(new Cliente("Holly-anne","Garrit","23","hgarrit46@infoseek.co.jp","56.160.461","81-2605-9262"));
			listaClientes.Add(new Cliente("Gertrud","Heinel","56","gheinel47@timesonline.co.uk","53.485.841","04-8212-2906"));
			listaClientes.Add(new Cliente("Bekki","Doran","67","bdoran48@weather.com","27.938.270","95-7315-2873"));
			listaClientes.Add(new Cliente("Morgan","Phillips","39","mphillips49@wix.com","29.037.893","22-4093-0126"));
			listaClientes.Add(new Cliente("Carlyn","Hammonds","43","chammonds4a@narod.ru","77.025.226","01-0962-1392"));
			listaClientes.Add(new Cliente("Frederico","Saggs","45","fsaggs4b@bloomberg.com","16.411.252","78-1139-2650"));
			listaClientes.Add(new Cliente("Hilary","Callaghan","44","hcallaghan4c@ucla.edu","14.269.041","27-3985-1727"));
			listaClientes.Add(new Cliente("Jasmine","Dockwray","50","jdockwray4d@blinklist.com","64.256.771","79-4750-8603"));
			listaClientes.Add(new Cliente("Roseline","Morfield","20","rmorfield4e@netscape.com","64.082.611","26-4682-8133"));
			listaClientes.Add(new Cliente("Jany","MacComiskey","98","jmaccomiskey4f@cnet.com","29.068.446","05-0345-7703"));
			listaClientes.Add(new Cliente("Corry","Strawbridge","36","cstrawbridge4g@geocities.jp","15.857.429","39-7139-9917"));
			listaClientes.Add(new Cliente("Lucilia","Coxwell","81","lcoxwell4h@cargocollective.com","85.601.006","65-3981-2698"));
			listaClientes.Add(new Cliente("Andrea","DeVaar","45","adevaar4i@linkedin.com","34.513.826","46-9750-2550"));
			listaClientes.Add(new Cliente("Lazare","Stammirs","38","lstammirs4j@gmpg.org","97.499.314","83-4397-3879"));
			listaClientes.Add(new Cliente("Shawnee","McCahey","68","smccahey4k@fastcompany.com","44.789.017","32-7829-6479"));
			listaClientes.Add(new Cliente("Zelig","Wehden","24","zwehden4l@princeton.edu","92.268.818","07-7046-6465"));
			listaClientes.Add(new Cliente("Dickie","Dragge","75","ddragge4m@drupal.org","29.669.645","39-2981-9334"));
			listaClientes.Add(new Cliente("Isiahi","Heiton","92","iheiton4n@digg.com","66.714.142","49-5228-8863"));
			listaClientes.Add(new Cliente("Ichabod","Oolahan","36","ioolahan4o@sbwire.com","28.747.071","54-8217-4289"));
			listaClientes.Add(new Cliente("Fae","Boothebie","23","fboothebie4p@fastcompany.com","81.273.022","34-2474-7095"));
			listaClientes.Add(new Cliente("Lyn","Gehrels","70","lgehrels4q@bbb.org","07.200.019","76-7586-2857"));
			listaClientes.Add(new Cliente("Belva","Caile","91","bcaile4r@1und1.de","07.861.644","78-4885-1919"));
			listaClientes.Add(new Cliente("Kylila","Cursons","92","kcursons4s@ox.ac.uk","63.801.044","41-3512-6058"));
			listaClientes.Add(new Cliente("Kristine","Henken","17","khenken4t@live.com","06.462.755","67-9428-7670"));
			listaClientes.Add(new Cliente("Grace","Cowlas","23","gcowlas4u@zdnet.com","32.394.819","90-1784-9941"));
			listaClientes.Add(new Cliente("Ram","Izaks","36","rizaks4v@google.nl","34.930.271","30-3009-8012"));
			listaClientes.Add(new Cliente("Tabbie","Mougin","97","tmougin4w@cocolog-nifty.com","40.905.549","02-6493-1539"));
			listaClientes.Add(new Cliente("Britte","Cleave","43","bcleave4x@mapquest.com","11.312.084","69-6419-8110"));
			listaClientes.Add(new Cliente("Esra","Hammerberg","37","ehammerberg4y@behance.net","08.209.881","06-2631-9600"));
			listaClientes.Add(new Cliente("Nero","Skitch","41","nskitch4z@cam.ac.uk","14.973.279","19-7867-6495"));
			listaClientes.Add(new Cliente("Anthony","Callam","31","acallam50@wikimedia.org","73.855.015","78-6492-6404"));
			listaClientes.Add(new Cliente("Erasmus","Brownstein","66","ebrownstein51@amazonaws.com","38.294.188","01-1692-4172"));
			listaClientes.Add(new Cliente("Bertie","Bartholat","28","bbartholat52@blogger.com","92.576.383","09-5843-1082"));
			listaClientes.Add(new Cliente("Angus","Burchall","50","aburchall53@xing.com","51.782.380","94-6813-1104"));
			listaClientes.Add(new Cliente("Dominic","Callacher","22","dcallacher54@slate.com","89.652.155","94-9976-7859"));
			listaClientes.Add(new Cliente("Keefe","MacPake","48","kmacpake55@naver.com","38.076.843","51-9311-5048"));
			listaClientes.Add(new Cliente("Lauraine","Ferras","17","lferras56@nydailynews.com","84.232.681","40-8006-7079"));
			listaClientes.Add(new Cliente("Eldredge","Sclater","41","esclater57@dmoz.org","16.822.563","14-2688-2804"));
			listaClientes.Add(new Cliente("Cherie","Melarkey","92","cmelarkey58@columbia.edu","31.814.178","31-1184-4867"));
			listaClientes.Add(new Cliente("Barnabe","Heilds","84","bheilds59@blog.com","15.322.191","29-2228-1328"));
			listaClientes.Add(new Cliente("Donny","Boorman","65","dboorman5a@dagondesign.com","94.416.460","74-0930-5164"));
			listaClientes.Add(new Cliente("Darda","Steels","60","dsteels5b@123-reg.co.uk","05.898.558","28-8971-4087"));
			listaClientes.Add(new Cliente("Symon","Metcalfe","52","smetcalfe5c@google.ru","69.819.031","73-8523-6824"));
			listaClientes.Add(new Cliente("Rey","Bachmann","81","rbachmann5d@wordpress.org","81.851.745","98-1802-7382"));
			listaClientes.Add(new Cliente("Abraham","Dunmore","23","adunmore5e@webnode.com","54.887.531","87-0295-9725"));
			listaClientes.Add(new Cliente("Berty","Ettles","29","bettles5f@yahoo.co.jp","16.680.735","36-2939-5011"));
			listaClientes.Add(new Cliente("Reider","Turneux","89","rturneux5g@wired.com","57.826.220","83-5743-7576"));
			listaClientes.Add(new Cliente("Sigrid","Frandsen","39","sfrandsen5h@wired.com","21.851.855","15-9740-1413"));
			listaClientes.Add(new Cliente("Julita","Giacopetti","97","jgiacopetti5i@ezinearticles.com","31.451.701","10-8143-9028"));
			listaClientes.Add(new Cliente("Chandra","Penberthy","34","cpenberthy5j@tuttocitta.it","57.830.332","83-2758-6979"));
			listaClientes.Add(new Cliente("Charlie","Norcutt","59","cnorcutt5k@parallels.com","44.537.174","00-8203-2566"));
			listaClientes.Add(new Cliente("Boycey","Ferraro","74","bferraro5l@hud.gov","66.111.523","50-4198-4961"));
			listaClientes.Add(new Cliente("Angelica","Redpath","18","aredpath5m@amazonaws.com","32.815.602","01-5089-9268"));
			listaClientes.Add(new Cliente("Letta","Krochmann","75","lkrochmann5n@admin.ch","32.759.997","71-9057-9592"));
			listaClientes.Add(new Cliente("Josee","Redhole","76","jredhole5o@imdb.com","66.324.395","49-1018-7563"));
			listaClientes.Add(new Cliente("Jule","McGrill","72","jmcgrill5p@yellowpages.com","23.244.525","34-3056-8403"));
			listaClientes.Add(new Cliente("Georgena","Huckett","35","ghuckett5q@rediff.com","94.611.497","50-8626-4159"));
			listaClientes.Add(new Cliente("Sherilyn","Sivill","69","ssivill5r@si.edu","95.793.199","74-7605-4465"));
			listaClientes.Add(new Cliente("Sheree","Ticehurst","72","sticehurst5s@yellowbook.com","64.641.846","61-7182-3495"));
			listaClientes.Add(new Cliente("Rita","Child","58","rchild5t@phpbb.com","96.089.266","94-2480-3811"));
			listaClientes.Add(new Cliente("Veronika","Curner","21","vcurner5u@cafepress.com","62.260.859","95-9827-0656"));
			listaClientes.Add(new Cliente("Belva","Henmarsh","51","bhenmarsh5v@cloudflare.com","97.994.005","62-6108-1634"));
			listaClientes.Add(new Cliente("Corny","Zapata","59","czapata5w@bbb.org","87.708.602","44-9807-2326"));
			listaClientes.Add(new Cliente("Berni","Bridgett","23","bbridgett5x@newsvine.com","50.328.473","11-9402-8277"));
			listaClientes.Add(new Cliente("Libbie","Duckitt","32","lduckitt5y@google.co.jp","57.076.848","08-1839-8961"));
			listaClientes.Add(new Cliente("Bastien","Lagadu","38","blagadu5z@mashable.com","96.240.858","18-3004-3466"));
			listaClientes.Add(new Cliente("Flem","Micklewicz","24","fmicklewicz60@mysql.com","15.020.546","60-7669-8325"));
			listaClientes.Add(new Cliente("Catlaina","Wigsell","47","cwigsell61@si.edu","12.802.114","18-6827-7121"));
			listaClientes.Add(new Cliente("Cam","Staff","84","cstaff62@bandcamp.com","56.907.485","12-6286-4089"));
			listaClientes.Add(new Cliente("Veradis","McLaughlin","26","vmclaughlin63@fema.gov","18.974.594","08-3242-3296"));
			listaClientes.Add(new Cliente("Diane","Storrock","80","dstorrock64@netlog.com","45.614.482","27-1432-8831"));
			listaClientes.Add(new Cliente("Christos","Thunders","27","cthunders65@oakley.com","21.059.911","67-7200-6122"));
			listaClientes.Add(new Cliente("Doug","Gaitley","53","dgaitley66@examiner.com","97.870.241","49-2624-2035"));
			listaClientes.Add(new Cliente("Ruby","Lowdwell","32","rlowdwell67@fc2.com","09.824.965","28-1443-4756"));
			listaClientes.Add(new Cliente("Dieter","Lavington","31","dlavington68@google.it","90.859.416","09-6229-2652"));
			listaClientes.Add(new Cliente("Todd","Helwig","36","thelwig69@macromedia.com","28.293.226","96-9292-6919"));
			listaClientes.Add(new Cliente("Ross","Kittow","23","rkittow6a@zimbio.com","65.437.460","82-1651-5855"));
			listaClientes.Add(new Cliente("Gabrila","Enevoldsen","33","genevoldsen6b@yellowpages.com","20.565.244","49-5172-9337"));
			listaClientes.Add(new Cliente("Faydra","Coslitt","34","fcoslitt6c@businessweek.com","10.647.690","86-3825-6020"));
			listaClientes.Add(new Cliente("Catha","Digle","56","cdigle6d@mac.com","39.188.384","83-3884-4433"));
			listaClientes.Add(new Cliente("Shari","Vanetti","24","svanetti6e@umn.edu","71.841.433","60-9792-6046"));
			listaClientes.Add(new Cliente("Marijn","Girardini","28","mgirardini6f@wired.com","72.331.810","45-8336-3186"));
			listaClientes.Add(new Cliente("Maynord","McSwan","44","mmcswan6g@friendfeed.com","90.425.191","27-0494-1541"));
			listaClientes.Add(new Cliente("Allyn","Whittek","95","awhittek6h@tinypic.com","83.506.142","90-6502-8190"));
			listaClientes.Add(new Cliente("Brett","Whatson","82","bwhatson6i@va.gov","43.005.524","90-5848-1168"));
			listaClientes.Add(new Cliente("Harris","Erat","28","herat6j@si.edu","46.833.727","36-7600-4394"));
			listaClientes.Add(new Cliente("Chantalle","Lawling","21","clawling6k@jigsy.com","31.620.661","81-1034-2011"));
			listaClientes.Add(new Cliente("Jessamine","Bradwell","28","jbradwell6l@ibm.com","84.590.401","60-3977-6146"));
			listaClientes.Add(new Cliente("Buddy","Kendrew","30","bkendrew6m@nbcnews.com","60.637.335","82-7369-9142"));
			listaClientes.Add(new Cliente("Tania","MacGaughie","31","tmacgaughie6n@people.com.cn","76.383.418","26-2818-1038"));
			listaClientes.Add(new Cliente("Selene","Spurrier","19","sspurrier6o@mozilla.org","85.831.770","14-9161-7287"));
			listaClientes.Add(new Cliente("Arleta","Davenhall","56","adavenhall6p@fastcompany.com","69.537.777","52-2098-4291"));
			listaClientes.Add(new Cliente("Lyndy","Krimmer","46","lkrimmer6q@1und1.de","92.062.085","46-6659-0278"));
			listaClientes.Add(new Cliente("Elita","Well","90","ewell6r@unc.edu","75.899.617","88-1110-9828"));
			listaClientes.Add(new Cliente("Murielle","Yakubowicz","90","myakubowicz6s@amazonaws.com","77.443.454","60-7283-4395"));
			listaClientes.Add(new Cliente("Kennith","Chominski","41","kchominski6t@admin.ch","47.690.851","66-1460-3430"));
			listaClientes.Add(new Cliente("Mohandas","Gilleson","24","mgilleson6u@over-blog.com","38.402.733","08-2646-4618"));
			listaClientes.Add(new Cliente("Myrwyn","Hawe","61","mhawe6v@cam.ac.uk","65.409.784","09-7583-2000"));
			listaClientes.Add(new Cliente("Clo","Waddicor","55","cwaddicor6w@oracle.com","08.218.774","37-2852-0532"));
			listaClientes.Add(new Cliente("Husein","Jurca","72","hjurca6x@yolasite.com","37.264.317","24-2258-1250"));
			listaClientes.Add(new Cliente("Rustin","Bromehed","69","rbromehed6y@twitter.com","76.520.793","88-0063-5225"));
			listaClientes.Add(new Cliente("Vanna","Helis","80","vhelis6z@oakley.com","84.346.784","60-7555-4728"));
			listaClientes.Add(new Cliente("Cleopatra","Treharne","18","ctreharne70@vimeo.com","63.227.224","82-7760-3097"));
			listaClientes.Add(new Cliente("Liz","Ertel","64","lertel71@aol.com","00.667.125","32-8558-9645"));
			listaClientes.Add(new Cliente("Gunilla","Ferriby","29","gferriby72@adobe.com","65.520.540","47-0114-4608"));
			listaClientes.Add(new Cliente("Florrie","Staner","21","fstaner73@merriam-webster.com","90.775.570","74-4762-7831"));
			listaClientes.Add(new Cliente("Alameda","OCorhane","95","aocorhane74@storify.com","20.672.196","85-1891-8842"));
			listaClientes.Add(new Cliente("Clarinda","Abelovitz","44","cabelovitz75@diigo.com","82.788.875","90-6162-4672"));
			listaClientes.Add(new Cliente("Lois","Dutson","48","ldutson76@ebay.com","58.006.339","22-9332-6698"));
			listaClientes.Add(new Cliente("Findlay","Seccombe","62","fseccombe77@cornell.edu","78.388.731","67-8785-1335"));
			listaClientes.Add(new Cliente("Kinny","Measor","50","kmeasor78@ustream.tv","22.131.775","23-1878-4334"));
			listaClientes.Add(new Cliente("Nolly","Chatainier","77","nchatainier79@hud.gov","33.774.879","24-0289-1939"));
			listaClientes.Add(new Cliente("Dacia","Jacson","19","djacson7a@nytimes.com","44.431.373","68-3319-0651"));
			listaClientes.Add(new Cliente("Ruth","Klimsch","48","rklimsch7b@reverbnation.com","86.449.123","27-5160-8426"));
			listaClientes.Add(new Cliente("Blane","Doornbos","33","bdoornbos7c@mashable.com","93.004.826","27-7025-5940"));
			listaClientes.Add(new Cliente("Annamarie","Habeshaw","29","ahabeshaw7d@examiner.com","22.610.083","06-2173-1418"));
			listaClientes.Add(new Cliente("Giulietta","Cosker","26","gcosker7e@acquirethisname.com","34.262.442","52-0290-7521"));
			listaClientes.Add(new Cliente("Gallagher","Sandyford","19","gsandyford7f@ibm.com","50.144.247","90-4671-5134"));
			listaClientes.Add(new Cliente("Rey","Scholfield","30","rscholfield7g@google.pl","75.038.699","51-6827-5548"));
			listaClientes.Add(new Cliente("Rosemarie","McLaren","18","rmclaren7h@issuu.com","35.191.724","75-3159-2646"));
			listaClientes.Add(new Cliente("Ignatius","Proschke","24","iproschke7i@clickbank.net","29.487.490","68-3680-6611"));
			listaClientes.Add(new Cliente("Bax","Claybourn","74","bclaybourn7j@twitpic.com","09.850.242","07-1415-2126"));
			listaClientes.Add(new Cliente("Charlton","Nulty","43","cnulty7k@vk.com","30.373.572","57-3158-3095"));
			listaClientes.Add(new Cliente("Thatcher","Cookes","35","tcookes7l@huffingtonpost.com","19.654.705","94-8560-2322"));
			listaClientes.Add(new Cliente("Claribel","Norquoy","58","cnorquoy7m@princeton.edu","67.744.436","26-3153-0879"));
			listaClientes.Add(new Cliente("Nigel","Staniland","36","nstaniland7n@gmpg.org","94.205.477","74-8688-1846"));
			listaClientes.Add(new Cliente("Laughton","Mawne","40","lmawne7o@etsy.com","11.591.918","71-1119-8195"));
			listaClientes.Add(new Cliente("Werner","VanDijk","66","wvandijk7p@wikispaces.com","60.955.526","43-4401-5944"));
			listaClientes.Add(new Cliente("Boonie","Luttger","45","bluttger7q@wsj.com","70.380.279","45-3153-9229"));
			listaClientes.Add(new Cliente("Shayne","Flann","21","sflann7r@addthis.com","49.108.433","10-4824-7544"));
			listaClientes.Add(new Cliente("Trumann","O'Crigan","52","tocrigan7s@smh.com.au","89.276.666","46-1935-3770"));
			listaClientes.Add(new Cliente("Constanta","Elcock","81","celcock7t@photobucket.com","12.928.750","96-5645-8268"));
			listaClientes.Add(new Cliente("Ediva","Bunworth","48","ebunworth7u@mapy.cz","22.438.882","47-4375-1467"));
			listaClientes.Add(new Cliente("Heddi","Feuell","55","hfeuell7v@google.ca","37.743.408","62-6344-6196"));
			listaClientes.Add(new Cliente("Claresta","Crown","66","ccrown7w@a8.net","32.700.997","96-4170-9749"));
			listaClientes.Add(new Cliente("Cherrita","Ors","38","cors7x@123-reg.co.uk","39.459.395","36-8462-3103"));
			listaClientes.Add(new Cliente("Laney","Fuggle","33","lfuggle7y@squidoo.com","65.613.093","35-7682-8635"));
			listaClientes.Add(new Cliente("Loise","O'Dea","93","lodea7z@domainmarket.com","65.606.983","93-1408-4748"));
			listaClientes.Add(new Cliente("Cahra","Monger","29","cmonger80@wunderground.com","08.331.885","26-3517-3715"));
			listaClientes.Add(new Cliente("Bert","Passman","15","bpassman81@slideshare.net","51.502.007","00-2050-5848"));
			listaClientes.Add(new Cliente("Timmy","Jacklings","19","tjacklings82@timesonline.co.uk","56.934.576","07-2250-8803"));
			listaClientes.Add(new Cliente("Bernadette","Toye","19","btoye83@imageshack.us","12.987.649","59-4877-6743"));
			listaClientes.Add(new Cliente("Joana","McCrystal","56","jmccrystal84@deviantart.com","49.455.801","20-1308-4373"));
			listaClientes.Add(new Cliente("Udale","Pinna","61","udepinna85@hao123.com","02.090.775","83-0074-1663"));
			listaClientes.Add(new Cliente("Constancy","Scarlett","26","cscarlett86@sitemeter.com","37.520.459","67-4042-1257"));
			listaClientes.Add(new Cliente("Kelcie","Biaggioni","74","kbiaggioni87@uiuc.edu","77.440.618","69-2504-0373"));
			listaClientes.Add(new Cliente("Alden","Francom","33","afrancom88@1und1.de","14.756.290","72-5017-0407"));
			listaClientes.Add(new Cliente("Cynde","Balogh","76","cbalogh89@yellowbook.com","44.934.134","66-8117-8120"));
			listaClientes.Add(new Cliente("Alejandra","Marcinkus","81","amarcinkus8a@bloglovin.com","26.123.486","89-8175-8902"));
			listaClientes.Add(new Cliente("Freddie","Denison","78","fdenison8b@google.de","99.716.044","91-3635-9171"));
			listaClientes.Add(new Cliente("Jaimie","Feldhorn","46","jfeldhorn8c@mapy.cz","08.606.088","80-1599-9403"));
			listaClientes.Add(new Cliente("Joyce","Kliemke","99","jkliemke8d@msu.edu","71.810.201","07-7660-4762"));
			listaClientes.Add(new Cliente("Vallie","Wilne","36","vwilne8e@flavors.me","46.675.997","88-8585-8736"));
			listaClientes.Add(new Cliente("Egan","Monard","22","emonard8f@nymag.com","62.659.193","42-2503-1945"));
			listaClientes.Add(new Cliente("Marga","Labusquiere","35","mlabusquiere8g@posterous.com","47.392.147","33-7295-2003"));
			listaClientes.Add(new Cliente("Carolynn","McBeth","83","cmcbeth8h@simplemachines.org","63.652.074","88-0053-8903"));
			listaClientes.Add(new Cliente("Jori","Kobsch","75","jkobsch8i@ustream.tv","40.044.104","01-6076-5698"));
			listaClientes.Add(new Cliente("Kriste","Cunniff","56","kcunniff8j@free.fr","86.836.288","69-3530-5643"));
			listaClientes.Add(new Cliente("Sidney","Sinson","78","ssinson8k@cargocollective.com","32.866.293","81-6363-3531"));
			listaClientes.Add(new Cliente("Kenny","Bodechon","29","kbodechon8l@harvard.edu","05.724.931","02-9322-1256"));
			listaClientes.Add(new Cliente("Waverly","Fairclough","29","wfairclough8m@stumbleupon.com","81.976.391","75-8233-5144"));
			listaClientes.Add(new Cliente("Katharyn","Presidey","71","kpresidey8n@google.com.br","29.908.433","50-7719-6541"));
			listaClientes.Add(new Cliente("Morganne","Abbati","98","mabbati8o@ask.com","98.459.282","55-5307-5136"));
			listaClientes.Add(new Cliente("Odie","Caiger","68","ocaiger8p@zdnet.com","96.733.506","04-5780-5134"));
			listaClientes.Add(new Cliente("Kinna","Wehden","71","kwehden8q@washington.edu","59.630.814","97-5330-7060"));
			listaClientes.Add(new Cliente("Dex","Greenroa","27","dgreenroa8r@senate.gov","75.703.913","61-6165-6657"));
			listaClientes.Add(new Cliente("Hervey","Blinerman","67","hblinerman8s@bluehost.com","14.437.945","12-7565-3297"));
			listaClientes.Add(new Cliente("Orelle","Gynne","70","ogynne8t@sun.com","98.735.718","63-7546-7553"));
			listaClientes.Add(new Cliente("Eben","Sahlstrom","86","esahlstrom8u@chronoengine.com","22.442.642","91-3751-8589"));
			listaClientes.Add(new Cliente("Bert","Medmore","98","bmedmore8v@symantec.com","38.330.709","81-8886-6563"));
			listaClientes.Add(new Cliente("Dix","Vido","24","dvido8w@printfriendly.com","80.468.906","12-7483-1698"));
			listaClientes.Add(new Cliente("Godfry","Davidovicz","44","gdavidovicz8x@spotify.com","63.877.127","35-0130-7970"));
			listaClientes.Add(new Cliente("Wilmar","Kitter","39","wkitter8y@ebay.co.uk","36.589.081","48-8127-7609"));
			listaClientes.Add(new Cliente("Hilton","Preene","23","hpreene8z@friendfeed.com","54.267.214","06-3923-2311"));
			listaClientes.Add(new Cliente("Tessy","Wogan","18","twogan90@t-online.de","46.337.438","46-4776-8787"));
			listaClientes.Add(new Cliente("Ede","Twidle","55","etwidle91@washingtonpost.com","51.759.650","69-1423-1989"));
			listaClientes.Add(new Cliente("Zacharia","Bonnet","42","zbonnet92@deviantart.com","82.201.451","29-4707-0312"));
			listaClientes.Add(new Cliente("Mavis","Benoist","90","mbenoist93@cisco.com","40.337.616","93-8023-6302"));
			listaClientes.Add(new Cliente("Braden","Cisland","49","bcisland94@pinterest.com","65.064.405","39-4450-1323"));
			listaClientes.Add(new Cliente("Damon","Pollitt","19","dpollitt95@mtv.com","58.262.592","84-3509-2202"));
			listaClientes.Add(new Cliente("Car","Verrill","43","cverrill96@blog.com","66.482.214","14-1932-7573"));
			listaClientes.Add(new Cliente("Amitie","Cicco","21","acicco97@amazonaws.com","68.608.578","07-8629-5454"));
			listaClientes.Add(new Cliente("Norris","Paxman","55","npaxman98@so-net.ne.jp","57.153.111","11-3610-5182"));
			listaClientes.Add(new Cliente("Elisabetta","Enticknap","20","eenticknap99@plala.or.jp","18.649.302","98-6561-2232"));
			listaClientes.Add(new Cliente("Dill","Hotton","21","dhotton9a@fc2.com","70.261.528","30-4878-0659"));
			listaClientes.Add(new Cliente("Sully","Jacquet","68","sjacquet9b@cafepress.com","37.741.441","82-8368-1571"));
			listaClientes.Add(new Cliente("Carina","Birtchnell","28","cbirtchnell9c@utexas.edu","47.725.039","97-6374-2073"));
			listaClientes.Add(new Cliente("Galven","Prugel","64","gprugel9d@ucoz.ru","52.409.356","88-1334-1475"));
			listaClientes.Add(new Cliente("Hermine","Pietranek","99","hpietranek9e@hostgator.com","56.660.796","56-5471-8818"));
			listaClientes.Add(new Cliente("Tabbie","Mulchrone","41","tmulchrone9f@netvibes.com","20.121.234","25-1936-0687"));
			listaClientes.Add(new Cliente("Letisha","Mackinder","88","lmackinder9g@geocities.jp","33.742.700","13-5846-1846"));
			listaClientes.Add(new Cliente("Simonette","Rodrig","88","srodrig9h@independent.co.uk","19.594.373","82-3815-9315"));
			listaClientes.Add(new Cliente("Harriette","Kemmett","68","hkemmett9i@ed.gov","75.671.613","11-3587-2090"));
			listaClientes.Add(new Cliente("Dick","Scarse","54","dscarse9j@senate.gov","46.822.833","23-1398-3025"));
			listaClientes.Add(new Cliente("Beale","Spary","44","bspary9k@ifeng.com","73.131.686","96-3318-3696"));
			listaClientes.Add(new Cliente("Franni","Pickance","52","fpickance9l@telegraph.co.uk","42.001.641","74-4797-4098"));
			listaClientes.Add(new Cliente("Sammy","Frodsam","40","sfrodsam9m@un.org","04.666.240","64-0202-3985"));
			listaClientes.Add(new Cliente("Davin","Jannasch","23","djannasch9n@jimdo.com","74.788.247","70-4194-0361"));
			listaClientes.Add(new Cliente("Sebastien","Beddall","52","sbeddall9o@businesswire.com","38.051.201","35-2371-6524"));
			listaClientes.Add(new Cliente("Marcelia","Horry","19","mhorry9p@wired.com","75.618.921","96-0991-9541"));
			listaClientes.Add(new Cliente("Selena","Gniewosz","59","sgniewosz9q@ftc.gov","61.584.204","53-9160-5310"));
			listaClientes.Add(new Cliente("Jenni","Lucas","43","jlucas9r@mozilla.com","80.718.608","24-8369-1926"));
			listaClientes.Add(new Cliente("Daloris","Jerdan","21","djerdan9s@macromedia.com","66.738.946","73-5082-0423"));
			listaClientes.Add(new Cliente("Gamaliel","Agnew","71","gagnew9t@so-net.ne.jp","80.071.442","69-3586-7272"));
			listaClientes.Add(new Cliente("Jane","Studdard","58","jstuddard9u@wsj.com","14.908.217","86-4548-9314"));
			listaClientes.Add(new Cliente("Gage","Jerschke","51","gjerschke9v@patch.com","34.595.425","10-2863-7319"));
			listaClientes.Add(new Cliente("Kennedy","Powys","82","kpowys9w@unc.edu","91.365.195","06-2754-5313"));
			listaClientes.Add(new Cliente("Adolpho","Ongin","87","aongin9x@github.com","64.049.290","87-6434-9947"));
			listaClientes.Add(new Cliente("Teri","Marcam","21","tmarcam9y@geocities.jp","25.041.506","19-7021-1999"));
			listaClientes.Add(new Cliente("Klarika","Surmon","74","ksurmon9z@github.com","31.933.769","98-2147-7148"));
			listaClientes.Add(new Cliente("Jarred","Boor","73","jboora0@blogtalkradio.com","71.248.778","63-3061-6748"));
			listaClientes.Add(new Cliente("Jocelyn","Huban","18","jhubana1@rakuten.co.jp","73.393.446","82-9018-9819"));
			listaClientes.Add(new Cliente("Dahlia","Kepling","90","dkeplinga2@amazon.co.uk","75.955.471","92-0749-6095"));
			listaClientes.Add(new Cliente("Bessy","Macquire","33","bmacquirea3@diigo.com","99.146.395","69-7149-5335"));
			listaClientes.Add(new Cliente("Matthiew","McGeouch","42","mmcgeoucha4@desdev.cn","69.339.188","59-2731-9494"));
			listaClientes.Add(new Cliente("Garreth","Fost","25","gfosta5@trellian.com","99.950.757","32-8724-5875"));
			listaClientes.Add(new Cliente("Bobbie","Roston","24","brostona6@photobucket.com","68.471.318","91-2759-4190"));
			listaClientes.Add(new Cliente("Bobbe","Coucher","95","bcouchera7@ucoz.com","27.523.093","18-5827-8494"));
			listaClientes.Add(new Cliente("Cleveland","Riha","75","crihaa8@yelp.com","97.035.342","44-5339-9306"));
			listaClientes.Add(new Cliente("Kamila","Lude","52","kludea9@epa.gov","44.884.556","06-2811-2021"));
			listaClientes.Add(new Cliente("Wilmer","Profit","45","wprofitaa@uiuc.edu","39.977.786","23-7051-1975"));
			listaClientes.Add(new Cliente("Esmeralda","Jerrand","37","ejerrandab@infoseek.co.jp","51.040.995","35-7172-1320"));
			listaClientes.Add(new Cliente("Brett","MacKeeg","57","bmackeegac@abc.net.au","52.410.769","08-9183-5228"));
			listaClientes.Add(new Cliente("Nevil","Denziloe","83","ndenziloead@delicious.com","45.884.697","44-4155-5939"));
			listaClientes.Add(new Cliente("Nilson","Huncoot","54","nhuncootae@wikia.com","30.675.744","44-2417-4714"));
			listaClientes.Add(new Cliente("Zedekiah","Geekin","52","zgeekinaf@sogou.com","21.937.615","73-8489-6341"));
			listaClientes.Add(new Cliente("Lenore","Rulf","57","lrulfag@istockphoto.com","43.550.280","88-2217-6534"));
			listaClientes.Add(new Cliente("Silvan","Freckleton","98","sfreckletonah@tinypic.com","39.539.238","25-4781-1299"));
			listaClientes.Add(new Cliente("Astra","Swetenham","26","aswetenhamai@ucoz.com","10.181.067","49-0841-2802"));
			listaClientes.Add(new Cliente("Maitilde","Dignan","84","mdignanaj@wix.com","74.847.474","01-5038-7837"));
			listaClientes.Add(new Cliente("Monah","Rattenberie","55","mrattenberieak@webeden.co.uk","31.984.779","02-1952-3543"));
			listaClientes.Add(new Cliente("Nil","Forte","40","nforteal@ocn.ne.jp","35.053.454","25-1002-9819"));
			listaClientes.Add(new Cliente("Guillermo","Larderot","40","glarderotam@phoca.cz","71.132.583","31-3442-3796"));
			listaClientes.Add(new Cliente("Eden","Lodwick","62","elodwickan@symantec.com","58.507.171","88-9293-0183"));
			listaClientes.Add(new Cliente("Verene","Sanpere","29","vsanpereao@miitbeian.gov.cn","91.359.433","82-2120-8260"));
			listaClientes.Add(new Cliente("Hillard","Nurcombe","55","hnurcombeap@pinterest.com","26.563.966","94-9878-2123"));
			listaClientes.Add(new Cliente("Kattie","Drinan","53","kdrinanaq@miitbeian.gov.cn","50.632.818","32-1950-8730"));
			listaClientes.Add(new Cliente("Artur","Donalson","69","adonalsonar@globo.com","17.887.805","25-6475-1717"));
			listaClientes.Add(new Cliente("Elizabet","Bentham3","45","ebenthamas@msn.com","94.644.576","79-9053-9405"));
			listaClientes.Add(new Cliente("Norri","Hum","52","nhumat@a8.net","66.817.056","53-3531-7971"));
			listaClientes.Add(new Cliente("Linc","Horley","28","lhorleyau@yahoo.com","08.061.512","45-9672-1738"));
			listaClientes.Add(new Cliente("Claribel","Vakhlov","60","cvakhlovav@loc.gov","02.045.816","60-6357-2966"));
			listaClientes.Add(new Cliente("Dela","McFadzean","17","dmcfadzeanaw@tamu.edu","60.496.402","66-1764-8436"));
			listaClientes.Add(new Cliente("Mariya","Dudden","37","mduddenax@google.ca","87.152.016","03-4455-4108"));
			listaClientes.Add(new Cliente("Pavlov","Deegin","43","pdeeginay@live.com","83.991.381","62-5882-6581"));
			listaClientes.Add(new Cliente("Clemmie","Sexon","85","csexonaz@wikia.com","72.544.125","91-5651-6130"));
			listaClientes.Add(new Cliente("Chad","Almey","33","calmeyb0@oaic.gov.au","77.396.807","80-8825-7237"));
			listaClientes.Add(new Cliente("Lyle","Berndtsson","53","lberndtssonb1@stumbleupon.com","65.771.840","13-6845-5304"));
			listaClientes.Add(new Cliente("Hamish","Sansum","41","hsansumb2@businessinsider.com","07.121.832","28-2913-0615"));
			listaClientes.Add(new Cliente("Selie","Constantine","73","sconstantineb3@narod.ru","38.872.697","12-6259-0300"));
			listaClientes.Add(new Cliente("Marylynne","Klosges","60","mklosgesb4@tinypic.com","91.286.127","88-5682-7342"));
			listaClientes.Add(new Cliente("Allayne","Chark","69","acharkb5@ask.com","02.107.262","30-3754-7788"));
			listaClientes.Add(new Cliente("Kalila","Moger","54","kmogerb6@cmu.edu","25.673.354","27-8130-8818"));
			listaClientes.Add(new Cliente("Mathian","McGourty","52","mmcgourtyb7@altervista.org","54.660.386","48-8004-5153"));
			listaClientes.Add(new Cliente("Noelani","Laffan","33","nlaffanb8@fotki.com","09.768.675","19-4414-3005"));
			listaClientes.Add(new Cliente("Lib","Salazar","48","lsalazarb9@dyndns.org","27.104.071","54-6990-5401"));
			listaClientes.Add(new Cliente("Cristen","Harness","54","charnessba@oracle.com","17.016.836","86-3733-8030"));
			listaClientes.Add(new Cliente("Anestassia","Stansby","77","astansbybb@technorati.com","06.944.140","31-9615-3697"));
			listaClientes.Add(new Cliente("Rutter","Turbard","94","rturbardbc@google.com.br","99.386.698","49-7835-4227"));
			listaClientes.Add(new Cliente("Juliane","Cancott","50","jcancottbd@infoseek.co.jp","71.410.348","07-7468-3601"));
			listaClientes.Add(new Cliente("Theobald","Pasterfield","26","tpasterfieldbe@t-online.de","94.820.314","29-9316-9831"));
			listaClientes.Add(new Cliente("Blakeley","Moriarty","98","bmoriartybf@tumblr.com","63.159.690","17-4488-7937"));
			listaClientes.Add(new Cliente("Lenci","Fryman","41","lfrymanbg@liveinternet.ru","80.031.617","25-2623-7864"));
			listaClientes.Add(new Cliente("Mab","Shailer","19","mshailerbh@unblog.fr","21.864.450","47-4954-7535"));
			listaClientes.Add(new Cliente("Dorian","Ruddick","67","druddickbi@guardian.co.uk","86.015.065","02-5726-8746"));
			listaClientes.Add(new Cliente("Basilio","Eagleton","49","beagletonbj@wikia.com","08.278.123","45-2006-5022"));
			listaClientes.Add(new Cliente("Jethro","Graalmans","67","jgraalmansbk@lycos.com","15.472.885","69-9331-2412"));
			listaClientes.Add(new Cliente("Regen","Ubsdale","41","rubsdalebl@about.me","29.108.563","72-0755-4877"));
			listaClientes.Add(new Cliente("Alla","Slavin","62","aslavinbm@netlog.com","70.587.473","01-0051-6370"));
			listaClientes.Add(new Cliente("Tess","Rumin","34","truminbn@hostgator.com","65.139.216","16-3751-2535"));
			listaClientes.Add(new Cliente("Tomasina","Ruggero","27","tdiruggerobo@free.fr","54.356.395","74-3754-5396"));
			listaClientes.Add(new Cliente("Morna","Honisch","23","mhonischbp@ezinearticles.com","63.492.708","61-6690-1563"));
			listaClientes.Add(new Cliente("Alec","Grossier","62","agrossierbq@sbwire.com","19.369.952","30-4257-2813"));
			listaClientes.Add(new Cliente("Concordia","Palffrey","25","cpalffreybr@blog.com","67.789.793","24-1976-4902"));
			listaClientes.Add(new Cliente("Ashil","Eydel","33","aeydelbs@imgur.com","70.345.093","93-1163-4057"));
			listaClientes.Add(new Cliente("Donny","Middlehurst","43","dmiddlehurstbt@merriam-webster.com","95.140.835","29-0423-8035"));
			listaClientes.Add(new Cliente("Kiley","Grigolli","53","kgrigollibu@cbc.ca","36.723.212","03-2172-3377"));
			listaClientes.Add(new Cliente("Wilhelm","Davenport","23","wdavenportbv@wired.com","10.537.600","51-6052-0903"));
			listaClientes.Add(new Cliente("Jocko","Loveguard","28","jloveguardbw@businessweek.com","94.411.431","78-6728-4979"));
			listaClientes.Add(new Cliente("Darrick","Baldacco","39","dbaldaccobx@eepurl.com","01.036.487","76-7014-2197"));
			listaClientes.Add(new Cliente("Bennett","Laybourn","60","blaybournby@usa.gov","63.353.954","52-4756-0899"));
			listaClientes.Add(new Cliente("Gerianne","Matiebe","91","gmatiebebz@phoca.cz","06.944.799","16-2577-7027"));
			listaClientes.Add(new Cliente("Cordie","Frankland","62","cfranklandc0@indiegogo.com","48.044.906","75-8179-3287"));
			listaClientes.Add(new Cliente("Stefan","Michetti","45","sdemichettic1@admin.ch","28.534.446","41-2571-2959"));
			listaClientes.Add(new Cliente("Andy","Robertazzi","93","arobertazzic2@stumbleupon.com","74.358.321","07-2371-9684"));
			listaClientes.Add(new Cliente("Kristoffer","Sidey","57","ksideyc3@mail.ru","21.098.434","12-0181-8107"));
			listaClientes.Add(new Cliente("Hakeem","Matschek","61","hmatschekc4@mozilla.org","02.514.740","02-1780-6648"));
			listaClientes.Add(new Cliente("Pierette","Seiler","18","pseilerc5@pcworld.com","20.221.394","77-4759-0206"));
			listaClientes.Add(new Cliente("Melinda","Aizic","90","maizicc6@blogtalkradio.com","87.814.663","32-4641-3623"));
			listaClientes.Add(new Cliente("Cherlyn","Jiranek","57","cjiranekc7@t.co","64.739.881","42-1128-2733"));
			listaClientes.Add(new Cliente("Jarvis","Dinan","83","jdinanc8@prlog.org","85.814.488","43-1077-0470"));
			listaClientes.Add(new Cliente("Sibbie","Pendle","65","spendlec9@economist.com","28.057.199","30-3189-6184"));
			listaClientes.Add(new Cliente("Moreen","Kingswood","22","mkingswoodca@pcworld.com","89.829.231","35-3296-4617"));
			listaClientes.Add(new Cliente("Geralda","Marl","52","gmarlcb@umn.edu","60.737.373","32-6159-9804"));
			listaClientes.Add(new Cliente("Inna","Akrigg","96","iakriggcc@is.gd","25.047.420","47-3336-6608"));
			listaClientes.Add(new Cliente("Charline","Boshier","55","cboshiercd@stanford.edu","97.737.880","61-0190-9975"));
			listaClientes.Add(new Cliente("Edita","Sawkin","74","esawkince@hhs.gov","82.402.336","56-6696-0613"));
			listaClientes.Add(new Cliente("Rickie","Benedictis","32","rdebenedictiscf@istockphoto.com","14.200.303","01-0331-7842"));
			listaClientes.Add(new Cliente("Wendall","Chellam","99","wchellamcg@odnoklassniki.ru","66.196.228","84-6887-1484"));
			listaClientes.Add(new Cliente("David","Goad","24","dgoadch@prlog.org","07.147.441","77-0857-9039"));
			listaClientes.Add(new Cliente("Marilin","Matzaitis","71","mmatzaitisci@themeforest.net","16.826.704","92-2936-8435"));
			listaClientes.Add(new Cliente("Barbie","Gronw","38","bgronwcj@irs.gov","79.673.106","70-1459-6974"));
			listaClientes.Add(new Cliente("Dunc","Coulbeck","26","dcoulbeckck@loc.gov","95.776.593","53-5579-9378"));
			listaClientes.Add(new Cliente("Agretha","Lurcock","17","alurcockcl@whitehouse.gov","19.621.642","49-7173-1760"));
			listaClientes.Add(new Cliente("Algernon","Meale","19","amealecm@trellian.com","32.135.169","55-0668-7334"));
			listaClientes.Add(new Cliente("Edi","Matiebe","44","ematiebecn@phoca.cz","41.370.940","28-9938-8949"));
			listaClientes.Add(new Cliente("Marne","Capps","35","mcappsco@answers.com","33.819.860","29-0078-6602"));
			listaClientes.Add(new Cliente("Melody","Grevel","57","mgrevelcp@samsung.com","35.021.526","09-8131-7184"));
			listaClientes.Add(new Cliente("Kendricks","Gippes","79","kgippescq@slashdot.org","31.876.368","40-8868-7673"));
			listaClientes.Add(new Cliente("Pail","Trimming","59","ptrimmingcr@wikia.com","91.945.047","27-0899-8834"));
			listaClientes.Add(new Cliente("Yetty","Barkworth","89","ybarkworthcs@smh.com.au","48.211.405","43-8145-2889"));
			listaClientes.Add(new Cliente("Hieronymus","Stanway","94","hstanwayct@wikipedia.org","77.131.254","26-7440-4464"));
			listaClientes.Add(new Cliente("Consuela","Peaker","38","cpeakercu@fema.gov","38.793.084","34-6038-3581"));
			listaClientes.Add(new Cliente("Toby","Roby","85","trobycv@hostgator.com","06.263.821","08-5591-6005"));
			listaClientes.Add(new Cliente("Cody","Glasscoo","51","cglasscoocw@edublogs.org","46.056.905","38-2451-0408"));
			listaClientes.Add(new Cliente("Jackson","Freiberg","63","jfreibergcx@ucoz.ru","45.666.943","73-3326-6681"));
			listaClientes.Add(new Cliente("Dorie","Ralfe","84","dralfecy@salon.com","17.651.582","82-3421-7505"));
			listaClientes.Add(new Cliente("Fabe","Gibbard","65","fgibbardcz@nps.gov","69.038.198","07-8347-9793"));
			listaClientes.Add(new Cliente("Adham","Crayden","64","acraydend0@instagram.com","58.430.076","44-4872-8349"));
			listaClientes.Add(new Cliente("Abelard","Teaze","28","ateazed1@ucla.edu","86.121.467","76-9520-1647"));
			listaClientes.Add(new Cliente("Tracy","Shelford","38","tshelfordd2@amazon.co.jp","76.126.158","84-1443-2623"));
			listaClientes.Add(new Cliente("Modestine","Ruperto","58","mrupertod3@uiuc.edu","81.532.613","36-4789-7470"));
			listaClientes.Add(new Cliente("Katya","Hatz","90","khatzd4@nih.gov","47.366.774","61-4474-9016"));
			listaClientes.Add(new Cliente("Pedro","Janauschek","77","pjanauschekd5@hao123.com","15.105.877","02-6499-2307"));
			listaClientes.Add(new Cliente("Nefen","Brands","37","nbrandsd6@loc.gov","27.546.920","35-7945-9585"));
			listaClientes.Add(new Cliente("Allyn","Kiddell","46","akiddelld7@meetup.com","79.822.513","67-0517-5293"));
			listaClientes.Add(new Cliente("Massimiliano","Bladge","67","mbladged8@craigslist.org","11.065.604","91-0026-7724"));
			listaClientes.Add(new Cliente("Lefty","Bresland","70","lbreslandd9@aol.com","15.255.306","67-3211-3643"));
			listaClientes.Add(new Cliente("Abagael","Tiler","81","atilerda@mapy.cz","91.941.091","77-6695-2919"));
			listaClientes.Add(new Cliente("Alexandrina","Harrower","52","aharrowerdb@toplist.cz","68.991.718","30-0636-1965"));
			listaClientes.Add(new Cliente("Beauregard","Sharple","18","bsharpledc@army.mil","35.112.421","80-7085-5974"));
			listaClientes.Add(new Cliente("Meade","Pasterfield","43","mpasterfielddd@plala.or.jp","22.909.089","35-9453-6683"));
			listaClientes.Add(new Cliente("Lizette","Catto","94","lcattode@hibu.com","45.430.086","44-9319-7619"));
			listaClientes.Add(new Cliente("Roi","Riedel","19","rriedeldf@bandcamp.com","92.245.207","01-7043-8124"));
			listaClientes.Add(new Cliente("Tiphanie","Blackader","37","tblackaderdg@google.pl","48.898.788","46-1347-8599"));
			listaClientes.Add(new Cliente("Shayna","Oury","46","sourydh@multiply.com","68.866.445","79-7058-6831"));
			listaClientes.Add(new Cliente("Korrie","Grund","24","kgrunddi@joomla.org","72.732.940","67-3470-1195"));
			listaClientes.Add(new Cliente("Gayla","Scade","44","gscadedj@last.fm","85.908.792","34-3086-3208"));
			listaClientes.Add(new Cliente("Belvia","Setter","54","bsetterdk@salon.com","44.435.105","10-0796-4189"));
			listaClientes.Add(new Cliente("Morey","Kernoghan","22","mkernoghandl@si.edu","62.961.650","89-8995-7519"));
			listaClientes.Add(new Cliente("Alisun","Geeraert","67","ageeraertdm@scientificamerican.com","34.700.360","31-1662-4909"));
			listaClientes.Add(new Cliente("Pippa","Giottini","84","pgiottinidn@php.net","19.020.840","74-7344-8528"));
			listaClientes.Add(new Cliente("Peggie","Closs","79","pclossdo@bloglovin.com","06.269.891","65-3883-7692"));
			listaClientes.Add(new Cliente("Erick","Suermeier","17","esuermeierdp@taobao.com","38.856.004","36-8894-9243"));
			listaClientes.Add(new Cliente("Alysia","Gamble","91","agambledq@shutterfly.com","51.093.923","36-5761-5654"));
			listaClientes.Add(new Cliente("Bobbee","Berndtssen","49","bberndtssendr@wiley.com","27.934.747","73-0399-7058"));
			listaClientes.Add(new Cliente("Wheeler","Detheridge","91","wdetheridgeds@clickbank.net","79.870.906","63-7236-8902"));
			listaClientes.Add(new Cliente("Jakob","Ianittello","19","jianittellodt@nih.gov","92.206.084","44-6497-3592"));
			listaClientes.Add(new Cliente("Charita","Feeham","81","cfeehamdu@forbes.com","75.664.757","02-1072-6613"));
			listaClientes.Add(new Cliente("Bryanty","Dodson","74","bdodsondv@cam.ac.uk","14.892.540","69-9447-7546"));
			listaClientes.Add(new Cliente("Olva","Wight","21","owightdw@dagondesign.com","59.152.410","83-2719-2009"));
			listaClientes.Add(new Cliente("Kellina","Selman","38","kselmandx@alexa.com","32.468.601","75-1551-7224"));
			listaClientes.Add(new Cliente("Frederic","Sprigg","65","fspriggdy@mail.ru","06.869.805","53-1437-8036"));
			listaClientes.Add(new Cliente("Demetre","Dorre","47","ddorredz@imageshack.us","38.115.900","55-8488-4003"));
			listaClientes.Add(new Cliente("Cody","Rowthorne","42","crowthornee0@g.co","67.294.006","12-2647-8500"));
			listaClientes.Add(new Cliente("Alikee","Oene","30","aoenee1@macromedia.com","13.472.161","77-2164-0174"));
			listaClientes.Add(new Cliente("Ann-marie","Creese","30","acreesee2@addthis.com","74.999.050","07-7729-4700"));
			listaClientes.Add(new Cliente("Shoshana","Gelardi","78","sgelardie3@addthis.com","16.768.687","31-2677-4738"));
			listaClientes.Add(new Cliente("Verna","Jeduch","24","vjeduche4@shinystat.com","18.689.310","26-5719-7803"));
			listaClientes.Add(new Cliente("Eward","Martinolli","77","emartinollie5@quantcast.com","52.634.116","15-1932-7529"));
			listaClientes.Add(new Cliente("Elroy","Pawlaczyk","59","epawlaczyke6@vistaprint.com","96.016.037","38-2961-1286"));
			listaClientes.Add(new Cliente("Heath","Regardsoe","19","hregardsoee7@shutterfly.com","11.536.044","86-1901-1515"));
			listaClientes.Add(new Cliente("Wat","Cullip","69","wdecullipe8@1und1.de","81.085.506","59-4933-4592"));
			listaClientes.Add(new Cliente("Dallis","Wicklen","76","dwicklene9@cpanel.net","26.836.183","62-3191-5928"));
			listaClientes.Add(new Cliente("Trstram","Vawton","51","tvawtonea@google.com.au","85.328.591","79-6466-5661"));
			listaClientes.Add(new Cliente("Dione","Scorton","76","dscortoneb@amazon.de","74.198.322","50-0110-0726"));
			listaClientes.Add(new Cliente("Carlye","Mar","23","cmarec@icio.us","59.179.490","16-5940-1055"));
			listaClientes.Add(new Cliente("Juieta","Benka","42","jbenkaed@angelfire.com","97.649.477","13-1624-6243"));
			listaClientes.Add(new Cliente("Ethelind","Gemlbett","33","egemlbettee@discovery.com","82.518.864","41-4855-3431"));
			listaClientes.Add(new Cliente("Dyann","Ridd","47","driddef@spotify.com","72.093.385","50-3921-2953"));
			listaClientes.Add(new Cliente("Carmine","Beany","19","cbeanyeg@csmonitor.com","72.619.571","77-4510-7918"));
			listaClientes.Add(new Cliente("Eleen","Paddison","87","epaddisoneh@yellowbook.com","25.220.898","08-8723-9752"));
			listaClientes.Add(new Cliente("Layney","Beaument","80","lbeaumentei@auda.org.au","67.895.520","81-2097-5100"));
			listaClientes.Add(new Cliente("Madge","Dunlap","96","mdunlapej@weebly.com","86.645.406","95-0949-8555"));
			listaClientes.Add(new Cliente("Miguel","Harcase","83","mharcaseek@dagondesign.com","22.896.910","22-4824-8244"));
			listaClientes.Add(new Cliente("Abbie","Botright","51","abotrightel@constantcontact.com","92.769.857","06-3911-3396"));
			listaClientes.Add(new Cliente("Valli","Gorling","87","vgorlingem@ucoz.ru","43.404.165","50-4763-3917"));
			listaClientes.Add(new Cliente("Jacky","Kalinsky","97","jkalinskyen@dailymail.co.uk","80.297.355","63-6115-5015"));
			listaClientes.Add(new Cliente("Jabez","Muat","45","jmuateo@ehow.com","83.067.867","42-4056-7919"));
			listaClientes.Add(new Cliente("Andreana","Lowseley","88","alowseleyep@cbsnews.com","14.756.565","86-4289-8051"));
			listaClientes.Add(new Cliente("Oralia","Packer","37","opackereq@sciencedirect.com","89.689.007","29-1012-4315"));
			listaClientes.Add(new Cliente("Elana","Mitkcov","49","emitkcover@geocities.jp","02.952.048","05-4275-8152"));
			listaClientes.Add(new Cliente("Beck","Sineath","96","bsineathes@bloglines.com","12.894.699","85-5875-1704"));
			listaClientes.Add(new Cliente("Lyndsey","Derill","60","lderillet@wordpress.org","63.024.542","27-0575-7665"));
			listaClientes.Add(new Cliente("Aubry","Sherbrook","75","asherbrookeu@linkedin.com","26.161.131","16-4137-1996"));
			listaClientes.Add(new Cliente("Fabien","Perllman","96","fperllmanev@oracle.com","91.823.608","31-9597-4895"));
			listaClientes.Add(new Cliente("Kris","O'Shea","82","kosheaew@dedecms.com","58.162.068","51-8851-6163"));
			listaClientes.Add(new Cliente("Byrom","Dutton","28","bduttonex@ucsd.edu","61.282.354","07-4425-1038"));
			listaClientes.Add(new Cliente("Fernanda","Helstrom","45","fhelstromey@bbc.co.uk","12.554.647","64-5626-7854"));
			listaClientes.Add(new Cliente("Elihu","Atyea","75","eatyeaez@themeforest.net","77.587.458","07-9098-5266"));
			listaClientes.Add(new Cliente("Fritz","Iacovo","46","fiacovof0@jigsy.com","44.260.934","62-9390-0182"));
			listaClientes.Add(new Cliente("Zerk","Zebedee","67","zzebedeef1@guardian.co.uk","69.283.460","70-8777-0924"));
			listaClientes.Add(new Cliente("Edlin","Plewes","74","eplewesf2@bing.com","48.001.936","20-6905-7821"));
			listaClientes.Add(new Cliente("Annadiane","Barwell","25","abarwellf3@state.gov","23.269.045","97-0990-6532"));
			listaClientes.Add(new Cliente("Peggy","McCudden","63","pmccuddenf4@globo.com","93.426.507","53-5814-3034"));
			listaClientes.Add(new Cliente("Amelina","Guidelli","95","aguidellif5@photobucket.com","41.889.835","63-5221-4085"));
			listaClientes.Add(new Cliente("Ingram","Wearn","44","iwearnf6@vk.com","06.220.400","74-5794-4181"));
			listaClientes.Add(new Cliente("Dorry","Wynrehame","44","dwynrehamef7@tripod.com","72.177.740","32-5585-1106"));
			listaClientes.Add(new Cliente("Rowen","Woolf","29","rwoolff8@symantec.com","12.329.445","35-2086-1103"));
			listaClientes.Add(new Cliente("Hilde","Cammock","84","hcammockf9@princeton.edu","49.174.015","79-9997-7719"));
			listaClientes.Add(new Cliente("Oliviero","Carnalan","38","ocarnalanfa@virginia.edu","87.622.229","75-7312-0703"));
			listaClientes.Add(new Cliente("Elmo","Bram","62","ebramfb@topsy.com","63.696.523","21-2146-5767"));
			listaClientes.Add(new Cliente("Ingelbert","Ricson","17","iricsonfc@marriott.com","14.495.690","58-3317-6204"));
			listaClientes.Add(new Cliente("Dag","Camamill","18","dcamamillfd@sina.com.cn","96.010.313","83-2952-0060"));
			listaClientes.Add(new Cliente("Gabrielle","Rubertelli","22","grubertellife@icq.com","87.853.796","81-7633-2152"));
			listaClientes.Add(new Cliente("Agneta","Prettyjohn","84","aprettyjohnff@trellian.com","39.693.777","55-8657-0578"));
			listaClientes.Add(new Cliente("Brietta","Dibbe","26","bdibbefg@gmpg.org","52.177.445","84-9439-1669"));
			listaClientes.Add(new Cliente("Lurlene","Paszek","95","lpaszekfh@timesonline.co.uk","88.227.207","34-4220-2480"));
			listaClientes.Add(new Cliente("Lucias","Myrie","79","lmyriefi@gmpg.org","64.424.130","88-2483-4400"));
			listaClientes.Add(new Cliente("Meredithe","Brodest","59","mbrodestfj@weibo.com","03.029.775","21-7203-8764"));
			listaClientes.Add(new Cliente("Roze","Motherwell","31","rmotherwellfk@gnu.org","44.172.392","01-8356-4035"));
			listaClientes.Add(new Cliente("Cary","Fivey","64","cfiveyfl@gnu.org","71.483.888","59-8953-2770"));
			listaClientes.Add(new Cliente("Lilian","Libreros","77","llibrerosfm@people.com.cn","57.572.311","02-0496-4095"));
			listaClientes.Add(new Cliente("Michaelina","Ianizzi","19","mianizzifn@engadget.com","39.250.512","79-2497-7607"));
			listaClientes.Add(new Cliente("Inglis","Huegett","96","ihuegettfo@etsy.com","32.898.484","18-3850-3629"));
			listaClientes.Add(new Cliente("Willie","Gouldstone","88","wgouldstonefp@miibeian.gov.cn","85.491.702","16-3142-2984"));
			listaClientes.Add(new Cliente("Ludwig","Gerhold","49","lgerholdfq@europa.eu","73.732.223","15-0475-5448"));
			listaClientes.Add(new Cliente("Jolie","McCafferty","53","jmccaffertyfr@privacy.gov.au","27.862.594","00-5983-6334"));
			listaClientes.Add(new Cliente("Devina","Wick","57","dwickfs@indiegogo.com","28.032.470","66-9374-3853"));
			listaClientes.Add(new Cliente("Donnell","Dunkersley","19","ddunkersleyft@slate.com","12.622.194","50-5165-6621"));
			listaClientes.Add(new Cliente("Cosette","Churcher","49","cchurcherfu@businessweek.com","09.546.441","42-8555-4519"));
			listaClientes.Add(new Cliente("Ermentrude","Wrigglesworth","99","ewrigglesworthfv@huffingtonpost.com","94.692.064","74-7560-0742"));
			listaClientes.Add(new Cliente("Shaun","Dinning","59","sdinningfw@rediff.com","74.812.391","16-3817-3330"));
			listaClientes.Add(new Cliente("Sofie","Spuffard","79","sspuffardfx@about.me","46.773.372","26-0772-9212"));
			listaClientes.Add(new Cliente("Brig","MacVagh","77","bmacvaghfy@ow.ly","43.083.704","29-0516-4272"));
			listaClientes.Add(new Cliente("Tull","Mussett","55","tmussettfz@is.gd","42.970.654","45-6871-3153"));
			listaClientes.Add(new Cliente("Vally","Burkill","59","vburkillg0@mtv.com","84.971.834","33-7402-7059"));
			listaClientes.Add(new Cliente("Arlette","Adin","96","aading1@deviantart.com","17.028.220","49-7481-8059"));
			listaClientes.Add(new Cliente("Loydie","Waldron","32","lwaldrong2@domainmarket.com","72.854.520","40-8346-7295"));
			listaClientes.Add(new Cliente("Pammie","List","43","plistg3@icq.com","19.729.118","41-2287-8463"));
			listaClientes.Add(new Cliente("Cheston","Harbert","36","charbertg4@patch.com","26.420.876","68-2418-3083"));
			listaClientes.Add(new Cliente("Jacklin","Blouet","87","jblouetg5@washington.edu","25.389.161","77-0081-3374"));
			listaClientes.Add(new Cliente("Arch","Stack","39","astackg6@ask.com","25.995.759","59-1577-9952"));
			listaClientes.Add(new Cliente("Gunilla","Cardero","54","gcarderog7@theglobeandmail.com","25.065.892","43-2874-2479"));
			listaClientes.Add(new Cliente("Zaria","Chilley","42","zchilleyg8@bloglines.com","81.134.584","82-0805-0365"));
			listaClientes.Add(new Cliente("Camel","Weatherdon","91","cweatherdong9@example.com","54.300.107","23-8317-6518"));
			listaClientes.Add(new Cliente("Malena","Ganforth","23","mganforthga@skyrock.com","37.056.279","40-8176-6656"));
			listaClientes.Add(new Cliente("Trudie","Wardley","19","twardleygb@freewebs.com","27.148.552","65-8214-0927"));
			listaClientes.Add(new Cliente("Quinlan","Texton","76","qtextongc@cdc.gov","12.118.696","17-0132-6154"));
			listaClientes.Add(new Cliente("Tabbie","Smidmore","91","tsmidmoregd@bbc.co.uk","20.010.501","77-3148-8311"));
			listaClientes.Add(new Cliente("Lindsey","Kobel","45","lkobelge@shutterfly.com","69.645.557","55-5667-4532"));
			listaClientes.Add(new Cliente("Bidget","Dugmore","29","bdugmoregf@bigcartel.com","85.504.072","33-9034-7203"));
			listaClientes.Add(new Cliente("Peggi","Tabb","44","ptabbgg@oaic.gov.au","33.490.287","12-7713-3789"));
			listaClientes.Add(new Cliente("Gwyn","Fasey","95","gfaseygh@t.co","48.986.409","54-5773-4714"));
			listaClientes.Add(new Cliente("Wye","Pietrzak","38","wpietrzakgi@altervista.org","74.871.254","44-8309-2240"));
			listaClientes.Add(new Cliente("Julienne","Camier","25","jcamiergj@woothemes.com","82.818.120","84-7285-7321"));
			listaClientes.Add(new Cliente("Krystle","Fragino","51","kfraginogk@economist.com","20.319.586","16-7140-4454"));
			listaClientes.Add(new Cliente("Derby","Greetland","52","dgreetlandgl@nydailynews.com","95.531.081","03-3748-8646"));
			listaClientes.Add(new Cliente("Chandler","Burgot","69","cburgotgm@pen.io","65.807.330","13-1024-3498"));
			listaClientes.Add(new Cliente("Yoshi","Sawford","19","ysawfordgn@paypal.com","34.590.437","76-0178-9956"));
			listaClientes.Add(new Cliente("Torry","Godlip","81","tgodlipgo@engadget.com","61.665.759","54-0257-2619"));
			listaClientes.Add(new Cliente("Cristin","Tansley","50","ctansleygp@cbslocal.com","79.748.375","38-4563-7715"));
			listaClientes.Add(new Cliente("Nickie","Wisden","25","nwisdengq@wired.com","72.524.968","68-2444-6510"));
			listaClientes.Add(new Cliente("Alta","Dallicott","59","adallicottgr@twitpic.com","91.323.312","70-9649-7779"));
			listaClientes.Add(new Cliente("Mariette","Fassmann","67","mfassmanngs@devhub.com","40.212.348","18-8619-7799"));
			listaClientes.Add(new Cliente("Gonzalo","Dax","38","gdaxgt@mayoclinic.com","04.796.128","52-8917-4359"));
			listaClientes.Add(new Cliente("Nomi","Spragge","96","nspraggegu@wisc.edu","10.268.274","37-4023-0478"));
			listaClientes.Add(new Cliente("Rossie","Hallewell","75","rhallewellgv@princeton.edu","54.102.375","06-3360-0537"));
			listaClientes.Add(new Cliente("Jedd","Sherry","31","jsherrygw@photobucket.com","38.281.960","68-9653-8063"));
			listaClientes.Add(new Cliente("Raquela","Labbett","40","rlabbettgx@booking.com","38.275.677","98-1850-3605"));
			listaClientes.Add(new Cliente("Adrian","Hackforth","82","ahackforthgy@adobe.com","85.468.088","97-9505-5860"));
			listaClientes.Add(new Cliente("Gretel","Tieman","59","gtiemangz@e-recht24.de","20.677.055","85-2724-8699"));
			listaClientes.Add(new Cliente("Sebastiano","Lea","36","sleah0@comsenz.com","26.986.087","22-6364-1266"));
			listaClientes.Add(new Cliente("Florida","Gouley","83","fgouleyh1@geocities.com","58.257.533","15-5184-1337"));
			listaClientes.Add(new Cliente("Lorain","Pettingall","96","lpettingallh2@washington.edu","46.069.880","27-4901-0586"));
			listaClientes.Add(new Cliente("Far","Wardell","38","fwardellh3@tamu.edu","66.477.997","08-2502-2416"));
			listaClientes.Add(new Cliente("Olivier","Abramamov","45","oabramamovh4@loc.gov","91.497.457","24-0699-0997"));
			listaClientes.Add(new Cliente("Byrann","Rowdell","72","browdellh5@mayoclinic.com","27.659.071","28-5854-9913"));
			listaClientes.Add(new Cliente("Wayland","Borer","46","wborerh6@barnesandnoble.com","79.076.600","38-4509-2050"));
			listaClientes.Add(new Cliente("Leda","Yeoland","68","lyeolandh7@digg.com","26.369.613","90-1716-9137"));
			listaClientes.Add(new Cliente("Romola","Showalter","94","rshowalterh8@clickbank.net","91.920.722","03-5550-5315"));
			listaClientes.Add(new Cliente("Fons","Fonteyne","43","ffonteyneh9@ow.ly","58.223.160","76-7657-9200"));
			listaClientes.Add(new Cliente("Carmella","Pichmann","43","cpichmannha@barnesandnoble.com","19.904.139","28-3807-7939"));
			listaClientes.Add(new Cliente("Drucie","Skehan","51","dskehanhb@cnet.com","59.321.894","96-5240-1646"));
			listaClientes.Add(new Cliente("Freddie","Dawton","37","fdawtonhc@sciencedaily.com","89.370.658","52-1675-5315"));
			listaClientes.Add(new Cliente("Coralie","Gamlin","23","cgamlinhd@sfgate.com","75.876.678","59-1025-6461"));
			listaClientes.Add(new Cliente("Kylynn","Mulhall","85","kmulhallhe@tinypic.com","43.458.587","74-9576-3035"));
			listaClientes.Add(new Cliente("Reagen","Bock","90","rbockhf@reddit.com","21.540.191","69-6642-9427"));
			listaClientes.Add(new Cliente("Nertie","Grigoli","50","ngrigolihg@cocolog-nifty.com","73.802.813","18-7406-3568"));
			listaClientes.Add(new Cliente("Piotr","Rosenstein","35","prosensteinhh@berkeley.edu","44.694.987","94-3943-6171"));
			listaClientes.Add(new Cliente("Ranice","McCurlye","67","rmccurlyehi@cisco.com","28.638.543","15-6129-7917"));
			listaClientes.Add(new Cliente("Marylee","Patmore","48","mpatmorehj@exblog.jp","88.157.356","84-5338-2986"));
			listaClientes.Add(new Cliente("Odo","Collinette","45","ocollinettehk@narod.ru","40.266.383","29-8734-6976"));
			listaClientes.Add(new Cliente("Wallie","Swayton","83","wswaytonhl@bbb.org","14.139.116","84-9976-7978"));
			listaClientes.Add(new Cliente("Valentina","Rouby","20","vroubyhm@irs.gov","60.532.490","79-3861-1736"));
			listaClientes.Add(new Cliente("Hayley","Gonzalez","54","hgonzalezhn@plala.or.jp","38.183.017","30-8455-3374"));
			listaClientes.Add(new Cliente("Dixie","Thorby","69","dthorbyho@constantcontact.com","05.352.703","76-3755-6709"));
			listaClientes.Add(new Cliente("Roosevelt","Turmell","65","rturmellhp@plala.or.jp","29.469.682","18-9974-9598"));
			listaClientes.Add(new Cliente("Nollie","Ahern","78","nahernhq@pinterest.com","81.857.876","68-9613-0255"));
			listaClientes.Add(new Cliente("Lisha","Carne","80","lcarnehr@digg.com","10.187.656","14-8404-4113"));
			listaClientes.Add(new Cliente("Beverie","Battersby","72","bbattersbyhs@amazonaws.com","76.213.712","44-7435-3149"));
			listaClientes.Add(new Cliente("Dominique","Aleksidze","47","daleksidzeht@artisteer.com","43.258.306","70-8545-1819"));
			listaClientes.Add(new Cliente("Janette","Valadez","73","jvaladezhu@ed.gov","96.559.674","00-1859-0208"));
			listaClientes.Add(new Cliente("Harlene","Giottini","81","hgiottinihv@wp.com","68.057.037","37-8478-4892"));
			listaClientes.Add(new Cliente("Hilliary","Povey","58","hpoveyhw@psu.edu","22.467.041","70-3063-5549"));
			listaClientes.Add(new Cliente("Vonnie","Scola","75","vscolahx@auda.org.au","27.010.389","09-8137-1701"));
			listaClientes.Add(new Cliente("Sayre","Rodenburgh","69","srodenburghhy@dell.com","18.517.050","43-6941-3241"));
			listaClientes.Add(new Cliente("Angie","Rawlingson","60","arawlingsonhz@stumbleupon.com","01.618.768","08-3228-5403"));
			listaClientes.Add(new Cliente("Molli","Alan","29","malani0@yellowpages.com","68.293.995","44-6415-1567"));
			listaClientes.Add(new Cliente("Fayette","Bolesworth","85","fbolesworthi1@time.com","51.868.219","92-1349-1490"));
			listaClientes.Add(new Cliente("Cletus","Eyton","38","ceytoni2@cbc.ca","74.102.090","44-8256-9790"));
			listaClientes.Add(new Cliente("Bianca","Eadmeads","19","beadmeadsi3@mysql.com","59.438.866","82-2980-1860"));
			listaClientes.Add(new Cliente("Raff","Stradling","44","rstradlingi4@biblegateway.com","22.486.262","01-1108-8309"));
			listaClientes.Add(new Cliente("Franky","Whitton","71","fwhittoni5@ihg.com","11.288.931","88-2683-1764"));
			listaClientes.Add(new Cliente("Walt","Eustace","51","weustacei6@squidoo.com","56.684.677","85-3650-5404"));
			listaClientes.Add(new Cliente("Lulita","Dykins","81","ldykinsi7@altervista.org","56.276.701","40-8812-8826"));
			listaClientes.Add(new Cliente("Athene","LeFevre","48","alefevrei8@skyrock.com","55.231.744","88-9646-6395"));
			listaClientes.Add(new Cliente("Wini","Feek","55","wfeeki9@imageshack.us","36.293.092","58-7675-9741"));
			listaClientes.Add(new Cliente("Hoyt","Monteaux","20","hmonteauxia@photobucket.com","28.939.465","19-7896-4399"));
			listaClientes.Add(new Cliente("Arman","O'Cahsedy","85","aocahsedyib@dailymotion.com","94.608.743","64-5668-5039"));
			listaClientes.Add(new Cliente("Burty","Summers","29","bsummersic@photobucket.com","85.521.361","43-1792-7882"));
			listaClientes.Add(new Cliente("Netta","Beslier","36","nbeslierid@cnbc.com","08.554.894","73-9439-2917"));
			listaClientes.Add(new Cliente("Letta","Collocott","57","lcollocottie@paginegialle.it","84.885.155","46-2335-1954"));
			listaClientes.Add(new Cliente("Hortense","Coulthart","81","hcoulthartif@apple.com","70.284.257","89-8414-3081"));
			listaClientes.Add(new Cliente("Malvin","Stormonth","89","mstormonthig@spotify.com","50.770.306","57-9498-2980"));
			listaClientes.Add(new Cliente("Auberta","Jerzak","93","ajerzakih@fc2.com","64.857.793","40-2046-5502"));
			listaClientes.Add(new Cliente("Aviva","Lente","26","alenteii@topsy.com","02.697.903","34-1971-3774"));
			listaClientes.Add(new Cliente("Wilhelmina","Peinke","35","wpeinkeij@ed.gov","72.149.543","35-6593-0906"));
			listaClientes.Add(new Cliente("Charil", "newing","65","cnewingik@gnu.org","49.918.122","92-8676-0610"));
			listaClientes.Add(new Cliente("Gaston","Pedro","38","gpedroil@nature.com","96.070.810","41-3022-9745"));
			listaClientes.Add(new Cliente("Barrie","Aliberti","19","balibertiim@fotki.com","34.930.331","26-9330-7148"));
			listaClientes.Add(new Cliente("Hesther","Giraldon","14","hgiraldonin@blogger.com","58.026.887","46-5553-2999"));
			listaClientes.Add(new Cliente("Chick","Rodder","85","crodderio@networkadvertising.org","90.239.556","04-9235-9520"));
			listaClientes.Add(new Cliente("Obed","Yurlov","31","oyurlovip@webs.com","22.298.230","82-5994-6632"));
			listaClientes.Add(new Cliente("Sharai","McNirlan","52","smcnirlaniq@archive.org","01.277.254","53-3814-3054"));
			listaClientes.Add(new Cliente("Alikee","Hewertson","90","ahewertsonir@creativecommons.org","23.459.850","89-2475-9737"));
			listaClientes.Add(new Cliente("Maggi","Maultby","18","mmaultbyis@sakura.ne.jp","82.278.834","66-3588-4892"));
			listaClientes.Add(new Cliente("Cassie","Berk","52","cberkit@bluehost.com","36.436.907","62-8878-4035"));
			listaClientes.Add(new Cliente("Tanney","McCumskay","72","tmccumskayiu@amazon.co.uk","63.551.698","97-2707-9752"));
			listaClientes.Add(new Cliente("Thea","Veighey","23","tveigheyiv@un.org","76.196.192","66-8685-5965"));
			listaClientes.Add(new Cliente("Kara-lynn","Cordingley","25","kcordingleyiw@unc.edu","50.737.237","96-0044-6766"));
			listaClientes.Add(new Cliente("Donna","Vasilechko","37","dvasilechkoix@buzzfeed.com","78.421.817","42-7963-4165"));
			listaClientes.Add(new Cliente("Aurora","Sarchwell","81","asarchwelliy@tiny.cc","75.387.211","76-5094-5411"));
			listaClientes.Add(new Cliente("Olympie","Cromleholme","98","ocromleholmeiz@goo.gl","76.512.128","35-9213-7859"));
			listaClientes.Add(new Cliente("Thomasine","Scedall","84","tscedallj0@hp.com","69.440.208","67-0290-3904"));
			listaClientes.Add(new Cliente("Demetra","Adolthine","64","dadolthinej1@reference.com","46.127.946","77-0912-3017"));
			listaClientes.Add(new Cliente("Claiborn","Andreuzzi","94","candreuzzij2@ycombinator.com","15.785.894","93-1681-8040"));
			listaClientes.Add(new Cliente("Karly","Cuer","76","kcuerj3@addthis.com","77.389.598","50-4840-9219"));
			listaClientes.Add(new Cliente("Claudette","Chevers","37","ccheversj4@woothemes.com","88.566.775","29-7280-3077"));
			listaClientes.Add(new Cliente("Cairistiona","Teall","82","cteallj5@thetimes.co.uk","59.824.382","32-8960-7368"));
			listaClientes.Add(new Cliente("Stephenie","Anderton","39","sandertonj6@netlog.com","47.016.031","79-1691-2058"));
			listaClientes.Add(new Cliente("Inessa","Yurasov","63","iyurasovj7@issuu.com","20.567.782","53-4766-6909"));
			listaClientes.Add(new Cliente("Nicolis","Cleife","42","ncleifej8@cam.ac.uk","84.144.317","87-1369-2758"));
			listaClientes.Add(new Cliente("Fiann","Oke","61","fokej9@va.gov","37.171.373","26-1892-1416"));
			listaClientes.Add(new Cliente("Skip","Bedrosian","69","sbedrosianja@bbb.org","04.377.878","08-3787-7901"));
			listaClientes.Add(new Cliente("Phil","Gilpillan","42","pgilpillanjb@joomla.org","61.246.332","25-9138-5009"));
			listaClientes.Add(new Cliente("Jenn","Roos","60","jroosjc@diigo.com","34.756.314","58-2369-2166"));
			listaClientes.Add(new Cliente("Kristofer","Poytheras","32","kpoytherasjd@ftc.gov","25.318.994","12-8684-5898"));
			listaClientes.Add(new Cliente("Evanne","Naul","65","enaulje@shop-pro.jp","27.069.591","57-9671-5692"));
			listaClientes.Add(new Cliente("Alden","Angerstein","43","aangersteinjf@spiegel.de","74.024.438","55-8012-9951"));
			listaClientes.Add(new Cliente("Reg","Moukes","87","rmoukesjg@imdb.com","97.277.149","39-8663-5678"));
			listaClientes.Add(new Cliente("Dennison","Livens","40","dlivensjh@zimbio.com","82.135.270","04-2653-8510"));
			listaClientes.Add(new Cliente("Chancey","Flewan","34","cflewanji@wordpress.com","47.479.134","69-1980-9799"));
			listaClientes.Add(new Cliente("Burgess","Joss","74","bjossjj@edublogs.org","53.411.181","21-8911-3468"));
			listaClientes.Add(new Cliente("Lucio","ChingeHals","25","lchingedehalsjk@google.it","49.757.977","85-2478-5948"));
			listaClientes.Add(new Cliente("Layne","Covill","42","lcovilljl@prweb.com","59.722.676","74-5386-5404"));
			listaClientes.Add(new Cliente("Minni","Mennell","59","mmennelljm@ehow.com","45.254.964","94-9027-7324"));
			listaClientes.Add(new Cliente("Doralia","Wyldbore","60","dwyldborejn@weebly.com","94.394.723","16-1687-0802"));
			listaClientes.Add(new Cliente("Isidro","MacAlister","70","imacalisterjo@census.gov","14.156.613","25-0007-0529"));
			listaClientes.Add(new Cliente("Maribeth","Landrean","48","mlandreanjp@issuu.com","63.148.492","36-6073-9903"));
			listaClientes.Add(new Cliente("Mariele","Threadkell","91","mthreadkelljq@scientificamerican.com","16.912.782","06-2208-4468"));
			listaClientes.Add(new Cliente("Dido","Cammocke","09","dcammockejr@odnoklassniki.ru","68.332.670","19-6149-9188"));
			listaClientes.Add(new Cliente("Sandi","Leverson","50","sleversonjs@msu.edu","18.998.990","90-8033-1001"));
			listaClientes.Add(new Cliente("Sigrid","Mathouse","64","smathousejt@mlb.com","47.460.141","59-5724-3079"));
			listaClientes.Add(new Cliente("Anica","Ivie","22","aivieju@parallels.com","95.995.026","07-3437-2688"));
			listaClientes.Add(new Cliente("Dredi","Hansana","69","dhansanajv@netscape.com","59.295.014","60-7142-9247"));
			listaClientes.Add(new Cliente("Dallas","Romanini","77","dromaninijw@gnu.org","75.590.614","95-7051-9038"));
			listaClientes.Add(new Cliente("Ellyn","Rutledge","65","erutledgejx@berkeley.edu","13.909.159","43-6165-4860"));
			listaClientes.Add(new Cliente("Rosie","Lohden","42","rlohdenjy@yahoo.com","59.764.827","91-0402-3635"));
			listaClientes.Add(new Cliente("Maximilien","Tatford","35","mtatfordjz@dell.com","65.526.424","80-3069-2623"));
			listaClientes.Add(new Cliente("Boniface","Prazer","62","bprazerk0@oracle.com","39.001.818","52-3242-2402"));
			listaClientes.Add(new Cliente("Worth","Job","93","wjobk1@youtu.be","43.392.982","36-1802-9242"));
			listaClientes.Add(new Cliente("Abba","Trounce","84","atrouncek2@fotki.com","73.105.475","25-7100-7924"));
			listaClientes.Add(new Cliente("Marilee","Poncet","20","mponcetk3@simplemachines.org","39.899.220","60-6803-6265"));
			listaClientes.Add(new Cliente("Carlotta","Gealle","63","cgeallek4@un.org","47.602.273","66-2441-3894"));
			listaClientes.Add(new Cliente("Marys","Ealden","25","mealdenk5@ycombinator.com","97.898.895","77-1255-3547"));
			listaClientes.Add(new Cliente("Ginny","Gheorghe","40","ggheorghek6@rakuten.co.jp","81.979.022","03-6853-5804"));
			listaClientes.Add(new Cliente("Augustina","Sturdy","74","asturdyk7@jiathis.com","68.767.977","07-2272-5712"));
			listaClientes.Add(new Cliente("Umberto","McGuiness","39","umcguinessk8@friendfeed.com","41.336.233","98-5398-5018"));
			listaClientes.Add(new Cliente("Kimmy","Toulch","29","ktoulchk9@etsy.com","10.974.000","70-0473-3951"));
			listaClientes.Add(new Cliente("Annabel","Sainteau","86","asainteauka@deliciousdays.com","51.010.947","23-4610-6482"));
			listaClientes.Add(new Cliente("Maridel","Klazenga","24","mklazengakb@fema.gov","65.897.110","67-2999-2942"));
			listaClientes.Add(new Cliente("Claire","Kembrey","37","ckembreykc@dmoz.org","69.078.776","12-1863-9760"));
			listaClientes.Add(new Cliente("Melony","Androlli","39","mandrollikd@guardian.co.uk","70.414.024","54-1210-2200"));
			listaClientes.Add(new Cliente("Clyde","Sutterby","39","csutterbyke@blogs.com","10.354.294","21-7293-9846"));
			listaClientes.Add(new Cliente("Randi","Briddle","82","rbriddlekf@clickbank.net","24.831.492","77-8149-7490"));
			listaClientes.Add(new Cliente("Inglebert","Stowell","26","istowellkg@altervista.org","03.164.928","10-1166-3941"));
			listaClientes.Add(new Cliente("Gabbie","Friedank","42","gfriedankkh@amazon.co.uk","59.517.617","13-5661-5453"));
			listaClientes.Add(new Cliente("Jethro","Marjoribanks","85","jmarjoribankski@imdb.com","17.357.869","84-1252-7280"));
			listaClientes.Add(new Cliente("Ezra","O'Connolly","38","eoconnollykj@myspace.com","31.399.938","40-6331-6637"));
			listaClientes.Add(new Cliente("Linette","Raubenheimer","42","lraubenheimerkk@nifty.com","68.082.756","57-1581-8370"));
			listaClientes.Add(new Cliente("Lauren","Johnston","60","ljohnstonkl@pinterest.com","90.853.951","14-8112-4005"));
			listaClientes.Add(new Cliente("Linzy","Basnett","09","lbasnettkm@netscape.com","93.243.222","39-4934-9177"));
			listaClientes.Add(new Cliente("Kalvin","Hitzke","68","khitzkekn@ucsd.edu","19.345.921","46-6933-9987"));
			listaClientes.Add(new Cliente("Connor","Klehyn","75","cklehynko@webs.com","84.854.262","51-8501-9801"));
			listaClientes.Add(new Cliente("Izaak","Casino","18","icasinokp@engadget.com","04.509.726","88-9986-2249"));
			listaClientes.Add(new Cliente("Charmain","Gazey","37","cgazeykq@google.de","44.276.770","80-5013-5166"));
			listaClientes.Add(new Cliente("Karia","Burgis","47","kburgiskr@weather.com","79.397.566","34-1087-0514"));
			listaClientes.Add(new Cliente("Killy","Moar","37","kmoarks@timesonline.co.uk","21.983.211","36-8624-5954"));
			listaClientes.Add(new Cliente("Link","Midford","55","lmidfordkt@abc.net.au","24.608.548","82-0179-3450"));
			listaClientes.Add(new Cliente("Alon","Kimbley","38","akimbleyku@meetup.com","24.773.722","25-3203-0365"));
			listaClientes.Add(new Cliente("Susana","Assel","99","sasselkv@omniture.com","08.960.927","84-4078-0360"));
			listaClientes.Add(new Cliente("Sophia","Menilove","51","smenilovekw@theguardian.com","18.049.132","95-7844-9326"));
			listaClientes.Add(new Cliente("Katharina","Kittless","48","kkittlesskx@ucoz.ru","32.374.961","88-9473-3290"));
			listaClientes.Add(new Cliente("Kathy","Trevithick","39","ktrevithickky@comsenz.com","68.399.811","29-5538-3075"));
			listaClientes.Add(new Cliente("Dix","Marians","75","dmarianskz@nationalgeographic.com","73.555.603","38-5475-7990"));
			listaClientes.Add(new Cliente("Therese","Hewlings","21","thewlingsl0@dedecms.com","31.590.657","16-8875-2330"));
			listaClientes.Add(new Cliente("Francene","Jewkes","71","fjewkesl1@stumbleupon.com","24.687.898","50-9427-9498"));
			listaClientes.Add(new Cliente("Fabien","Sharrock","74","fsharrockl2@booking.com","57.420.440","44-9902-9860"));
			listaClientes.Add(new Cliente("Sal","Torbard","52","storbardl3@walmart.com","06.002.609","22-3794-5812"));
			listaClientes.Add(new Cliente("Livvie","Beggs","61","lbeggsl4@nationalgeographic.com","48.375.745","28-9826-2636"));
			listaClientes.Add(new Cliente("Carlee","Redish","33","credishl5@clickbank.net","58.470.178","09-6232-7951"));
			listaClientes.Add(new Cliente("Killy","Furmage","18","kfurmagel6@tuttocitta.it","73.470.007","78-5220-5271"));
			listaClientes.Add(new Cliente("Frants","Giotto","75","fgiottol7@hubpages.com","51.976.893","25-5720-0398"));
			listaClientes.Add(new Cliente("Ingunna","Withrington","62","iwithringtonl8@nymag.com","31.766.915","79-0897-3209"));
			listaClientes.Add(new Cliente("Brendis","Royce","43","broycel9@vkontakte.ru","28.290.520","00-4636-6870"));
			listaClientes.Add(new Cliente("Shea","Hallgate","87","shallgatela@mac.com","43.664.184","06-5879-1291"));
			listaClientes.Add(new Cliente("Onfroi","Werendell","23","owerendelllb@examiner.com","22.868.486","66-5638-7401"));
			listaClientes.Add(new Cliente("Camilla","Simmans","97","csimmanslc@ox.ac.uk","11.085.595","58-6048-5644"));
			listaClientes.Add(new Cliente("Linus","Fellowes","43","lfellowesld@gravatar.com","83.588.219","82-5665-0362"));
			listaClientes.Add(new Cliente("Cindelyn","Haryngton","39","charyngtonle@miibeian.gov.cn","12.339.700","46-6800-7345"));
			listaClientes.Add(new Cliente("Jerri","Bess","45","jbesslf@e-recht24.de","90.148.873","22-2314-8757"));
			listaClientes.Add(new Cliente("Chuck","Mitchelmore","52","cmitchelmorelg@nasa.gov","75.172.021","93-3208-7730"));
			listaClientes.Add(new Cliente("Meghan","Feye","50","mfeyelh@stumbleupon.com","75.413.578","04-4053-1625"));
			listaClientes.Add(new Cliente("Elmira","Dudgeon","52","edudgeonli@nyu.edu","13.945.376","56-9069-5120"));
			listaClientes.Add(new Cliente("Cyndia","Rikel","93","crikellj@harvard.edu","11.951.060","05-0199-3965"));
			listaClientes.Add(new Cliente("Maurita","Queenborough","89","mqueenboroughlk@psu.edu","71.024.071","31-9655-1077"));
			listaClientes.Add(new Cliente("Paula","Bixley","26","pbixleyll@marketwatch.com","63.904.494","35-0834-3400"));
			listaClientes.Add(new Cliente("Gilles","Coale","48","gcoalelm@woothemes.com","42.030.480","49-6864-9706"));
			listaClientes.Add(new Cliente("Claudie","Shadrack","67","cshadrackln@mtv.com","03.276.115","03-4517-1094"));
			listaClientes.Add(new Cliente("Clarinda","McGraith","24","cmcgraithlo@hostgator.com","06.695.893","87-9755-8268"));
			listaClientes.Add(new Cliente("Agretha","Gandy","85","agandylp@amazonaws.com","06.422.033","83-7492-9115"));
			listaClientes.Add(new Cliente("Ross","Vine","83","rvinelq@parallels.com","39.109.246","42-1220-6153"));
			listaClientes.Add(new Cliente("Janaya","Hynd","18","jhyndlr@furl.net","96.365.923","17-0860-2274"));
			listaClientes.Add(new Cliente("Arlyne","Roswarn","35","aroswarnls@tumblr.com","55.921.496","78-9230-4638"));
			listaClientes.Add(new Cliente("Corabel","Danielsen","59","cdanielsenlt@berkeley.edu","84.400.498","69-2265-8473"));
			listaClientes.Add(new Cliente("Marcy","Gaskoin","20","mgaskoinlu@typepad.com","11.843.519","18-3934-6469"));
			listaClientes.Add(new Cliente("Carly","LeMarchand","89","clemarchandlv@deviantart.com","26.424.030","69-0572-5547"));
			listaClientes.Add(new Cliente("Tynan","Tammadge","73","ttammadgelw@wix.com","41.877.491","12-4007-8897"));
			listaClientes.Add(new Cliente("Arabella","Poutress","19","apoutresslx@sfgate.com","69.155.653","04-9914-1160"));
			listaClientes.Add(new Cliente("Cristina","Surfleet","42","csurfleetly@google.com.au","77.881.041","70-7226-6482"));
			listaClientes.Add(new Cliente("Hinda","Tomaszek","35","htomaszeklz@cocolog-nifty.com","05.970.544","48-8228-5763"));
			listaClientes.Add(new Cliente("Noemi","Fincke","29","nfinckem0@state.tx.us","34.031.485","50-4662-0423"));
			listaClientes.Add(new Cliente("Elana","Mattiussi","56","emattiussim1@netvibes.com","21.073.022","82-7763-2028"));
			listaClientes.Add(new Cliente("Tessy","Mitchener","53","tmitchenerm2@intel.com","85.969.341","84-6098-0139"));
			listaClientes.Add(new Cliente("Korey","Sansom","97","ksansomm3@seesaa.net","68.688.029","86-5440-5835"));
			listaClientes.Add(new Cliente("Sheela","Walpole","46","swalpolem4@homestead.com","90.455.382","69-3011-3057"));
			listaClientes.Add(new Cliente("Germain","Serman","80","gsermanm5@state.gov","21.125.247","20-7841-0031"));
			listaClientes.Add(new Cliente("Linzy","Magrannell","69","lmagrannellm6@icq.com","24.921.152","11-0699-9368"));
			listaClientes.Add(new Cliente("Carlin","Fines","55","cfinesm7@ask.com","96.043.548","35-2989-2707"));
			listaClientes.Add(new Cliente("Crichton","Persicke","68","cpersickem8@usgs.gov","06.285.211","76-1700-6614"));
			listaClientes.Add(new Cliente("Izabel","Errichi","98","ierrichim9@yandex.ru","93.726.942","44-7317-8090"));
			listaClientes.Add(new Cliente("Christiana","Gordon","37","cgordonma@live.com","65.298.676","70-4199-4491"));
			listaClientes.Add(new Cliente("Bart","Klezmski","68","bklezmskimb@apple.com","16.599.530","30-0219-6492"));
			listaClientes.Add(new Cliente("Dotty","Caldecot","45","dcaldecotmc@dot.gov","41.806.785","12-6180-7560"));
			listaClientes.Add(new Cliente("Padraig","McGiff","62","pmcgiffmd@businessweek.com","68.194.290","39-4716-4134"));
			listaClientes.Add(new Cliente("Zolly","Yankov","63","zyankovme@quantcast.com","83.832.729","95-7433-7504"));
			listaClientes.Add(new Cliente("Valdemar","Lumby","41","vlumbymf@mysql.com","47.376.069","31-4219-6468"));
			listaClientes.Add(new Cliente("Abbe","Stollberger","61","astollbergermg@usnews.com","43.766.926","60-5183-4500"));
			listaClientes.Add(new Cliente("Constancy","Novic","22","cnovicmh@amazon.com","81.198.750","06-7705-3913"));
			listaClientes.Add(new Cliente("Robinette","Lupton","34","rluptonmi@cornell.edu","18.062.198","56-5795-8896"));
			listaClientes.Add(new Cliente("Gill","Ferrotti","48","gferrottimj@drupal.org","48.899.972","74-2705-1836"));
			listaClientes.Add(new Cliente("Pauline","MacCawley","67","pmaccawleymk@youtube.com","34.984.594","63-5732-3211"));
			listaClientes.Add(new Cliente("Jennifer","Soaper","19","jsoaperml@tumblr.com","34.063.599","04-3821-6075"));
			listaClientes.Add(new Cliente("Franny","Vann","46","fvannmm@economist.com","60.311.577","15-3217-0532"));
			listaClientes.Add(new Cliente("Gwennie","Parratt","80","gparrattmn@twitpic.com","42.922.109","60-9066-4520"));
			listaClientes.Add(new Cliente("Josie","Bolland","71","jbollandmo@dailymail.co.uk","38.539.861","55-1606-9521"));
			listaClientes.Add(new Cliente("Eba","Derisly","68","ederislymp@tumblr.com","51.822.875","49-4529-8985"));
			listaClientes.Add(new Cliente("Shoshana","Stafford","31","sstaffordmq@vimeo.com","12.835.017","69-1031-4575"));
			listaClientes.Add(new Cliente("Addie","Loynton","81","aloyntonmr@wikia.com","54.422.281","47-9491-6007"));
			listaClientes.Add(new Cliente("Colby","Naylor","30","cnaylorms@ibm.com","58.149.199","06-9994-3309"));
			listaClientes.Add(new Cliente("Archaimbaud","Dench","93","adenchmt@home.pl","74.388.491","00-8223-1743"));
			listaClientes.Add(new Cliente("Ninetta","Bess","35","nbessmu@huffingtonpost.com","01.933.946","32-8415-6596"));
			listaClientes.Add(new Cliente("Artair","Rowat","98","arowatmv@yandex.ru","63.947.191","49-4780-8621"));
			listaClientes.Add(new Cliente("Langsdon","Oslar","33","loslarmw@cpanel.net","60.281.401","84-5369-3091"));
			listaClientes.Add(new Cliente("Alexander","Alfonsetti","41","aalfonsettimx@slashdot.org","08.033.022","99-7042-3784"));
			listaClientes.Add(new Cliente("Alejandrina","Ginnety","73","aginnetymy@seesaa.net","62.526.627","01-7465-2850"));
			listaClientes.Add(new Cliente("Ximenez","McAllaster","89","xmcallastermz@booking.com","32.753.433","02-1078-9230"));
			listaClientes.Add(new Cliente("Ina","Urwen","99","iurwenn0@1und1.de","49.909.581","96-4488-1647"));
			listaClientes.Add(new Cliente("Upton","Renowden","72","urenowdenn1@unicef.org","59.728.373","33-5120-4298"));
			listaClientes.Add(new Cliente("Jeanine","Juszczyk","64","jjuszczykn2@walmart.com","43.749.960","98-6765-9583"));
			listaClientes.Add(new Cliente("Sylvan","Hanster","48","shanstern3@sina.com.cn","76.432.203","67-3706-1293"));
			listaClientes.Add(new Cliente("May","Tapner","76","mtapnern4@baidu.com","52.136.277","09-6305-5721"));
			listaClientes.Add(new Cliente("Betty","Asp","28","baspn5@wp.com","69.290.535","07-3834-6189"));
			listaClientes.Add(new Cliente("Revkah","Baseke","41","rbaseken6@noaa.gov","86.989.235","33-1729-4985"));
			listaClientes.Add(new Cliente("Marthena","Stoyle","48","mstoylen7@java.com","24.271.249","68-0241-3768"));
			listaClientes.Add(new Cliente("Barbette","Trafford","15","btraffordn8@upenn.edu","34.277.312","18-0164-7665"));
			listaClientes.Add(new Cliente("Robert","Mattimoe","28","rmattimoen9@abc.net.au","07.302.061","96-0371-9374"));
			listaClientes.Add(new Cliente("Pincas","Hansmann","19","phansmannna@gov.uk","43.828.920","55-3086-8953"));
			listaClientes.Add(new Cliente("Brit","Triggle","85","btrigglenb@adobe.com","08.328.630","58-1402-8482"));
			listaClientes.Add(new Cliente("Andrus","Gerardi","74","agerardinc@goo.ne.jp","30.791.369","86-2737-4955"));
			listaClientes.Add(new Cliente("Corly","Bail","83","cbailnd@samsung.com","53.711.587","53-0129-3858"));
			listaClientes.Add(new Cliente("Nataline","Mounce","95","nmouncene@slate.com","06.921.186","29-9838-1608"));
			listaClientes.Add(new Cliente("Sharona","Cuseck","91","scusecknf@discuz.net","58.970.102","13-8805-7406"));
			listaClientes.Add(new Cliente("Staci","Martinek","18","smartinekng@163.com","45.123.293","85-0422-1433"));
			listaClientes.Add(new Cliente("Karine","Bollini","17","kbollininh@bing.com","15.399.443","27-4989-8308"));
			listaClientes.Add(new Cliente("Farleigh","Scrivens","69","fscrivensni@psu.edu","82.378.677","27-4158-5000"));
			listaClientes.Add(new Cliente("Emelyne","Gell","58","egellnj@bizjournals.com","10.277.339","17-2351-8641"));
			listaClientes.Add(new Cliente("Douglas","Aimer","60","daimernk@tinyurl.com","94.793.541","22-9298-9635"));
			listaClientes.Add(new Cliente("Elsie","Daunay","91","edaunaynl@bbb.org","43.811.330","85-1465-7893"));
			listaClientes.Add(new Cliente("Torrance","Madgin","19","tmadginnm@army.mil","00.299.617","26-7554-1918"));
			listaClientes.Add(new Cliente("Zak","Woollam","29","zwoollamnn@e-recht24.de","22.111.229","82-0168-2848"));
			listaClientes.Add(new Cliente("Eloise","Sclater","45","esclaterno@constantcontact.com","03.315.871","37-2579-8102"));
			listaClientes.Add(new Cliente("Caldwell","Copeland","46","ccopelandnp@youtube.com","78.325.041","62-4671-9669"));
			listaClientes.Add(new Cliente("Antons","Pauleau","45","apauleaunq@ifeng.com","01.270.564","51-8982-5246"));
			listaClientes.Add(new Cliente("George","Isakov","96","gisakovnr@soup.io","83.210.805","31-0451-1921"));
			listaClientes.Add(new Cliente("Collen","Poetz","39","cpoetzns@tripadvisor.com","05.617.086","88-9193-8431"));
			listaClientes.Add(new Cliente("Avril","Southeran","75","asoutherannt@sogou.com","44.056.861","23-6339-6157"));
			listaClientes.Add(new Cliente("Worthy","Waskett","57","wwaskettnu@devhub.com","49.953.399","57-0928-3888"));
			listaClientes.Add(new Cliente("Kirby","Roskruge","31","kroskrugenv@ebay.com","93.992.060","40-5793-5790"));
			listaClientes.Add(new Cliente("Claiborn","Kid","55","ckidnw@xrea.com","50.345.930","73-3606-7250"));
			listaClientes.Add(new Cliente("Sheila","Aysik","17","saysiknx@altervista.org","40.467.029","12-0986-9562"));
			listaClientes.Add(new Cliente("Wes","Vanlint","48","wvanlintny@google.pl","46.144.152","42-1321-3865"));
			listaClientes.Add(new Cliente("Gail","Radleigh","58","gradleighnz@google.com.au","78.144.452","67-6285-0806"));
			listaClientes.Add(new Cliente("Yardley","Schankel","32","yschankelo0@amazon.de","02.052.469","62-6587-4998"));
			listaClientes.Add(new Cliente("Zeb","Santello","47","zsantelloo1@google.co.uk","18.758.052","56-0064-7350"));
			listaClientes.Add(new Cliente("Phillie","Hyland","74","phylando2@shinystat.com","27.289.018","96-5636-5618"));
			listaClientes.Add(new Cliente("Gabriele","Paulucci","37","gpauluccio3@hugedomains.com","58.446.857","55-4200-7222"));
			listaClientes.Add(new Cliente("Ginnifer","Pistol","83","gpistolo4@t-online.de","05.713.040","70-7114-6482"));
			listaClientes.Add(new Cliente("Mollee","Mazillius","29","mmazilliuso5@squarespace.com","21.769.539","83-3290-3033"));
			listaClientes.Add(new Cliente("Juliette","Alger","50","jalgero6@wordpress.org","83.787.202","91-4309-3725"));
			listaClientes.Add(new Cliente("Sonia","Kobelt","37","skobelto7@economist.com","06.638.087","08-9507-5740"));
			listaClientes.Add(new Cliente("Maisey","Ibbison","56","mibbisono8@facebook.com","76.141.237","86-0838-9228"));
			listaClientes.Add(new Cliente("Gerrilee","Schwander","49","gschwandero9@icio.us","03.853.309","68-9153-1050"));
			listaClientes.Add(new Cliente("Berky","Spadelli","65","bspadellioa@jugem.jp","47.334.636","20-4136-8251"));
			listaClientes.Add(new Cliente("Archie","Kolis","82","akolisob@cmu.edu","65.042.186","44-8698-2992"));
			listaClientes.Add(new Cliente("Kaycee","Miliffe","44","kmiliffeoc@phpbb.com","10.527.383","97-8634-8117"));
			listaClientes.Add(new Cliente("Deedee","Hitzmann","67","dhitzmannod@state.tx.us","02.733.868","83-5304-5697"));
			listaClientes.Add(new Cliente("Laurens","Hartup","53","lhartupoe@sciencedirect.com","61.256.233","28-2474-6142"));
			listaClientes.Add(new Cliente("Cozmo","Silbermann","28","csilbermannof@list-manage.com","00.776.515","30-3914-8371"));
			listaClientes.Add(new Cliente("Ivonne","Heibel","81","iheibelog@squidoo.com","47.750.144","56-6653-7203"));
			listaClientes.Add(new Cliente("Zita","Stacy","31","zstacyoh@aol.com","28.951.230","37-3105-7862"));
			listaClientes.Add(new Cliente("Brittni","Trengrove","55","btrengroveoi@mozilla.com","78.255.512","24-0025-4231"));
			listaClientes.Add(new Cliente("Mona","Crofts","38","mcroftsoj@mac.com","11.291.480","20-8211-8506"));
			listaClientes.Add(new Cliente("Keven","Trewhella","55","ktrewhellaok@msu.edu","87.763.784","67-9696-8337"));
			listaClientes.Add(new Cliente("Gabi","Pentelo","29","gpentelool@google.de","71.330.684","81-6647-2210"));
			listaClientes.Add(new Cliente("Wyatt","Larkings","33","wlarkingsom@ow.ly","57.207.264","26-3829-5565"));
			listaClientes.Add(new Cliente("Jinny","Olman","79","jolmanon@patch.com","64.875.871","22-6943-1175"));
			listaClientes.Add(new Cliente("Quintus","Cantero","40","qcanterooo@spiegel.de","30.228.047","54-5447-1214"));
			listaClientes.Add(new Cliente("Adriano","Brittles","22","abrittlesop@state.gov","87.635.764","88-2780-9199"));
			listaClientes.Add(new Cliente("Reid","Opdenort","51","ropdenortoq@imageshack.us","42.436.006","48-4682-9040"));
			listaClientes.Add(new Cliente("Fabiano","Snyder","71","fsnyderor@ezinearticles.com","85.504.341","31-0634-5208"));
			listaClientes.Add(new Cliente("Costa","Sunderland","49","csunderlandos@mashable.com","02.526.274","47-1881-3763"));
			listaClientes.Add(new Cliente("Winnifred","Warde","23","wwardeot@addthis.com","07.838.445","15-1092-5176"));
			listaClientes.Add(new Cliente("Jorgan","Yelland","41","jyellandou@pagesperso-orange.fr","23.675.598","01-7867-9697"));
			listaClientes.Add(new Cliente("Danyelle","Flewett","79","dflewettov@altervista.org","60.461.642","42-9823-5267"));
			listaClientes.Add(new Cliente("Aleece","Rolfe","21","arolfeow@simplemachines.org","73.987.058","88-5028-9705"));
			listaClientes.Add(new Cliente("Hannis","Iuorio","20","hiuorioox@whitehouse.gov","54.706.816","58-6871-4289"));
			listaClientes.Add(new Cliente("Alana","Ulyatt","17","aulyattoy@ed.gov","73.614.762","66-1327-2726"));
			listaClientes.Add(new Cliente("Martie","Starkey","68","mstarkeyoz@youtu.be","38.988.891","09-1796-4980"));
			listaClientes.Add(new Cliente("Webb","Halfacree","56","whalfacreep0@ameblo.jp","93.059.598","41-0219-4725"));
			listaClientes.Add(new Cliente("Malinde","Ballintyne","70","mballintynep1@scribd.com","65.830.309","18-1073-9574"));
			listaClientes.Add(new Cliente("Arvy","Cardoe","45","acardoep2@usa.gov","59.366.301","34-9052-9771"));
			listaClientes.Add(new Cliente("Nefen","Brock","87","nbrockp3@ucla.edu","53.426.481","15-9595-9956"));
			listaClientes.Add(new Cliente("Inigo","Fassum","71","ifassump4@deliciousdays.com","23.084.355","25-2721-7625"));
			listaClientes.Add(new Cliente("Allyson","Bollum","95","abollump5@nih.gov","78.352.515","05-6130-5873"));
			listaClientes.Add(new Cliente("Humbert","Sieghard","83","hsieghardp6@latimes.com","47.707.835","08-8048-0470"));
			listaClientes.Add(new Cliente("Janessa","Corp","59","jcorpp7@bizjournals.com","57.363.856","76-4005-0167"));
			listaClientes.Add(new Cliente("Francoise","Vardon","53","fvardonp8@tmall.com","73.206.291","55-0076-1707"));
			listaClientes.Add(new Cliente("Rania","Esome","61","resomep9@addthis.com","16.242.864","48-3780-4694"));
			listaClientes.Add(new Cliente("Hasty","Screwton","89","hscrewtonpa@chronoengine.com","78.516.521","93-2687-4741"));
			listaClientes.Add(new Cliente("Karie","Vuitton","39","kvuittonpb@google.it","77.788.136","58-4502-7394"));
			listaClientes.Add(new Cliente("Madel","Brithman","53","mbrithmanpc@e-recht24.de","55.505.489","77-1855-6966"));
			listaClientes.Add(new Cliente("Elyn","Rochford","22","erochfordpd@bloomberg.com","74.593.415","74-9611-3137"));
			listaClientes.Add(new Cliente("Barnard","Waddingham","35","bwaddinghampe@sfgate.com","35.529.010","53-1153-9245"));
			listaClientes.Add(new Cliente("Con","Naisey","30","cnaiseypf@ameblo.jp","85.406.944","38-1358-7321"));
			listaClientes.Add(new Cliente("Axel","Cuddihy","81","acuddihypg@admin.ch","08.043.789","07-0535-6192"));
			listaClientes.Add(new Cliente("Korry","Checchi","18","kchecchiph@imgur.com","13.656.019","35-0761-7220"));
			listaClientes.Add(new Cliente("Cecilia","Penhale","69","cpenhalepi@wired.com","28.646.265","06-0224-0943"));
			listaClientes.Add(new Cliente("Bevan","Sesser","87","bsesserpj@usatoday.com","18.324.774","62-6863-9239"));
			listaClientes.Add(new Cliente("Simeon","Courtois","95","scourtoispk@ted.com","47.387.532","85-1084-3555"));
			listaClientes.Add(new Cliente("Windham","Vigers","25","wvigerspl@nps.gov","77.289.264","46-4224-8210"));
			listaClientes.Add(new Cliente("Hart","Glaysher","18","hglaysherpm@ifeng.com","49.425.790","81-9076-1701"));
			listaClientes.Add(new Cliente("Iggie","Fink","73","ifinkpn@mediafire.com","06.824.046","99-9845-1837"));
			listaClientes.Add(new Cliente("Heywood","Andreix","72","handreixpo@discuz.net","10.777.296","70-4135-6677"));
			listaClientes.Add(new Cliente("Tedi","Borthwick","25","tborthwickpp@youku.com","16.018.755","11-6145-4652"));
			listaClientes.Add(new Cliente("Ulberto","Cisar","27","ucisarpq@huffingtonpost.com","03.977.559","50-2152-4776"));
			listaClientes.Add(new Cliente("Eleni","Kann","35","ekannpr@sfgate.com","15.235.411","36-8255-1230"));
			listaClientes.Add(new Cliente("Joyann","Baly","28","jbalyps@163.com","34.628.968","65-2514-1793"));
			listaClientes.Add(new Cliente("Ax","Durham","98","adurhampt@reverbnation.com","95.750.076","44-5960-8546"));
			listaClientes.Add(new Cliente("Alta","Filippucci","90","afilippuccipu@flickr.com","64.839.095","59-8903-6792"));
			listaClientes.Add(new Cliente("Sherrie","Exall","78","sexallpv@cafepress.com","29.135.840","13-8857-0506"));
			listaClientes.Add(new Cliente("Maxi","Callander","89","mcallanderpw@vinaora.com","98.505.909","32-1419-5617"));
			listaClientes.Add(new Cliente("Jimmie","Coche","23","jcochepx@edublogs.org","43.646.022","93-7835-5859"));
			listaClientes.Add(new Cliente("Meggie","Mouncher","76","mmouncherpy@4shared.com","38.362.247","07-8102-3071"));
			listaClientes.Add(new Cliente("Aaron","Gockelen","55","agockelenpz@flickr.com","06.245.477","64-3230-8000"));
			listaClientes.Add(new Cliente("Korie","Lismer","65","klismerq0@aol.com","90.144.407","84-0972-3359"));
			listaClientes.Add(new Cliente("Natalie","Yannikov","44","nyannikovq1@apache.org","87.977.377","96-9154-6290"));
			listaClientes.Add(new Cliente("Marijo","Okroy","78","mokroyq2@goodreads.com","36.515.622","07-5161-2827"));
			listaClientes.Add(new Cliente("Sully","Eynaud","33","seynaudq3@blogger.com","41.282.795","11-3950-9971"));
			listaClientes.Add(new Cliente("Arch","Antonijevic","28","aantonijevicq4@delicious.com","23.140.014","19-7319-4664"));
			listaClientes.Add(new Cliente("Maitilde","Swainston","42","mswainstonq5@meetup.com","42.336.463","29-8394-7004"));
			listaClientes.Add(new Cliente("Carolee","Stallen","46","cstallenq6@amazon.de","30.938.410","39-4411-6158"));
			listaClientes.Add(new Cliente("Maurise","Chase","82","mchaseq7@istockphoto.com","19.270.110","02-3283-5101"));
			listaClientes.Add(new Cliente("Drusilla","McCrory","85","dmccroryq8@nydailynews.com","94.513.835","24-2953-0434"));
			listaClientes.Add(new Cliente("Merrielle","Downse","83","mdownseq9@flavors.me","76.569.267","53-5866-9386"));
			listaClientes.Add(new Cliente("Adella","Gilmore","71","agilmoreqa@gov.uk","72.424.078","89-9206-3888"));
			listaClientes.Add(new Cliente("Siusan","Reneke","19","srenekeqb@vimeo.com","49.450.633","97-1698-1122"));
			listaClientes.Add(new Cliente("Cornelle","Thams","83","cthamsqc@nbcnews.com","54.536.935","03-8958-4510"));
			listaClientes.Add(new Cliente("Ambrosi","Tesyro","96","atesyroqd@biblegateway.com","76.038.333","43-8809-6925"));
			listaClientes.Add(new Cliente("Murial","Tutchell","22","mtutchellqe@homestead.com","53.239.127","15-7554-8304"));
			listaClientes.Add(new Cliente("Beulah","Allin","80","ballinqf@sfgate.com","30.489.485","16-8381-5671"));
			listaClientes.Add(new Cliente("Derk","Joron","85","djoronqg@delicious.com","78.248.574","29-4528-4955"));
			listaClientes.Add(new Cliente("Gibbie","Coghlan","60","gcoghlanqh@g.co","55.136.512","50-8901-4215"));
			listaClientes.Add(new Cliente("Cliff","Gidney","65","cgidneyqi@yahoo.com","42.936.999","42-0670-8542"));
			listaClientes.Add(new Cliente("Iggy","Klesl","26","ikleslqj@de.vu","30.346.030","63-6039-8924"));
			listaClientes.Add(new Cliente("Lexi","Lokier","87","llokierqk@delicious.com","61.996.693","45-8072-8800"));
			listaClientes.Add(new Cliente("Evyn","Lusk","57","eluskql@squidoo.com","61.607.136","44-5031-6304"));
			listaClientes.Add(new Cliente("Alan","Jewers","69","ajewersqm@yahoo.co.jp","34.988.430","98-0825-2857"));
			listaClientes.Add(new Cliente("Harrietta","Jaggar","83","hjaggarqn@senate.gov","65.778.458","40-7013-6162"));
			listaClientes.Add(new Cliente("Hy","France","36","hfranceqo@woothemes.com","01.808.643","21-7836-2368"));
			listaClientes.Add(new Cliente("Rudy","Romney","21","rromneyqp@phoca.cz","77.737.520","22-1795-5886"));
			listaClientes.Add(new Cliente("Nicolle","Spurge","37","nspurgeqq@epa.gov","12.501.717","83-7954-6202"));
			listaClientes.Add(new Cliente("Hubie","Sparham","98","hsparhamqr@icio.us","01.792.531","80-6126-6639"));
			listaClientes.Add(new Cliente("Dimitri","Carden","85","dcardenqs@ovh.net","10.132.373","03-4099-8159"));
			listaClientes.Add(new Cliente("Kearney","Bolden","61","kboldenqt@japanpost.jp","58.625.505","79-1471-1905"));
			listaClientes.Add(new Cliente("Ileana","Haizelden","22","ihaizeldenqu@123-reg.co.uk","86.857.792","66-4843-4705"));
			listaClientes.Add(new Cliente("Flemming","Weare","84","fweareqv@wix.com","23.636.017","51-8905-0279"));
			listaClientes.Add(new Cliente("Winna","Morecombe","19","wmorecombeqw@utexas.edu","29.570.573","20-1193-4675"));
			listaClientes.Add(new Cliente("Meredithe","Boulsher","63","mboulsherqx@domainmarket.com","25.218.772","10-5452-4350"));
			listaClientes.Add(new Cliente("Fenelia","Pering","90","fperingqy@geocities.jp","29.376.043","12-1677-5060"));
			listaClientes.Add(new Cliente("Aggy","Tolson","68","atolsonqz@wired.com","43.553.139","15-6498-2306"));
			listaClientes.Add(new Cliente("Caron","MacKey","49","cmackeyr0@ucsd.edu","43.368.166","12-3137-7735"));
			listaClientes.Add(new Cliente("Nicolette","Leckie","59","nleckier1@ft.com","12.731.362","67-5669-1446"));
			listaClientes.Add(new Cliente("Rutherford","Gilpin","43","rgilpinr2@alexa.com","22.026.373","28-2270-4268"));
			listaClientes.Add(new Cliente("Adelina","Laminman","40","alaminmanr3@usa.gov","69.966.645","82-4945-2456"));
			listaClientes.Add(new Cliente("Nelie","Beri","78","nberir4@ocn.ne.jp","48.685.659","22-9959-9010"));
			listaClientes.Add(new Cliente("Caroline","Storry","80","cstorryr5@dedecms.com","12.931.938","76-4525-3598"));
			listaClientes.Add(new Cliente("Niki","Davy","77","ndavyr6@marriott.com","71.571.843","04-8711-0783"));
			listaClientes.Add(new Cliente("Lawrence","McHarg","73","lmchargr7@virginia.edu","57.734.909","08-0017-3369"));
			listaClientes.Add(new Cliente("Ada","Hedin","78","ahedinr8@instagram.com","55.022.543","91-3076-7711"));
			listaClientes.Add(new Cliente("Rosamund","Rodbourne","64","rrodbourner9@imageshack.us","78.173.765","87-5192-6671"));
			listaClientes.Add(new Cliente("Ericka","McCaghan","40","emccaghanra@bloglovin.com","68.771.926","74-3880-3463"));
			listaClientes.Add(new Cliente("Vivie","Fitch","24","vfitchrb@acquirethisname.com","73.850.292","13-8034-5759"));
			listaClientes.Add(new Cliente("Clemmie","Piperley","25","cpiperleyrc@statcounter.com","20.116.471","01-9657-9109"));
			listaClientes.Add(new Cliente("Garfield","Seggie","20","gseggierd@squarespace.com","72.810.011","40-0326-1249"));
			listaClientes.Add(new Cliente("Friederike","Ashforth","30","fashforthre@globo.com","93.560.829","48-8086-2669"));
			listaClientes.Add(new Cliente("Florence","Struis","81","fstruisrf@pagesperso-orange.fr","00.297.432","74-8559-6599"));
			listaClientes.Add(new Cliente("Georgena","Wloch","43","gwlochrg@cloudflare.com","05.973.136","03-7737-9730"));
			listaClientes.Add(new Cliente("Damita","Anthoin","76","danthoinrh@disqus.com","06.136.308","81-3491-3508"));
			listaClientes.Add(new Cliente("Rosalinda","Djurdjevic","34","rdjurdjevicri@state.tx.us","14.284.100","17-5175-6776"));
			listaClientes.Add(new Cliente("Orly","Wickey","43","owickeyrj@sciencedirect.com","49.465.391","30-2544-4499"));
			listaClientes.Add(new Cliente("Denys","Pickford","51","dpickfordrk@ezinearticles.com","21.526.063","33-8816-2863"));
			listaClientes.Add(new Cliente("Egan","Punch","37","epunchrl@usda.gov","66.930.022","37-5057-2791"));
			listaClientes.Add(new Cliente("Janeta","Wellan","78","jwellanrm@disqus.com","71.709.085","48-3124-8341"));
			listaClientes.Add(new Cliente("Keri","Canning","44","kcanningrn@yelp.com","43.380.823","34-2578-6693"));
			listaClientes.Add(new Cliente("Felice","Englefield","65","fenglefieldro@wikia.com","45.844.543","85-7705-9953"));
			listaClientes.Add(new Cliente("Kirk","Miskelly","70","kmiskellyrp@microsoft.com","73.167.539","05-4692-1553"));
			listaClientes.Add(new Cliente("Burl","Kristof","65","bkristofrq@amazon.com","80.044.210","75-1099-7091"));
			listaClientes.Add(new Cliente("Carri","Rotherham","60","crotherhamrr@redcross.org","16.471.588","63-3782-4247"));
		}
		public static void PrecargarAviones() {
			for(int i = 0;i<100;i++) {
				Sistema.listaDeAviones.Add(new Avion(Sistema.GenerarCodigoAlfanumericoRandom(), Sistema.GenerarNumeroRandom(200,500), Sistema.GenerarNumeroRandom(8,15), Sistema.GenerarNumeroRandom(15000,20000), Sistema.GenerarRandomBool(), Sistema.GenerarNumeroRandom(15000,21000)));
			}
		}
		public static void PrecargarUsuario() {
			Sistema.listaUsuarios.Add(new Usuario("PepePeposo","pepe1","Lucas","Rodriguez","34","ejemplo@gmail.com","34.654.321","11-9375-4519"));
			Sistema.listaUsuarios.Add(new Usuario("Tanito","maggiori2d","Gianni","Maggiori","30","taniitoo@gmail.com","94.270.046","11-5220-6650"));
			Sistema.listaUsuarios.Add(new Usuario("Hoop","gatito11","Gatito Hooper","Felino","21","gatitoNaranjoso@gmail.com","54.158.199","11-5731-9086"));
			Sistema.listaUsuarios.Add(new Usuario("May","magia2008","Mayra","Maestu","28","mayra@estonoesunmail.com","37.788.155","11-3184-3365"));
			Sistema.listaUsuarios.Add(new Usuario("ezetabo","123contraseñajaja","Ezequiel","Taboada","42","estemailtampocoesreal@nomail.com","34.159.159","11-5555-9455"));
		}
		public static void PrecargarVuelos() {
			Sistema.GenerarVuelo(50,"Buenos Aires","Recife, Brasil");
			Sistema.GenerarVuelo(50,"Buenos Aires","Roma, Italia");
			Sistema.GenerarVuelo(50,"Buenos Aires","Acapulco, México");
			Sistema.GenerarVuelo(50,"Buenos Aires","Miami, EEUU");
			Sistema.GenerarVuelo(50,"Recife, Brasil","Buenos Aires");
			Sistema.GenerarVuelo(50,"Roma, Italia","Buenos Aires");
			Sistema.GenerarVuelo(50,"Acapulco, México","Buenos Aires");
			Sistema.GenerarVuelo(50,"Miami, EEUU","Buenos Aires");
			Sistema.GenerarVuelo(50,"Buenos Aires","Santa Rosa");
			Sistema.GenerarVuelo(50,"Buenos Aires","Bariloche");
			Sistema.GenerarVuelo(50,"Buenos Aires","Corrientes");
			Sistema.GenerarVuelo(50,"Buenos Aires","Córdoba");
			Sistema.GenerarVuelo(50,"Buenos Aires","Jujuy");
			Sistema.GenerarVuelo(50,"Buenos Aires","Mendoza");
			Sistema.GenerarVuelo(50,"Buenos Aires","Neuquén");
			Sistema.GenerarVuelo(50,"Buenos Aires","Posadas");
			Sistema.GenerarVuelo(50,"Buenos Aires","Iguazú");
			Sistema.GenerarVuelo(50,"Buenos Aires","Salta");
			Sistema.GenerarVuelo(50,"Buenos Aires","Santiago del Estero");
			Sistema.GenerarVuelo(50,"Buenos Aires","Trelew");
			Sistema.GenerarVuelo(50,"Buenos Aires","Tucumán");
			Sistema.GenerarVuelo(50,"Buenos Aires","Puerto Madryn");
			Sistema.GenerarVuelo(50,"Buenos Aires","Ushuaia");
			Sistema.GenerarVuelo(50,"Santa Rosa","Buenos Aires");
			Sistema.GenerarVuelo(50,"Santa Rosa","Bariloche");
			Sistema.GenerarVuelo(50,"Santa Rosa","Corrientes");
			Sistema.GenerarVuelo(50,"Santa Rosa","Córdoba");
			Sistema.GenerarVuelo(50,"Santa Rosa","Jujuy");
			Sistema.GenerarVuelo(50,"Santa Rosa","Mendoza");
			Sistema.GenerarVuelo(50,"Santa Rosa","Neuquén");
			Sistema.GenerarVuelo(50,"Santa Rosa","Posadas");
			Sistema.GenerarVuelo(50,"Santa Rosa","Iguazú");
			Sistema.GenerarVuelo(50,"Santa Rosa","Salta");
			Sistema.GenerarVuelo(50,"Santa Rosa","Santiago del Estero");
			Sistema.GenerarVuelo(50,"Santa Rosa","Trelew");
			Sistema.GenerarVuelo(50,"Santa Rosa","Tucumán");
			Sistema.GenerarVuelo(50,"Santa Rosa","Puerto Madryn");
			Sistema.GenerarVuelo(50,"Santa Rosa","Ushuaia");
			Sistema.GenerarVuelo(50,"Bariloche","Buenos Aires");
			Sistema.GenerarVuelo(50,"Bariloche","Santa Rosa");
			Sistema.GenerarVuelo(50,"Bariloche","Corrientes");
			Sistema.GenerarVuelo(50,"Bariloche","Córdoba");
			Sistema.GenerarVuelo(50,"Bariloche","Jujuy");
			Sistema.GenerarVuelo(50,"Bariloche","Mendoza");
			Sistema.GenerarVuelo(50,"Bariloche","Neuquén");
			Sistema.GenerarVuelo(50,"Bariloche","Posadas");
			Sistema.GenerarVuelo(50,"Bariloche","Iguazú");
			Sistema.GenerarVuelo(50,"Bariloche","Salta");
			Sistema.GenerarVuelo(50,"Bariloche","Santiago del Estero");
			Sistema.GenerarVuelo(50,"Bariloche","Trelew");
			Sistema.GenerarVuelo(50,"Bariloche","Tucumán");
			Sistema.GenerarVuelo(50,"Bariloche","Puerto Madryn");
			Sistema.GenerarVuelo(50,"Bariloche","Ushuaia");
			Sistema.GenerarVuelo(50,"Corrientes","Buenos Aires");
			Sistema.GenerarVuelo(50,"Corrientes","Santa Rosa");
			Sistema.GenerarVuelo(50,"Corrientes","Bariloche");
			Sistema.GenerarVuelo(50,"Corrientes","Córdoba");
			Sistema.GenerarVuelo(50,"Corrientes","Jujuy");
			Sistema.GenerarVuelo(50,"Corrientes","Mendoza");
			Sistema.GenerarVuelo(50,"Corrientes","Neuquén");
			Sistema.GenerarVuelo(50,"Corrientes","Posadas");
			Sistema.GenerarVuelo(50,"Corrientes","Iguazú");
			Sistema.GenerarVuelo(50,"Corrientes","Salta");
			Sistema.GenerarVuelo(50,"Corrientes","Santiago del Estero");
			Sistema.GenerarVuelo(50,"Corrientes","Trelew");
			Sistema.GenerarVuelo(50,"Corrientes","Tucumán");
			Sistema.GenerarVuelo(50,"Corrientes","Puerto Madryn");
			Sistema.GenerarVuelo(50,"Corrientes","Ushuaia");
			Sistema.GenerarVuelo(50,"Córdoba","Buenos Aires");
			Sistema.GenerarVuelo(50,"Córdoba","Santa Rosa");
			Sistema.GenerarVuelo(50,"Córdoba","Bariloche");
			Sistema.GenerarVuelo(50,"Córdoba","Corrientes");
			Sistema.GenerarVuelo(50,"Córdoba","Jujuy");
			Sistema.GenerarVuelo(50,"Córdoba","Mendoza");
			Sistema.GenerarVuelo(50,"Córdoba","Neuquén");
			Sistema.GenerarVuelo(50,"Córdoba","Posadas");
			Sistema.GenerarVuelo(50,"Córdoba","Iguazú");
			Sistema.GenerarVuelo(50,"Córdoba","Salta");
			Sistema.GenerarVuelo(50,"Córdoba","Santiago del Estero");
			Sistema.GenerarVuelo(50,"Córdoba","Trelew");
			Sistema.GenerarVuelo(50,"Córdoba","Tucumán");
			Sistema.GenerarVuelo(50,"Córdoba","Puerto Madryn");
			Sistema.GenerarVuelo(50,"Córdoba","Ushuaia");
			Sistema.GenerarVuelo(50,"Jujuy","Buenos Aires");
			Sistema.GenerarVuelo(50,"Jujuy","Santa Rosa");
			Sistema.GenerarVuelo(50,"Jujuy","Bariloche");
			Sistema.GenerarVuelo(50,"Jujuy","Corrientes");
			Sistema.GenerarVuelo(50,"Jujuy","Córdoba");
			Sistema.GenerarVuelo(50,"Jujuy","Mendoza");
			Sistema.GenerarVuelo(50,"Jujuy","Neuquén");
			Sistema.GenerarVuelo(50,"Jujuy","Posadas");
			Sistema.GenerarVuelo(50,"Jujuy","Iguazú");
			Sistema.GenerarVuelo(50,"Jujuy","Salta");
			Sistema.GenerarVuelo(50,"Jujuy","Santiago del Estero");
			Sistema.GenerarVuelo(50,"Jujuy","Trelew");
			Sistema.GenerarVuelo(50,"Jujuy","Tucumán");
			Sistema.GenerarVuelo(50,"Jujuy","Puerto Madryn");
			Sistema.GenerarVuelo(50,"Jujuy","Ushuaia");
			Sistema.GenerarVuelo(50,"Mendoza","Buenos Aires");
			Sistema.GenerarVuelo(50,"Mendoza","Santa Rosa");
			Sistema.GenerarVuelo(50,"Mendoza","Bariloche");
			Sistema.GenerarVuelo(50,"Mendoza","Corrientes");
			Sistema.GenerarVuelo(50,"Mendoza","Córdoba");
			Sistema.GenerarVuelo(50,"Mendoza","Jujuy");
			Sistema.GenerarVuelo(50,"Mendoza","Neuquén");
			Sistema.GenerarVuelo(50,"Mendoza","Posadas");
			Sistema.GenerarVuelo(50,"Mendoza","Iguazú");
			Sistema.GenerarVuelo(50,"Mendoza","Salta");
			Sistema.GenerarVuelo(50,"Mendoza","Santiago del Estero");
			Sistema.GenerarVuelo(50,"Mendoza","Trelew");
			Sistema.GenerarVuelo(50,"Mendoza","Tucumán");
			Sistema.GenerarVuelo(50,"Mendoza","Puerto Madryn");
			Sistema.GenerarVuelo(50,"Mendoza","Ushuaia");
			Sistema.GenerarVuelo(50,"Neuquén","Buenos Aires");
			Sistema.GenerarVuelo(50,"Neuquén","Santa Rosa");
			Sistema.GenerarVuelo(50,"Neuquén","Bariloche");
			Sistema.GenerarVuelo(50,"Neuquén","Corrientes");
			Sistema.GenerarVuelo(50,"Neuquén","Córdoba");
			Sistema.GenerarVuelo(50,"Neuquén","Jujuy");
			Sistema.GenerarVuelo(50,"Neuquén","Mendoza");
			Sistema.GenerarVuelo(50,"Neuquén","Posadas");
			Sistema.GenerarVuelo(50,"Neuquén","Iguazú");
			Sistema.GenerarVuelo(50,"Neuquén","Salta");
			Sistema.GenerarVuelo(50,"Neuquén","Santiago del Estero");
			Sistema.GenerarVuelo(50,"Neuquén","Trelew");
			Sistema.GenerarVuelo(50,"Neuquén","Tucumán");
			Sistema.GenerarVuelo(50,"Neuquén","Puerto Madryn");
			Sistema.GenerarVuelo(50,"Neuquén","Ushuaia");
			Sistema.GenerarVuelo(50,"Posadas","Buenos Aires");
			Sistema.GenerarVuelo(50,"Posadas","Santa Rosa");
			Sistema.GenerarVuelo(50,"Posadas","Bariloche");
			Sistema.GenerarVuelo(50,"Posadas","Corrientes");
			Sistema.GenerarVuelo(50,"Posadas","Córdoba");
			Sistema.GenerarVuelo(50,"Posadas","Jujuy");
			Sistema.GenerarVuelo(50,"Posadas","Mendoza");
			Sistema.GenerarVuelo(50,"Posadas","Neuquén");
			Sistema.GenerarVuelo(50,"Posadas","Iguazú");
			Sistema.GenerarVuelo(50,"Posadas","Salta");
			Sistema.GenerarVuelo(50,"Posadas","Santiago del Estero");
			Sistema.GenerarVuelo(50,"Posadas","Trelew");
			Sistema.GenerarVuelo(50,"Posadas","Tucumán");
			Sistema.GenerarVuelo(50,"Posadas","Puerto Madryn");
			Sistema.GenerarVuelo(50,"Posadas","Ushuaia");
			Sistema.GenerarVuelo(50,"Iguazú","Buenos Aires");
			Sistema.GenerarVuelo(50,"Iguazú","Santa Rosa");
			Sistema.GenerarVuelo(50,"Iguazú","Bariloche");
			Sistema.GenerarVuelo(50,"Iguazú","Corrientes");
			Sistema.GenerarVuelo(50,"Iguazú","Córdoba");
			Sistema.GenerarVuelo(50,"Iguazú","Jujuy");
			Sistema.GenerarVuelo(50,"Iguazú","Mendoza");
			Sistema.GenerarVuelo(50,"Iguazú","Neuquén");
			Sistema.GenerarVuelo(50,"Iguazú","Posadas");
			Sistema.GenerarVuelo(50,"Iguazú","Salta");
			Sistema.GenerarVuelo(50,"Iguazú","Santiago del Estero");
			Sistema.GenerarVuelo(50,"Iguazú","Trelew");
			Sistema.GenerarVuelo(50,"Iguazú","Tucumán");
			Sistema.GenerarVuelo(50,"Iguazú","Puerto Madryn");
			Sistema.GenerarVuelo(50,"Iguazú","Ushuaia");
			Sistema.GenerarVuelo(50,"Salta","Buenos Aires");
			Sistema.GenerarVuelo(50,"Salta","Santa Rosa");
			Sistema.GenerarVuelo(50,"Salta","Bariloche");
			Sistema.GenerarVuelo(50,"Salta","Corrientes");
			Sistema.GenerarVuelo(50,"Salta","Córdoba");
			Sistema.GenerarVuelo(50,"Salta","Jujuy");
			Sistema.GenerarVuelo(50,"Salta","Mendoza");
			Sistema.GenerarVuelo(50,"Salta","Neuquén");
			Sistema.GenerarVuelo(50,"Salta","Posadas");
			Sistema.GenerarVuelo(50,"Salta","Iguazú");
			Sistema.GenerarVuelo(50,"Salta","Santiago del Estero");
			Sistema.GenerarVuelo(50,"Salta","Trelew");
			Sistema.GenerarVuelo(50,"Salta","Tucumán");
			Sistema.GenerarVuelo(50,"Salta","Puerto Madryn");
			Sistema.GenerarVuelo(50,"Salta","Ushuaia");
			Sistema.GenerarVuelo(50,"Santiago del Estero","Buenos Aires");
			Sistema.GenerarVuelo(50,"Santiago del Estero","Santa Rosa");
			Sistema.GenerarVuelo(50,"Santiago del Estero","Bariloche");
			Sistema.GenerarVuelo(50,"Santiago del Estero","Corrientes");
			Sistema.GenerarVuelo(50,"Santiago del Estero","Córdoba");
			Sistema.GenerarVuelo(50,"Santiago del Estero","Jujuy");
			Sistema.GenerarVuelo(50,"Santiago del Estero","Mendoza");
			Sistema.GenerarVuelo(50,"Santiago del Estero","Neuquén");
			Sistema.GenerarVuelo(50,"Santiago del Estero","Posadas");
			Sistema.GenerarVuelo(50,"Santiago del Estero","Iguazú");
			Sistema.GenerarVuelo(50,"Santiago del Estero","Salta");
			Sistema.GenerarVuelo(50,"Santiago del Estero","Trelew");
			Sistema.GenerarVuelo(50,"Santiago del Estero","Tucumán");
			Sistema.GenerarVuelo(50,"Santiago del Estero","Puerto Madryn");
			Sistema.GenerarVuelo(50,"Santiago del Estero","Ushuaia");
			Sistema.GenerarVuelo(50,"Trelew","Buenos Aires");
			Sistema.GenerarVuelo(50,"Trelew","Santa Rosa");
			Sistema.GenerarVuelo(50,"Trelew","Bariloche");
			Sistema.GenerarVuelo(50,"Trelew","Corrientes");
			Sistema.GenerarVuelo(50,"Trelew","Córdoba");
			Sistema.GenerarVuelo(50,"Trelew","Jujuy");
			Sistema.GenerarVuelo(50,"Trelew","Mendoza");
			Sistema.GenerarVuelo(50,"Trelew","Neuquén");
			Sistema.GenerarVuelo(50,"Trelew","Posadas");
			Sistema.GenerarVuelo(50,"Trelew","Iguazú");
			Sistema.GenerarVuelo(50,"Trelew","Salta");
			Sistema.GenerarVuelo(50,"Trelew","Santiago del Estero");
			Sistema.GenerarVuelo(50,"Trelew","Tucumán");
			Sistema.GenerarVuelo(50,"Trelew","Puerto Madryn");
			Sistema.GenerarVuelo(50,"Trelew","Ushuaia");
			Sistema.GenerarVuelo(50,"Puerto Madryn","Buenos Aires");
			Sistema.GenerarVuelo(50,"Puerto Madryn","Santa Rosa");
			Sistema.GenerarVuelo(50,"Puerto Madryn","Bariloche");
			Sistema.GenerarVuelo(50,"Puerto Madryn","Corrientes");
			Sistema.GenerarVuelo(50,"Puerto Madryn","Córdoba");
			Sistema.GenerarVuelo(50,"Puerto Madryn","Jujuy");
			Sistema.GenerarVuelo(50,"Puerto Madryn","Mendoza");
			Sistema.GenerarVuelo(50,"Puerto Madryn","Neuquén");
			Sistema.GenerarVuelo(50,"Puerto Madryn","Posadas");
			Sistema.GenerarVuelo(50,"Puerto Madryn","Iguazú");
			Sistema.GenerarVuelo(50,"Puerto Madryn","Salta");
			Sistema.GenerarVuelo(50,"Puerto Madryn","Santiago del Estero");
			Sistema.GenerarVuelo(50,"Puerto Madryn","Trelew");
			Sistema.GenerarVuelo(50,"Puerto Madryn","Tucumán");
			Sistema.GenerarVuelo(50,"Puerto Madryn","Ushuaia");
			Sistema.GenerarVuelo(50,"Ushuaia","Buenos Aires");
			Sistema.GenerarVuelo(50,"Ushuaia","Santa Rosa");
			Sistema.GenerarVuelo(50,"Ushuaia","Bariloche");
			Sistema.GenerarVuelo(50,"Ushuaia","Corrientes");
			Sistema.GenerarVuelo(50,"Ushuaia","Córdoba");
			Sistema.GenerarVuelo(50,"Ushuaia","Jujuy");
			Sistema.GenerarVuelo(50,"Ushuaia","Mendoza");
			Sistema.GenerarVuelo(50,"Ushuaia","Neuquén");
			Sistema.GenerarVuelo(50,"Ushuaia","Posadas");
			Sistema.GenerarVuelo(50,"Ushuaia","Iguazú");
			Sistema.GenerarVuelo(50,"Ushuaia","Salta");
			Sistema.GenerarVuelo(50,"Ushuaia","Santiago del Estero");
			Sistema.GenerarVuelo(50,"Ushuaia","Trelew");
			Sistema.GenerarVuelo(50,"Ushuaia","Tucumán");
			Sistema.GenerarVuelo(50,"Ushuaia","Puerto Madryn");
		}
		public static Usuario? ValidarDatosUsuarioExistente(string nombreDeUsuario, string contraseña) {
			if(nombreDeUsuario is not null && contraseña is not null) {
				foreach(Usuario item in listaUsuarios) {
					if(item.NombreDeUsuario==nombreDeUsuario && item.Contraseña==contraseña) {
						return item;
					}
				}
			}
			return null;
		}
		public static bool AgregarNuevoUsuario(string nombre, string apellido, string nombreDeUsuario, string contraseña, string email, string dni, string numeroTelefono, string edad) {
			if(!string.IsNullOrEmpty(nombre)&&!string.IsNullOrEmpty(apellido)&&!string.IsNullOrEmpty(nombreDeUsuario)&&!string.IsNullOrEmpty(contraseña)&&!string.IsNullOrEmpty(email)&&!string.IsNullOrEmpty(dni)&&!string.IsNullOrEmpty(numeroTelefono)) {
				listaUsuarios.Add(new Usuario(nombreDeUsuario.Trim(),contraseña.Trim(),nombre.Trim(), apellido.Trim(),edad.Trim(), email.Trim(), dni.Trim(), numeroTelefono.Trim()));
				return true;
			}
			return false;
		}
		public static int ObtenerIndiceClientePorDni(string dni) {
			foreach(var item in ListaClientes) {
				if(item.Dni==dni) {
					return listaClientes.IndexOf(item);
				}
			}
			return -1;
		}
		public static Avion? EncontrarAvionPorPatente(string patente) {
			foreach(Avion item in Sistema.listaDeAviones) {
				if(item.Patente ==patente) {
					return item;
				}
			}
			return null;
		}
		public static Dictionary<string, bool> CargarDiccionarioDeDestinos(List<Destino> listaDestino) {
			Dictionary<string, bool> dic = new Dictionary<string, bool>();
			foreach(Destino item in listaDestino) {
				dic.Add(item.Ciudad,item.EsInternacional);
			}
			return dic;
		}
		public static bool EsInternacional(string destino) {
			foreach(KeyValuePair<string,bool> item in diccionarioDestinos) {
				if(item.Key==destino) {
					return item.Value;
				}
			}
			return false;
		}
		public static List<Vuelo> BuscarVueloDisponible(string origen, string destino, int cantidadTickets, bool primeraClase) {
			List<Vuelo> lista = new List<Vuelo>();
			if(origen is not null && destino is not null && cantidadTickets>0) {
				foreach(Vuelo item in Sistema.listaVuelos) {
					if(item.Avion.EstaEnVuelo=="Aún no despegó") {
						if(item.Origen==origen && item.Destino==destino && item.Fecha>=DateTime.Now) {
							if(primeraClase) {
								if(item.Avion.AsientosPrimerClase>=cantidadTickets) {
									lista.Add(item);
								}
							}
							else {
								if(item.Avion.AsientosComercial>=cantidadTickets) {
									lista.Add(item);
								}
							}
						}
					}
				}
			}
			return lista;
		}
		public static List<Vuelo> BuscarVuelosPorFecha(bool esViejo) {
			List<Vuelo> lista = new List<Vuelo>();
			foreach(Vuelo item in Sistema.listaVuelos) {
				if((esViejo && item.Fecha<DateTime.Now) || (!esViejo && item.Fecha>=DateTime.Now)) {
					lista.Add(item);
				}
			}
			return lista;
		}
		public static bool BuscarClienteEnPasajeros(Cliente cliente, List<Pasajero> listaCliente) {
			if(cliente is not null && listaCliente is not null) {
				foreach(Pasajero item in listaCliente) {
					if(item.Dni==cliente.Dni) {
						return true;
					}
				}
			}
			return false;
		}
		public static void CargarVuelo(Vuelo vuelo, List<Pasajero> pasajeros) {
			if (pasajeros is not null && pasajeros.Count>0 && vuelo is not null && vuelo.Disponibilidad>0) {
				vuelo.PasajerosAbordo.AddRange(pasajeros);
			}
		}
		public static int ActualizarCantidadDeHorasDeVuelo(Avion avion, Vuelo vuelo) {
			int retorno=0;
			if(avion is not null && vuelo is not null) {
				retorno=avion.HorasDeVuelo+vuelo.Duracion;
			}
			return retorno;
		}
		public static double CalcularPesoValijas(bool esPremium) {
			Random random = new Random();
			if(esPremium) {
				return random.Next(12,42);
			}
			else {
				return random.Next(8,25);
			}
		}
		public static string MostrarDatosEquipajeReportado(bool tieneBolsoDeMano, bool esPrimeraClase, double pesoValijas) {
			StringBuilder sb= new StringBuilder();
			if(tieneBolsoDeMano && esPrimeraClase) {
				sb.AppendLine($"Tiene bolso de mano,");
				sb.AppendLine($"y reportó {pesoValijas} Kg's");
				sb.AppendLine($"de equipaje");
			}
			else {
				sb.AppendLine($"No tiene bolso de mano,");
				sb.AppendLine($"y reportó {pesoValijas} Kg's");
				sb.AppendLine($"de equipaje");
			}
			return sb.ToString();
		}
		public static List<Vuelo>? GenerarHistorialDeVuelos(string patente, List<Vuelo> listaBuscar) {
			List<Vuelo> lista = new List<Vuelo>();
			if(patente is not null) {
				foreach(Vuelo item in listaBuscar) {
					if(item.Avion.Patente==patente) {
						lista.Add(item);
					}
				}
			}
			return lista;
		}
		public static double CalcularPrecioDeVuelo(bool esInternacional, int duracionVuelo) {
			double precioDelVuelo;
			//int conversionPesoDolar=310;

			if(esInternacional) {
				precioDelVuelo=duracionVuelo*100;
			}
			else {
				precioDelVuelo=duracionVuelo*50;
			}
			return precioDelVuelo;
		}
		public static void CalcularPrecioPasaje(double precioVuelo, Pasajero pasajero) {
			double precioAditivo=0;
			if(pasajero is not null) {
				if(pasajero.ContratoPeliculas) {
					precioAditivo+=precioVuelo*1.05;
				}
				if(pasajero.ContratoWifi) {
					precioAditivo+=precioVuelo*1.03;
				}
				if(pasajero.TipoComida.ToString()=="Carne" || pasajero.TipoComida.ToString()=="Pollo" || pasajero.TipoComida.ToString()=="Sin_TACC" ||pasajero.TipoComida.ToString()=="Vegana") {
					precioAditivo+=precioVuelo*1.08;
				}
				precioAditivo+=precioVuelo;
				if(pasajero.PrimeraClase) {
					precioAditivo+=(precioAditivo*15/100);
				}
				pasajero.Precio=precioAditivo*1.21;
			}
		}
		public static double CalcularPrecioPasajes(List<Pasajero> pasajeros) {
			double recaudacionDeLaVenta=0;
			if(pasajeros is not null) {
				foreach(Pasajero item in pasajeros) {
					recaudacionDeLaVenta+=item.Precio;
				}
			}
			return recaudacionDeLaVenta;
		}
		public static void CalcularRecaudacionVuelo(Vuelo vuelo) {
			double acumuladorPrecio=0;
			foreach(Pasajero item in vuelo.PasajerosAbordo) {
				acumuladorPrecio+=item.Precio;
			}
			vuelo.Recaudacion=acumuladorPrecio;
		}
		public static bool GenerarRandomBool() {
			Random random=new Random();
			int numeroRandom=random.Next(1, 100);
			if(numeroRandom%2==0) {
				return true;
			}
			return false;
		}
		public static int GenerarNumeroRandom(int numeroMinimo, int numeroMaximo) {
			Random random = new Random();
			return random.Next(numeroMinimo, numeroMaximo);
		}
		public static string GenerarCodigoAlfanumericoRandom() {
			string caracteresPermitidos = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Char[] ticket = new char[8];
            Random random = new Random();
            for (int i = 0; i < ticket.Length; i++){
                ticket[i] = caracteresPermitidos[random.Next(caracteresPermitidos.Length)];
            }
            string stringRetorno = new String(ticket);
			return stringRetorno;
		}
		public static DateTime GenerarFechaRandom(bool esFechaDelPasado) {
			Random random= new Random();
			DateTime dateTime = DateTime.Now;
			DateTime fechaRetorno;
			if(esFechaDelPasado) {
				do {
					fechaRetorno=new DateTime(random.Next(2015,2022), random.Next(1,12), random.Next(1,28));
				}while(fechaRetorno>=dateTime);
			}
			else {
				return new DateTime(random.Next(2023, 2030),random.Next(1,12),random.Next(1,28));
			}
			return fechaRetorno;
		}
		public static void GenerarVuelo(int cantidad, string origen, string destino) {
			for(int i = 0; i < cantidad;i++) {
				Sistema.listaVuelos.Add(new Vuelo(listaDeAviones[Sistema.GenerarNumeroRandom(0,Sistema.listaDeAviones.Count)],origen, destino, Sistema.GenerarFechaRandom(Sistema.GenerarRandomBool())));
			}
		}
		public static int CalcularCantidadDeAsientosPrimeraClaseDisponibles(Vuelo vuelo) {
			int contadorPasajerosPrimeraClase=0;
			if(vuelo is not null) {
				foreach(Pasajero item in vuelo.PasajerosAbordo) {
					if(item.PrimeraClase) {
						contadorPasajerosPrimeraClase++;
					}
				}
			}
			return vuelo!.Avion.AsientosPrimerClase-contadorPasajerosPrimeraClase;
		}
		public static int CalcularCantidadDeAsientosComercialDisponibles(Vuelo vuelo) {
			int contadorPasajerosComercialClase=0;
			if(vuelo is not null) {
				foreach(Pasajero item in vuelo.PasajerosAbordo) {
					if(!item.PrimeraClase) {
						contadorPasajerosComercialClase++;
					}
				}
			}
			return vuelo!.Avion.AsientosComercial-contadorPasajerosComercialClase;
		}
		public static void PrecargarVuelosConPasajeros() {
			Random random = new Random();
			foreach(Vuelo item in Sistema.listaVuelos) {
				for(int i = 0;i<random.Next(150, item.Avion.CapacidadDeAsientos);i++) {

					if(GenerarRandomBool() && Sistema.CalcularCantidadDeAsientosPrimeraClaseDisponibles(item)>0) {
						
						item.PasajerosAbordo.Add(new Pasajero(Sistema.CalcularPesoValijas(true), Sistema.GenerarNumeroRandom(1,5), Sistema.GenerarRandomBool(),Comida.Refrigerio, true, Sistema.GenerarRandomBool(),Sistema.listaClientes[random.Next(0,listaClientes.Count)],Sistema.GenerarRandomBool()));
					}
					else if(Sistema.CalcularCantidadDeAsientosComercialDisponibles(item)>0) {
						item.PasajerosAbordo.Add(new (Sistema.CalcularPesoValijas(false), Sistema.GenerarNumeroRandom(1,5), Sistema.GenerarRandomBool(),Comida.Refrigerio, false, Sistema.GenerarRandomBool(),Sistema.listaClientes[random.Next(0,listaClientes.Count)],Sistema.GenerarRandomBool()));
					}
				}
				Sistema.CalcularPrecioPasajerosHardcodeados(item);
				Sistema.CalcularRecaudacionVuelo(item);
			}
		}
		private static void CalcularPrecioPasajerosHardcodeados(Vuelo vuelo) {
			foreach(Pasajero item in vuelo.PasajerosAbordo) {
				Sistema.CalcularPrecioPasaje(vuelo.Precio, item);
			}
		}
		public static void ModificarUsuario(Usuario usuario) {
			for(int i = 0;i<Sistema.listaUsuarios.Count;i++) {
				if(Sistema.listaUsuarios[i].Dni==usuario.Dni) {
					Sistema.listaUsuarios[i]=usuario;
					break;
				}
			}
		}
		public static int CalcularElTiempoDeVuelo(bool esInternacional) {
			Random random=new Random();
			if(esInternacional) {
				return random.Next(8,12);
			}
			else {
				return random.Next(2,4);
			}
		}
		public static string MostrarDatosDeUnAvion(Avion avion) {
			StringBuilder sb=new StringBuilder();
			sb.AppendLine($"Patente: {avion.Patente}");
			sb.AppendLine($"Tiene una capacidad máxima de: {avion.CapacidadDeAsientos}");
			sb.AppendLine($"En primera clase: {avion.AsientosPrimerClase}");
			sb.AppendLine($"En clase comercial: {avion.AsientosComercial}");
			sb.AppendLine($"Cantidad de baños: {avion.CantidadDeBaños}");
			sb.AppendLine($"Capacidad máxima de Equipaje: {avion.PesoMaximo}");
			return sb.ToString();
		}
		public static double CalcularRecaudacionTotal() {
			double total = 0;
			foreach(Vuelo item in Sistema.listaVuelos) {
				total+=item.Recaudacion;
			}
			return Math.Round(total,2);
		}
		public static double CalcularRecaudacionInternacional() {
			double total=0;
			foreach(Vuelo item in Sistema.listaVuelos) {
				if(item.EsInternacional) {
					total=total+item.Recaudacion;
				}
			}
			return Math.Round(total,2);
		}
		public static double CalcularRecaudacionNacional() {
			double total=0;
			foreach(Vuelo item in Sistema.listaVuelos) {
				if(!item.EsInternacional) {
					total=total+item.Recaudacion;
				}
			}
			return Math.Round(total,2);
		}
	}
}
