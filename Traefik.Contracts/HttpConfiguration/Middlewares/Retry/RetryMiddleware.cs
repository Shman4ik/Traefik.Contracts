using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// Retrying until it Succeeds
	/// </summary>
	public class RetryMiddleware : BaseMiddleware
	{
		/// <summary>
		/// The Retry middleware reissues requests a given number of times to a backend server if that server does not reply. As soon as the server answers, the middleware stops retrying, regardless of the response status. The Retry middleware has an optional configuration to enable an exponential backoff.
		/// </summary>
		[JsonPropertyName("retry")]
		public Retry Retry { get; set; }
	}
}