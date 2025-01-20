using FluentValidation;
using JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1;

namespace JobLeet.WebApi.JobLeet.Core.Validators.Accounts
{
    public class RoleValidator : AbstractValidator<Role>
    {
        public RoleValidator()
        {
            RuleFor(role => role.RoleName)
                .IsInEnum()
                .WithMessage("Invalid RoleName. Allowed values are Admin (1) and Users (2).")
                .NotNull()
                .WithMessage("RoleName is required.");
        }
    }
}
