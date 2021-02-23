using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class Retry
	{
		[JsonPropertyName("attempts")]
		public int Attempts { get; set; }

		[JsonPropertyName("initialInterval")]
		public int InitialInterval { get; set; }
	}
}