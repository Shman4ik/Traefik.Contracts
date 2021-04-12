using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// Limiting Clients to Specific IPs
	/// </summary>
	public class IpWhiteListMiddleware : BaseMiddleware
	{
		/// <summary>
		/// IPWhitelist accepts / refuses requests based on the client IP.
		/// </summary>
		[JsonPropertyName("ipWhiteList")]
		public IpWhiteList IpWhiteList { get; set; }
	}
}