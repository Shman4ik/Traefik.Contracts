using Newtonsoft.Json;

namespace Traefik.Contracts.UdpConfiguration
{
	public class Weighted
	{
		[JsonProperty("services")]
		public Service[] Services { get; set; }
	}
}