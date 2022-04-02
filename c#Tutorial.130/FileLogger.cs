using System;
using System.Collections.Generic;
using System.Text;

namespace CSahrp.Ders._30
{
    public class FileLogger : Ilogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Dosyaya log yazar.");
        }
    }
}
