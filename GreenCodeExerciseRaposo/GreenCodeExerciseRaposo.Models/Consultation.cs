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

		public Provider Provider { get; set; }

		public DateTime IssuedDate { get; set; }

		public virtual double GetConsultationCost()
		{
			return GetChargeOfConsultation(IssuedDate);
		}

		public double GetChargeOfConsultation(DateTime issuedDate)
		{
			var basicConsultationCost = this.Provider.BasicConsultationValue;
			if (this.IsBusinessDay(issuedDate))
			{
				return  basicConsultationCost * this.GetBusinessDayCharge(issuedDate);
			}

			return basicConsultationCost * 1.5;
		}

		#region Private helpers
		private bool IsBusinessDay(DateTime date)
		{
			return date.DayOfWeek != DayOfWeek.Sunday && date.DayOfWeek != DayOfWeek.Saturday;
		}

		private double GetBusinessDayCharge(DateTime issuedDate)
		{
			if (issuedDate.Hour >= 8 && issuedDate.Hour <= 20)
				return 1;
			return 1.35;
		} 
		#endregion
	}
}
