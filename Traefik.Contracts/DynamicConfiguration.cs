using System.Text.Json.Serialization;
using Traefik.Contracts.HttpConfiguration;
using Traefik.Contracts.TcpConfiguration;
using Traefik.Contracts.UdpConfiguration;
using Tls = Traefik.Contracts.TlcConfiguration.Tls;

namespace Traefik.Contracts
{
	public class DynamicConfiguration
	{
		[JsonPropertyName("http")]
		public Http Http { get; set; }

		[JsonPropertyName("tcp")]
		public Tcp Tcp { get; set; }

		[JsonPropertyName("udp")]
		public Udp Udp { get; set; }

		[JsonPropertyName("tls")]
		public Tls Tls { get; set; }
	}
}