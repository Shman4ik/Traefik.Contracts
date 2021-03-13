using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	public class RetryMiddleware : BaseMiddleware
	{
		[JsonPropertyName("retry")]
		public Retry Retry { get; set; }
	}
}