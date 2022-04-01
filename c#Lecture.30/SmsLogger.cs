using System;
using System.Collections.Generic;
using System.Text;

namespace CSahrp.Ders._30
{
    public class SmsLogger : Ilogger
    {
        public void WriteLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Sms olarak log yazar.");
        }
    }
}
