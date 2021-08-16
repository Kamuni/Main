using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Counter
{
    public class Space_count
    {
        public int spacesInString(string input)
        {
            string str = input;
            int length = str.Length;
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if (str[i] == ' ')
                {
                    count++;
                }
            }

            return count;
        }

    }

}

