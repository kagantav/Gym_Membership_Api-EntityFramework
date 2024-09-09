namespace Gym_Membership.Models.Dtos
{
	public class MemberEditDto
	{
		public int Id { get; set; }
        public string UyeAdi { get; set; }
		public string UyeSoyadi { get; set; }

		public DateTime UyelikBitisTarihi { get; set; }

	}
}
