using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class ChainMiddleware : BaseMiddleware
	{
		[JsonPropertyName("chain")]
		public Chain Chain { get; set; }
	}

}
