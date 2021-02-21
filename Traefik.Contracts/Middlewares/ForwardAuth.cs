using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class ForwardAuth
	{
		[JsonPropertyName("address")]
		public string address { get; set; }
		[JsonPropertyName("tls")]
		public Tls tls { get; set; }
		[JsonPropertyName("trustForwardHeader")]
		public bool trustForwardHeader { get; set; }
		[JsonPropertyName("authResponseHeaders")]
		public string[] authResponseHeaders { get; set; }
		[JsonPropertyName("authResponseHeadersRegex")]
		public string authResponseHeadersRegex { get; set; }
		[JsonPropertyName("authRequestHeaders")]
		public string[] authRequestHeaders { get; set; }
	}

}
