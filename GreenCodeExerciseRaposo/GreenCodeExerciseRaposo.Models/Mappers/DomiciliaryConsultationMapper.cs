using GreenCodeExerciseRaposo.DAL;
using GreenCodeExerciseRaposo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenCodeExerciseRaposo.Models.Mappers
{
	public static class DomiciliaryConsultationMapper
	{
		public static Consultation FromDto(DomiciliaryConsultationDTO consultationDto)
		{
			return new DomiciliaryConsultation
			{
				Id = consultationDto.Id,
				IssuedDate = consultationDto.IssuedDate,
				Provider = ProviderMapper.FromDto(ProviderService.GetProviderBy(consultationDto.ProviderId)),
				DistanceTravelled = consultationDto.DistanceTravelled,
				Consultations = BasicConsultationService.GetDomiciliaryConsultationsBy(consultationDto.Id)
								.Select(c => BasicConsultationMapper.FromDto(c)).ToList()
			};
		}
	}
}
