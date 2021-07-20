using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mcut.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mcut.Domain.Entities
{
	public class AccountEnt : AuditableEntity
	{
		[Key]
		[Column(Order = 0)]
		public string UserID {get; set;}
		public string Password {get; set;}
	}

}
