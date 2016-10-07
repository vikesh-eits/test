using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilities.Validations
{
    public static class ValidUrl
    {
        public static bool IsValidUrl(string source)
        {
            return Uri.IsWellFormedUriString(source, UriKind.Absolute);
        }
    }
}
