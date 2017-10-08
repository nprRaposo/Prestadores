using GreenCodeExerciseRaposo.DAL;
using GreenCodeExerciseRaposo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenCodeExerciseRaposo.Models.Mappers
{
	public static class BasicConsultationMapper
	{
		public static Consultation FromDto(ConsultationDTO consultationDto)
		{
			return new Consultation
			{
				Id = consultationDto.Id,
				IssuedDate = consultationDto.IssuedDate,
				Provider = ProviderMapper.FromDto(ProviderService.GetProviderBy(consultationDto.ProviderId))
			};
		}
	}
}
