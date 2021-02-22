namespace Traefik.Contracts.TcpConfiguration
{
	public class LoadBalancerTcpService : BaseTcpService
	{
		public LoadBalancer loadBalancer { get; set; }
	}
}