using System;

namespace Traefik.Contracts
{

	public class Middlewares
	{
		public Middleware00 Middleware00 { get; set; }
		public Middleware01 Middleware01 { get; set; }
		public Middleware02 Middleware02 { get; set; }
		public Middleware03 Middleware03 { get; set; }
		public Middleware04 Middleware04 { get; set; }
		public Middleware05 Middleware05 { get; set; }
		public Middleware06 Middleware06 { get; set; }
		public Middleware07 Middleware07 { get; set; }
		public Middleware08 Middleware08 { get; set; }
		public Middleware09 Middleware09 { get; set; }
		public Middleware10 Middleware10 { get; set; }
		public Middleware11 Middleware11 { get; set; }
		public Middleware12 Middleware12 { get; set; }
		public Middleware13 Middleware13 { get; set; }
		public Middleware14 Middleware14 { get; set; }
		public Middleware15 Middleware15 { get; set; }
		public Middleware16 Middleware16 { get; set; }
		public Middleware17 Middleware17 { get; set; }
		public Middleware18 Middleware18 { get; set; }
		public Middleware19 Middleware19 { get; set; }
		public Middleware20 Middleware20 { get; set; }
		public Middleware21 Middleware21 { get; set; }
		public Middleware22 Middleware22 { get; set; }
	}

	public class Middleware00
	{
		public Addprefix addPrefix { get; set; }
	}

	public class Addprefix
	{
		public string prefix { get; set; }
	}

	public class Middleware01
	{
		public Basicauth basicAuth { get; set; }
	}

	public class Basicauth
	{
		public string[] users { get; set; }
		public string usersFile { get; set; }
		public string realm { get; set; }
		public bool removeHeader { get; set; }
		public string headerField { get; set; }
	}

	public class Middleware02
	{
		public Buffering buffering { get; set; }
	}

	public class Buffering
	{
		public int maxRequestBodyBytes { get; set; }
		public int memRequestBodyBytes { get; set; }
		public int maxResponseBodyBytes { get; set; }
		public int memResponseBodyBytes { get; set; }
		public string retryExpression { get; set; }
	}

	public class Middleware03
	{
		public Chain chain { get; set; }
	}

	public class Chain
	{
		public string[] middlewares { get; set; }
	}

	public class Middleware04
	{
		public Circuitbreaker circuitBreaker { get; set; }
	}

	public class Circuitbreaker
	{
		public string expression { get; set; }
	}

	public class Middleware05
	{
		public Compress compress { get; set; }
	}

	public class Compress
	{
		public string[] excludedContentTypes { get; set; }
	}

	public class Middleware06
	{
		public Contenttype contentType { get; set; }
	}

	public class Contenttype
	{
		public bool autoDetect { get; set; }
	}

	public class Middleware07
	{
		public Digestauth digestAuth { get; set; }
	}

	public class Digestauth
	{
		public string[] users { get; set; }
		public string usersFile { get; set; }
		public bool removeHeader { get; set; }
		public string realm { get; set; }
		public string headerField { get; set; }
	}

	public class Middleware08
	{
		public Errors errors { get; set; }
	}

	public class Errors
	{
		public string[] status { get; set; }
		public string service { get; set; }
		public string query { get; set; }
	}

	public class Middleware09
	{
		public Forwardauth forwardAuth { get; set; }
	}

	public class Forwardauth
	{
		public string address { get; set; }
		public Tls2 tls { get; set; }
		public bool trustForwardHeader { get; set; }
		public string[] authResponseHeaders { get; set; }
		public string authResponseHeadersRegex { get; set; }
		public string[] authRequestHeaders { get; set; }
	}

	public class Tls2
	{
		public string ca { get; set; }
		public bool caOptional { get; set; }
		public string cert { get; set; }
		public string key { get; set; }
		public bool insecureSkipVerify { get; set; }
	}

	public class Middleware10
	{
		public Headers1 headers { get; set; }
	}

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

	public class Customrequestheaders
	{
		public string name0 { get; set; }
		public string name1 { get; set; }
	}

	public class Customresponseheaders
	{
		public string name0 { get; set; }
		public string name1 { get; set; }
	}

	public class Sslproxyheaders
	{
		public string name0 { get; set; }
		public string name1 { get; set; }
	}

	public class Middleware11
	{
		public Ipwhitelist ipWhiteList { get; set; }
	}

	public class Ipwhitelist
	{
		public string[] sourceRange { get; set; }
		public Ipstrategy ipStrategy { get; set; }
	}

	public class Ipstrategy
	{
		public int depth { get; set; }
		public string[] excludedIPs { get; set; }
	}

	public class Middleware12
	{
		public Inflightreq inFlightReq { get; set; }
	}

