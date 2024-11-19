using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TextCheck
    {
        public static bool kitu(string text)
        {
            if(text.Contains('/'))
                return false;
            return true;
        }
    }
}
