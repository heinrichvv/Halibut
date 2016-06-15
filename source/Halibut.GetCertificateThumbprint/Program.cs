using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halibut.GetCertificateThumbprint
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage:  Halibut.GetCertificateThumbprint.exe <certificate-file-name>");
                return;
            }

            var filePath = args[0];

            if (!File.Exists(filePath))
            {
                Console.WriteLine("file does not exist: " + filePath);
                return;
            }
            var reader = new CertificateThumbprintReader();
            var thumbprint = reader.GetCertificateThumbprint(filePath);
            Console.WriteLine(thumbprint);
        }
    }
}
