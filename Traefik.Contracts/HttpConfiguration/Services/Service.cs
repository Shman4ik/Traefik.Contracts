using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration
{
	public class Service
	{
		[JsonPropertyName("loadBalancer")]
		public Loadbalancer LoadBalancer { get; set; }

		[JsonPropertyName("weighted")]
		public Weighted Weighted { get; set; }

		[JsonPropertyName("mirroring")]
		public Mirroring Mirroring { get; set; }
	}

}
