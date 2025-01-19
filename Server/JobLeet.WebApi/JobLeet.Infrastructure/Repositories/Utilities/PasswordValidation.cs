using System.Text.RegularExpressions;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Repositories.Utilities
{
    public static class PasswordValidation
    {
        public static bool ValidatePassword(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 8 || password.Length > 101)
            {
                return false;
            }
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";
            if (!Regex.IsMatch(password, pattern))
            {
                return false;
            }

            return true;
        }
    }
}
