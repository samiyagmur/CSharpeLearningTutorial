using System;
using System.Collections.Generic;
using System.Text;

namespace CSahrp.Ders._30
{
    public class LogManager:Ilogger
    {
        public Ilogger _logger;

        public void WriteLog()
        {
           _logger.WriteLog();
        }

        public LogManager (Ilogger logger)//İntarfaceler newle oluşturmaz tek başlarına anlamlı değildir
                                            //Bu sınıftan türeyen 
        {
            _logger = logger;
        }

    }
}
