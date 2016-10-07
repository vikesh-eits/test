
namespace Utilities.Validations
{
    public static class validDocument
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="documentName"></param>
        /// <returns></returns>
        public static bool isValidDocument(string documentName)
        {
            //if (DocumentExtension.isValidDocExtension(documentName) || ImageExtension.isValidImageExtension(documentName)) return true;
            //return false;
            return DocumentExtension.isValidDocExtension(documentName) || ImageExtension.isValidImageExtension(documentName);
        }
    }
}
