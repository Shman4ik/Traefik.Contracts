using Newtonsoft.Json;

namespace Traefik.Contracts
{
	public class UdpRouter
	{
		[JsonProperty("entryPoints")]
		public string[] EntryPoints { get; set; }

		[JsonProperty("service")]
		public string Service { get; set; }
	}
}