using GreenCodeExerciseRaposo.Entities;
using System.Collections.Generic;
using System.Linq;

namespace GreenCodeExerciseRaposo.DAL
{
	public class ConsultationService
	{
		private List <ConsultationDTO> _consultations { get; set; }

		public List<ConsultationDTO> GetConsultations()
		{
			return new List<ConsultationDTO>();
		}

		public ConsultationDTO GetConsultationBy(int id)
		{
			return this._consultations.FirstOrDefault(p => p.Id.Equals(id));
		}
    }
}
