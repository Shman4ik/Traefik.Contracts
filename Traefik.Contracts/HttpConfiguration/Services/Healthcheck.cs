using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration
{
	public class Healthcheck
	{
		[JsonPropertyName("scheme")]
		public string Scheme { get; set; }
		
		[JsonPropertyName("path")]
		public string Path { get; set; }
		
		[JsonPropertyName("port")]
		public int Port { get; set; }
		
		[JsonPropertyName("interval")]
		public string Interval { get; set; }
		
		[JsonPropertyName("timeout")]
		public string Timeout { get; set; }
		
		[JsonPropertyName("hostname")]
		public string Hostname { get; set; }
		
		[JsonPropertyName("followRedirects")]
		public bool FollowRedirects { get; set; }
		
		[JsonPropertyName("headers")]
		public Dictionary<string, string> Headers { get; set; }
	}
}
