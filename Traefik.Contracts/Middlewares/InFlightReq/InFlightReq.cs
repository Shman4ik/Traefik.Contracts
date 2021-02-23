using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class InFlightReq
	{
		[JsonPropertyName("amount")]
		public int amount { get; set; }

		[JsonPropertyName("sourceCriterion")]
		public SourceCriterion sourceCriterion { get; set; }
	}

}
