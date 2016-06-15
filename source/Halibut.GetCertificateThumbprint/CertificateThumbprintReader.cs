using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace Halibut.GetCertificateThumbprint
{
    public class CertificateThumbprintReader
    {
        public string GetCertificateThumbprint(string file)
        {
            var cert = new X509Certificate2(File.ReadAllBytes(file));
            return cert.Thumbprint;
        }
    }
}
