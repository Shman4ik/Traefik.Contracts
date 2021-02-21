using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class CompressMiddleware : BaseMiddleware
	{
		[JsonPropertyName("compress")]
		public Compress Compress { get; set; }
	}

}
