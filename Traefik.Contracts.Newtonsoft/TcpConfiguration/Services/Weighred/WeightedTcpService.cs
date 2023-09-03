using Newtonsoft.Json;

namespace Traefik.Contracts.TcpConfiguration
{
	public class WeightedTcpService : BaseTcpService
	{
		[JsonProperty("weighted")]
		public Weighted Weighted { get; set; }
	}
}