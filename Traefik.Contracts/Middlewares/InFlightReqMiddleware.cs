using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class InFlightReqMiddleware : BaseMiddleware
	{
		[JsonPropertyName("inFlightReq")]
		public InFlightReq inFlightReq { get; set; }
	}

}
