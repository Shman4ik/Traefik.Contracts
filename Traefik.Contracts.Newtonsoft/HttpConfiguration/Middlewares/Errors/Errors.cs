using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// The ErrorPage middleware returns a custom page in lieu of the default, according to configured ranges of HTTP Status codes.
	/// </summary>
	public class Errors
	{
		/// <summary>
		/// The status option defines which status or range of statuses should result in an error page.
		/// The status code ranges are inclusive(500-599 will trigger with every code between 500 and 599, 500 and 599 included).
		/// </summary>
		[JsonProperty("status")]
		public string[] Status { get; set; }

		/// <summary>
		/// The service that will serve the new requested error page.
		/// </summary>
		[JsonProperty("service")]
		public string Service { get; set; }

		/// <summary>
		/// The URL for the error page (hosted by service). You can use the {status} variable in the query option in order to insert the status code in the URL.
		/// </summary>
		[JsonProperty("query")]
		public string Query { get; set; }
	}
}