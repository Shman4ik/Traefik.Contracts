using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class RateLimitMiddleware : BaseMiddleware
	{
		[JsonPropertyName("rateLimit")]
		public RateLimit rateLimit { get; set; }
	}

}
