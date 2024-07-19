using Org.BouncyCastle.Crypto.Digests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageDigestApplication2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(args.Length < 1) {
                Console.Error.WriteLine("コマンドライン引数が不足しています！");
                Environment.Exit(1);
            }
            var data = Encoding.UTF8.GetBytes(args[0]);
            var digest = new RipeMD160Digest();
            var result = new byte[digest.GetDigestSize()];
            digest.BlockUpdate(data, 0, data.Length);
            digest.DoFinal(result, 0);

            Console.WriteLine(string.Join("", result.Select(x => $"{x:x2}")));
        }
    }
}
