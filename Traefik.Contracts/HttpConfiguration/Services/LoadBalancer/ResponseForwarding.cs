﻿using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration
{
	public class ResponseForwarding
	{
		[JsonPropertyName("flushInterval")]
		public string FlushInterval { get; set; }
	}
}