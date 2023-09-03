using Newtonsoft.Json;

namespace Traefik.Contracts.TcpConfiguration
{
	public class Weighted
	{
		[JsonProperty("services")]
		public Service[] Services { get; set; }
	}
}