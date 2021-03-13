using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	public class RedirectRegexMiddleware : BaseMiddleware
	{
		[JsonPropertyName("redirectRegex")]
		public RedirectRegex RedirectRegex { get; set; }
	}
}