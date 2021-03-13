using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	public class RateLimitMiddleware : BaseMiddleware
	{
		[JsonPropertyName("rateLimit")]
		public RateLimit RateLimit { get; set; }
	}
}