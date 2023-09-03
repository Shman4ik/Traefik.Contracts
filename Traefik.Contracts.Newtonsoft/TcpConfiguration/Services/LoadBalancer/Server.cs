using Newtonsoft.Json;

namespace Traefik.Contracts.TcpConfiguration
{
	public class Server
	{
		[JsonProperty("address")]
		public string Address { get; set; }
	}
}