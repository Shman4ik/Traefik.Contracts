using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration
{
	public class WeightedHttpService : BaseHttpService
	{
		//public WeightedHttpService(Weighted weighted) : base(null, null, weighted)
		//{
		//	Weighted = weighted;
		//}

		[JsonPropertyName("weighted")]
		public Weighted Weighted { get; set; }
	}
}
