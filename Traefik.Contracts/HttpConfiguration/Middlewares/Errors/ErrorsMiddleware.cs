using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// It Has Never Been Easier to Say That Something Went Wrong
	/// </summary>
	public class ErrorsMiddleware : BaseMiddleware
	{
		/// <summary>
		/// The ErrorPage middleware returns a custom page in lieu of the default, according to configured ranges of HTTP Status codes.
		/// </summary>
		[JsonPropertyName("errors")]
		public Errors Errors { get; set; }
	}
}