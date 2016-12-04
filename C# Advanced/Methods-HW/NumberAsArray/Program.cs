namespace NumberAsArray
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("Adds two positive integer numbers represented as arrays of digits");
            // Console.Write("Enter first number: ");
            string inputLenghtOfNumbers = Console.ReadLine();
            string[] firstArrayAsString = Console.ReadLine().Split(' ');
            string[] secondArrayAsString = Console.ReadLine().Split(' ');
            int[] firstNumber = new int[firstArrayAsString.Length];
            for (int i = 0; i < firstArrayAsString.Length; i++)
            {
                firstNumber[i] = int.Parse(firstArrayAsString[i]);
            }

            int[] secondNumber = new int[secondArrayAsString.Length];
            for (int i = 0; i < secondArrayAsString.Length; i++)
            {
                secondNumber[i] = int.Parse(secondArrayAsString[i]);
            }

            SumTwoDigitArrays(firstNumber, secondNumber);
        }

        //extract the digits of a number into an array;


        //sums two arrays of digits
        static void SumTwoDigitArrays(int[] firstNumberAsArray, int[] secondNumberAsArray)
        {
            // int[] array1 = ConvertBigIntToArray(number1);
            // int[] array2 = ConvertBigIntToArray(number2);
            //изравнявам дължините на двата масива, за да ги събера по лесно
            if (firstNumberAsArray.Length > secondNumberAsArray.Length)
            {
                Array.Resize(ref secondNumberAsArray, firstNumberAsArray.Length);
            }
            else
            {
                Array.Resize(ref firstNumberAsArray, secondNumberAsArray.Length);
            }

            int[] sumAsArray = new int[firstNumberAsArray.Length + 1]; //дължината на масива в който ще събирам е +1
            int carry = 0; //числото на ум
                           //цикъл за да ги събера
            for (int i = 0; i < sumAsArray.Length - 1; i++)
            {
                sumAsArray[i] = (firstNumberAsArray[i] + secondNumberAsArray[i] + carry) % 10;
                if (firstNumberAsArray[i] + secondNumberAsArray[i] + carry > 9)
                {
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }
            }

            sumAsArray[sumAsArray.Length - 1] = carry; //на последния елемент присвоявам числото на ум

            if (sumAsArray[sumAsArray.Length - 1] != 0) // ако последния елемент не е 0 го отпечатвам, ако ли не - го прескачам
            {
                Console.Write(sumAsArray[sumAsArray.Length - 1]);
            }

            for (int i = 0; i <= sumAsArray.Length - 2; i++) //отпечатвам масива наобратно, за да изглежда като число
            {

                Console.Write("{0} ", sumAsArray[i]);
            }

            Console.WriteLine();
        }
    }
}


///*Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.*/

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//class AddsTwoArraysOfDigits
//{
//    static void Main()
//    {
//        // Console.WriteLine("Adds two positive integer numbers represented as arrays of digits");
//        // Console.Write("Enter first number: ");
//        string inputLenghtOfNumbers = Console.ReadLine();
//        string[] firstArrayAsString = Console.ReadLine().Split(' ');
//        string[] secondArrayAsString = Console.ReadLine().Split(' ');
//        int[] number1 = new int[firstArrayAsString.Length];
//        for (int i = 0; i < firstArrayAsString.Length; i++)
//        {
//            number1[i] = int.Parse(firstArrayAsString[i]);
//        }

//        int[] number2 = new int[secondArrayAsString.Length];
//        for (int i = 0; i < secondArrayAsString.Length; i++)
//        {
//            number2[i] = int.Parse(secondArrayAsString[i]);
//        }

//        int[] array3 = SumTwoDigitArrays(number1, number2);

//        for (int i = 0; i <= array3.Length - 2; i++) //отпечатвам масива наобратно, за да изглежда като число
//        {

//            Console.Write("{0} ", array3[i]);
//        }
//    }

//    //extract the digits of a number into an array;


//    //sums two arrays of digits
//    static int[] SumTwoDigitArrays(int[] array1, int[] array2)
//    {
//        // int[] array1 = ConvertBigIntToArray(number1);
//        // int[] array2 = ConvertBigIntToArray(number2);
//        //изравнявам дължините на двата масива, за да ги събера по лесно
//        if (array1.Length > array2.Length)
//        {
//            Array.Resize(ref array2, array1.Length);
//        }
//        else
//        {
//            Array.Resize(ref array1, array2.Length);
//        }

//        int[] array3 = new int[array1.Length + 1]; //дължината на масива в който ще събирам е +1
//        int carry = 0; //числото на ум
//                       //цикъл за да ги събера
//        for (int i = 0; i < array3.Length - 1; i++)
//        {
//            array3[i] = (array1[i] + array2[i] + carry) % 10;
//            if (array1[i] + array2[i] + carry > 9)
//            {
//                carry = 1;
//            }
//            else
//            {
//                carry = 0;
//            }
//        }

//        array3[array3.Length - 1] = carry; //на последния елемент присвоявам числото на ум

//        return array3;
//    }
//}