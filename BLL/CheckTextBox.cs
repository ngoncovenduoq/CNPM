using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CheckTextBox
    {
        public static bool KiemTraTen(string text)
        {
            // Kiểm tra xem text chỉ chứa các ký tự chữ cái của tiếng Việt và dấu cách
            return text.All(c => char.IsLetter(c) || c == ' ' || IsTiengViet(c));
        }

        public static bool KiemTraSo(string text)
        {
            // Kiểm tra xem text có thể được chuyển đổi thành số float hoặc int không
            int intResult;
            return int.TryParse(text, out intResult);
        }

        public static bool KiemTraSoThuc(string text)
        {
            // Kiểm tra xem text có thể được chuyển đổi thành số float hoặc int không
            float intResult;
            return float.TryParse(text, out intResult);
        }

        public static bool KiemTraTenDacbiet(string text)
        {
            // Kiểm tra xem text chỉ chứa các ký tự chữ cái của tiếng Việt, dấu cách và số
            return text.All(c => char.IsLetter(c) || char.IsDigit(c) || c == ' ' || IsTiengViet(c));
        }

        // Phương thức kiểm tra ký tự có phải là ký tự tiếng Việt không
        private static bool IsTiengViet(char c)
        {
            return ((c >= '\u0041' && c <= '\u005A') || (c >= '\u0061' && c <= '\u007A') || (c >= '\u00C0' && c <= '\u00FF') || (c >= '\u0102' && c <= '\u0103') || (c >= '\u0110' && c <= '\u0111') || (c >= '\u00C2' && c <= '\u00CA') || (c >= '\u00D4' && c <= '\u00D5') || (c >= '\u00DC' && c <= '\u00DD') || (c >= '\u00E0' && c <= '\u00FD') || (c >= '\u00E2' && c <= '\u00EA') || (c >= '\u00F4' && c <= '\u00F5') || (c >= '\u00FC' && c <= '\u00FD') || (c == 'đ' || c == 'Đ'));
        }
    }
}
