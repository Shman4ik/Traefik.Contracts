using System.Text.Json.Serialization;

namespace Traefik.Contracts.UdpConfiguration
{
	public class LoadBalancerUdpService : BaseUdpService
	{
		[JsonPropertyName("loadBalancer")]
		public LoadBalancer LoadBalancer { get; set; }
	}
}