using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class ContentTypeMiddleware : BaseMiddleware
	{
		[JsonPropertyName("contentType")]
		public ContentType ContentType { get; set; }
	}

}
