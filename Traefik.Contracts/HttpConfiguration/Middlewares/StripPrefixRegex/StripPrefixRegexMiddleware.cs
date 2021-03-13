using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	public class StripPrefixRegexMiddleware : BaseMiddleware
	{
		[JsonPropertyName("stripPrefixRegex")]
		public StripPrefixRegex StripPrefixRegex { get; set; }
	}
}