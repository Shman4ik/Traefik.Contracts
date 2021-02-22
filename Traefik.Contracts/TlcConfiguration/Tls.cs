using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Traefik.Contracts.TlcConfiguration
{
	public class Tls
	{
		[JsonPropertyName("certificates")]
		public Certificate[] Certificates { get; set; }

		[JsonPropertyName("options")]
		public Dictionary<string, Options> Options { get; set; }

		[JsonPropertyName("stores")]
		public Dictionary<string, Store> Stores { get; set; }
	}
}