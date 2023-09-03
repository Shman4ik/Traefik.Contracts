using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// The ipStrategy option defines two parameters that configures how Traefik determines the client IP: depth, and excludedIPs.
	/// </summary>
	public class IpStrategy
	{
		/// <summary>
		/// The depth option tells Traefik to use the X-Forwarded-For header and select the IP located at the depth position (starting from the right).
		/// </summary>
		[JsonProperty("depth")]
		public int Depth { get; set; }

		/// <summary>
		/// excludedIPs configures Traefik to scan the X-Forwarded-For header and select the first IP not in the list.
		/// </summary>
		[JsonProperty("excludedIPs")]
		public string[] ExcludedIPs { get; set; }
	}
}