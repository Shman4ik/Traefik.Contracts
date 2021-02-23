using System.Text.Json.Serialization;

namespace Traefik.Contracts.TcpConfiguration
{
	[JsonConverter(typeof(TcpServiceJsonConverter))]
	public abstract class BaseTcpService
	{
	}
}