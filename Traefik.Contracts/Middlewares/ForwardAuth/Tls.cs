using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class Tls
	{
		[JsonPropertyName("ca")]
		public string Ca { get; set; }
		[JsonPropertyName("caOptional")]
		public bool CaOptional { get; set; }
		[JsonPropertyName("cert")]
		public string Cert { get; set; }
		[JsonPropertyName("key")]
		public string Key { get; set; }
		[JsonPropertyName("insecureSkipVerify")]
		public bool InsecureSkipVerify { get; set; }
	}

}
