using System;
using System.Numerics;

namespace PR2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "слово";
            Console.WriteLine("Сообщение: {0}", text);
            BigInteger hash = HashFunction(text);
            Console.WriteLine("Зашифрованое сообщение: {0}", hash);
           
        }
        static BigInteger HashFunction(string text)
        {
            char[] chars = text.ToCharArray();
            int a = 12345363;
            BigInteger hash = 1;
            for (int i = 0; i < chars.Length; i++)
            {
                hash += (a * hash) + chars[i] * BigInteger.ModPow(10, chars.Length - 1, 1);
            }
            return hash;
        }

    }
}
