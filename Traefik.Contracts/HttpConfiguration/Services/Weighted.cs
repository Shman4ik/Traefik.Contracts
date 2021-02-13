﻿using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration
{
	public class Weighted
	{
		[JsonPropertyName("services")]
		public Service[] Services { get; set; }

		[JsonPropertyName("sticky")]
		public Sticky Sticky { get; set; }
	}
}