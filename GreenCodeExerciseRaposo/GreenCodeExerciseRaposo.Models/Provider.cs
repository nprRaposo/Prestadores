using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenCodeExerciseRaposo.Models
{
    public class Provider
    {
		public int Id { get; set; }

		public string Name { get; set; }

		public int BasicConsultationValue { get; set; }

		public int MinimumSalary { get; set; }

		public List<Consultation> Consultations { get; set; }

		public int GetMonthlyEarntValue(int month)
		{
			var monthlyConsultations = this.Consultations.Where(c => c.IssuedDate.Month.Equals(month));
			var monthlyTotal = 0;

			foreach (var consultation in monthlyConsultations)
			{
				monthlyTotal += consultation.GetConsultationCost();
			}

			return monthlyTotal;
		}
    }
}
