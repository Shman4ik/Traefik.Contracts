using System.Text.Json.Serialization;

namespace Traefik.Contracts.TcpConfiguration
{
	public class Tls
	{
		[JsonPropertyName("passthrough")]
		public bool Passthrough { get; set; }

		[JsonPropertyName("options")]
		public string Options { get; set; }

		[JsonPropertyName("certResolver")]
		public string CertResolver { get; set; }

		[JsonPropertyName("domains")]
		public Domain[] Domains { get; set; }
	}
}