using System;

namespace GreenCodeExerciseRaposo.Entities
{
	public class ConsultationDTO
	{
		public int Id { get; set; }

		public int ProviderId{ get; set; }

		public int? DomiciliaryConsultationId { get; set; }

		public bool IsBasicConsultation { get; set; }

		public DateTime IssuedDate { get; set; }
	}
}