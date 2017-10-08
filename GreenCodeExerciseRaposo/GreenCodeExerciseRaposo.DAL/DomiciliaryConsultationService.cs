using GreenCodeExerciseRaposo.Models;
using GreenCodeExerciseRaposo.Services.Mappers;
using System.Collections.Generic;
using System.Linq;

namespace GreenCodeExerciseRaposo.DAL
{
	public class DomiciliaryConsultationService
	{
		public static List<DomiciliaryConsultation> GetConsultationsByProvider(int providerId)
		{
			return DomiciliaryConsultationRepository.GetConsultationsByProvider(providerId).Select(dc => DomiciliaryConsultationMapper.FromDto(dc)).ToList();
		}
    }
}
