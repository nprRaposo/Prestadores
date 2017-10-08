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
		private List <ProviderDTO> _providers { get; set; }

		public List<ProviderDTO> GetProviders()
		{
			return new List<ProviderDTO>();
		}

		public ProviderDTO GetProviderBy(int id)
		{
			return this._providers.FirstOrDefault(p => p.Id.Equals(id));
		}
    }
}
