using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class IpWhiteListMiddleware : BaseMiddleware
	{
		[JsonPropertyName("ipWhiteList")]
		public IpWhiteList IpWhiteList { get; set; }
	}
}