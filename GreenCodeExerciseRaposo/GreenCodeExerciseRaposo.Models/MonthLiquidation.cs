using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenCodeExerciseRaposo.Models
{
	public class MonthLiquidation
	{
		public int Id { get; set; }

		public int MonthNumber { get; set; }

		public Dictionary<string, double> MonthValues { get; set; }
	}
}
