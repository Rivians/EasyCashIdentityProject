using EasyCashIdentityProject.EntityLayer.Concrete;
using EasyCashIdentityProject.PresentationLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresentationLayer.Controllers
{
	public class ConfirmMailController : Controller
	{
		// UserManager<AppUser> ifadesi, ASP.NET Identity tarafından sağlanan kullanıcı yönetimi sınıfını, uygulamanızın kullanıcı modeli olan AppUser tipi ile kullanmak üzere konfigüre etmektedir.
		private readonly UserManager<AppUser> _userManager;
		public ConfirmMailController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		[HttpGet]
		public IActionResult Index()
		{
			var value = TempData["Mail"];
			ViewBag.v = value;
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Index(ConfirmMailViewModel confirmMailViewModel)
		{
			//var value = TempData["Mail"];

			var user = await _userManager.FindByEmailAsync(confirmMailViewModel.Mail);
			if(user.ConfirmCode == confirmMailViewModel.ConfirmCode)
			{
				// _userManager.UpdateAsync(user); ifadesi, UserManager sınıfının bir metodu olup, bir kullanıcının veritabanındaki bilgilerini güncellemek için kullanılır. (genelde yapılan değişikler sonrasında bu kod yazılır.)
				user.EmailConfirmed = true;
				await _userManager.UpdateAsync(user);
				return RedirectToAction("Index", "Login");
			}
			return View();
		}
	}
}
