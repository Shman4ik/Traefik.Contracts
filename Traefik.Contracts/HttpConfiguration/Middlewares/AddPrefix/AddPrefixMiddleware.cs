﻿using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	///     Prefixing the Path
	/// </summary>
	public class AddPrefixMiddleware : BaseMiddleware
	{
		/// <summary>
		/// The AddPrefix middleware updates the path of a request before forwarding it.
		/// </summary>
		[JsonPropertyName("addPrefix")]
		public AddPrefix AddPrefix { get; set; }
	}
}