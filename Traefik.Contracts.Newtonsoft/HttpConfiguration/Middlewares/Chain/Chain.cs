using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// The Chain middleware enables you to define reusable combinations of other pieces of middleware. It makes reusing the same groups easier.
	/// </summary>
	public class Chain
	{
		/// <summary>
		/// Below is an example of a Chain containing WhiteList, BasicAuth, and RedirectScheme.
		/// </summary>
		[JsonProperty("middlewares")]
		public string[] Middlewares { get; set; }
	}
}