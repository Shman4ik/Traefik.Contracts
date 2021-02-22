using System.Text.Json.Serialization;
using Traefik.Contracts.TcpConfiguration;

namespace Traefik.Contracts.UdpConfiguration
{
	public class WeightedUdpService : BaseUdpService
	{
		[JsonPropertyName("weighted")]
		public Weighted weighted { get; set; }
	}
}