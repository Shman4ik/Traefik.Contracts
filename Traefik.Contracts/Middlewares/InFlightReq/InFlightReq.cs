﻿using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class InFlightReq
	{
		[JsonPropertyName("amount")]
		public int Amount { get; set; }

		[JsonPropertyName("sourceCriterion")]
		public SourceCriterion SourceCriterion { get; set; }
	}
}