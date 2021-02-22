using System.Text.Json.Serialization;

namespace Traefik.Contracts.UdpConfiguration
{
	public class Server
	{
		[JsonPropertyName("address")]
		public string address { get; set; }
	}
}