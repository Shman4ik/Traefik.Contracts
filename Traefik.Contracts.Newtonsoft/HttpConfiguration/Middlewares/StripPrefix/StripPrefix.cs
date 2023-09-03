using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// Remove the specified prefixes from the URL path.
	/// </summary>
	public class StripPrefix
	{
		/// <summary>
		/// The prefixes option defines the prefixes to strip from the request URL.
		/// For instance, /products also matches /products/shoes and /products/shirts.
		/// </summary>
		[JsonProperty("prefixes")]
		public string[] Prefixes { get; set; }

		/// <summary>
		/// The forceSlash option ensures the resulting stripped path is not the empty string, by replacing it with / when necessary.
		/// </summary>
		[JsonProperty("forceSlash")]
		public bool ForceSlash { get; set; }
	}
}