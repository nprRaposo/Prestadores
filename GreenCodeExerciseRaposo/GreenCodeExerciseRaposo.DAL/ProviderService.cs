using GreenCodeExerciseRaposo.Models;
using GreenCodeExerciseRaposo.Models.Mappers;
using System.Collections.Generic;
using System.Linq;

namespace GreenCodeExerciseRaposo.DAL
{
	public class ProviderService
	{
		public static List<Provider> GetProviders()
		{
			return ProviderRepository.Instance().GetProviders().Select(p => ProviderMapper.FromDto(p)).ToList();
		}
    }
}
