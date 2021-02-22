using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration
{
	public class LoadbalancerHttpService : BaseHttpService
	{
		[JsonPropertyName("loadBalancer")]
		public Loadbalancer LoadBalancer { get; set; }
	}

}
