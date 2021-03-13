﻿using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	public class StripPrefixMiddleware : BaseMiddleware
	{
		[JsonPropertyName("stripPrefix")]
		public StripPrefix StripPrefix { get; set; }
	}
}