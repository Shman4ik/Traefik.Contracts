using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class RateLimit
	{
		[JsonPropertyName("average")]
		public int Average { get; set; }

		[JsonPropertyName("period")]
		public int Period { get; set; }

		[JsonPropertyName("burst")]
		public int Burst { get; set; }

		[JsonPropertyName("sourceCriterion")]
		public SourceCriterion SourceCriterion { get; set; }
	}
}