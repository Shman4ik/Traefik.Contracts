using Newtonsoft.Json;

namespace Traefik.Contracts.TcpConfiguration
{
	public class LoadBalancer
	{
		[JsonProperty("terminationDelay")]
		public int TerminationDelay { get; set; }

		[JsonProperty("proxyProtocol")]
		public ProxyProtocol ProxyProtocol { get; set; }

		[JsonProperty("servers")]
		public Server[] Servers { get; set; }
	}
}