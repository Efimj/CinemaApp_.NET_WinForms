namespace CPProject.DataBaseModel.handlers
{
    public static class Helpers
    {
        public static int CalculateAge(DateTime birthDate)
        {
            int age = DateTime.Today.Year - birthDate.Year;
            if (birthDate > DateTime.Today.AddYears(-age))
            {
                age--;
            }
            return age;
        }
        public static bool CheckLogin(string password)
        {
            const int minCharactersInPassword = 8;

            if (password.Length < minCharactersInPassword)
            {
                return false;
            }
            return true;
        }

        public static bool CreateDirectories(string path)
        {
            try
            {
                string? directoryPath = Path.GetDirectoryName(path);

                if (directoryPath != null && !Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                    return true;
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static bool CheckPassword(string password)
        {
            bool hasLetter = false;
            bool hasDigit = false;
            const int minCharactersInPassword = 8;

            if (password.Length < minCharactersInPassword)
            {
                return false;
            }

            foreach (char c in password)
            {
                if (char.IsLetter(c))
                {
                    hasLetter = true;
                }
                else if (char.IsDigit(c))
                {
                    hasDigit = true;
                }
            }

            return hasLetter && hasDigit;
        }
    }
}
