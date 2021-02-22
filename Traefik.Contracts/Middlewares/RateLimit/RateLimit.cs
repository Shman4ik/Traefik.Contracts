using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class RateLimit
	{
		[JsonPropertyName("average")]
		public int average { get; set; }

		[JsonPropertyName("period")]
		public int period { get; set; }

		[JsonPropertyName("burst")]
		public int burst { get; set; }

		[JsonPropertyName("sourceCriterion")]
		public SourceCriterion sourceCriterion { get; set; }
	}

}
