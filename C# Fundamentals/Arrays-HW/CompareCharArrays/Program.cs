/*Write a program that compares two char arrays lexicographically (letter by letter).*/

namespace CompareCharArrays
{
    using System;

    public class Program
    {
        public static void Main()
        {
            // Console.Write("Number of array`s elements = ");
            string inputFirstString = Console.ReadLine(); 

            int size = inputFirstString.Length;
            char[] array = new char[size];

            for (int i = 0; i < size; i++)
            {
                // Console.Write("arr[{0}] = ", i);
                array[i] = inputFirstString[i];
            }

            string inputSecondString = Console.ReadLine();
            // Console.Write("Number of array2`s elements = ");
            int size2 = inputSecondString.Length;
            char[] array2 = new char[size2];

            for (int i = 0; i < size2; i++)
            {
                // Console.Write("arr2[{0}] = ", i);
                array2[i] = inputSecondString[i];
            }

            bool compare = false;
            if (size == size2) // случаите когато са еднакви мсаивите - равни дължини с еднакви елементи
            {
                for (int i = 0; i < size; i++)
                {
                    if (array[i] == array2[i])
                    {
                        compare = true;
                    }
                    else
                    {
                        compare = false;
                        break;
                    }
                }

                if (compare)
                {
                    Console.WriteLine("=");
                }
                else
                {
                    for (int i = 0; i < size; i++)
                    {
                        if (array[i] != array2[i]) //проверка ако са равни дължините и ако са еднакви елементите -> да премине на следващия
                        {
                            if (array[i] < array2[i])
                            {
                                Console.WriteLine("<");
                                break;
                            }
                            else
                            {
                                Console.WriteLine(">");
                                break;
                            }
                        }
                    }
                }
            }
            else
            {
                if (size > size2)  // правя тази проверка, за да мога даобхвана случаите когато всички елементи на двата масива са еднакви, но този с по-малка дължина (с по малко елементи) ще бъде по напред
                {
                    for (int i = 0; i < size2; i++)
                    {
                        if (array[i] != array2[i])
                        {
                            if (array[i] < array2[i])
                            {
                                Console.WriteLine("<");
                                break;
                            }
                            else
                            {
                                Console.WriteLine(">");
                                break;
                            }
                        }

                        if (i == size2 - 1)
                        {
                            Console.WriteLine(">");
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < size; i++)
                    {
                        if (array[i] != array2[i])
                        {
                            if (array2[i] < array[i])
                            {
                                Console.WriteLine(">");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("<");
                                break;
                            }
                        }

                        if (i == size - 1)
                        {
                            Console.WriteLine("<");
                            break;
                        }
                    }
                }
                //Console.WriteLine("The arrays are NOT equal");
            }

        }
    }
}
