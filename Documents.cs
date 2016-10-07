
namespace Utilities.Validations
{
    public class DocumentExtension
    {
        /// <summary>test
        /// used to check document extension
        /// </summary>
        /// <param name="imageName">Can be document name, document path</param>
        /// <returns></returns>
        public static bool isValidDocExtension(string imageName)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(imageName, @"(.*?)\.(doc|docx|xls|xlsx|pdf|txt|rtf)$", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        }
        /// <summary>
        /// doc, docx, txt,rtf
        /// </summary>
        /// <param name="imageName"></param>
        /// <returns></returns>
        public static bool isValidCv(string imageName)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(imageName, @"(.*?)\.(doc|docx|pdf|txt|rtf)$", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        }
    }
}
