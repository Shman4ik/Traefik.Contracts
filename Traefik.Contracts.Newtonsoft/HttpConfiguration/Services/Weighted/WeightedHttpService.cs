using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration
{
	public class WeightedHttpService : BaseHttpService
	{
		//public WeightedHttpService(Weighted weighted) : base(null, null, weighted)
		//{
		//	Weighted = weighted;
		//}

		[JsonProperty("weighted")]
		public Weighted Weighted { get; set; }
	}
}