using System;
using System.Collections.Generic;

namespace GreenCodeExerciseRaposo.Entities
{
	public class DomiciliaryConsultationDTO
	{
		public int Id { get; set; }

		public int ProviderId{ get; set; }

		public DateTime IssuedDate { get; set; }

		public List<ConsultationDTO> Consultations { get; set; }

		public int DistanceTravelled { get; set; }
	}
}