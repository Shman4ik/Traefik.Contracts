﻿using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class StripPrefixRegex
	{
		[JsonPropertyName("regex")]
		public string[] regex { get; set; }
	}

}
