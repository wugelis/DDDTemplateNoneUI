using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mcut.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mcut.Domain.Entities
{
	public class HosingLoansDataEnt : AuditableEntity
	{
		[Key]
		[Column(Order = 0)]
		public int LoansID {get; set;}
		public string HourseOwner {get; set;}
		public string Borrower {get; set;}
		public string Industry {get; set;}
		public string LoanUsage {get; set;}
		public decimal LoanAmount {get; set;}
		public decimal AnnualIncome {get; set;}
		public string LocationNow {get; set;}
		public int CustomerID {get; set;}
	}

}
