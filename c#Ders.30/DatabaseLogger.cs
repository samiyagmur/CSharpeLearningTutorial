using System;
using System.Collections.Generic;
using System.Text;

namespace CSahrp.Ders._30
{
    public class DatabaseLogger : Ilogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Database'e yazar.");
        }
    }
}
