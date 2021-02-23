using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class ForwardAuth
	{
		[JsonPropertyName("address")]
		public string Address { get; set; }

		[JsonPropertyName("tls")]
		public Tls Tls { get; set; }

		[JsonPropertyName("trustForwardHeader")]
		public bool TrustForwardHeader { get; set; }

		[JsonPropertyName("authResponseHeaders")]
		public string[] AuthResponseHeaders { get; set; }

		[JsonPropertyName("authResponseHeadersRegex")]
		public string AuthResponseHeadersRegex { get; set; }

		[JsonPropertyName("authRequestHeaders")]
		public string[] AuthRequestHeaders { get; set; }
	}
}