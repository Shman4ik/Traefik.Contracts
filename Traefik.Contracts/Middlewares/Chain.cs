﻿using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class Chain
	{
		[JsonPropertyName("middlewares")]
		public string[] middlewares { get; set; }
	}

}