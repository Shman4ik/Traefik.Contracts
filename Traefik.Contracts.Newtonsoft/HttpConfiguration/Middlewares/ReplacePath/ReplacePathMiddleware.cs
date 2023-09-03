using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// Updating the Path Before Forwarding the Request
	/// </summary>
	public class ReplacePathMiddleware : BaseMiddleware
	{
		/// <summary>
		/// Replace the path of the request URL.
		/// </summary>
		[JsonProperty("replacePath")]
		public ReplacePath ReplacePath { get; set; }
	}
}