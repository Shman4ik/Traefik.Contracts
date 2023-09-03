using System.Collections.Generic;
using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration
{
	public class HealthCheck
	{
		[JsonProperty("scheme")]
		public string Scheme { get; set; }

		[JsonProperty("path")]
		public string Path { get; set; }

		[JsonProperty("port")]
		public int Port { get; set; }

		[JsonProperty("interval")]
		public string Interval { get; set; }

		[JsonProperty("timeout")]
		public string Timeout { get; set; }

		[JsonProperty("hostname")]
		public string Hostname { get; set; }

		[JsonProperty("followRedirects")]
		public bool FollowRedirects { get; set; }

		[JsonProperty("headers")]
		public Dictionary<string, string> Headers { get; set; }
	}
}