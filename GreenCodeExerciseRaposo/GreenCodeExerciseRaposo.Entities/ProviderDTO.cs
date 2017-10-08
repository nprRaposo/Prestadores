using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenCodeExerciseRaposo.Entities
{
	public class ProviderDTO
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public int BasicConsultationValue { get; set; }

		public int MinimumSalary { get; set; }

		public List<ConsultationDTO> Consultations { get; set; }
	}
}
