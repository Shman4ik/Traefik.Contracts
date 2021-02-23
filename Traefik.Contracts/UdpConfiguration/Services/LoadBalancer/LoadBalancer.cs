using System.Text.Json.Serialization;

namespace Traefik.Contracts.UdpConfiguration
{
	public class LoadBalancer
	{
		[JsonPropertyName("servers")]
		public Server[] Servers { get; set; }
	}
}