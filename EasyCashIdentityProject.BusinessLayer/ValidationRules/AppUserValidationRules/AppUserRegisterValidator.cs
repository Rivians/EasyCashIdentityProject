using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using FluentValidation;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.ValidationRules.AppUserValidationRules
{
	public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
	{
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez.");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez.");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Mail alanı boş geçilemez.");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı adı alanı boş geçilemez.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez.");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrar alanı boş geçilemez.");

            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Lütfen en az 2 veri girişi yapınız.");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen en fazla 30 veri girişi yapınız.");
            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("Parolalarınız eşleşmiyor.");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen geçerli bir email adresi giriniz.");
        }
    }
}
