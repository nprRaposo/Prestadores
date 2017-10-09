using System;
using System.Collections.Generic;

namespace GreenCodeExerciseRaposo.DAL.DTO
{
	public class DomiciliaryConsultationDTO
	{
		public int Id { get; set; }

		public int ProviderId{ get; set; }

		public List<ConsultationDTO> Consultations { get; set; }

		public int DistanceTravelled { get; set; }
	}
}