using Newtonsoft.Json;

namespace Traefik.Contracts.TcpConfiguration
{
	public class LoadBalancerTcpService : BaseTcpService
	{
		[JsonProperty("loadBalancer")]
		public LoadBalancer LoadBalancer { get; set; }
	}
}