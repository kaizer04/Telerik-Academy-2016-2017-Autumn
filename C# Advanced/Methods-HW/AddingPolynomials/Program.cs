using System;

namespace AddingPolynomials
{
    public class Program
    {
        static int[] FillArray(string inputArray)
        {
            string[] arrayAsString = inputArray.Split(' ');
            int[] array = new int[arrayAsString.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(arrayAsString[i]);
            }

            return array;
        }

        static int[] AddsTwoPolynomials(int[] firstArray, int[] seconfdArray)
        {
            int[] sumAsArray = new int[firstArray.Length];
            for (int i = 0; i < sumAsArray.Length; i++)
            {
                sumAsArray[i] = firstArray[i] + seconfdArray[i];
            }

            return sumAsArray;
        }

        static void PrintPolinomial(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }

        public static void Main()
        {
            int degree = int.Parse(Console.ReadLine());
            string firstPolinomialAsString = Console.ReadLine();
            string secondPolinomialAsString = Console.ReadLine();

            int[] firstPolinomialAsArray = FillArray(firstPolinomialAsString);
            int[] secondPolinomialAsArray = FillArray(secondPolinomialAsString);
            
            PrintPolinomial(AddsTwoPolynomials(firstPolinomialAsArray, secondPolinomialAsArray));
        }
    }
}
