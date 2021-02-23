using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class ForwardAuthMiddleware : BaseMiddleware
	{
		[JsonPropertyName("forwardAuth")]
		public ForwardAuth ForwardAuth { get; set; }
	}
}