using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// To proactively prevent services from being overwhelmed with high load, the number of allowed simultaneous in-flight requests can be limited.
	/// </summary>
	public class InFlightReq
	{
		/// <summary>
		/// The amount option defines the maximum amount of allowed simultaneous in-flight request. The middleware responds with HTTP 429 Too Many Requests if there are already amount requests in progress (based on the same sourceCriterion strategy).
		/// </summary>
		[JsonProperty("amount")]
		public int Amount { get; set; }

		/// <summary>
		/// The sourceCriterion option defines what criterion is used to group requests as originating from a common source. The precedence order is ipStrategy, then requestHeaderName, then requestHost. If none are set, the default is to use the requestHost.
		/// </summary>
		[JsonProperty("sourceCriterion")]
		public SourceCriterion SourceCriterion { get; set; }
	}
}