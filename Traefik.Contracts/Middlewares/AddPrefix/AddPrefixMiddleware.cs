using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	/// <summary>
	///     The AddPrefix middleware updates the path of a request before forwarding it.
	/// </summary>
	public class AddPrefixMiddleware : BaseMiddleware
	{
		[JsonPropertyName("addPrefix")]
		public AddPrefix AddPrefix { get; set; }
	}
}