	public class Inflightreq
	{
		public int amount { get; set; }
		public Sourcecriterion sourceCriterion { get; set; }
	}

	public class Sourcecriterion
	{
		public Ipstrategy1 ipStrategy { get; set; }
		public string requestHeaderName { get; set; }
		public bool requestHost { get; set; }
	}

	public class Ipstrategy1
	{
		public int depth { get; set; }
		public string[] excludedIPs { get; set; }
	}

	public class Middleware13
	{
		public Passtlsclientcert passTLSClientCert { get; set; }
	}

	public class Passtlsclientcert
	{
		public bool pem { get; set; }
		public Info info { get; set; }
	}

	public class Info
	{
		public bool notAfter { get; set; }
		public bool notBefore { get; set; }
		public bool sans { get; set; }
		public Subject subject { get; set; }
		public Issuer issuer { get; set; }
		public bool serialNumber { get; set; }
	}

	public class Subject
	{
		public bool country { get; set; }
		public bool province { get; set; }
		public bool locality { get; set; }
		public bool organization { get; set; }
		public bool commonName { get; set; }
		public bool serialNumber { get; set; }
		public bool domainComponent { get; set; }
	}

	public class Issuer
	{
		public bool country { get; set; }
		public bool province { get; set; }
		public bool locality { get; set; }
		public bool organization { get; set; }
		public bool commonName { get; set; }
		public bool serialNumber { get; set; }
		public bool domainComponent { get; set; }
	}

	public class Middleware14
	{
		public Plugin plugin { get; set; }
	}

	public class Plugin
	{
		public Pluginconf PluginConf { get; set; }
	}

	public class Pluginconf
	{
		public string foo { get; set; }
	}

	public class Middleware15
	{
		public Ratelimit rateLimit { get; set; }
	}

	public class Ratelimit
	{
		public int average { get; set; }
		public int period { get; set; }
		public int burst { get; set; }
		public Sourcecriterion1 sourceCriterion { get; set; }
	}

	public class Sourcecriterion1
	{
		public Ipstrategy2 ipStrategy { get; set; }
		public string requestHeaderName { get; set; }
		public bool requestHost { get; set; }
	}

	public class Ipstrategy2
	{
		public int depth { get; set; }
		public string[] excludedIPs { get; set; }
	}

	public class Middleware16
	{
		public Redirectregex redirectRegex { get; set; }
	}

	public class Redirectregex
	{
		public string regex { get; set; }
		public string replacement { get; set; }
		public bool permanent { get; set; }
	}

	public class Middleware17
	{
		public Redirectscheme redirectScheme { get; set; }
	}

	public class Redirectscheme
	{
		public string scheme { get; set; }
		public string port { get; set; }
		public bool permanent { get; set; }
	}

	public class Middleware18
	{
		public Replacepath replacePath { get; set; }
	}

	public class Replacepath
	{
		public string path { get; set; }
	}

	public class Middleware19
	{
		public Replacepathregex replacePathRegex { get; set; }
	}

	public class Replacepathregex
	{
		public string regex { get; set; }
		public string replacement { get; set; }
	}

	public class Middleware20
	{
		public Retry retry { get; set; }
	}

	public class Retry
	{
		public int attempts { get; set; }
		public int initialInterval { get; set; }
	}

	public class Middleware21
	{
		public Stripprefix stripPrefix { get; set; }
	}

	public class Stripprefix
	{
		public string[] prefixes { get; set; }
		public bool forceSlash { get; set; }
	}

	public class Middleware22
	{
		public Stripprefixregex stripPrefixRegex { get; set; }
	}

	public class Stripprefixregex
	{
		public string[] regex { get; set; }
	}

	public class Serverstransport1
	{
		public string serverName { get; set; }
		public bool insecureSkipVerify { get; set; }
		public string[] rootCAs { get; set; }
		public Certificate1[] certificates { get; set; }
		public int maxIdleConnsPerHost { get; set; }
		public Forwardingtimeouts1 forwardingTimeouts { get; set; }
	}

	public class Forwardingtimeouts1
	{
		public string dialTimeout { get; set; }
		public string responseHeaderTimeout { get; set; }
		public string idleConnTimeout { get; set; }
	}

	public class Certificate1
	{
		public string certFile { get; set; }
		public string keyFile { get; set; }
	}

	public class Tcp
	{
		public Routers1 routers { get; set; }
		public Services1 services { get; set; }
	}

	public class Routers1
	{
		public Tcprouter0 TCPRouter0 { get; set; }
		public Tcprouter1 TCPRouter1 { get; set; }
	}

