using System.Text.Json.Serialization;

namespace Traefik.Contracts.UdpConfiguration
{
	public class Server
	{
		[JsonPropertyName("address")]
		public string Address { get; set; }
	}
}