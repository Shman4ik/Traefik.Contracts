using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class RetryMiddleware : BaseMiddleware
	{
		[JsonPropertyName("retry")]
		public Retry retry { get; set; }
	}

}
