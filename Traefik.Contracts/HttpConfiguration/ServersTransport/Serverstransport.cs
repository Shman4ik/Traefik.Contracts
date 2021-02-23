using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration
{
	public class ServersTransport
	{
		[JsonPropertyName("serverName")]
		public string ServerName { get; set; }

		[JsonPropertyName("insecureSkipVerify")]
		public bool InsecureSkipVerify { get; set; }

		[JsonPropertyName("rootCAs")]
		public string[] RootCAs { get; set; }

		[JsonPropertyName("certificates")]
		public Certificate[] Certificates { get; set; }

		[JsonPropertyName("maxIdleConnsPerHost")]
		public int MaxIdleConnsPerHost { get; set; }

		[JsonPropertyName("forwardingTimeouts")]
		public ForwardingTimeouts ForwardingTimeouts { get; set; }
	}

}
