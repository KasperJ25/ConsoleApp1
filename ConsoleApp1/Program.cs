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

            GetVersionS();
        }

        public static void GetVersionS() 
        {
            var assembly = Assembly.GetExecutingAssembly();
            var assemblyName = assembly.GetName().Name;
            var gitVersionInformationType = assembly.GetType("GitVersionInformation");
            //var versionField = gitVersionInformationType.GetField("Major"); AAAAAaAAAAAAAAA

            Console.WriteLine($"Assembly: {assembly.ToString()}");
            Console.WriteLine($"Assembly Name: {assemblyName}");
            Console.WriteLine($"GitVersion: {gitVersionInformationType}");
            //Console.WriteLine($"Major: {versionField}"); A

        }
    }
}
