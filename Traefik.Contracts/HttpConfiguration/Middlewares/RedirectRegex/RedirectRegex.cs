using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// The RedirectRegex redirects a request using regex matching and replacement.
	/// </summary>
	public class RedirectRegex
	{
		/// <summary>
		/// The regex option is the regular expression to match and capture elements from the request URL.
		/// </summary>
		[JsonPropertyName("regex")]
		public string Regex { get; set; }

		/// <summary>
		/// The replacement option defines how to modify the URL to have the new target URL.
		/// </summary>
		[JsonPropertyName("replacement")]
		public string Replacement { get; set; }
		
		/// <summary>
		/// Set the permanent option to true to apply a permanent redirection.
		/// </summary>
		[JsonPropertyName("permanent")]
		public bool Permanent { get; set; }
	}
}