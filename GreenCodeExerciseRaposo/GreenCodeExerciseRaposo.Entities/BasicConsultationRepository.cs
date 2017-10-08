using GreenCodeExerciseRaposo.DAL.DTO;
using System.Collections.Generic;
using System.Linq;

namespace GreenCodeExerciseRaposo.DAL
{
	public static class BasicConsultationRepository
	{
		private static List <ConsultationDTO> _consultations { get; set; }

		public static List<ConsultationDTO> GetConsultationsByProvider(int providerId)
		{
			return _consultations.Where(c => c.IsBasicConsultation && c.ProviderId.Equals(providerId)).ToList();
		}

		public static List<ConsultationDTO> GetDomiciliaryConsultationsBy(int idDomiciliary)
		{
			return _consultations.Where(c => ! c.IsBasicConsultation && c.DomiciliaryConsultationId.Equals(idDomiciliary)).ToList();
		}
    }
}
