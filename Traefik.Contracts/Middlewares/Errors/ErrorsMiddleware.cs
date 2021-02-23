using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class ErrorsMiddleware : BaseMiddleware
	{
		[JsonPropertyName("errors")]
		public Errors Errors { get; set; }
	}
}