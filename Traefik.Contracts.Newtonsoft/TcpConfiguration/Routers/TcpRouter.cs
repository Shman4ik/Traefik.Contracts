using Newtonsoft.Json;

namespace Traefik.Contracts.TcpConfiguration
{
	public class TcpRouter
	{
		[JsonProperty("entryPoints")]
		public string[] EntryPoints { get; set; }
		
		[JsonProperty("service")]
		public string Service { get; set; }
		
		[JsonProperty("rule")]
		public string Rule { get; set; }
		
		[JsonProperty("tls")]
		public Tls Tls { get; set; }
	}
}