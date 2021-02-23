using System.Text.Json.Serialization;

namespace Traefik.Contracts.TlcConfiguration
{
	public class DefaultCertificate
	{
		[JsonPropertyName("certFile")]
		public string CertFile { get; set; }

		[JsonPropertyName("keyFile")]
		public string KeyFile { get; set; }
	}
}