namespace Traefik.Contracts
{
	public class Info
	{
		public bool notAfter { get; set; }
		public bool notBefore { get; set; }
		public bool sans { get; set; }
		public Subject subject { get; set; }
		public Issuer issuer { get; set; }
		public bool serialNumber { get; set; }
	}

}
