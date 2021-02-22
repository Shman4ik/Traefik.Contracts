using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class RedirectRegexMiddleware : BaseMiddleware
	{
		[JsonPropertyName("redirectRegex")]
		public RedirectRegex redirectRegex { get; set; }
	}

}
