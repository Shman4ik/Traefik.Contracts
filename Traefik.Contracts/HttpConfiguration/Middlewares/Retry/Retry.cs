using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// The Retry middleware reissues requests a given number of times to a backend server if that server does not reply. As soon as the server answers, the middleware stops retrying, regardless of the response status. The Retry middleware has an optional configuration to enable an exponential backoff.
	/// </summary>
	public class Retry
	{
		/// <summary>
		/// The attempts option defines how many times the request should be retried.
		/// </summary>
		[JsonPropertyName("attempts")]
		public int Attempts { get; set; }

		/// <summary>
		/// The initialInterval option defines the first wait time in the exponential backoff series. The maximum interval is calculated as twice the initialInterval. If unspecified, requests will be retried immediately.
		/// </summary>
		[JsonPropertyName("initialInterval")]
		public int InitialInterval { get; set; }
	}
}