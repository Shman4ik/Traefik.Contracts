using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration
{
	public class ForwardingTimeouts
	{
		[JsonProperty("dialTimeout")]
		public string DialTimeout { get; set; }

		[JsonProperty("responseHeaderTimeout")]
		public string ResponseHeaderTimeout { get; set; }

		[JsonProperty("idleConnTimeout")]
		public string IdleConnTimeout { get; set; }
	}
}