using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// The tls option is the TLS configuration from Traefik to the authentication server.
	/// </summary>
	public class Tls
	{
		/// <summary>
		/// Certificate Authority used for the secured connection to the authentication server.
		/// </summary>
		[JsonPropertyName("ca")]
		public string Ca { get; set; }

		/// <summary>
		/// The value of tls.caOptional defines which policy should be used for the secure connection with TLS Client Authentication to the authentication server.
		/// </summary>
		[JsonPropertyName("caOptional")]
		public bool CaOptional { get; set; }

		/// <summary>
		/// The public certificate used for the secure connection to the authentication server.
		/// </summary>
		[JsonPropertyName("cert")]
		public string Cert { get; set; }

		/// <summary>
		/// The private certificate used for the secure connection to the authentication server.
		/// </summary>
		[JsonPropertyName("key")]
		public string Key { get; set; }

		/// <summary>
		/// If insecureSkipVerify is true, the TLS connection to the authentication server accepts any certificate presented by the server regardless of the hostnames it covers.
		/// </summary>
		[JsonPropertyName("insecureSkipVerify")]
		public bool InsecureSkipVerify { get; set; }
	}
}