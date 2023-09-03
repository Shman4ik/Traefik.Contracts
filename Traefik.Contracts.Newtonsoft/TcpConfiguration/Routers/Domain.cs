using Newtonsoft.Json;

namespace Traefik.Contracts.TcpConfiguration
{
	public class Domain
	{
		[JsonProperty("main")]
		public string Main { get; set; }

		[JsonProperty("sans")]
		public string[] Sans { get; set; }
	}
}