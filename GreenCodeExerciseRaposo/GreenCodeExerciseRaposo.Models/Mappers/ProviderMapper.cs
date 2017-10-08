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
			var provider = new Provider
			{
				Id = providerDto.Id,
				BasicConsultationValue = providerDto.BasicConsultationValue,
				MinimumSalary = providerDto.MinimumSalary,
				Name = providerDto.Name,
				CostPerKm = providerDto.CostPerKm
			};

			provider.Consultations = providerDto.Consultations.Select(c => BasicConsultationMapper.FromDto(c)).ToList();
			provider.Consultations.AddRange(providerDto.DomiciliaryConsultations.Select(dc => DomiciliaryConsultationMapper.FromDto(dc)));

			return provider;
		}
	}
}
