using System;
using System.Linq;

namespace gitAtcoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] value = Console.ReadLine().Split(' ');
            var a = Enumerable.Repeat(0, n).ToArray();
            /*Enumerable.Repeat(値、サイズ）
             * Enumerable.Repeat(値、サイズ）.ToList() 指定されたサイズのリストを作成し
             * 値で初期化する
             * Enumerable.Repeat(値、サイズ）.ToArray
             * 
             * List<int> values = new List<int>(Enumerable.Repeat(0, n));
             */
           　for( int i=0; i<n; i++)
            {
                a[i] = int.Parse(value[i]);
            }
            int kaisuu = 0;
            bool owari = false;
            do
            {
                for (int i = 0; i < n; i++)
                {
                    int amari = a[i] % 2;
                    if (amari == 0)
                    {
                        a[i] = a[i] / 2;

                    }
                    else
                    {
                        owari = true;
                    }
                }
                if (!owari) kaisuu++;
            } while (owari == false);

            Console.WriteLine(kaisuu);
        }

        
    }

}
