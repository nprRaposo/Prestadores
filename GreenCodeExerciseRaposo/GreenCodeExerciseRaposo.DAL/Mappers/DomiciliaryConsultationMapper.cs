using GreenCodeExerciseRaposo.DAL;
using GreenCodeExerciseRaposo.DAL.DTO;
using GreenCodeExerciseRaposo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenCodeExerciseRaposo.Services.Mappers
{
	public static class DomiciliaryConsultationMapper
	{
		public static DomiciliaryConsultation FromDto(DomiciliaryConsultationDTO consultationDto)
		{
			return new DomiciliaryConsultation
			{
				Id = consultationDto.Id,
				IssuedDate = consultationDto.IssuedDate,
				Provider = ProviderMapper.FromDto(ProviderRepository.GetProviderBy(consultationDto.ProviderId)),
				DistanceTravelled = consultationDto.DistanceTravelled,
				Consultations = BasicConsultationRepository.GetDomiciliaryConsultationsBy(consultationDto.Id)
								.Select(c => BasicConsultationMapper.FromDto(c)).ToList()
			};
		}
	}
}
