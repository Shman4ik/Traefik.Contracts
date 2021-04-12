using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// The RateLimit middleware ensures that services will receive a fair amount of requests, and allows one to define what fair is.
	/// </summary>
	public class RateLimit
	{
		/// <summary>
		/// average is the maximum rate, by default in requests per second, allowed from a given source.
		/// It defaults to 0, which means no rate limiting.
		/// The rate is actually defined by dividing average by period.So for a rate below 1 req/s, one needs to define a period larger than a second.
		/// </summary>
		[JsonPropertyName("average")]
		public int Average { get; set; }

		/// <summary>
		/// period, in combination with average, defines the actual maximum rate, such as:	r = average / period
		/// It defaults to 1 second.
		/// </summary>
		[JsonPropertyName("period")]
		public int Period { get; set; }

		/// <summary>
		/// burst is the maximum number of requests allowed to go through in the same arbitrarily small period of time.
		/// </summary>
		[JsonPropertyName("burst")]
		public int Burst { get; set; }

		/// <summary>
		/// The sourceCriterion option defines what criterion is used to group requests as originating from a common source. The precedence order is ipStrategy, then requestHeaderName, then requestHost. If none are set, the default is to use the request's remote address field (as an ipStrategy).
		/// </summary>
		[JsonPropertyName("sourceCriterion")]
		public SourceCriterion SourceCriterion { get; set; }
	}
}