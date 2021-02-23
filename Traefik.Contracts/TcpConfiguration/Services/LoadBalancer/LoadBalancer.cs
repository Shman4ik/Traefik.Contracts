using System.Text.Json.Serialization;

namespace Traefik.Contracts.TcpConfiguration
{
	public class LoadBalancer
	{
		[JsonPropertyName("terminationDelay")]
		public int TerminationDelay { get; set; }

		[JsonPropertyName("proxyProtocol")]
		public ProxyProtocol ProxyProtocol { get; set; }

		[JsonPropertyName("servers")]
		public Server[] Servers { get; set; }
	}
}