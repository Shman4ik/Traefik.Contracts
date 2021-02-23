using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class Headers
	{
		[JsonPropertyName("customRequestHeaders")]
		public Dictionary<string, string> CustomRequestHeaders { get; set; }

		[JsonPropertyName("customResponseHeaders")]
		public Dictionary<string, string> CustomResponseHeaders { get; set; }

		[JsonPropertyName("accessControlAllowCredentials")]
		public bool AccessControlAllowCredentials { get; set; }

		[JsonPropertyName("accessControlAllowHeaders")]
		public string[] AccessControlAllowHeaders { get; set; }

		[JsonPropertyName("accessControlAllowMethods")]
		public string[] AccessControlAllowMethods { get; set; }

		[JsonPropertyName("accessControlAllowOrigin")]
		public string AccessControlAllowOrigin { get; set; }

		[JsonPropertyName("accessControlAllowOriginList")]
		public string[] AccessControlAllowOriginList { get; set; }

		[JsonPropertyName("accessControlAllowOriginListRegex")]
		public string[] AccessControlAllowOriginListRegex { get; set; }

		[JsonPropertyName("accessControlExposeHeaders")]
		public string[] AccessControlExposeHeaders { get; set; }

		[JsonPropertyName("accessControlMaxAge")]
		public int AccessControlMaxAge { get; set; }

		[JsonPropertyName("addVaryHeader")]
		public bool AddVaryHeader { get; set; }

		[JsonPropertyName("allowedHosts")]
		public string[] AllowedHosts { get; set; }

		[JsonPropertyName("hostsProxyHeaders")]
		public string[] HostsProxyHeaders { get; set; }

		[JsonPropertyName("sslRedirect")]
		public bool SslRedirect { get; set; }

		[JsonPropertyName("sslTemporaryRedirect")]
		public bool SslTemporaryRedirect { get; set; }

		[JsonPropertyName("sslHost")]
		public string SslHost { get; set; }

		[JsonPropertyName("sslProxyHeaders")]
		public Dictionary<string, string> SslProxyHeaders { get; set; }

		[JsonPropertyName("sslForceHost")]
		public bool SslForceHost { get; set; }

		[JsonPropertyName("stsSeconds")]
		public int StsSeconds { get; set; }

		[JsonPropertyName("stsIncludeSubdomains")]
		public bool StsIncludeSubdomains { get; set; }

		[JsonPropertyName("stsPreload")]
		public bool StsPreload { get; set; }

		[JsonPropertyName("forceSTSHeader")]
		public bool ForceSTSHeader { get; set; }

		[JsonPropertyName("frameDeny")]
		public bool FrameDeny { get; set; }

		[JsonPropertyName("customFrameOptionsValue")]
		public string CustomFrameOptionsValue { get; set; }

		[JsonPropertyName("contentTypeNosniff")]
		public bool ContentTypeNosniff { get; set; }

		[JsonPropertyName("browserXssFilter")]
		public bool BrowserXssFilter { get; set; }

		[JsonPropertyName("customBrowserXSSValue")]
		public string CustomBrowserXSSValue { get; set; }

		[JsonPropertyName("contentSecurityPolicy")]
		public string ContentSecurityPolicy { get; set; }

		[JsonPropertyName("publicKey")]
		public string PublicKey { get; set; }

		[JsonPropertyName("referrerPolicy")]
		public string ReferrerPolicy { get; set; }

		[JsonPropertyName("featurePolicy")]
		public string FeaturePolicy { get; set; }

		[JsonPropertyName("isDevelopment")]
		public bool IsDevelopment { get; set; }
	}
}