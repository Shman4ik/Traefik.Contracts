using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	/// <summary>
	/// The BasicAuth middleware restricts access to your services to known users.
	/// </summary>
	public class BasicAuthMiddleware : BaseMiddleware
	{
		[JsonPropertyName("basicAuth")]
		public BasicAuth BasicAuth { get; set; }
	}
}
