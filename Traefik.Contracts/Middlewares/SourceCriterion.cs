using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class SourceCriterion
	{
		[JsonPropertyName("ipStrategy")]
		public IpStrategy IpStrategy { get; set; }

		[JsonPropertyName("requestHeaderName")]
		public string RequestHeaderName { get; set; }

		[JsonPropertyName("requestHost")]
		public bool RequestHost { get; set; }
	}
}