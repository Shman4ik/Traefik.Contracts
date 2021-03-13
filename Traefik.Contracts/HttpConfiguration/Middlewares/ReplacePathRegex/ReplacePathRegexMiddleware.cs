using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	public class ReplacePathRegexMiddleware : BaseMiddleware
	{
		[JsonPropertyName("replacePathRegex")]
		public ReplacePathRegex ReplacePathRegex { get; set; }
	}
}