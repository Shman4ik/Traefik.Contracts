using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class DigestAuthMiddleware : BaseMiddleware
	{
		[JsonPropertyName("digestAuth")]
		public DigestAuth digestAuth { get; set; }
	}

}
