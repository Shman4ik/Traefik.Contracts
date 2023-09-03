using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// Managing Request/Response headers
	/// </summary>
	public class HeadersMiddleware : BaseMiddleware
	{
		/// <summary>
		/// The Headers middleware manages the headers of requests and responses.
		/// </summary>
		[JsonProperty("headers")]
		public Headers Headers { get; set; }
	}
}