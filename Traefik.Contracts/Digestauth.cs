namespace Traefik.Contracts
{
	public class Digestauth
	{
		public string[] users { get; set; }
		public string usersFile { get; set; }
		public bool removeHeader { get; set; }
		public string realm { get; set; }
		public string headerField { get; set; }
	}

}
