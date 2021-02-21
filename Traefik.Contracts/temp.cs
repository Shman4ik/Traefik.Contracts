namespace Traefik.Contracts
{
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
