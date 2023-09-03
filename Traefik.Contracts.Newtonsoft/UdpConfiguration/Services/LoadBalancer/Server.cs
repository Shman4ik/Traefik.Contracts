using Newtonsoft.Json;

namespace Traefik.Contracts.UdpConfiguration
{
	public class Server
	{
		[JsonProperty("address")]
		public string Address { get; set; }
	}
}