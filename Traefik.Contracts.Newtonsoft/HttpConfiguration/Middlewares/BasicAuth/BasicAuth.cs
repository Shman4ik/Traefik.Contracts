using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// The BasicAuth middleware restricts access to your services to known users.
	/// </summary>
	/// <remarks>Passwords must be hashed using MD5, SHA1, or BCrypt.</remarks>
	public class BasicAuth
	{
		/// <summary>
		/// The users option is an array of authorized users. Each user must be declared using the name:hashed-password format.
		/// </summary>
		[JsonProperty("users")]
		public string[] Users { get; set; }

		/// <summary>
		/// The usersFile option is the path to an external file that contains the authorized users for the middleware.
		/// The file content is a list of name:hashed-password.
		/// </summary>
		[JsonProperty("usersFile")]
		public string UsersFile { get; set; }

		/// <summary>
		/// You can customize the realm for the authentication with the realm option. The default value is traefik.
		/// </summary>
		[JsonProperty("realm")]
		public string Realm { get; set; }

		/// <summary>
		/// Set the removeHeader option to true to remove the authorization header before forwarding the request to your service. (Default value is false.)
		/// </summary>
		[JsonProperty("removeHeader")]
		public bool RemoveHeader { get; set; }

		/// <summary>
		/// You can define a header field to store the authenticated user using the headerField option.
		/// </summary>
		[JsonProperty("headerField")]
		public string HeaderField { get; set; }
	}
}