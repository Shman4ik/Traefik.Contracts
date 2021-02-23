using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class StripPrefixRegexMiddleware : BaseMiddleware
	{
		[JsonPropertyName("stripPrefixRegex")]
		public StripPrefixRegex StripPrefixRegex { get; set; }
	}
}