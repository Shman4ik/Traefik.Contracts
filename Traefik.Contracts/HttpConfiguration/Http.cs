﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using Traefik.Contracts.HttpConfiguration.Middlewares;

namespace Traefik.Contracts.HttpConfiguration
{
	public class Http
	{
		/// <summary>
		/// A router is in charge of connecting incoming requests to the services that can handle them. In the process, routers may use pieces of middleware to update the request, or act before forwarding the request to the service.
		/// </summary>
		[JsonPropertyName("routers")]
		public Dictionary<string, Router> Routers { get; set; }

		[JsonPropertyName("services")]
		public Dictionary<string, BaseHttpService> Services { get; set; }

		[JsonPropertyName("middlewares")]
		public Dictionary<string, BaseMiddleware> Middlewares { get; set; }

		[JsonPropertyName("serversTransports")]
		public Dictionary<string, ServersTransport> ServersTransports { get; set; }
	}
}