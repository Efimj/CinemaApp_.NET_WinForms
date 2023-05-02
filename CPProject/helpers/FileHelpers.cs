namespace CPProject.helpers
{
    public static class FileHelpers
    {
        public static bool DeleteFile(string filePath)
        {
#pragma warning disable CS0168 // Переменная объявлена, но не используется
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (IOException e)
            {
                return false;
            }
#pragma warning restore CS0168 // Переменная объявлена, но не используется
        }
    }
}
