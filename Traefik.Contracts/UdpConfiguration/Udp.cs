using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Traefik.Contracts.UdpConfiguration
{
	public class Udp
	{
		[JsonPropertyName("routers")]
		public Dictionary<string, UdpRouter> routers { get; set; }

		[JsonPropertyName("services")]
		public Dictionary<string, BaseUdpService> services { get; set; }
	}
}