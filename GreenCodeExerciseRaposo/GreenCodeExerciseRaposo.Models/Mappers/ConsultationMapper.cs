using GreenCodeExerciseRaposo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenCodeExerciseRaposo.Models.Mappers
{
	public static class ConsultationMapper
	{
		public static Consultation FromDto(ConsultationDTO consultationDto)
		{
			return new Consultation
			{
				Id = consultationDto.Id,
				IssuedDate = consultationDto.IssuedDate,
				ProviderId = consultationDto.ProviderId
			};
		}
	}
}
