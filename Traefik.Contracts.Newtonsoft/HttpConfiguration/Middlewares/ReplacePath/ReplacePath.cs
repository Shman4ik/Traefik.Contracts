using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// Replace the path of the request URL.
	/// </summary>
	public class ReplacePath
	{
		/// <summary>
		/// The path option defines the path to use as replacement in the request URL.
		/// </summary>
		[JsonProperty("path")]
		public string Path { get; set; }
	}
}