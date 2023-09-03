﻿using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// Limiting the Number of Simultaneous In-Flight Requests
	/// </summary>
	public class InFlightReqMiddleware : BaseMiddleware
	{
		/// <summary>
		/// Limiting the Number of Simultaneous In-Flight Requests
		/// </summary>
		[JsonProperty("inFlightReq")]
		public InFlightReq InFlightReq { get; set; }
	}
}