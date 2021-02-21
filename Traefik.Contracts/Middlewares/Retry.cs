using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class Retry
	{
		[JsonPropertyName("attempts")]
		public int attempts { get; set; }

		[JsonPropertyName("initialInterval")]
		public int initialInterval { get; set; }
	}

}
