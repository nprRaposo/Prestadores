using GreenCodeExerciseRaposo.DAL.DTO;
using GreenCodeExerciseRaposo.Models;
using System.Linq;

namespace GreenCodeExerciseRaposo.Services.Mappers
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
