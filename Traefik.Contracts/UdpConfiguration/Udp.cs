using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Traefik.Contracts.UdpConfiguration
{
	public class Udp
	{
		[JsonPropertyName("routers")]
		public Dictionary<string, UdpRouter> Routers { get; set; }

		[JsonPropertyName("services")]
		public Dictionary<string, BaseUdpService> Services { get; set; }
	}
}