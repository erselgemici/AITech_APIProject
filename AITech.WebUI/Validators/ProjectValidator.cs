using AITech.WebUI.DTOs.ProjectDtos;
using FluentValidation;

namespace AITech.WebUI.Validators
{
    public class ProjectValidator : AbstractValidator<CreateProjectDto>
    {
        public ProjectValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık Boş Bırakılamaz")
                .MinimumLength(3).WithMessage("Başlık En Az 3 Karakter Olmalıdır");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim Boş Bırakılamaz");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Kategori Boş Bırakılamaz");
        }
    }
}
