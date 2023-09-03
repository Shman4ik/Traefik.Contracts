using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// Don't Waste Time Calling Unhealthy Services
	/// </summary>
	public class CircuitBreakerMiddleware : BaseMiddleware
	{
		/// <summary>
		/// The circuit breaker protects your system from stacking requests to unhealthy services, resulting in cascading failures.
		/// When your system is healthy, the circuit is closed(normal operations). When your system becomes unhealthy, the circuit opens, and the requests are no longer forwarded, but instead are handled by a fallback mechanism.
		/// To assess if your system is healthy, the circuit breaker constantly monitors the services.
		/// </summary>
		[JsonProperty("circuitBreaker")]
		public CircuitBreaker CircuitBreaker { get; set; }
	}
}