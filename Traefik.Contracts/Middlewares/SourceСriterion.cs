using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class SourceСriterion
	{
		[JsonPropertyName("ipStrategy")]
		public IpStrategy ipStrategy { get; set; }

		[JsonPropertyName("requestHeaderName")]
		public string requestHeaderName { get; set; }

		[JsonPropertyName("requestHost")]
		public bool requestHost { get; set; }
	}

}
