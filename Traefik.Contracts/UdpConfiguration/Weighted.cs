using System.Text.Json.Serialization;
using Traefik.Contracts.TcpConfiguration;

namespace Traefik.Contracts.UdpConfiguration
{
	public class Weighted
	{
		[JsonPropertyName("services")]
		public Service[] services { get; set; }
	}
}