	public class Tcprouter0
	{
		public string[] entryPoints { get; set; }
		public string service { get; set; }
		public string rule { get; set; }
		public Tls3 tls { get; set; }
	}

	public class Tls3
	{
		public bool passthrough { get; set; }
		public string options { get; set; }
		public string certResolver { get; set; }
		public Domain2[] domains { get; set; }
	}

	public class Domain2
	{
		public string main { get; set; }
		public string[] sans { get; set; }
	}

	public class Tcprouter1
	{
		public string[] entryPoints { get; set; }
		public string service { get; set; }
		public string rule { get; set; }
		public Tls4 tls { get; set; }
	}

	public class Tls4
	{
		public bool passthrough { get; set; }
		public string options { get; set; }
		public string certResolver { get; set; }
		public Domain3[] domains { get; set; }
	}

	public class Domain3
	{
		public string main { get; set; }
		public string[] sans { get; set; }
	}

	public class Services1
	{
		public Tcpservice01 TCPService01 { get; set; }
		public Tcpservice02 TCPService02 { get; set; }
	}

	public class Tcpservice01
	{
		public Loadbalancer1 loadBalancer { get; set; }
	}

	public class Loadbalancer1
	{
		public int terminationDelay { get; set; }
		public Proxyprotocol proxyProtocol { get; set; }
		public Server1[] servers { get; set; }
	}

	public class Proxyprotocol
	{
		public int version { get; set; }
	}

	public class Server1
	{
		public string address { get; set; }
	}

	public class Tcpservice02
	{
		public Weighted1 weighted { get; set; }
	}

	public class Weighted1
	{
		public Service1[] services { get; set; }
	}

	public class Service1
	{
		public string name { get; set; }
		public int weight { get; set; }
	}

	public class Udp
	{
		public Routers2 routers { get; set; }
		public Services2 services { get; set; }
	}

	public class Routers2
	{
		public Udprouter0 UDPRouter0 { get; set; }
		public Udprouter1 UDPRouter1 { get; set; }
	}

	public class Udprouter0
	{
		public string[] entryPoints { get; set; }
		public string service { get; set; }
	}

	public class Udprouter1
	{
		public string[] entryPoints { get; set; }
		public string service { get; set; }
	}

	public class Services2
	{
		public Udpservice01 UDPService01 { get; set; }
		public Udpservice02 UDPService02 { get; set; }
	}

	public class Udpservice01
	{
		public Loadbalancer2 loadBalancer { get; set; }
	}

	public class Loadbalancer2
	{
		public Server2[] servers { get; set; }
	}

	public class Server2
	{
		public string address { get; set; }
	}

	public class Udpservice02
	{
		public Weighted2 weighted { get; set; }
	}

	public class Weighted2
	{
		public Service2[] services { get; set; }
	}

	public class Service2
	{
		public string name { get; set; }
		public int weight { get; set; }
	}

	public class Tls5
	{
		public Certificate2[] certificates { get; set; }
		public Options options { get; set; }
		public Stores stores { get; set; }
	}

	public class Options
	{
		public Options0 Options0 { get; set; }
		public Options1 Options1 { get; set; }
	}

	public class Options0
	{
		public string minVersion { get; set; }
		public string maxVersion { get; set; }
		public string[] cipherSuites { get; set; }
		public string[] curvePreferences { get; set; }
		public Clientauth clientAuth { get; set; }
		public bool sniStrict { get; set; }
		public bool preferServerCipherSuites { get; set; }
	}

	public class Clientauth
	{
		public string[] caFiles { get; set; }
		public string clientAuthType { get; set; }
	}

	public class Options1
	{
		public string minVersion { get; set; }
		public string maxVersion { get; set; }
		public string[] cipherSuites { get; set; }
		public string[] curvePreferences { get; set; }
		public Clientauth1 clientAuth { get; set; }
		public bool sniStrict { get; set; }
		public bool preferServerCipherSuites { get; set; }
	}

	public class Clientauth1
	{
		public string[] caFiles { get; set; }
		public string clientAuthType { get; set; }
	}

	public class Stores
	{
		public Store0 Store0 { get; set; }
		public Store1 Store1 { get; set; }
	}

	public class Store0
	{
		public Defaultcertificate defaultCertificate { get; set; }
	}

	public class Defaultcertificate
	{
		public string certFile { get; set; }
		public string keyFile { get; set; }
	}

	public class Store1
	{
		public Defaultcertificate1 defaultCertificate { get; set; }
	}

	public class Defaultcertificate1
	{
		public string certFile { get; set; }
		public string keyFile { get; set; }
	}

	public class Certificate2
	{
		public string certFile { get; set; }
		public string keyFile { get; set; }
		public string[] stores { get; set; }
	}

}
