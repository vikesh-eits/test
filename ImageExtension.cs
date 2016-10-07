
namespace Utilities.Validations
{
    public static class ImageExtension
    {
        /// <summary>
        /// used to check image extension
        /// </summary>
        /// <param name="imageName">Can be image name, image path</param>
        /// <returns></returns>
        public static bool isValidImageExtension(string imageName)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(imageName, @"(.*?)\.(jpg|jpeg|png|gif|bmp)$", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        }
    }
}
