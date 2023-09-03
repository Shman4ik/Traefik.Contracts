using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// When One Isn't Enough
	/// </summary>
	public class ChainMiddleware : BaseMiddleware
	{
		/// <summary>
		/// The Chain middleware enables you to define reusable combinations of other pieces of middleware. It makes reusing the same groups easier.
		/// </summary>
		[JsonProperty("chain")]
		public Chain Chain { get; set; }
	}
}