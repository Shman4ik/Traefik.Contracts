using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// To Control the Number of Requests Going to a Service
	/// </summary>
	public class RateLimitMiddleware : BaseMiddleware
	{
		/// <summary>
		/// The RateLimit middleware ensures that services will receive a fair amount of requests, and allows one to define what fair is.
		/// </summary>
		[JsonPropertyName("rateLimit")]
		public RateLimit RateLimit { get; set; }
	}
}