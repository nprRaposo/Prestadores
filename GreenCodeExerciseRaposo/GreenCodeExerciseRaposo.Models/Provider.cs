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

		public int CostPerKm { get; set; }

		public List<Consultation> Consultations { get; set; }

		public double GetMonthlyEarntValue(int month,int year)
		{
			var monthlyConsultations = this.Consultations.Where(c => c.IssuedDate.Month.Equals(month) && c.IssuedDate.Year.Equals(year));
			var monthlyTotal = 0.0;

			foreach (var consultation in monthlyConsultations)
			{
				monthlyTotal += consultation.GetConsultationCost();
			}

			return monthlyTotal + MinimumSalary;
		}
    }
}
