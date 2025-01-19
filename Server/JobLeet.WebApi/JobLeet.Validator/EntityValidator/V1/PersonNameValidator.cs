using System.Text.RegularExpressions;

namespace JobLeet.WebApi.JobLeet.Validator.EntityValidator.V1
{
    public static class PersonNameValidator
    {
        private static readonly Regex _nameRegex = new Regex(@"^[\p{L}\p{M}'\- ]+$", RegexOptions.Compiled);
        /*
        \p{L}: Matches any kind of letter from any language.
        \p{M}: Matches a combining mark (accent).
        ': Allows apostrophes.
        \-: Allows hyphens.
        : Allows spaces.
        +: Ensures the name contains at least one valid character.
        */

        public static bool IsValidUsername(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                return false;
            }

            return _nameRegex.IsMatch(username);

        }

        public static bool IsValidMiddleName(string username){
            if (string.IsNullOrWhiteSpace(username))
            {
                return true;
            }
            return _nameRegex.IsMatch(username);
        }
    }

}