using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// Redirecting the Client to a Different Location
	/// </summary>
	public class RedirectRegexMiddleware : BaseMiddleware
	{
		/// <summary>
		/// The RedirectRegex redirects a request using regex matching and replacement.
		/// </summary>
		[JsonProperty("redirectRegex")]
		public RedirectRegex RedirectRegex { get; set; }
	}
}