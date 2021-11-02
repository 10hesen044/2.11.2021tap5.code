using System;

namespace _2._11._2021tap5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreatMethod("Aze","Baku","Uni"));
        }

        static string CreatMethod(params string[] mass)
        {
            string strArr = string.Empty;
            
            for (int i = 0; i<mass.Length; i++)
			{
               strArr = mass[i];
			}
             return strArr;
        }    
    }
}
