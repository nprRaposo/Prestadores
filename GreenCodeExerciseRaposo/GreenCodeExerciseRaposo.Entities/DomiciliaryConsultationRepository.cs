using GreenCodeExerciseRaposo.DAL.DTO;
using System.Collections.Generic;
using System.Linq;

namespace GreenCodeExerciseRaposo.DAL
{
	public class DomiciliaryConsultationRepository
	{
		private static List <DomiciliaryConsultationDTO> _consultations { get; set; }

		public static List<DomiciliaryConsultationDTO> GetConsultationsByProvider(int providerId)
		{
			return _consultations.Where(c => c.ProviderId.Equals(providerId)).ToList();
		}
    }
}
