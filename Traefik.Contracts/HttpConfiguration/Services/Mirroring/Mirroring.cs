using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration
{
	public class Mirroring
	{
		[JsonPropertyName("service")]
		public string Service { get; set; }

		[JsonPropertyName("maxBodySize")]
		public int MaxBodySize { get; set; }

		[JsonPropertyName("mirrors")]
		public Mirror[] Mirrors { get; set; }
	}
}