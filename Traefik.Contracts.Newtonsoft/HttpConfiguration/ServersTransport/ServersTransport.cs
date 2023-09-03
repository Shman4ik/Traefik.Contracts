using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration
{
	public class ServersTransport
	{
		[JsonProperty("serverName")]
		public string ServerName { get; set; }

		[JsonProperty("insecureSkipVerify")]
		public bool InsecureSkipVerify { get; set; }

		[JsonProperty("rootCAs")]
		public string[] RootCAs { get; set; }

		[JsonProperty("certificates")]
		public Certificate[] Certificates { get; set; }

		[JsonProperty("maxIdleConnsPerHost")]
		public int MaxIdleConnsPerHost { get; set; }

		[JsonProperty("forwardingTimeouts")]
		public ForwardingTimeouts ForwardingTimeouts { get; set; }
	}
}