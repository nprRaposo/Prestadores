using GreenCodeExerciseRaposo.Models;
using GreenCodeExerciseRaposo.Services.Mappers;
using System.Collections.Generic;
using System.Linq;

namespace GreenCodeExerciseRaposo.DAL
{
	public class BasicConsultationService
	{
		public static List<Consultation> GetConsultationsByProvider(int providerId)
		{
			return BasicConsultationRepository.GetConsultationsByProvider(providerId).Select(c => BasicConsultationMapper.FromDto(c)).ToList();
		}
	}
}
