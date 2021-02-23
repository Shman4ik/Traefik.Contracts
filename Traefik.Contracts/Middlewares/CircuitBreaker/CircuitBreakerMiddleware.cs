using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class CircuitBreakerMiddleware : BaseMiddleware
	{
		[JsonPropertyName("circuitBreaker")]
		public CircuitBreaker CircuitBreaker { get; set; }
	}
}