using GreenCodeExerciseRaposo.DAL.DTO;
using System.Collections.Generic;
using System.Linq;

namespace GreenCodeExerciseRaposo.DAL
{
	public class BasicConsultationRepository
	{
		private static BasicConsultationRepository _instance;
		private List<ConsultationDTO> _consultations;

		public static BasicConsultationRepository Instance()
		{
			if (_instance == null)
			{
				_instance = new BasicConsultationRepository();
			}

			return _instance;
		}

		public BasicConsultationRepository()
		{

			_consultations = new List<ConsultationDTO>();

			_consultations.Add(new ConsultationDTO
			{
				Id = 1,
				ProviderId = 1,
				IssuedDate = new System.DateTime(2017, 01, 12),
				DomiciliaryConsultationId = 0
			});

			_consultations.Add(new ConsultationDTO
			{
				Id = 2,
				ProviderId = 1,
				IssuedDate = new System.DateTime(2017, 01, 13),
				DomiciliaryConsultationId = 0
			});

			_consultations.Add(new ConsultationDTO
			{
				Id = 3,
				ProviderId = 1,
				IssuedDate = new System.DateTime(2017, 01, 13),
				DomiciliaryConsultationId = 1
			});

			_consultations.Add(new ConsultationDTO
			{
				Id = 4,
				ProviderId = 1,
				IssuedDate = new System.DateTime(2017, 01, 13),
				DomiciliaryConsultationId = 1
			});
		}

		public List<ConsultationDTO> GetConsultationsByProvider(int providerId)
		{
			return _consultations.Where(c => c.IsBasicConsultation && c.ProviderId.Equals(providerId)).ToList();
		}

		public List<ConsultationDTO> GetDomiciliaryConsultationsBy(int idDomiciliary)
		{
			return _consultations.Where(c => !c.IsBasicConsultation && c.DomiciliaryConsultationId.Equals(idDomiciliary)).ToList();
		}
	}
}
