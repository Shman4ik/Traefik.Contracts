using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	public class CircuitBreaker
	{
		/// <summary>
		/// https://doc.traefik.io/traefik/middlewares/circuitbreaker/
		/// </summary>
		/// <example>LatencyAtQuantileMS(50.0) > 100</example>
		[JsonProperty("expression")]
		public string Expression { get; set; }
	}
}