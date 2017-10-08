using GreenCodeExerciseRaposo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenCodeExerciseRaposo.Models.Mappers
{
	public static class ProviderMapper
	{
		public static Provider FromDto(ProviderDTO providerDto)
		{
			return new Provider
			{
				Id = providerDto.Id,
				BasicConsultationValue = providerDto.BasicConsultationValue,
				MinimumSalary = providerDto.MinimumSalary,
				Name = providerDto.Name,
				Consultations = providerDto.Consultations.Select(c => ConsultationMapper.FromDto(c)).ToList()
			};
		}
	}
}
