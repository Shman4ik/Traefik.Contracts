using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// Removing Prefixes From the Path Before Forwarding the Request (Using a Regex)
	/// </summary>
	public class StripPrefixRegexMiddleware : BaseMiddleware
	{
		/// <summary>
		/// Remove the matching prefixes from the URL path.
		/// </summary>
		[JsonProperty("stripPrefixRegex")]
		public StripPrefixRegex StripPrefixRegex { get; set; }
	}
}