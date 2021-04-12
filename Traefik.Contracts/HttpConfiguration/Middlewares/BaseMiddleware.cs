using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// Base abstract Middleware class
	/// </summary>
	[JsonConverter(typeof(MiddlewareJsonConverter))]
	public abstract class BaseMiddleware
	{
	}
}