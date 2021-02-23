using System.Text.Json.Serialization;

namespace Traefik.Contracts.UdpConfiguration
{
	public class WeightedUdpService : BaseUdpService
	{
		[JsonPropertyName("weighted")]
		public Weighted Weighted { get; set; }
	}
}