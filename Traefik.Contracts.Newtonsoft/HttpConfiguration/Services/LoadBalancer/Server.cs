using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration
{
	public class Server
	{
		[JsonProperty("url")]
		public string Url { get; set; }
	}
}