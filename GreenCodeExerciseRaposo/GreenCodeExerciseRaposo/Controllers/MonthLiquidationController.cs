using GreenCodeExerciseRaposo.DAL;
using GreenCodeExerciseRaposo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GreenCodeExerciseRaposo.Controllers
{
	public class MonthLiquidationController : ApiController
	{
		// GET api/<controller>/5
		public MonthLiquidation Get(int month, int year)
		{
			return MonthlyLiquidationService.GetMonthDetail(month, year);
		}
	}
}