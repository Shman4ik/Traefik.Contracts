using System.Collections.Generic;
using Newtonsoft.Json;

namespace Traefik.Contracts.TlcConfiguration
{
	public class Tls
	{
		[JsonProperty("certificates")]
		public Certificate[] Certificates { get; set; }

		[JsonProperty("options")]
		public Dictionary<string, Options> Options { get; set; }

		[JsonProperty("stores")]
		public Dictionary<string, Store> Stores { get; set; }
	}
}