using EasyCashIdentityProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DataAccessLayer.Concrete
{
	// IdentityDbContext özünde yine dbContext'ten miras alıyor. !!!
	public class Context : IdentityDbContext<AppUser,AppRole,int>
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=DESKTOP-OHHVBJO\\SQLEXPRESS; initial catalog=EasyCashDb; integrated security=true");

		}
		public DbSet<CustomerAccount> CustomerAccounts { get; set; }
		public DbSet<CustomerAccountProcess> CustomerAccountProcesses { get; set; }

		// AppUser ve AppRole classlarını DbSet etmemize gerek yok. Çünkü onlar yeni bir sınıf olarak değil, mevcuttaki bir sınıfın içine property olarak eklenecektir. !!!
	}
}
