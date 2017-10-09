using GreenCodeExerciseRaposo.Models;
using GreenCodeExerciseRaposo.Models.Mappers;
using System.Collections.Generic;
using System.Linq;

namespace GreenCodeExerciseRaposo.DAL
{
	public class DomiciliaryConsultationService
	{
		public static List<DomiciliaryConsultation> GetConsultationsByProvider(int providerId)
		{
			return DomiciliaryConsultationRepository.Instance().GetConsultationsByProvider(providerId).Select(dc => DomiciliaryConsultationMapper.FromDto(dc)).ToList();
		}
    }
}
