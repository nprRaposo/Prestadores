using GreenCodeExerciseRaposo.DAL;
using GreenCodeExerciseRaposo.DAL.DTO;
using GreenCodeExerciseRaposo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenCodeExerciseRaposo.Models.Mappers
{
	public static class DomiciliaryConsultationMapper
	{
		public static DomiciliaryConsultation FromDto(DomiciliaryConsultationDTO consultationDto)
		{
			return new DomiciliaryConsultation
			{
				Id = consultationDto.Id,
				ProviderId = consultationDto.ProviderId,
				DistanceTravelled = consultationDto.DistanceTravelled,
				Consultations = BasicConsultationRepository.Instance().GetDomiciliaryConsultationsBy(consultationDto.Id)
								.Select(c => BasicConsultationMapper.FromDto(c)).ToList()
			};
		}
	}
}
