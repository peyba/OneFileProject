using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;
using OneFileProject.Properties;
using System.IO.Compression;
using ClassLibraryForTest;

namespace OneFileProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // 
            AppDomain.CurrentDomain.AssemblyResolve += AppDomain_AssemblyResolve;

            /*
             * Don't call loading assabbly from Main method.
             * Compoiler doesn't know anything about your dll at this scope.
             * 
             * Next code becomes compile error("Could not load file or assembly ..."):
             * 
             * var testObject = new ClassLibraryForTest.SimpleLibClass();
             * 
             * But, if you wrap loading assabbly classes in any method - it works cool.
             */

            DoAnything();
        }

        /// <summary>
        /// Using loaded assambly
        /// </summary>
        private static void DoAnything()
        {
            Console.WriteLine("Creating object by ClassLibraryForTest.SimpleLibClass");
            var testObject = new ClassLibraryForTest.SimpleLibClass() { MyProperty = "test_literal" };

            Console.WriteLine("testObject.MyProperty = {0}", testObject.MyProperty);
            Console.WriteLine("SimpleLibClass.Version = {0}", ClassLibraryForTest.SimpleLibClass.Version);
            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }

        /// <summary>
        /// Loading assambly from resources
        /// More info at: http://habrahabr.ru/post/85480/, thank you http://habrahabr.ru/users/FallenGameR/
        /// </summary>
        private static Assembly AppDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            if (args.Name.Contains("ClassLibraryForTest"))
            {
                Console.WriteLine("Resolving assembly: {0}", args.Name);

                using (var resource = new MemoryStream(Resources.ClassLibraryForTest_dll))
                {
                    using (MemoryStream resultStream = new MemoryStream())
                    {
                        using (var deflated = new DeflateStream(resource, CompressionMode.Decompress))
                        {
                            int dllReadBufferSize = 1024;

                            List<byte> libData = new List<byte>();
                            byte[] buffer = new byte[dllReadBufferSize];
                            
                            while (deflated.Read(buffer, 0, dllReadBufferSize) > 0)
                            {
                                libData.AddRange(buffer);
                            }

                            return Assembly.Load(libData.ToArray());
                        }
                    }
                }
            }

            return null;
        }
    }
}
