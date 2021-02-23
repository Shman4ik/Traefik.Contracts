using System.Text.Json.Serialization;

namespace Traefik.Contracts.TcpConfiguration
{
	public class Server
	{
		[JsonPropertyName("address")]
		public string Address { get; set; }
	}
}