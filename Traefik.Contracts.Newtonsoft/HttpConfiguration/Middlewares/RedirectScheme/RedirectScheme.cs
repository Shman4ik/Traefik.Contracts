using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// RedirectScheme redirects requests from a scheme/port to another.
	/// </summary>
	public class RedirectScheme
	{
		/// <summary>
		/// The scheme option defines the scheme of the new URL.
		/// </summary>
		[JsonProperty("scheme")]
		public string Scheme { get; set; }

		/// <summary>
		/// The port option defines the port of the new URL.
		/// </summary>
		[JsonProperty("port")]
		public string Port { get; set; }

		/// <summary>
		/// Set the permanent option to true to apply a permanent redirection.
		/// </summary>
		[JsonProperty("permanent")]
		public bool Permanent { get; set; }
	}
}