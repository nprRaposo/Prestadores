using GreenCodeExerciseRaposo.DAL;
using GreenCodeExerciseRaposo.DAL.DTO;
using GreenCodeExerciseRaposo.Models;

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
				ProviderId = consultationDto.ProviderId
			};
		}
	}
}
