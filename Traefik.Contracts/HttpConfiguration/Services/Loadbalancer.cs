using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration
{ 
	public class Loadbalancer
	{
		[JsonPropertyName("sticky")]
		public Sticky Sticky { get; set; }

		[JsonPropertyName("servers")]
		public Server[] Servers { get; set; }

		[JsonPropertyName("healthCheck")]
		public Healthcheck HealthCheck { get; set; }

		[JsonPropertyName("passHostHeader")]
		public bool PassHostHeader { get; set; }

		[JsonPropertyName("responseForwarding")]
		public Responseforwarding ResponseForwarding { get; set; }

		[JsonPropertyName("serversTransport")]
		public string ServersTransport { get; set; }
	}

}
