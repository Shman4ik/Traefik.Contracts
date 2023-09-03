using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// Removing Prefixes From the Path Before Forwarding the Request
	/// </summary>
	public class StripPrefixMiddleware : BaseMiddleware
	{
		/// <summary>
		/// Remove the specified prefixes from the URL path.
		/// </summary>
		[JsonProperty("stripPrefix")]
		public StripPrefix StripPrefix { get; set; }
	}
}