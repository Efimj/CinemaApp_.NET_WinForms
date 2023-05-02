using System.Drawing.Imaging;
using System.Security.AccessControl;

namespace CPProject.imageHandler
{
    public static class ImageHandler
    {
        public static bool SaveImageToFile(Image image, string filePath, ImageFormat format)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    if (IsFileLocked(filePath))
                    {
                        MessageBox.Show("lock");
                        return false;
                    }

                    if (!HasWritePermission(filePath))
                    {
                        MessageBox.Show("Perm");
                        return false;
                    }
                }
                image.Save(filePath, format);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool IsFileLocked(string filePath)
        {
            try
            {
                using (FileStream stream = File.Open(filePath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    // Файл не заблокирован для записи, можно выполнить операции записи
                    //Console.WriteLine("Файл не заблокирован для записи.");
                }
            }
            catch (IOException ex)
            {
                // Файл заблокирован для записи, необходимо обработать исключение
                //Console.WriteLine("Файл заблокирован для записи: " + ex.Message);
                return true;
            }

            return false;
        }

        public static bool HasWritePermission(string folderPath)
        {
            try
            {
                DirectoryInfo dInfo = new DirectoryInfo(folderPath);
                DirectorySecurity security = dInfo.GetAccessControl();
                AuthorizationRuleCollection rules = security.GetAccessRules(true, true, typeof(System.Security.Principal.SecurityIdentifier));
                foreach (FileSystemAccessRule rule in rules)
                {
                    if ((FileSystemRights.Write & rule.FileSystemRights) != FileSystemRights.Write)
                        continue;

                    if (rule.AccessControlType == AccessControlType.Allow)
                        return true;

                    if (rule.AccessControlType == AccessControlType.Deny)
                        return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public static Image? LoadImageFromFile(string filePath)
        {
            Image? image = null;

            try
            {
                using (FileStream stream = new FileStream(filePath, FileMode.Open))
                {
                    image = Image.FromStream(stream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // Обработка ошибки, если не удалось загрузить изображение
                // Например, можно вывести сообщение об ошибке
            }

            return image;
        }

        public static Image? LoadImage(string imagePath, Image? errorImage = null)
        {
            try
            {
                using (FileStream stream = new FileStream(imagePath, FileMode.Open))
                {
                    return Image.FromStream(stream);
                }
            }
            catch (Exception ex)
            {
                if (errorImage != null)
                {
                    return errorImage;
                }
                return null;
            }
        }

        public static bool LoadImageToPictureBox(string imagePath, PictureBox pictureBox, Image? errorImage = null)
        {
            try
            {
                using (FileStream stream = new FileStream(imagePath, FileMode.Open))
                {
                    pictureBox.Image = Image.FromStream(stream);
                }
                return true;
            }
            catch (Exception ex)
            {
                if (errorImage != null)
                {
                    pictureBox.Image = errorImage;
                }
                return false;
            }
        }
    }
}
