using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GreenCodeExerciseRaposo.Models;
using System.Collections.Generic;

namespace GreenCodeExerciseRaposo.Tests
{
	[TestClass]
	public class DomiciliaryConsultationTest
	{
		private Consultation BasicConsultationIssuedInBusinessHourDoneDomiciliary { get; set; }

		private Consultation OtherConsultationIssuedInBusinessHourDoneDomiciliary { get; set; }

		private Consultation OtherConsultationIssuedInBusinessHourNotDoneDomiciliary { get; set; }

		private Provider Provider { get; set; }

		private DomiciliaryConsultation DomiciliaryConsultation { get; set; }

		[TestInitialize]
		public void Initialize()
		{
			this.Provider = new Provider
			{
				Id = 1,
				Name = "Carlos Sanchez",
				BasicConsultationValue = 1000,
				MinimumSalary = 10000,
				Consultations = new List<Consultation>(),
				CostPerKm = 100
			};

			this.BasicConsultationIssuedInBusinessHourDoneDomiciliary = new Consultation
			{
				Id = 1,
				Provider = this.Provider,
				IssuedDate = new DateTime(2017, 10, 10, 10, 0, 0)
			};

			this.OtherConsultationIssuedInBusinessHourDoneDomiciliary = new Consultation
			{
				Id = 2,
				Provider = this.Provider,
				IssuedDate = new DateTime(2017, 10, 10, 10, 30, 0)
			};

			this.OtherConsultationIssuedInBusinessHourNotDoneDomiciliary = new Consultation
			{
				Id = 3,
				Provider = this.Provider,
				IssuedDate = new DateTime(2017, 10, 10, 10, 0, 0)
			};

			this.DomiciliaryConsultation = new DomiciliaryConsultation
			{
				Consultations = new List<Consultation> { this.BasicConsultationIssuedInBusinessHourDoneDomiciliary, this.OtherConsultationIssuedInBusinessHourDoneDomiciliary },
				DistanceTravelled = 10,
				Id = 1,
				Provider = Provider,
				ProviderId = 1,
				IssuedDate = new DateTime(2017, 10, 10, 10, 30, 0)
			};
		}

		[TestMethod]
		public void CalculateLiquidationWithDomiciliaryConsultation()
		{
			this.Provider.Consultations.Add(this.DomiciliaryConsultation);

			Assert.AreEqual(13500, this.Provider.GetMonthlyEarntValue(10, 2017));
		}

		[TestMethod]
		public void CalculateLiquidationWithDomiciliaryAndNoDomiciliaryConsultation()
		{
			this.Provider.Consultations.Add(this.DomiciliaryConsultation);
			this.Provider.Consultations.Add(this.OtherConsultationIssuedInBusinessHourNotDoneDomiciliary);

			Assert.AreEqual(14500, this.Provider.GetMonthlyEarntValue(10, 2017));
		}
	}
}
