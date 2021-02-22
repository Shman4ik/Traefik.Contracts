using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class CircuitBreaker
	{
		[JsonPropertyName("expression")]
		public string Expression { get; set; }
	}

}
