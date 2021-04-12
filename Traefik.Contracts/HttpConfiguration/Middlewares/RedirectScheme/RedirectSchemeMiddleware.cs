using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// Redirecting the Client to a Different Scheme/Port
	/// </summary>
	public class RedirectSchemeMiddleware : BaseMiddleware
	{
		/// <summary>
		/// RedirectScheme redirects requests from a scheme/port to another.
		/// </summary>
		[JsonPropertyName("redirectScheme")]
		public RedirectScheme RedirectScheme { get; set; }
	}
}