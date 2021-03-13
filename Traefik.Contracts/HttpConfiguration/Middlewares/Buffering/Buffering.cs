using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// The Buffering middleware limits the size of requests that can be forwarded to services.
	/// With Buffering, Traefik reads the entire request into memory(possibly buffering large requests into disk), and rejects requests that are over a specified size limit.
	/// This can help services avoid large amounts of data (multipart/form-data for example), and can minimize the time spent sending data to a service.
	/// </summary>
	public class Buffering
	{
		/// <summary>
		/// The maxRequestBodyBytes option configures the maximum allowed body size for the request (in bytes).
		/// If the request exceeds the allowed size, it is not forwarded to the service, and the client gets a 413 (Request Entity Too Large) response.
		/// </summary>
		[JsonPropertyName("maxRequestBodyBytes")]
		public int MaxRequestBodyBytes { get; set; }

		/// <summary>
		/// You can configure a threshold (in bytes) from which the request will be buffered on disk instead of in memory with the memRequestBodyBytes option.
		/// </summary>
		[JsonPropertyName("memRequestBodyBytes")]
		public int MemRequestBodyBytes { get; set; }

		/// <summary>
		/// The maxResponseBodyBytes option configures the maximum allowed response size from the service (in bytes).
		/// If the response exceeds the allowed size, it is not forwarded to the client.The client gets a 413 (Request Entity Too Large) response instead.
		/// </summary>
		[JsonPropertyName("maxResponseBodyBytes")]
		public int MaxResponseBodyBytes { get; set; }

		/// <summary>
		/// You can configure a threshold (in bytes) from which the response will be buffered on disk instead of in memory with the memResponseBodyBytes option.
		/// </summary>
		[JsonPropertyName("memResponseBodyBytes")]
		public int MemResponseBodyBytes { get; set; }

		/// <summary>
		/// You can have the Buffering middleware replay the request using retryExpression.
		/// </summary>
		[JsonPropertyName("retryExpression")]
		public string RetryExpression { get; set; }
	}
}