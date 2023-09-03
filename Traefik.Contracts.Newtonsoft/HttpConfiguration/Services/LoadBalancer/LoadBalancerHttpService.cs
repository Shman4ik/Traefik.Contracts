using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration
{
	public class LoadBalancerHttpService : BaseHttpService
	{
		//public LoadBalancerHttpService(LoadBalancer loadBalancer) : base(loadBalancer, null, null)
		//{
		//	LoadBalancer = loadBalancer;
		//}

		[JsonProperty("loadBalancer")]
		public LoadBalancer LoadBalancer { get; set; }
	}
}