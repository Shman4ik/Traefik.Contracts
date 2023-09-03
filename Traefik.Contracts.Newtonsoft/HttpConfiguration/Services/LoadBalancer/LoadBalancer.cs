using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration
{
	public class LoadBalancer
	{
		[JsonProperty("sticky")]
		public Sticky Sticky { get; set; }

		[JsonProperty("servers")]
		public Server[] Servers { get; set; }

		[JsonProperty("healthCheck")]
		public HealthCheck HealthCheck { get; set; }

		[JsonProperty("passHostHeader")]
		public bool PassHostHeader { get; set; }

		[JsonProperty("responseForwarding")]
		public ResponseForwarding ResponseForwarding { get; set; }

		[JsonProperty("serversTransport")]
		public string ServersTransport { get; set; }
	}
}