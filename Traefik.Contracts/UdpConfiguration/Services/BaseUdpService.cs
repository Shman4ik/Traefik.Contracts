using System.Text.Json.Serialization;

namespace Traefik.Contracts.UdpConfiguration
{
	[JsonConverter(typeof(UdpServiceJsonConverter))]
	public class BaseUdpService { }
}
