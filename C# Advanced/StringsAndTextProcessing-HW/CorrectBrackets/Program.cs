namespace CorrectBrackets
{
    using System;

    public class Program
    {
        public static void Main()
        {
            // Console.Write("Enter an expression: ");
            string expression = Console.ReadLine();
            int brackets = 0;

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    brackets++;
                }

                if (expression[i] == ')')
                {
                    brackets--;
                }

                if (brackets < 0)
                {
                    //Console.WriteLine("Incorrect");
                    break;
                }
            }

            if (brackets == 0)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
