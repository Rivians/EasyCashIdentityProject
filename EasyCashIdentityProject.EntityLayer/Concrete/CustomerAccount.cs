using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer.Concrete
{
	public class CustomerAccount
	{
		[Key]
        public int CustomerAccountID { get; set; }  // Sonuna ID ekleyince üstte Key data annotationu'nu eklememize gerek kalmıyor.
        public string CustomerAccountNumber { get; set; }
        public string CustomerAccountCurrency { get; set; } // para birimi yada döviz birimi 
        public decimal CustomerAccountBalance { get; set; } // bakiye
        public string BankBranch { get; set; }


    }
}
