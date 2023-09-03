using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// The ForwardAuth middleware delegates authentication to an external service. If the service answers with a 2XX code, access is granted, and the original request is performed. Otherwise, the response from the authentication server is returned.
	/// </summary>
	public class ForwardAuth
	{
		/// <summary>
		/// The address option defines the authentication server address.
		/// </summary>
		[JsonProperty("address")]
		public string Address { get; set; }

		/// <summary>
		/// The tls option is the TLS configuration from Traefik to the authentication server.
		/// </summary>
		[JsonProperty("tls")]
		public Tls Tls { get; set; }

		/// <summary>
		/// Set the trustForwardHeader option to true to trust all X-Forwarded-* headers.
		/// </summary>
		[JsonProperty("trustForwardHeader")]
		public bool TrustForwardHeader { get; set; }

		/// <summary>
		/// The authResponseHeaders option is the list of headers to copy from the authentication server response and set on forwarded request, replacing any existing conflicting headers.
		/// </summary>
		[JsonProperty("authResponseHeaders")]
		public string[] AuthResponseHeaders { get; set; }

		/// <summary>
		/// The authResponseHeadersRegex option is the regex to match headers to copy from the authentication server response and set on forwarded request, after stripping all headers that match the regex. It allows partial matching of the regular expression against the header key. The start of string (^) and end of string ($) anchors should be used to ensure a full match against the header key.
		/// </summary>
		[JsonProperty("authResponseHeadersRegex")]
		public string AuthResponseHeadersRegex { get; set; }

		/// <summary>
		/// The authRequestHeaders option is the list of the headers to copy from the request to the authentication server. It allows filtering headers that should not be passed to the authentication server. If not set or empty then all request headers are passed.
		/// </summary>
		[JsonProperty("authRequestHeaders")]
		public string[] AuthRequestHeaders { get; set; }
	}
}