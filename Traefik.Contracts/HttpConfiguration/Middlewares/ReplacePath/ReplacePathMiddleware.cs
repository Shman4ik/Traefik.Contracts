using System.Text.Json.Serialization;

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
		[JsonPropertyName("replacePath")]
		public ReplacePath ReplacePath { get; set; }
	}
}