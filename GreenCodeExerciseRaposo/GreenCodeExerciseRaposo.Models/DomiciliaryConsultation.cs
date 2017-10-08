using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenCodeExerciseRaposo.Models
{
	public class DomiciliaryConsultation : Consultation
	{
		public override int GetConsultationCost()
		{
			return base.GetConsultationCost() + 0;
		}
	}
}
