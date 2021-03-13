using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	public class PluginMiddleware : BaseMiddleware
	{
		[JsonPropertyName("plugin")]
		public Plugin Plugin { get; set; }
	}
}