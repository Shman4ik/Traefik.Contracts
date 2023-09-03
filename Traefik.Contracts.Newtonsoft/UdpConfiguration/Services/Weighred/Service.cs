using Newtonsoft.Json;

namespace Traefik.Contracts.UdpConfiguration
{
	public class Service
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("weight")]
		public int Weight { get; set; }
	}
}