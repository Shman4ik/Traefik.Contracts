using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	/// <summary>
	/// The AddPrefix middleware updates the path of a request before forwarding it.
	/// </summary>
	public class AddPrefix
	{
		/// <summary>
		/// is the string to add before the current path in the requested URL. It should include a leading slash '/'
		/// </summary>
		/// <example>
		/// "/foo"
		/// </example>
		[JsonPropertyName("prefix")]
		public string Prefix { get; set; }
	}
}
