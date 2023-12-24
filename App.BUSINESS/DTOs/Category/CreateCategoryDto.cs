using FluentValidation;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BUSINESS.DTOs.Category
{
    public record CreateCategoryDto
    {
        public string? Name { get; set; }
        public IFormFile? LogoImg { get; set; }

    }

    public class CategoryCreateDtoValidator : AbstractValidator<CreateCategoryDto>
    {
        public CategoryCreateDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Marka adı mutleqdir.")
                .MinimumLength(3).WithMessage("Marka adı en az 3 herf olmalıdır.")
                .MaximumLength(100).WithMessage("Marka adı en cox 55 herf olmalıdır.");
        }
    }
}
