using System.Text.Json.Serialization;

namespace Traefik.Contracts.TcpConfiguration
{
	public class LoadBalancerTcpService : BaseTcpService
	{
		[JsonPropertyName("loadBalancer")]
		public LoadBalancer LoadBalancer { get; set; }
	}
}