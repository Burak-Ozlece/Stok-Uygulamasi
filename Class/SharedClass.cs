using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Stok_Uygulaması.Class
{
    public class SharedClass
    {
        public static bool ValidatePassword(string password)
        {
            // Şifre koşullarını kontrol eden regex:
            var regex = new Regex(@"^(?=.*[a-zA-Z])(?=.*\d)(?=.*[^\w\s]).{6,}$");
            return regex.IsMatch(password);
        }
    }
}
