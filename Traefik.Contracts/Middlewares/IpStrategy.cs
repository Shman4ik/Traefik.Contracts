using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class IpStrategy
	{
		[JsonPropertyName("depth")]
		public int depth { get; set; }
		[JsonPropertyName("excludedIPs")]
		public string[] excludedIPs { get; set; }
	}

}
