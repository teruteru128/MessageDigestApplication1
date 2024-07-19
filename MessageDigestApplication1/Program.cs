// See https://aka.ms/new-console-template for more information
using Org.BouncyCastle.Crypto.Digests;
using System.Text;

var data = Encoding.UTF8.GetBytes("うんち！ｗ");
var digest = new RipeMD160Digest();
var result = new byte[digest.GetDigestSize()];
digest.BlockUpdate(data, 0, data.Length);
digest.DoFinal(result, 0);

Console.WriteLine(string.Join("", result.Select(x => $"{x:x2}")));

