using GreenCodeExerciseRaposo.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenCodeExerciseRaposo.DAL
{
	public class ProviderRepository
	{
		private static ProviderRepository _instance;
		private List<ProviderDTO> _providers;

		public static ProviderRepository Instance()
		{
			if (_instance == null)
			{
				_instance = new ProviderRepository();
			}

			return _instance;
		}

		public ProviderRepository()
		{

			_providers = new List<ProviderDTO>();
			_providers.Add(new ProviderDTO
			{
				Id = 1,
				BasicConsultationValue = 500,
				CostPerKm = 100,
				MinimumSalary = 40000,
				Name = "Carlos Sanchez",
				Consultations = BasicConsultationRepository.Instance().GetConsultationsByProvider(1),
				DomiciliaryConsultations = DomiciliaryConsultationRepository.Instance().GetConsultationsByProvider(1)
			});

			_providers.Add(new ProviderDTO
			{
				Id = 2,
				BasicConsultationValue = 600,
				CostPerKm = 10,
				MinimumSalary = 30000,
				Name = "Matias Ramirez",
				Consultations = BasicConsultationRepository.Instance().GetConsultationsByProvider(2),
				DomiciliaryConsultations = DomiciliaryConsultationRepository.Instance().GetConsultationsByProvider(2)
			});

			_providers.Add(new ProviderDTO
			{
				Id = 3,
				BasicConsultationValue = 1000,
				CostPerKm = 1000,
				MinimumSalary = 41000,
				Name = "Federico Fernandez",
				Consultations = BasicConsultationRepository.Instance().GetConsultationsByProvider(3),
				DomiciliaryConsultations = DomiciliaryConsultationRepository.Instance().GetConsultationsByProvider(3)
			});

			_providers.Add(new ProviderDTO
			{
				Id = 4,
				BasicConsultationValue = 500,
				CostPerKm = 60,
				MinimumSalary = 45000,
				Name = "Clara Burgos",
				Consultations = BasicConsultationRepository.Instance().GetConsultationsByProvider(4),
				DomiciliaryConsultations = DomiciliaryConsultationRepository.Instance().GetConsultationsByProvider(4)
			});
		}

		public List<ProviderDTO> GetProviders()
		{
			return _providers;
		}

		public ProviderDTO GetProviderBy(int id)
		{
			return _providers.FirstOrDefault(p => p.Id.Equals(id));
		}
	}
}
