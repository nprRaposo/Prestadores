using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenCodeExerciseRaposo.Models
{
	public class DomiciliaryConsultation : Consultation
	{

		public List<Consultation> Consultations { get; set; }

		public int DistanceTravelled { get; set; }

		public override double GetConsultationCost()
		{
			var totalBasicConsultations = 0.0;

			foreach (var consultation in Consultations)
			{
				totalBasicConsultations += consultation.GetConsultationCost();
			}

			return GetCostOfConsultation(totalBasicConsultations);
		}

		private double GetCostOfConsultation(double totalBasicConsultations)
		{
			return totalBasicConsultations * 1.25 + DistanceTravelled * this.Provider.CostPerKm;
		}
	}
}
