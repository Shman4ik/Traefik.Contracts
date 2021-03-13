using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// Compress Responses before Sending them to the Client
	/// </summary>
	public class CompressMiddleware : BaseMiddleware
	{
		/// <summary>
		/// The Compress middleware uses gzip compression.
		/// </summary>
		[JsonPropertyName("compress")]
		public Compress Compress { get; set; }
	}
}