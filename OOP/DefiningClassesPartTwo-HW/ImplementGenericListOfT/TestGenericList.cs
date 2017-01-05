using System;
using System.Text;

namespace ImplementGenericListOfT
{
    public class TestGenericList
    {
        public static void Main()
        {
            GenericList<int> list = new GenericList<int>(5);
            StringBuilder result = new StringBuilder();
            list.Add(3);
            list.Add(2);
            list.Add(1);
            list.InsertAtPosition(0, 2);
            result.AppendLine(list.ToString());

            result.AppendLine("--REMOVE AT INDEX 1--");
            list.RemoveByIndex(1);
            result.AppendLine(list.ToString());

            result.AppendLine("     MIN: " + list.Min());
            result.AppendLine("     MAX: " + list.Max());

            result.AppendLine("-----INDEX OF 3-----");
            result.AppendLine(list.FindByIndex(3).ToString());
            result.AppendLine("-----INDEX OF 2-----");
            result.AppendLine(list.FindByIndex(2).ToString());

            result.AppendLine("-----CLEAR LIST-----");
            list.Clear();
            result.AppendLine(list.ToString());

            Console.WriteLine(result);
        }
    }
}
