using Newtonsoft.Json;

namespace Traefik.Contracts.UdpConfiguration
{
	public class LoadBalancerUdpService : BaseUdpService
	{
		[JsonProperty("loadBalancer")]
		public LoadBalancer LoadBalancer { get; set; }
	}
}