using GreenCodeExerciseRaposo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenCodeExerciseRaposo.DAL
{
	public static class MonthlyLiquidationService
	{
		public static MonthLiquidation GetMonthDetail(int month, int year)
		{
			var monthLiquidation = new MonthLiquidation();

			monthLiquidation.MonthNumber = month;
			monthLiquidation.YearNumber = year;
			monthLiquidation.MonthValues = new Dictionary<string, double>();

			var providers = ProviderService.GetProviders();

			foreach (var provider in providers)
			{
				monthLiquidation.MonthValues.Add(provider.Name, provider.GetMonthlyEarntValue(month, year));
			}

			return monthLiquidation;
		}
	}
}
