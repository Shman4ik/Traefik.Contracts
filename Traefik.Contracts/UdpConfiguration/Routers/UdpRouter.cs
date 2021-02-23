using System.Text.Json.Serialization;

namespace Traefik.Contracts
{
	public class UdpRouter
	{
		[JsonPropertyName("entryPoints")]
		public string[] EntryPoints { get; set; }

		[JsonPropertyName("service")]
		public string Service { get; set; }
	}
}