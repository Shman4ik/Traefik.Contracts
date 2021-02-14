namespace Traefik.Contracts
{
	public class Headers1
	{
		public Customrequestheaders customRequestHeaders { get; set; }
		public Customresponseheaders customResponseHeaders { get; set; }
		public bool accessControlAllowCredentials { get; set; }
		public string[] accessControlAllowHeaders { get; set; }
		public string[] accessControlAllowMethods { get; set; }
		public string accessControlAllowOrigin { get; set; }
		public string[] accessControlAllowOriginList { get; set; }
		public string[] accessControlAllowOriginListRegex { get; set; }
		public string[] accessControlExposeHeaders { get; set; }
		public int accessControlMaxAge { get; set; }
		public bool addVaryHeader { get; set; }
		public string[] allowedHosts { get; set; }
		public string[] hostsProxyHeaders { get; set; }
		public bool sslRedirect { get; set; }
		public bool sslTemporaryRedirect { get; set; }
		public string sslHost { get; set; }
		public Sslproxyheaders sslProxyHeaders { get; set; }
		public bool sslForceHost { get; set; }
		public int stsSeconds { get; set; }
		public bool stsIncludeSubdomains { get; set; }
		public bool stsPreload { get; set; }
		public bool forceSTSHeader { get; set; }
		public bool frameDeny { get; set; }
		public string customFrameOptionsValue { get; set; }
		public bool contentTypeNosniff { get; set; }
		public bool browserXssFilter { get; set; }
		public string customBrowserXSSValue { get; set; }
		public string contentSecurityPolicy { get; set; }
		public string publicKey { get; set; }
		public string referrerPolicy { get; set; }
		public string featurePolicy { get; set; }
		public bool isDevelopment { get; set; }
	}

}
