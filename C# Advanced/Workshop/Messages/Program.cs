namespace Messages
{
    using System;
    using System.Numerics;

    public class Program
    {
        static string[] numSystem = { "cad", "xoz", "nop", "cyk", "min", "mar", "kon", "iva", "ogi", "yan" };

        public static void Main()
        {
            string firstInputString = Console.ReadLine();
            string op = Console.ReadLine();
            string secondInputString = Console.ReadLine();

            BigInteger firstNumber = Decrypt(firstInputString);
            BigInteger secondNumber = Decrypt(secondInputString);

            BigInteger numResult = (op == "+" ? firstNumber + secondNumber : firstNumber - secondNumber);

            string result = Encrypt(numResult);
            Console.WriteLine(result);
        }

        private static string Encrypt(BigInteger number)
        {
            string result = string.Empty;

            int digit = 0;
            while (number > 0)
            {
                digit = (int)(number % 10);
                result = numSystem[digit] + result;
                number /= 10;
            }

            return result;
        }

        private static BigInteger Decrypt(string str)
        {
            BigInteger result = 0;

            string digit;
            for (int j = 0; j < str.Length; j += 3)
            {
                digit = str.Substring(j, 3);
                // result = result * Array.IndexOf(numSystem, digit);
                for (int i = 0; i < numSystem.Length; i++)
                {
                    if (digit == numSystem[i])
                    {
                        result = result * 10 + i;
                    }
                }
            }

            return result;
        }
    }
}
