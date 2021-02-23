using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class RedirectSchemeMiddleware : BaseMiddleware
	{
		[JsonPropertyName("redirectScheme")]
		public RedirectScheme RedirectScheme { get; set; }
	}

}
