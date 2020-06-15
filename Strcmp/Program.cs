using System;

namespace Strcmp
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            bool choice = Strcmp(str1, str2);

            Console.WriteLine(choice);
        }

        public static bool Strcmp(string str1, string str2)
        {
            if(str1.Length == str2.Length)
            {
                for (int i = 0; i < str1.Length;)
                {
                    if(str1[i] == str2[i])
                    {
                        i++;
                    }
                    else
                    {
                        return false;
                    }
                }
                Console.WriteLine("동일한 문자열입니다.");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
