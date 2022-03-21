using System;

namespace CSahrp.Ders._30
{
    internal class Program
    {
        //interface:Sınıfların içermesi gereken metotların
        //imzaların yer aldığı özelliklerin yer aldığı taslaktır.
        //İnterface içersindeki proportilere bir değer ataması yazılmaz
        //Metotlar gibi proportler gibi kullanılır
        //proportler gibi ilk değer ataması yapılmaz
        //metotların gövdeside yazılmaz
        //sadece impament eden sınıfın ara yüzü olarak düşünübiliriz
        //Neden ihtiyaç duyulduğu konusunda interfaceden kalıtım alan sorumluluğun çerçevesinin çizilmesine
        //yardımcı olur
        //Aynı sorunu başka bir tarzda yapması gereken başkabir sınıf söz konusu olduğunda
        //o implementten türeyerek aynı işi kendi tarzında yapabilir
        //yukarıdan baktımızda o interface ondan türeyen n tane sınıfın ne iş yaptığını çok kolay bir şekilde anlayabilriz.
        static void Main(string[] args)//Gerçek hayatta interface data base ve loglama işlemleri içi çok kullnıyoruz.Şimdi loglama işlemi için bir örnek görelim.
        { 

            FileLogger fileLogger =new FileLogger();
            fileLogger.WriteLog();
            
            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.WriteLog();

            SmsLogger smsLogger = new SmsLogger();
            smsLogger.WriteLog();

            LogManager logManager = new LogManager(new FileLogger());
            logManager.WriteLog();
        }
    }
}
