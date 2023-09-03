using System.Collections.Generic;
using Newtonsoft.Json;

namespace Traefik.Contracts.TcpConfiguration
{
	public class Tcp
	{
		[JsonProperty("routers")]
		public Dictionary<string, TcpRouter> Routers { get; set; }

		[JsonProperty("services")]
		public Dictionary<string, BaseTcpService> Services { get; set; }
	}
}