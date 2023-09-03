using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration
{
	public class ResponseForwarding
	{
		[JsonProperty("flushInterval")]
		public string FlushInterval { get; set; }
	}
}