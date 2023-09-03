using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration
{
	public class Weighted
	{
		[JsonProperty("services")]
		public WeightedServer[] Services { get; set; }

		[JsonProperty("sticky")]
		public Sticky Sticky { get; set; }
	}
}