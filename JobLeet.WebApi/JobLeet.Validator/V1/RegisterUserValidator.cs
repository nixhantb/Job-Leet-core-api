using FluentValidation;
using JobLeet.WebApi.JobLeet.Core.Entities.Accounts.V1;
using JobLeet.WebApi.JobLeet.Validator;

namespace JobLeet.WebApi.JobLeet.Core.Validators.Accounts
{
    public class RegisterUserValidator : AbstractValidator<RegisterUser>
    {
        public RegisterUserValidator()
        {
           
            RuleFor(registerUser => registerUser.PersonName)
                .NotNull().WithMessage("personName is a required field.")
                .SetValidator(new PersonNameValidator()); 

           
            RuleFor(registerUser => registerUser.UserEmail)
                .NotNull().WithMessage("userEmail is a required field.")
                .SetValidator(new EmailValidator()); 

           
            RuleFor(registerUser => registerUser.Password)
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(8).WithMessage("Password must be at least 8 characters long.")
                .MaximumLength(100).WithMessage("Password cannot exceed 100 characters.")
                .Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$")
                .WithMessage("Password must contain at least one uppercase letter, one lowercase letter, one digit, and one special character.");

            
            RuleFor(registerUser => registerUser.ConfirmPassword)
                .NotEmpty().WithMessage("ConfirmPassword is required.")
                .Equal(registerUser => registerUser.Password)
                .WithMessage("Passwords do not match.")
                .MinimumLength(8).WithMessage("Password must be at least 8 characters long.")
                .MaximumLength(100).WithMessage("Password cannot exceed 100 characters.")
                .Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$")
                .WithMessage("Password must contain at least one uppercase letter, one lowercase letter, one digit, and one special character.");
        }
    }
}
