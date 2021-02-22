using System.Text.Json.Serialization;

namespace Traefik.Contracts.TlcConfiguration
{
	public class Certificate
	{
		[JsonPropertyName("certFile")]
		public string certFile { get; set; }
		[JsonPropertyName("keyFile")]
		public string keyFile { get; set; }
		[JsonPropertyName("stores")]
		public string[] stores { get; set; }
	}
}