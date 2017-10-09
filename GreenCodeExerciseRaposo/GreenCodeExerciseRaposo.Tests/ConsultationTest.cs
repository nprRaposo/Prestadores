using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GreenCodeExerciseRaposo.Models;
using System.Collections.Generic;

namespace GreenCodeExerciseRaposo.Tests
{
	[TestClass]
	public class ConsultationTest
	{

		private Consultation BasicConsultationIssuedInBusinessHour { get; set; }
		private Consultation BasicConsultationNotIssuedInBusinessHour { get; set; }

		private Consultation BasicConsultationIssuedOnWeekend { get; set; }

		private Provider Provider { get; set; }

		[TestInitialize]
		public void Initialize()
		{
			this.Provider = new Provider
			{
				Id = 1,
				Name = "Carlos Sanchez",
				BasicConsultationValue = 1000,
				MinimumSalary = 10000,
				Consultations = new List<Consultation>()
			};

			this.BasicConsultationIssuedInBusinessHour = new Consultation
			{
				Id = 1,
				Provider = this.Provider,
				IssuedDate = new DateTime(2017, 10, 10, 10, 0, 0)
			};

			this.BasicConsultationNotIssuedInBusinessHour = new Consultation
			{
				Id = 2,
				Provider = this.Provider,
				IssuedDate = new DateTime(2017, 10, 10, 0, 0, 0)
			};

			this.BasicConsultationIssuedOnWeekend = new Consultation
			{
				Id = 3,
				Provider = this.Provider,
				IssuedDate = new DateTime(2017, 10, 8, 0, 0, 0)
			};
		}

		[TestMethod]
		public void CalculateLiquidationWithConsultationIssuedOnBusinessHours()
		{
			this.Provider.Consultations.Add(this.BasicConsultationIssuedInBusinessHour);

			Assert.AreEqual(11000, this.Provider.GetMonthlyEarntValue(10, 2017));
		}

		[TestMethod]
		public void CalculateLiquidationWithConsultationNotIssuedOnBusinessHours()
		{
			this.Provider.Consultations.Add(this.BasicConsultationNotIssuedInBusinessHour);

			Assert.AreEqual(11350, this.Provider.GetMonthlyEarntValue(10, 2017));
		}

		[TestMethod]
		public void CalculateLiquidationWithConsultationIssuedOnWeekend()
		{
			this.Provider.Consultations.Add(this.BasicConsultationIssuedOnWeekend);

			Assert.AreEqual(11500, this.Provider.GetMonthlyEarntValue(10, 2017));
		}

		[TestMethod]
		public void CalculateLiquidationUsingAProviderWithManyConsultations()
		{
			this.Provider.Consultations.Add(this.BasicConsultationIssuedOnWeekend);
			this.Provider.Consultations.Add(this.BasicConsultationNotIssuedInBusinessHour);
			this.Provider.Consultations.Add(this.BasicConsultationIssuedInBusinessHour);

			Assert.AreEqual(13850, this.Provider.GetMonthlyEarntValue(10, 2017));
		}
	}
}
