using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Traefik.Contracts.TcpConfiguration
{
	public class Tcp
	{
		[JsonPropertyName("routers")]
		public Dictionary<string, TcpRouter> Routers { get; set; }

		[JsonPropertyName("services")]
		public Dictionary<string, BaseTcpService> Services { get; set; }
	}
}