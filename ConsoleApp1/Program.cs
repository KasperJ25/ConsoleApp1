using System.Reflection;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string major = Environment.GetEnvironmentVariable("GitVersion_Major");
            string minor = Environment.GetEnvironmentVariable("GitVersion_Minor");
            string patch = Environment.GetEnvironmentVariable("GitVersion_Patch");
            string semVer = Environment.GetEnvironmentVariable("GitVersion_SemVer");
            string informationalVersion = Environment.GetEnvironmentVariable("GitVersion_InformationalVersion");

            Console.WriteLine($"GitVersion MajorR: {major}");
            Console.WriteLine($"GitVersion Minor: {minor}");
            Console.WriteLine($"GitVersion Patch: {patch}");
            Console.WriteLine($"Full SemVer: {semVer}");
            Console.WriteLine($"Informational Version: {informationalVersion}");

            HelloWorld();
            GetVersionS();
            CountToOneHundred();
        }

        public static void GetVersionS()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var versionAttribute = (AssemblyInformationalVersionAttribute)assembly.GetCustomAttributes(typeof(AssemblyInformationalVersionAttribute), false)[0];
            var version = versionAttribute.InformationalVersion;

            Console.WriteLine($"Assembly: {version}");
            //Console.WriteLine($"Major: {versionField}");






        }

        public static void HelloWorld()
        {
            Console.WriteLine($"Hello World!"); 
















        }

        public static void CountToOneHundred()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i); 
                //test
            }
        }
    }
}
