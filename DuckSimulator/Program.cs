using DuckSimulator.ClassesDerivadas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DuckSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var assemblyTypeList = GetAssemblyTypes("DuckSimulator.ClassesDerivadas");

            foreach(var assemblyType in assemblyTypeList)
            {
                Console.WriteLine($" --- {assemblyType.Name} --- ");

                var classMethods = GetAssemblyMethods(assemblyType);

                Object classInstanceObject = Activator.CreateInstance(assemblyType);
                foreach (var method in classMethods)
                {
                    method.Invoke(classInstanceObject, null);
                }
            }

            Console.WriteLine(" --- FIM --- ");

            Console.ReadKey();
        }

        private static IEnumerable<Type> GetAssemblyTypes(string assemblyNamespace)
        {
            return from assemblyType in Assembly.GetExecutingAssembly().GetTypes()
                   where assemblyType.IsClass && assemblyType.Namespace == assemblyNamespace
                   select assemblyType;
        }

        private static IEnumerable<MethodInfo> GetAssemblyMethods(Type assemblyType)
        {
            //var result = assemblyType.GetInterfaceMap(interfaceType).TargetMethods;
            return assemblyType.GetMethods().Where(method => method.DeclaringType.FullName != "System.Object" && !method.IsSpecialName);
        }

    }
}
