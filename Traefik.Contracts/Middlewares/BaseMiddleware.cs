using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	[JsonConverter(typeof(MiddlewareJsonConverter))]
	public abstract class BaseMiddleware
	{
	}
}