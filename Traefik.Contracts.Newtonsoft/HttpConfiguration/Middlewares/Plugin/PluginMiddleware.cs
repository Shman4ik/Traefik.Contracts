using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	public class PluginMiddleware : BaseMiddleware
	{
		[JsonProperty("plugin")]
		public Plugin Plugin { get; set; }
	}
}