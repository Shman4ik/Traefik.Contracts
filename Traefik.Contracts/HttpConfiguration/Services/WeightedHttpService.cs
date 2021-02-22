using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration
{
	public class WeightedHttpService :BaseHttpService
	{
		[JsonPropertyName("weighted")]
		public Weighted Weighted { get; set; }
	}
}
