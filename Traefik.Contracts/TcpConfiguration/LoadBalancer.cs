using System.Text.Json.Serialization;

namespace Traefik.Contracts.TcpConfiguration
{
	public class LoadBalancer
	{
		[JsonPropertyName("terminationDelay")]
		public int terminationDelay { get; set; }
		
		[JsonPropertyName("proxyProtocol")]
		public ProxyProtocol proxyProtocol { get; set; }
		
		[JsonPropertyName("servers")]
		public Server[] servers { get; set; }
	}
}