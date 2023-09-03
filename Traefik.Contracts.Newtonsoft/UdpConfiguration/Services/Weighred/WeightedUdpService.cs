using Newtonsoft.Json;

namespace Traefik.Contracts.UdpConfiguration
{
	public class WeightedUdpService : BaseUdpService
	{
		[JsonProperty("weighted")]
		public Weighted Weighted { get; set; }
	}
}