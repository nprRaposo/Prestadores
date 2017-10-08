using System;

namespace GreenCodeExerciseRaposo.Entities
{
	public class ConsultationDTO
	{
		public int Id { get; set; }

		public int ProviderId { get; set; }

		public DateTime IssuedDate { get; set; }
	}
}