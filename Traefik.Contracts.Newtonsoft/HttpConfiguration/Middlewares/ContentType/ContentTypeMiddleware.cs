﻿using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// Handling Content-Type auto-detection
	/// </summary>
	public class ContentTypeMiddleware : BaseMiddleware
	{
		/// <summary>
		/// The Content-Type middleware - or rather its autoDetect option - specifies whether to let the Content-Type header, if it has not been defined by the backend, be automatically set to a value derived from the contents of the response.
		/// As a proxy, the default behavior should be to leave the header alone, regardless of what the backend did with it.However, the historic default was to always auto-detect and set the header if it was not already defined, and altering this behavior would be a breaking change which would impact many users.
		/// This middleware exists to enable the correct behavior until at least the default one can be changed in a future version.
		/// </summary>
		[JsonProperty("contentType")]
		public ContentType ContentType { get; set; }
	}
}