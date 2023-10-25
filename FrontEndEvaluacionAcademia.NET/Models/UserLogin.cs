namespace FrontEndEvaluacionAcademia.NET.Models
{
	public class UserLogin
	{
		public int CodeUser { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Dni { get; set; }
		public bool IsActive { get; set; }
		public string Token { get; set; }
	}
}
