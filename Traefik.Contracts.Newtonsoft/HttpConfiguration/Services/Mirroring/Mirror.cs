using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration
{
	public class Mirror
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("percent")]
		public int Percent { get; set; }
	}
}