using System.Text.Json.Serialization;

namespace Traefik.Contracts.TcpConfiguration
{
	public class TcpRouter
	{
		[JsonPropertyName("entryPoints")]
		public string[] EntryPoints { get; set; }
		
		[JsonPropertyName("service")]
		public string Service { get; set; }
		
		[JsonPropertyName("rule")]
		public string Rule { get; set; }
		
		[JsonPropertyName("tls")]
		public Tls Tls { get; set; }
	}
}