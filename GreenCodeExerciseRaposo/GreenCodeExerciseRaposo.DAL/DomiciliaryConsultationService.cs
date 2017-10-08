using GreenCodeExerciseRaposo.Entities;
using System.Collections.Generic;
using System.Linq;

namespace GreenCodeExerciseRaposo.DAL
{
	public class DomiciliaryConsultationService
	{
		private static List <DomiciliaryConsultationDTO> _consultations { get; set; }

		public static List<DomiciliaryConsultationDTO> GetConsultationsByProvider(int providerId)
		{
			return _consultations.Where(c => c.ProviderId.Equals(providerId)).ToList();
		}
    }
}
