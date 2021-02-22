using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class StripPrefixMiddleware : BaseMiddleware
	{
		[JsonPropertyName("stripPrefix")]
		public StripPrefix stripPrefix { get; set; }
	}

}
