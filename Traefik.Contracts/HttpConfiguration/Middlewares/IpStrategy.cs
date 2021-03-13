using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	public class IpStrategy
	{
		[JsonPropertyName("depth")]
		public int Depth { get; set; }

		[JsonPropertyName("excludedIPs")]
		public string[] ExcludedIPs { get; set; }
	}
}