using System.Text.Json.Serialization;

namespace Traefik.Contracts
{
	public class UdpRouter
	{
		[JsonPropertyName("entryPoints")]
		public string[] entryPoints { get; set; }
		
		[JsonPropertyName("service")]
		public string service { get; set; }
	}
}