using System;

namespace gitAtcoder
{
    class Program
    {
        static void Main(string[] args)
        {
            //atcoderで解いた問題をgitやgithubにアップロードしていきます。
            /*
            
            string[] input = Console.ReadLine().Split(" ");
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            if (a * b % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            */

            char[] c = Console.ReadLine().ToCharArray();
            int a = int.Parse(c[0].ToString());
            int b = int.Parse(c[1].ToString());
            int d = int.Parse(c[2].ToString());

            if(a+b+d == 0)
            {
                Console.WriteLine(0);
            }else if(a + b + d == 1){
                Console.WriteLine(2);
            }else if(a + b + d == 2){
                Console.WriteLine(3);
            }else if(a + b + d == 3){
                Console.WriteLine(4);
            }
        }
    }
}
