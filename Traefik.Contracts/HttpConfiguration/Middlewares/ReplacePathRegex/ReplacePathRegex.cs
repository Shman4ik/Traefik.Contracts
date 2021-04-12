using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// The ReplaceRegex replaces the path of a URL using regex matching and replacement.
	/// </summary>
	public class ReplacePathRegex
	{
		/// <summary>
		/// The regex option is the regular expression to match and capture the path from the request URL.
		/// </summary>
		[JsonPropertyName("regex")]
		public string Regex { get; set; }

		/// <summary>
		/// The replacement option defines the replacement path format, which can include captured variables.
		/// </summary>
		[JsonPropertyName("replacement")]
		public string Replacement { get; set; }
	}
}