using GreenCodeExerciseRaposo.Models;
using GreenCodeExerciseRaposo.Models.Mappers;
using System.Collections.Generic;
using System.Linq;

namespace GreenCodeExerciseRaposo.DAL
{
	public class BasicConsultationService
	{
		public static List<Consultation> GetConsultationsByProvider(int providerId)
		{
			return BasicConsultationRepository.Instance().GetConsultationsByProvider(providerId).Select(c => BasicConsultationMapper.FromDto(c)).ToList();
		}
	}
}
