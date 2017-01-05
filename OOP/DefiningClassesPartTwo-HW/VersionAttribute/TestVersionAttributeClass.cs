namespace VersionAttribute
{
    using System;

    [Version("2.11")]
    public class TestVersionAttributeClass
    {
        public static void Main()
        {
            Type type = typeof(TestVersionAttributeClass);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute ver in allAttributes)
            {
                Console.WriteLine(ver.Version);
            }
        }
    }
}
