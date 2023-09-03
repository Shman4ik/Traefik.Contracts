using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// IPWhitelist accepts / refuses requests based on the client IP.
	/// </summary>
	public class IpWhiteList
	{
		/// <summary>
		/// The sourceRange option sets the allowed IPs (or ranges of allowed IPs by using CIDR notation).
		/// </summary>
		[JsonProperty("sourceRange")]
		public string[] SourceRange { get; set; }

		/// <summary>
		/// The ipStrategy option defines two parameters that set how Traefik determines the client IP: depth, and excludedIPs.
		/// </summary>
		[JsonProperty("ipStrategy")]
		public IpStrategy IpStrategy { get; set; }
	}
}