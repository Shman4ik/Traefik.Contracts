using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	public class InFlightReqMiddleware : BaseMiddleware
	{
		[JsonPropertyName("inFlightReq")]
		public InFlightReq InFlightReq { get; set; }
	}
}