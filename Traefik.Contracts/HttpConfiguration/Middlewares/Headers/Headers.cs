using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// Managing Request/Response headers
	/// </summary>
	public class Headers
	{
		/// <summary>
		/// The customRequestHeaders option lists the header names and values to apply to the request.
		/// </summary>
		[JsonPropertyName("customRequestHeaders")]
		public Dictionary<string, string> CustomRequestHeaders { get; set; }

		/// <summary>
		/// The customResponseHeaders option lists the header names and values to apply to the response.
		/// </summary>
		[JsonPropertyName("customResponseHeaders")]
		public Dictionary<string, string> CustomResponseHeaders { get; set; }

		/// <summary>
		/// The accessControlAllowCredentials indicates whether the request can include user credentials.
		/// </summary>
		[JsonPropertyName("accessControlAllowCredentials")]
		public bool AccessControlAllowCredentials { get; set; }

		/// <summary>
		/// The accessControlAllowHeaders indicates which header field names can be used as part of the request.
		/// </summary>
		[JsonPropertyName("accessControlAllowHeaders")]
		public string[] AccessControlAllowHeaders { get; set; }

		/// <summary>
		/// The accessControlAllowMethods indicates which methods can be used during requests.
		/// </summary>
		[JsonPropertyName("accessControlAllowMethods")]
		public string[] AccessControlAllowMethods { get; set; }

		
		[JsonPropertyName("accessControlAllowOrigin")]
		public string AccessControlAllowOrigin { get; set; }

		/// <summary>
		/// The accessControlAllowOriginList indicates whether a resource can be shared by returning different values.
		/// A wildcard origin* can also be configured, and matches all requests.If this value is set by a backend service, it will be overwritten by Traefik.
		/// This value can contain a list of allowed origins.
		/// </summary>
		[JsonPropertyName("accessControlAllowOriginList")]
		public string[] AccessControlAllowOriginList { get; set; }

		/// <summary>
		/// The accessControlAllowOriginListRegex option is the counterpart of the accessControlAllowOriginList option with regular expressions instead of origin values. It allows all origins that contain any match of a regular expression in the accessControlAllowOriginList.
		/// </summary>
		[JsonPropertyName("accessControlAllowOriginListRegex")]
		public string[] AccessControlAllowOriginListRegex { get; set; }

		/// <summary>
		/// The accessControlExposeHeaders indicates which headers are safe to expose to the api of a CORS API specification.
		/// </summary>
		[JsonPropertyName("accessControlExposeHeaders")]
		public string[] AccessControlExposeHeaders { get; set; }

		/// <summary>
		/// The accessControlMaxAge indicates how many seconds a preflight request can be cached for.
		/// </summary>
		[JsonPropertyName("accessControlMaxAge")]
		public int AccessControlMaxAge { get; set; }

		/// <summary>
		/// The addVaryHeader is used in conjunction with accessControlAllowOriginList to determine whether the Vary header should be added or modified to demonstrate that server responses can differ based on the value of the origin header.
		/// </summary>
		[JsonPropertyName("addVaryHeader")]
		public bool AddVaryHeader { get; set; }

		/// <summary>
		/// The allowedHosts option lists fully qualified domain names that are allowed.
		/// </summary>
		[JsonPropertyName("allowedHosts")]
		public string[] AllowedHosts { get; set; }

		/// <summary>
		/// The hostsProxyHeaders option is a set of header keys that may hold a proxied hostname value for the request.
		/// </summary>
		[JsonPropertyName("hostsProxyHeaders")]
		public string[] HostsProxyHeaders { get; set; }

		/// <summary>
		/// The sslRedirect only allow HTTPS requests when set to true.
		/// </summary>
		[JsonPropertyName("sslRedirect")]
		public bool SslRedirect { get; set; }

		/// <summary>
		/// Set sslTemporaryRedirect to true to force an SSL redirection using a 302 (instead of a 301).
		/// </summary>
		[JsonPropertyName("sslTemporaryRedirect")]
		public bool SslTemporaryRedirect { get; set; }

		/// <summary>
		/// The sslHost option is the host name that is used to redirect HTTP requests to HTTPS.
		/// </summary>
		[JsonPropertyName("sslHost")]
		public string SslHost { get; set; }

		/// <summary>
		/// The sslProxyHeaders option is set of header keys with associated values that would indicate a valid HTTPS request. It can be useful when using other proxies (example: "X-Forwarded-Proto": "https").
		/// </summary>
		[JsonPropertyName("sslProxyHeaders")]
		public Dictionary<string, string> SslProxyHeaders { get; set; }

		/// <summary>
		/// Set sslForceHost to true and set sslHost to force requests to use SSLHost regardless of whether they already use SSL.
		/// </summary>
		[JsonPropertyName("sslForceHost")]
		public bool SslForceHost { get; set; }

		/// <summary>
		/// The stsSeconds is the max-age of the Strict-Transport-Security header. If set to 0, the header is not set.
		/// </summary>
		[JsonPropertyName("stsSeconds")]
		public int StsSeconds { get; set; }

		/// <summary>
		/// If the stsIncludeSubdomains is set to true, the includeSubDomains directive is appended to the Strict-Transport-Security header.
		/// </summary>
		[JsonPropertyName("stsIncludeSubdomains")]
		public bool StsIncludeSubdomains { get; set; }

		/// <summary>
		/// Set stsPreload to true to have the preload flag appended to the Strict-Transport-Security header.
		/// </summary>
		[JsonPropertyName("stsPreload")]
		public bool StsPreload { get; set; }

		/// <summary>
		/// Set forceSTSHeader to true to add the STS header even when the connection is HTTP.
		/// </summary>
		[JsonPropertyName("forceSTSHeader")]
		public bool ForceSTSHeader { get; set; }

		/// <summary>
		/// Set frameDeny to true to add the X-Frame-Options header with the value of DENY.
		/// </summary>
		[JsonPropertyName("frameDeny")]
		public bool FrameDeny { get; set; }

		/// <summary>
		/// The customFrameOptionsValue allows the X-Frame-Options header value to be set with a custom value. This overrides the FrameDeny option.
		/// </summary>
		[JsonPropertyName("customFrameOptionsValue")]
		public string CustomFrameOptionsValue { get; set; }

		/// <summary>
		/// Set contentTypeNosniff to true to add the X-Content-Type-Options header with the value nosniff.
		/// </summary>
		[JsonPropertyName("contentTypeNosniff")]
		public bool ContentTypeNosniff { get; set; }

		/// <summary>
		/// Set browserXssFilter to true to add the X-XSS-Protection header with the value 1; mode=block.
		/// </summary>
		[JsonPropertyName("browserXssFilter")]
		public bool BrowserXssFilter { get; set; }

		/// <summary>
		/// The customBrowserXssValue option allows the X-XSS-Protection header value to be set with a custom value. This overrides the BrowserXssFilter option.
		/// </summary>
		[JsonPropertyName("customBrowserXSSValue")]
		public string CustomBrowserXSSValue { get; set; }

		/// <summary>
		/// The contentSecurityPolicy option allows the Content-Security-Policy header value to be set with a custom value.
		/// </summary>
		[JsonPropertyName("contentSecurityPolicy")]
		public string ContentSecurityPolicy { get; set; }

		/// <summary>
		/// The publicKey implements HPKP to prevent MITM attacks with forged certificates.
		/// </summary>
		[JsonPropertyName("publicKey")]
		public string PublicKey { get; set; }

		/// <summary>
		/// The referrerPolicy allows sites to control whether browsers forward the Referer header to other sites.
		/// </summary>
		[JsonPropertyName("referrerPolicy")]
		public string ReferrerPolicy { get; set; }

		/// <summary>
		/// The featurePolicy allows sites to control browser features.
		/// </summary>
		[JsonPropertyName("featurePolicy")]
		public string FeaturePolicy { get; set; }

		/// <summary>
		/// Set isDevelopment to true when developing to mitigate the unwanted effects of the AllowedHosts, SSL, and STS options. Usually testing takes place using HTTP, not HTTPS, and on localhost, not your production domain. If you would like your development environment to mimic production with complete Host blocking, SSL redirects, and STS headers, leave this as false.
		/// </summary>
		[JsonPropertyName("isDevelopment")]
		public bool IsDevelopment { get; set; }
	}
}