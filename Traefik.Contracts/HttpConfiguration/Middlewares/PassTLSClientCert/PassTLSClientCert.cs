using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	public class PassTLSClientCert
	{
		[JsonPropertyName("pem")]
		public bool Pem { get; set; }

		[JsonPropertyName("info")]
		public Info Info { get; set; }
	}
}