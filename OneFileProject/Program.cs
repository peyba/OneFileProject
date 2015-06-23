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
        // Array of ur included libraries
        private static Assembly[] includedLibraries = new Assembly[] 
        {
            Assembly.Load(DecompressAssembly(Resources.ClassLibraryForTest_dll))
            /*
             * If u don't compress ur assambly make this:
             * 
             * Assembly.Load(Resources.ClassLibraryForTest_dll)
             */
        };

        static void Main(string[] args)
        {
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
        /// Get included assambly
        /// </summary>
        private static Assembly AppDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            return includedLibraries.SingleOrDefault(w => w.FullName == args.Name);
        }

        /// <summary>
        /// Decompress assembly
        /// </summary>
        /// <param name="compressedAssamblyData">Compressed assembly bytes data</param>
        /// <returns>Decompress assembly bytes data</returns>
        private static byte[] DecompressAssembly(byte[] compressedAssamblyData)
        {
            using (var resource = new MemoryStream(compressedAssamblyData))
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

                    return libData.ToArray();
                }
            }
        }
    }
}
