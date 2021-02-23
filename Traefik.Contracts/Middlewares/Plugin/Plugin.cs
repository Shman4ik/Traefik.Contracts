using System.Collections.Generic;

namespace Traefik.Contracts.Middlewares
{
	public class Plugin
	{
		public Dictionary<string, string> PluginConf { get; set; }
	}
}