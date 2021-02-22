using System.Text.Json.Serialization;

namespace Traefik.Contracts.TlcConfiguration
{
	public class DefaultCertificate
	{
		[JsonPropertyName("certFile")]
		public string certFile { get; set; }
		
		[JsonPropertyName("keyFile")]
		public string keyFile { get; set; }
	}
}