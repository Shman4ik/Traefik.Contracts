using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// Adding Digest Authentication
	/// </summary>
	public class DigestAuthMiddleware : BaseMiddleware
	{
		/// <summary>
		/// The DigestAuth middleware restricts access to your services to known users.
		/// </summary>
		[JsonProperty("digestAuth")]
		public DigestAuth DigestAuth { get; set; }
	}
}