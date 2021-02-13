using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration
{
	public class Tls
	{
		[JsonPropertyName("options")]
		public string Options { get; set; }
		[JsonPropertyName("certResolver")] 
		public string CertResolver { get; set; }
		[JsonPropertyName("domains")] 
		public Domain[] Domains { get; set; }
	}

}
