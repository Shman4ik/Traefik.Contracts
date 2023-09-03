using Newtonsoft.Json;

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
		[JsonProperty("basicAuth")]
		public BasicAuth BasicAuth { get; set; }
	}
}