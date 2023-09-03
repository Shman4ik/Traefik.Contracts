using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration
{
	public class Mirroring
	{
		[JsonProperty("service")]
		public string Service { get; set; }

		[JsonProperty("maxBodySize")]
		public int MaxBodySize { get; set; }

		[JsonProperty("mirrors")]
		public Mirror[] Mirrors { get; set; }
	}
}