using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration
{
	public class WeightedServer
	{
		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("weight")]
		public int Weight { get; set; }
	}
}