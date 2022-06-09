using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class WordCounter
    {
        int cnt = 0;
        public int Count(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if ((int)text[i] < 91 && (int)text[i] > 66 || (int)text[i] < 122 && (int)text[i] > 96)
                {
                    for (int j = i+1; j < text.Length; j++)
                    {
                        if ((int)text[j] < 91 && (int)text[j] > 66 || (int)text[j] < 123 && (int)text[j] > 96)
                        {
                            i++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
            return cnt;
        }
    }
}
