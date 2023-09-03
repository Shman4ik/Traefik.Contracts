using System.Collections.Generic;
using Newtonsoft.Json;

namespace Traefik.Contracts.UdpConfiguration
{
	public class Udp
	{
		[JsonProperty("routers")]
		public Dictionary<string, UdpRouter> Routers { get; set; }

		[JsonProperty("services")]
		public Dictionary<string, BaseUdpService> Services { get; set; }
	}
}