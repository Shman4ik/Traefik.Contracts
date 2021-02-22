using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class PassTLSClientCert
	{
		[JsonPropertyName("pem")]
		public bool pem { get; set; }
		[JsonPropertyName("info")]
		public Info info { get; set; }
	}

}
