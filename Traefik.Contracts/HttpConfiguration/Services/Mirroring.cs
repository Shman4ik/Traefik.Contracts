using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration
{
	public class Mirroring
	{
		[JsonPropertyName("servers")]
		public string Service { get; set; }
		
		[JsonPropertyName("servers")]
		public int MaxBodySize { get; set; }
		
		[JsonPropertyName("servers")]
		public Mirror[] Mirrors { get; set; }
	}

}
