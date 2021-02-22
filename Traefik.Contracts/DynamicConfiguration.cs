using System.Text.Json.Serialization;
using Traefik.Contracts.HttpConfiguration;
using Traefik.Contracts.TcpConfiguration;
using Traefik.Contracts.TlcConfiguration;
using Traefik.Contracts.UdpConfiguration;
using Tls = Traefik.Contracts.TlcConfiguration.Tls;

namespace Traefik.Contracts
{
	public class DynamicConfiguration
	{
		[JsonPropertyName("http")]
		public Http Http { get; set; }
		public Tcp tcp { get; set; }
		public Udp udp { get; set; }
		public Tls tls { get; set; }

	}
}
