namespace JobLeet.WebApi.JobLeet.Core.Constants.V1
{
    public class AuthenticationConstant
    {
        public const int UserNameMinimumLength = 3;
        public const string PasswordValidation = @"^(?=.*[A-Z])(?=.*[\W])(?=.*[0-9])(?=.*[a-z]).{6,128}$";
        public const string UsernameValidationError = "Username must have minimum 3 characters.";
        public const string EmailValidationError = "Email must have valid email format";
        public const string PasswordValidationError = "Password must have more than 6 characters, min. 1 uppercase, min. 1 lowercase, min. 1 special characters.";

    }
}
