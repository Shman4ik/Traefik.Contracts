using Newtonsoft.Json;

namespace Traefik.Contracts.UdpConfiguration
{
	public class LoadBalancer
	{
		[JsonProperty("servers")]
		public Server[] Servers { get; set; }
	}
}