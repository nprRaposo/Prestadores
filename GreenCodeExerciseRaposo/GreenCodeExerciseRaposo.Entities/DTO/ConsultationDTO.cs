using System;

namespace GreenCodeExerciseRaposo.DAL.DTO
{
	public class ConsultationDTO
	{
		public int Id { get; set; }

		public int ProviderId{ get; set; }

		public int DomiciliaryConsultationId { get; set; }

		public bool IsBasicConsultation { get { return DomiciliaryConsultationId == 0; } }

		public DateTime IssuedDate { get; set; }
	}
}