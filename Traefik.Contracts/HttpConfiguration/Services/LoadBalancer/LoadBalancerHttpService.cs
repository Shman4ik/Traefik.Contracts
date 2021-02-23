using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration
{
	public class LoadBalancerHttpService : BaseHttpService
	{
		//public LoadBalancerHttpService(LoadBalancer loadBalancer) : base(loadBalancer, null, null)
		//{
		//	LoadBalancer = loadBalancer;
		//}

		[JsonPropertyName("loadBalancer")]
		public LoadBalancer LoadBalancer { get; set; }
	}
}
