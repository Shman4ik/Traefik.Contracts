using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class HeadersMiddleware : BaseMiddleware
	{
		[JsonPropertyName("headers")]
		public Headers Headers { get; set; }
	}

}
