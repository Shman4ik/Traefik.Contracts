using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration
{
	public class ForwardingTimeouts
	{
		[JsonPropertyName("dialTimeout")]
		public string DialTimeout { get; set; }

		[JsonPropertyName("responseHeaderTimeout")]
		public string ResponseHeaderTimeout { get; set; }

		[JsonPropertyName("idleConnTimeout")]
		public string IdleConnTimeout { get; set; }
	}
}
