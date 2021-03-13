using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	///     Adding Basic Authentication
	/// </summary>
	public class BasicAuthMiddleware : BaseMiddleware
	{
		/// <summary>
		/// The BasicAuth middleware restricts access to your services to known users.
		/// </summary>
		[JsonPropertyName("basicAuth")]
		public BasicAuth BasicAuth { get; set; }
	}
}