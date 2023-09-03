using Newtonsoft.Json;

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
		[JsonProperty("rateLimit")]
		public RateLimit RateLimit { get; set; }
	}
}