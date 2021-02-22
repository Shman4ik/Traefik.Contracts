using System.Text.Json.Serialization;
using Traefik.Contracts.HttpConfiguration;
using Traefik.Contracts.TcpConfiguration;
using Traefik.Contracts.TlcConfiguration;
using Traefik.Contracts.UdpConfiguration;

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
		public TlcConfiguration.Tls Tls { get; set; }

	}
}
