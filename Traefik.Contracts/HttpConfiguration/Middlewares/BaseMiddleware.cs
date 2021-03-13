using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	[JsonConverter(typeof(MiddlewareJsonConverter))]
	public abstract class BaseMiddleware
	{
	}
}