using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration
{
	public class LoadBalancer
	{
		[JsonPropertyName("sticky")]
		public Sticky Sticky { get; set; }

		[JsonPropertyName("servers")]
		public Server[] Servers { get; set; }

		[JsonPropertyName("healthCheck")]
		public HealthCheck HealthCheck { get; set; }

		[JsonPropertyName("passHostHeader")]
		public bool PassHostHeader { get; set; }

		[JsonPropertyName("responseForwarding")]
		public ResponseForwarding ResponseForwarding { get; set; }

		[JsonPropertyName("serversTransport")]
		public string ServersTransport { get; set; }
	}
}