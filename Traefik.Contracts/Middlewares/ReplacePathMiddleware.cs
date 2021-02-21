﻿using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class ReplacePathMiddleware : BaseMiddleware
	{
		[JsonPropertyName("replacePath")]
		public ReplacePath replacePath { get; set; }
	}

}
