using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration
{
	public class WeightedServer
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("weight")]
		public int Weight { get; set; }
	}
}