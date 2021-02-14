namespace Traefik.Contracts
{
	public class Redirectregex
	{
		public string regex { get; set; }
		public string replacement { get; set; }
		public bool permanent { get; set; }
	}

}
