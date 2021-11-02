using System;

namespace HM7referancevaluetypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task#1
            Console.WriteLine("1.Metni Daxil Edin:");
            string txt1 = Console.ReadLine();
            space(txt1);

            //Task#2
            Console.WriteLine("2.Bir deyer daxil edin:");
            Console.WriteLine($"Cavab-{check(Console.ReadLine())}");

            //Task#3
            Console.WriteLine("3.Value daxil edin:");
            int[] intArry = new int[] { 23, 09, 2002 };
            string numberstr = Console.ReadLine();
            int number = Convert.ToInt32(numberstr);

            int[] arry = returnNewArry(ref intArry, number);
            foreach (var num in arry)
            {
                Console.WriteLine(num);
            }

            //Task#4 
            Console.WriteLine("4.String deyerlerinin sayini qeyd edin:");
            string counterStr = Console.ReadLine();
            int counter = Convert.ToInt32(counterStr);

            string[] newStrArr = getStringArry(counter);


            foreach (var words in newStrArr)
            {
                Console.WriteLine($"Cavab:{words}");
            }
        }



        static void space(string space)
        {
            space = space.Trim().ToUpper().ToLower();
            for (int i = 0; i < space.Length; i++)
            {
                while (space[i] == ' ' && space[i + 1] == ' ')
                {
                    space = space.Remove(i, 1);
                }

            }
            Console.WriteLine(space);
        }

        static bool check(string txt2)
        {
            txt2 = txt2.Trim();
            bool check = false;
            bool check1 = false;
            bool check2 = false;
            bool check3 = false;
            for (int i = 0; i < txt2.Length; i++)
            {
                char chr = txt2[i];
                if (char.IsUpper(chr))
                {
                    check1 = true;
                }
                if (char.IsLower(chr))
                {
                    check2 = true;
                }
                if (char.IsDigit(chr))
                {
                    check3 = true;
                }
                if (check1 == true && check2 == true && check3 == true)
                {
                    return true;
                }

            }
            return false;

        }

        static int[] returnNewArry(ref int[] intArry, int number)
        {
            int[] newIntArry = intArry;
            Array.Resize(ref newIntArry, intArry.Length + 1);
            newIntArry[newIntArry.Length - 1] = number;

            return newIntArry;
        }

        static string[] getStringArry(int counter)
        {
            string[] newStrArry = new string[0];
            string word;
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine("Daxil Et:");
                word = Console.ReadLine();
                Array.Resize(ref newStrArry, newStrArry.Length + 1);
                newStrArry[newStrArry.Length - 1] = word;
            }
            return newStrArry;
        }

        
    }
}