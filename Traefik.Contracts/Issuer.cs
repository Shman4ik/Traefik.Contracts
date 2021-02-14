namespace Traefik.Contracts
{
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

}
