namespace Traefik.Contracts
{
	public class Tls2
	{
		public string ca { get; set; }
		public bool caOptional { get; set; }
		public string cert { get; set; }
		public string key { get; set; }
		public bool insecureSkipVerify { get; set; }
	}

}
