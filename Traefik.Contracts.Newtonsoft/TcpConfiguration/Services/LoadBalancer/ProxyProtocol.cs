using Newtonsoft.Json;

namespace Traefik.Contracts.TcpConfiguration
{
	public class ProxyProtocol
	{
		[JsonProperty("version")]
		public int Version { get; set; }
	}
}