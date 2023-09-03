using Newtonsoft.Json;
using Traefik.Contracts.HttpConfiguration;
using Traefik.Contracts.TcpConfiguration;
using Traefik.Contracts.UdpConfiguration;
using Tls = Traefik.Contracts.TlcConfiguration.Tls;

namespace Traefik.Contracts
{
	public class DynamicConfiguration
	{
		[JsonProperty("http")]
		public Http Http { get; set; }

		[JsonProperty("tcp")]
		public Tcp Tcp { get; set; }

		[JsonProperty("udp")]
		public Udp Udp { get; set; }

		[JsonProperty("tls")]
		public Tls Tls { get; set; }
	}
}