using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenCodeExerciseRaposo.Models
{
	public class Consultation
	{
		public int Id { get; set; }

		public int ProviderId { get; set; }

		public DateTime IssuedDate { get; set; }

		public virtual int GetConsultationCost()
		{
			return 0;
		}
	}
}
