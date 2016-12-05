namespace DecodeAndDecrypt
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        static void MockInput()
        {
            var reader = new StringReader(@"KKICXDE3P5");
            Console.SetIn(reader);
        }

        static string GetCypherLength(string encrypted)
        {
            var result = string.Empty;

            for (int i = encrypted.Length - 1; char.IsDigit(encrypted[i]); i--)
            {
                result = encrypted[i] + result;
            }

            return result;
        }

        static string GetEncodedPart(string message, int cypherLength)
        {
            var length = message.Length - cypherLength;

            return message.Substring(0, length);
        }

        static string GetCypher(string encryptedWithCypher, int cypherLength)
        {
            var start = encryptedWithCypher.Length - cypherLength;

            return encryptedWithCypher.Substring(start);
        }

        static string GetEncryptedPart(string encryptedWithCypher, int cypherLength)
        {
            var length = encryptedWithCypher.Length - cypherLength;

            return encryptedWithCypher.Substring(0, length);
        }

        static string Decode(string encode)
        {
            var result = string.Empty;

            for (int i = 0; i < encode.Length; i++)
            {
                var currentAmount = string.Empty;

                while (char.IsDigit(encode[i]))
                {
                    currentAmount += encode[i];
                    i++;
                }

                var symbolToRepeat = encode[i];

                if (string.IsNullOrEmpty(currentAmount))
                {
                    currentAmount = "1";
                }

                result += new string(symbolToRepeat, int.Parse(currentAmount));
            }

            return result;
        }

        static int CodeOf(char s)
        {
            return s - 'A';
        }

        static char CharOf(int code)
        {
            return (char)(code + 'A');
        }

        static string Decrypt(string encrypted, string cypher)
        {
            var result = encrypted.ToCharArray();
            var length = Math.Max(encrypted.Length, cypher.Length);

            for (int i = 0; i < length; i++)
            {
                var code1 = CodeOf(result[i % encrypted.Length]);
                var code2 = CodeOf(cypher[i % cypher.Length]);

                var xor = code1 ^ code2;

                result[i % result.Length] = CharOf(xor);
            }

            return string.Join("", result);
        }

        //static void InfiniteArrayPrint()
        //{
        //    string word = "abcde";
        //    string word2 = "";

        //    var i = 0;

        //    while (true)
        //    {
        //        Console.WriteLine(word[i % word.Length]);
        //        Console.WriteLine(word2[i % word2.Length]);
                
        //    }
        //}

        public static void Main()
        {
            MockInput();

            var encryptedMessage = Console.ReadLine();
            var cypherLengthString = GetCypherLength(encryptedMessage);
            var encodedPart = GetEncodedPart(encryptedMessage, cypherLengthString.Length);

            var decoded = Decode(encodedPart);

            var cypherLength = int.Parse(cypherLengthString);
            var encryptedPart = GetEncryptedPart(decoded, cypherLength);
            var cypher = GetCypher(decoded, cypherLength);

            ////Console.WriteLine(encodedPart);
            ////Console.WriteLine(Decode("100a3b4caa"));
            //Console.WriteLine(encryptedPart);
            //Console.WriteLine(cypher);

            var decrypted = Decrypt(encryptedPart, cypher);

            Console.WriteLine(decrypted);
        }
    }
}
