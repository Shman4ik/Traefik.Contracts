using System.Text.Json.Serialization;
using Traefik.Contracts.TcpConfiguration;

namespace Traefik.Contracts.UdpConfiguration
{
	public class LoadBalancerUdpService : BaseUdpService
	{
		[JsonPropertyName("loadBalancer")]
		public LoadBalancer loadBalancer { get; set; }
	}
}