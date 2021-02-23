using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class Buffering
	{
		[JsonPropertyName("maxRequestBodyBytes")]
		public int MaxRequestBodyBytes { get; set; }

		[JsonPropertyName("memRequestBodyBytes")]
		public int MemRequestBodyBytes { get; set; }

		[JsonPropertyName("maxResponseBodyBytes")]
		public int MaxResponseBodyBytes { get; set; }

		[JsonPropertyName("memResponseBodyBytes")]
		public int MemResponseBodyBytes { get; set; }

		[JsonPropertyName("retryExpression")]
		public string RetryExpression { get; set; }
	}
}