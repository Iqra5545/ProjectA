using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    class Valid
    {
        public bool IsAllChar(string a)
        {
            int count = 0;
            bool value = false;
            foreach (char c in a)
            {
                if (char.IsLetter(c))
                    value = true;
                else
                    count++;
            }
            if (count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsAllDigit(string b)
        {
            int count = 0;
            bool value = false;
            foreach (char c in b)
            {
                if (char.IsDigit(c))
                    value = true;
                else
                    count++;
            }
            if (count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool IsDigitAndLetter(string b)
        {
            int count = 0;
            bool value = false;
            foreach (char c in b)
            {
                if (char.IsLetterOrDigit(c))
                    value = true;
                else
                    count++;
            }
            if (count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
