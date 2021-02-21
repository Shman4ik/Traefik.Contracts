using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class HeadersMiddleware : BaseMiddleware
	{
		[JsonPropertyName("Headers")]
		public Headers headers { get; set; }
	}

}
