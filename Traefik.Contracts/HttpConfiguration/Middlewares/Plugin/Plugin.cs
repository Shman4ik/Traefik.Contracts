using System.Collections.Generic;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	public class Plugin
	{
		public Dictionary<string, string> PluginConf { get; set; }
	}
}