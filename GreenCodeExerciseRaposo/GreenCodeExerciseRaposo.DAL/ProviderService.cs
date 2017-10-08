using GreenCodeExerciseRaposo.Models;
using GreenCodeExerciseRaposo.Services.Mappers;
using System.Collections.Generic;
using System.Linq;

namespace GreenCodeExerciseRaposo.DAL
{
	public class ProviderService
	{
		public static List<Provider> GetProviders()
		{
			return ProviderRepository.GetProviders().Select(p => ProviderMapper.FromDto(p)).ToList();
		}
    }
}
