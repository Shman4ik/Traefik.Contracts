using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class ReplacePathRegexMiddleware : BaseMiddleware
	{
		[JsonPropertyName("replacePathRegex")]
		public ReplacePathRegex ReplacePathRegex { get; set; }
	}
}