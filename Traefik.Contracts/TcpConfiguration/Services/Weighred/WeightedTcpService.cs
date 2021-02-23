using System.Text.Json.Serialization;

namespace Traefik.Contracts.TcpConfiguration
{
	public class WeightedTcpService : BaseTcpService
	{
		[JsonPropertyName("weighted")]
		public Weighted Weighted { get; set; }
	}
}