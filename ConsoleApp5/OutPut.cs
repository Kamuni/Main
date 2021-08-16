using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp5
{
    public class ResponseOutput

    {
        public char SimpleString(string userString)
        {
            userString = Console.ReadLine();
            int[] userStringArr = new int[userString.Length];
            char minChar = userString[0], maxChar = userString[0];
            int i, j, min, max;
            char[] string1 = userString.ToCharArray();

            if (userString == " ")
            {
                return (char)0;
            }
            else
            {
                for (i = 0; i < string1.Length; i++)

                    userStringArr[i] = 1;
                for (j = i + 1; j < string1.Length; j++)
                {
                    if (string1[i] == string1[j] && string1[i] != ' ' && string1[i] != '0')
                    {
                        userStringArr[i]++;

                        string1[j] = '0';
                    }
                }
            }

            min = max = userStringArr[0];
            for (i = 0; i < userStringArr.Length; i++)
            {
                if (min > userStringArr[i] && userStringArr[i] != '0')
                {
                    min = userStringArr[i];
                    minChar = string1[i];
                }
                if (max < userStringArr[i])
                {
                    max = userStringArr[i];
                    maxChar = string1[i];
                }

            }
            for (i = 0; i < string1.Length; i++)

                userStringArr[i] = 1;
            for (j = i + 1; j < string1.Length; j++)
            {
                if (string1[i] == string1[j] && string1[i] != ' ' && string1[i] != '0')
                {
                    userStringArr[i]++;

                    string1[j] = '0';
                }
            }
            return maxChar;
        }

        public char StringEmtpy(string userString)
        {
            userString = Console.ReadLine();
            if (userString == String.Empty)
            {
                return ' ';
            }
            else
            {
                int[] userStringArr = new int[userString.Length];
                char minChar = userString[0], maxChar = userString[0];
                int i, j, min, max;
                char[] string1 = userString.ToCharArray();
                for (i = 0; i < string1.Length; i++)

                    userStringArr[i] = 1;
                for (j = i + 1; j < string1.Length; j++)
                {
                    if (string1[i] == string1[j] && string1[i] != ' ' && string1[i] != '0')
                    {
                        userStringArr[i]++;

                        string1[j] = '0';
                    }
                }

                min = max = userStringArr[0];
                for (i = 0; i < userStringArr.Length; i++)
                {
                    if (min > userStringArr[i] && userStringArr[i] != '0')
                    {
                        min = userStringArr[i];
                        minChar = string1[i];
                    }
                    if (max < userStringArr[i])
                    {
                        max = userStringArr[i];
                        maxChar = string1[i];
                    }

                }
                for (i = 0; i < string1.Length; i++)

                    userStringArr[i] = 1;
                for (j = i + 1; j < string1.Length; j++)
                {
                    if (string1[i] == string1[j] && string1[i] != ' ' && string1[i] != '0')
                    {
                        userStringArr[i]++;

                        string1[j] = '0';
                    }
                }
                return maxChar;
            }
        }

        public int StringIsZeroes(string userString)
        {
            userString = Console.ReadLine();
            if (userString == " ")
            {
                return ' ';
            }
            else
            {
                int[] userStringArr = new int[userString.Length];
                char minChar = userString[0], maxChar = userString[0];
                int i, j, min, max;
                char[] string1 = userString.ToCharArray();
                for (i = 0; i < string1.Length; i++)

                    userStringArr[i] = 1;
                for (j = i + 1; j < string1.Length; j++)
                {
                    if (string1[i] == string1[j] && string1[i] != ' ' && string1[i] != '0')
                    {
                        userStringArr[i]++;

                        string1[j] = '0';
                    }
                }

                min = max = userStringArr[0];
                for (i = 0; i < userStringArr.Length; i++)
                {
                    if (min > userStringArr[i] && userStringArr[i] != '0')
                    {
                        min = userStringArr[i];
                        minChar = string1[i];
                    }
                    if (max < userStringArr[i])
                    {
                        max = userStringArr[i];
                        maxChar = string1[i];
                    }

                }
                for (i = 0; i < string1.Length; i++)

                    userStringArr[i] = 1;
                for (j = i + 1; j < string1.Length; j++)
                {
                    if (string1[i] == string1[j] && string1[i] != ' ' && string1[i] != '0')
                    {
                        userStringArr[i]++;

                        string1[j] = '0';
                    }
                }
                return maxChar;
            }
        }
    }
}
    

