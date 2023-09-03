using Newtonsoft.Json;

namespace Traefik.Contracts.TcpConfiguration
{
	public class Tls
	{
		[JsonProperty("passthrough")]
		public bool Passthrough { get; set; }

		[JsonProperty("options")]
		public string Options { get; set; }

		[JsonProperty("certResolver")]
		public string CertResolver { get; set; }

		[JsonProperty("domains")]
		public Domain[] Domains { get; set; }
	}
}