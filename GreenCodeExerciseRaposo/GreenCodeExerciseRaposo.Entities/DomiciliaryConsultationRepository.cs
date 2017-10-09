using GreenCodeExerciseRaposo.DAL.DTO;
using System.Collections.Generic;
using System.Linq;

namespace GreenCodeExerciseRaposo.DAL
{
	public class DomiciliaryConsultationRepository
	{

		private static DomiciliaryConsultationRepository _instance;
		private List<DomiciliaryConsultationDTO> _consultations;

		public static DomiciliaryConsultationRepository Instance()
		{
			if (_instance == null)
			{
				_instance = new DomiciliaryConsultationRepository();
			}

			return _instance;
		}

		public DomiciliaryConsultationRepository()
		{
			_consultations = new List<DomiciliaryConsultationDTO>();

			_consultations.Add(new DomiciliaryConsultationDTO
			{
				Id = 1,
				DistanceTravelled = 10,
				ProviderId = 1,
				Consultations = BasicConsultationRepository.Instance().GetDomiciliaryConsultationsBy(1)
			});
		}


		public List<DomiciliaryConsultationDTO> GetConsultationsByProvider(int providerId)
		{
			return _consultations.Where(c => c.ProviderId.Equals(providerId)).ToList();
		}
	}
}
