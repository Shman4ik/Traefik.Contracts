using System.Text.Json.Serialization;

namespace Traefik.Contracts.TlcConfiguration
{
	public class Certificate
	{
		[JsonPropertyName("certFile")]
		public string CertFile { get; set; }

		[JsonPropertyName("keyFile")]
		public string KeyFile { get; set; }

		[JsonPropertyName("stores")]
		public string[] Stores { get; set; }
	}
}