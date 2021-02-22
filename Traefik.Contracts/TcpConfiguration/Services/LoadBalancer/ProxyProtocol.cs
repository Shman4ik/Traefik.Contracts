using System.Text.Json.Serialization;

namespace Traefik.Contracts.TcpConfiguration
{
	public class ProxyProtocol
	{
		[JsonPropertyName("version")]
		public int version { get; set; }
	}
}