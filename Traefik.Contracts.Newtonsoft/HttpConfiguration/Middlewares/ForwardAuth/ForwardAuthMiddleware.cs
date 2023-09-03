using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// Using an External Service to Forward Authentication
	/// </summary>
	public class ForwardAuthMiddleware : BaseMiddleware
	{
		/// <summary>
		/// The ForwardAuth middleware delegates authentication to an external service. If the service answers with a 2XX code, access is granted, and the original request is performed. Otherwise, the response from the authentication server is returned.
		/// </summary>
		[JsonProperty("forwardAuth")]
		public ForwardAuth ForwardAuth { get; set; }
	}
}