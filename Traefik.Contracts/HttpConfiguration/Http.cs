using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration
{
	public class Http
	{
		[JsonPropertyName("routers")]
		public Dictionary<string, Router> Routers { get; set; }

		[JsonPropertyName("services")]
		public Dictionary<string, BaseHttpService> Services { get; set; }

		[JsonPropertyName("middlewares")]
		public Dictionary<string, Contracts.Middlewares.BaseMiddleware> Middlewares { get; set; }

		[JsonPropertyName("serversTransports")]
		public Dictionary<string, Serverstransport> ServersTransports { get; set; }
	}
}
