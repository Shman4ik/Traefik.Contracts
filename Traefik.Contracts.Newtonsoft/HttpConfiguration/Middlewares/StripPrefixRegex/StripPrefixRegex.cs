using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// Remove the matching prefixes from the URL path.
	/// </summary>
	public class StripPrefixRegex
	{
		/// <summary>
		/// The regex option is the regular expression to match the path prefix from the request URL.
		/// </summary>
		[JsonProperty("regex")]
		public string[] Regex { get; set; }
	}
}