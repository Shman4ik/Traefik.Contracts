using System;
using System.Collections.Generic;
using System.Text;

namespace Traefik.Contracts.Middlewares
{
	public class Plugin
	{
		public Dictionary<string, string> PluginConf { get; set; }
	}
}
