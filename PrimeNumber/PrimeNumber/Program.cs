using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("整数の数値を入力してください");
            var input = Console.ReadLine();
            int atInt;
            if (!int.TryParse(input, out atInt))
            {
                Console.WriteLine("は？！");
            }

            //スコープの広い変数
            List<int> primeNumberList = new List<int>();
            var endPoint = System.Math.Sqrt(atInt);

            //計算リストの作成
            const int start = 2;
            var tagetList = Enumerable.Range(start, atInt-1);

            int pi = 0;
            do
            {
                //最初の素数をリストに入れる
                pi = tagetList.First();
                //素数リストに入れる
                primeNumberList.Add(pi);

                //素数リストの倍数をリストから消す
                tagetList = tagetList.Where(v => v % pi != 0).ToList();

            } while (pi < endPoint);

            //平方根に到達したら残りのリスト入れて終わり
            primeNumberList.AddRange(tagetList.ToList<int>());

            Console.WriteLine("素数は・・・");
            Console.WriteLine( string.Join(",", primeNumberList.ToList()));
            Console.WriteLine("です！");
            Console.ReadKey();
        }

    }

}
