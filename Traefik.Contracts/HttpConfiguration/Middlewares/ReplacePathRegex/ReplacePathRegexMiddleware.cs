using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// Updating the Path Before Forwarding the Request (Using a Regex)
	/// </summary>
	public class ReplacePathRegexMiddleware : BaseMiddleware
	{
		/// <summary>
		/// The ReplaceRegex replaces the path of a URL using regex matching and replacement.
		/// </summary>
		[JsonPropertyName("replacePathRegex")]
		public ReplacePathRegex ReplacePathRegex { get; set; }
	}
}