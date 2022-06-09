using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class FormatChecker
    {
        int count = 0;
        public bool IsValid(string mobileNumber)
        {
            if (mobileNumber.Length == 11)
            {
                for (int i = 0; i < mobileNumber.Length; i++)
                {
                    if ((int)mobileNumber[i] > 47 && (int)mobileNumber[i] < 58)
                    {
                        count++;
                    }
                }
                if (count == 11)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
