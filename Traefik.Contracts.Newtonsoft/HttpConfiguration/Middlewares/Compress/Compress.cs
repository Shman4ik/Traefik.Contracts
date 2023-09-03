using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// The Compress middleware uses gzip compression.
	/// </summary>
	public class Compress
	{
		/// <summary>
		/// excludedContentTypes specifies a list of content types to compare the Content-Type header of the incoming requests and responses before compressing.
		/// The responses with content types defined in excludedContentTypes are not compressed.
		/// Content types are compared in a case-insensitive, whitespace-ignored manner.
		/// </summary>
		/// <example>text/event-stream</example>
		[JsonProperty("excludedContentTypes")]
		public string[] ExcludedContentTypes { get; set; }
	}
}