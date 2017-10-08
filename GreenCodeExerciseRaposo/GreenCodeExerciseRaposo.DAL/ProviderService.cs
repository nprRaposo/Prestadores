using GreenCodeExerciseRaposo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenCodeExerciseRaposo.DAL
{
    public class ProviderService
	{
		private static List <ProviderDTO> _providers { get; set; }

		public static List<ProviderDTO> GetProviders()
		{
			return new List<ProviderDTO>();
		}

		public static ProviderDTO GetProviderBy(int id)
		{
			return _providers.FirstOrDefault(p => p.Id.Equals(id));
		}
    }
}
