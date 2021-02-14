namespace Traefik.Contracts
{
	public class Forwardauth
	{
		public string address { get; set; }
		public Tls2 tls { get; set; }
		public bool trustForwardHeader { get; set; }
		public string[] authResponseHeaders { get; set; }
		public string authResponseHeadersRegex { get; set; }
		public string[] authRequestHeaders { get; set; }
	}

}
