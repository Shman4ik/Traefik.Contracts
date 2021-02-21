using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class ErrorPageMiddleware : BaseMiddleware
	{
		[JsonPropertyName("errors")]
		public Errors Errors { get; set; }
	}

}
