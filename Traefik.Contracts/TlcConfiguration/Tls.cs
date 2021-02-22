using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Traefik.Contracts.TlcConfiguration
{
	public class Tls
	{
		[JsonPropertyName("certificates")]
		public Certificate[] certificates { get; set; }

		[JsonPropertyName("options")]
		public Dictionary<string, Options> options { get; set; }

		[JsonPropertyName("stores")]
		public Dictionary<string, Store> stores { get; set; }
	}
}