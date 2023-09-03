using Newtonsoft.Json;

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
		[JsonProperty("compress")]
		public Compress Compress { get; set; }
	}
}