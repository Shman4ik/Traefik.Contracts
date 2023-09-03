using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// The sourceCriterion option defines what criterion is used to group requests as originating from a common source. The precedence order is ipStrategy, then requestHeaderName, then requestHost. If none are set, the default is to use the requestHost.
	/// </summary>
	public class SourceCriterion
	{
		/// <summary>
		/// The ipStrategy option defines two parameters that configures how Traefik determines the client IP: depth, and excludedIPs.
		/// </summary>
		[JsonProperty("ipStrategy")]
		public IpStrategy IpStrategy { get; set; }

		/// <summary>
		/// Name of the header used to group incoming requests.
		/// </summary>
		[JsonProperty("requestHeaderName")]
		public string RequestHeaderName { get; set; }

		/// <summary>
		/// Whether to consider the request host as the source.
		/// </summary>
		[JsonProperty("requestHost")]
		public bool RequestHost { get; set; }
	}
}