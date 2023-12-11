using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer.Concrete
{
    // IdentityUser dan miras alınmasının sebebi : veritabanındaki AspNetUsers tablosundaki verilerle uyuşması için.
	public class AppUser : IdentityUser<int>  // burada <int> 'in anlamı şu : primary key (genelde id oluyor) 'in veri tipi string değil int olucak.
	{
        public string Name { get; set; }
        public string Surname { get; set; }
        public string District { get; set; }  // ilçe
        public string City { get; set; }  // şehir
        public string ImageUrl { get; set; }
        public List<CustomerAccount> CustomerAccounts { get; set; }  // bir user'in 1'den fazla account'u olabilir.

        // name, surname, district, city, imageurl değişkenleri, sql deki AspNetUsers tablosuna yeni bir sutün olarak eklenecektir. 
        // yani aslında identityUser kütüphanesinden miras alarak, yeni bir tablo almaktan ziyade var olan tabloya eklemeler yapmış oluyoruz. 
    }
}
