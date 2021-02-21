using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class Headers
	{
		[JsonPropertyName("customRequestHeaders")]
		public Dictionary<string, string> customRequestHeaders { get; set; }

		[JsonPropertyName("customResponseHeaders")]
		public Dictionary<string, string> customResponseHeaders { get; set; }

		[JsonPropertyName("accessControlAllowCredentials")]
		public bool accessControlAllowCredentials { get; set; }
		[JsonPropertyName("accessControlAllowHeaders")]
		public string[] accessControlAllowHeaders { get; set; }
		[JsonPropertyName("accessControlAllowMethods")]
		public string[] accessControlAllowMethods { get; set; }
		[JsonPropertyName("accessControlAllowOrigin")]
		public string accessControlAllowOrigin { get; set; }
		[JsonPropertyName("accessControlAllowOriginList")]
		public string[] accessControlAllowOriginList { get; set; }
		[JsonPropertyName("accessControlAllowOriginListRegex")]
		public string[] accessControlAllowOriginListRegex { get; set; }
		[JsonPropertyName("accessControlExposeHeaders")]
		public string[] accessControlExposeHeaders { get; set; }
		[JsonPropertyName("accessControlMaxAge")]
		public int accessControlMaxAge { get; set; }
		[JsonPropertyName("addVaryHeader")]
		public bool addVaryHeader { get; set; }
		[JsonPropertyName("allowedHosts")]
		public string[] allowedHosts { get; set; }
		[JsonPropertyName("hostsProxyHeaders")]
		public string[] hostsProxyHeaders { get; set; }
		[JsonPropertyName("sslRedirect")]
		public bool sslRedirect { get; set; }
		[JsonPropertyName("sslTemporaryRedirect")]
		public bool sslTemporaryRedirect { get; set; }
		[JsonPropertyName("sslHost")]
		public string sslHost { get; set; }
		[JsonPropertyName("sslProxyHeaders")]
		public Dictionary<string, string> sslProxyHeaders { get; set; }
		[JsonPropertyName("sslForceHost")]
		public bool sslForceHost { get; set; }
		[JsonPropertyName("stsSeconds")]
		public int stsSeconds { get; set; }
		[JsonPropertyName("stsIncludeSubdomains")]
		public bool stsIncludeSubdomains { get; set; }
		[JsonPropertyName("stsPreload")]
		public bool stsPreload { get; set; }
		[JsonPropertyName("forceSTSHeader")]
		public bool forceSTSHeader { get; set; }
		[JsonPropertyName("frameDeny")]
		public bool frameDeny { get; set; }
		[JsonPropertyName("customFrameOptionsValue")]
		public string customFrameOptionsValue { get; set; }
		[JsonPropertyName("contentTypeNosniff")]
		public bool contentTypeNosniff { get; set; }
		[JsonPropertyName("browserXssFilter")]
		public bool browserXssFilter { get; set; }
		[JsonPropertyName("customBrowserXSSValue")]
		public string customBrowserXSSValue { get; set; }
		[JsonPropertyName("contentSecurityPolicy")]
		public string contentSecurityPolicy { get; set; }
		[JsonPropertyName("publicKey")]
		public string publicKey { get; set; }
		[JsonPropertyName("referrerPolicy")]
		public string referrerPolicy { get; set; }
		[JsonPropertyName("featurePolicy")]
		public string featurePolicy { get; set; }
		[JsonPropertyName("isDevelopment")]
		public bool isDevelopment { get; set; }
	}

}
