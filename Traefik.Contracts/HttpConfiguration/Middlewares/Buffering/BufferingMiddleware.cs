using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	///     How to Read the Request before Forwarding It
	/// </summary>
	public class BufferingMiddleware : BaseMiddleware
	{
		/// <summary>
		///	The Buffering middleware limits the size of requests that can be forwarded to services.
		///	With Buffering, Traefik reads the entire request into memory(possibly buffering large requests into disk), and rejects requests that are over a specified size limit.
		///	This can help services avoid large amounts of data (multipart/form-data for example), and can minimize the time spent sending data to a service.
		/// </summary>
		[JsonPropertyName("buffering")]
		public Buffering Buffering { get; set; }
	}
}