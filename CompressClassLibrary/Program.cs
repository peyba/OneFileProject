using System.IO;
using System.IO.Compression;

namespace CompressClassLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Get library file */
            var fileInputName = @"lib\ClassLibraryForTest.dll";
            var assembly = File.ReadAllBytes(fileInputName);

            /* Compress and save */
            var fileOutputName = @"lib\ClassLibraryForTest.dll.cmp";
            using (var file = File.Open(fileOutputName, FileMode.Create))
            using (var stream = new DeflateStream(file, CompressionMode.Compress))
            using (var writer = new BinaryWriter(stream))
            {
                writer.Write(assembly);
            }
        }
    }
}