using System;
using System.Collections.Generic;


namespace toDo.Uygulamasi
{
    public class Program
    {   
        static void Main(string[] args)
        {
            KartBilgileri kartBilgileri = new KartBilgileri();
            
            Methods methods = new Methods();
            var toDo = toDoo.todo;
            var inProgress = InProgress.inProgress;
            var done =Done.done;
            short islemHangiKart;


            while (true)
            {
                Console.Write(  "*******************************************\n"
                              + "Lütfen yapmak istediğiniz işlemi numarasını seçiniz\n"
                              + "*******************************************\n"
                              + "(1) Board Listelemek\n"
                              + "(2) Board'a Kart Eklemek\n"
                              + "(3) Board'dan Kart Silmek\n"
                              + "(4) Board'dan Kart Güncellemek\n"
                              + "(5) Kart Taşımak \n"
                              + "(6) işlemi sonlandırmak\n" 
                              + "İşlem=");
                short islem = Convert.ToInt16(Console.ReadLine());

                

                


                switch (islem)
                {
                    case 1:
                        for (int i = 1; i <= 3; i++)
                        {
                            switch (i)
                            {
                                case 1:
                                    methods.Listele(toDo);
                                    break;
                                case 2:
                                    methods.Listele(inProgress);
                                    break;
                                case 3:
                                    methods.Listele(done);
                                    break;
                                default:
                                    methods.HataDurumu();
                                    break;
                            }
                        }

                        break;
                    case 2:

                        islemHangiKart = methods.KartSecimi();
                        switch (islemHangiKart)
                        {
                            case 1:
                                methods.Ekle(toDo);
                                break;
                            case 2:
                                methods.Ekle(inProgress);
                                break;
                            case 3:
                                methods.Ekle(done);
                                break;
                            default:
                                methods.HataDurumu();
                                break;
                        }

                        break;
                    case 3:

                        islemHangiKart = methods.KartSecimi();
                        switch (islemHangiKart)
                        {
                            case 1:
                                methods.Sil(toDo);
                                break;
                            case 2:
                                methods.Sil(inProgress);
                                break;
                            case 3:
                                methods.Sil(done);
                                break;
                            default:
                                methods.HataDurumu();
                                break;
                        }

                        break;
                    case 4:

                        islemHangiKart = methods.KartSecimi();
                        switch (islemHangiKart)
                        {
                            case 1:
                                methods.Guncelle(toDo);
                                break;
                            case 2:
                                methods.Guncelle(inProgress);
                                break;
                            case 3:
                                methods.Guncelle(done);
                                break;
                            default:
                                methods.HataDurumu();
                                break;
                        }

                        break;
                    case 5:

                        Console.Write("Lütfen taşımak istediğiniz Line'ı seçiniz:\n"
                                  + "(1) TODO\n"
                                  + "(2) IN PROGRESS\n"
                                  + "(3) DONE\n"
                                  + "İşlem=");
                        short tasınacakKartSecim = Convert.ToInt16(Console.ReadLine());
                        methods.DegerGirSadeceBaslik();
                        KartBilgileri todolistedeVarmi = toDo.Find(x => x.Baslik == methods.Baslik);
                        KartBilgileri inProgresslistedeVarmi = inProgress.Find(x => x.Baslik == methods.Baslik);
                        KartBilgileri donelistedeVarmi = done.Find(x => x.Baslik == methods.Baslik);

                        if (todolistedeVarmi != null)
                        {   
                            switch (tasınacakKartSecim)
                            {
                                case 2:
                                    methods.Tasi(toDo, inProgress, todolistedeVarmi);
                                    break;
                                case 3:
                                    methods.Tasi(toDo, done, todolistedeVarmi);
                                    break;
                                default:
                                    methods.HataDurumu();
                                    break;
                            }
                        }
                        else if (inProgresslistedeVarmi != null)
                        {
                            switch (tasınacakKartSecim)
                            {
                                case 1:
                                    methods.Tasi(inProgress, toDo, inProgresslistedeVarmi);
                                    break;
                                case 3:
                                    methods.Tasi(inProgress, done, inProgresslistedeVarmi);
                                    break;
                                default:
                                    methods.HataDurumu();
                                    break;
                            }
                        }
                        else if (donelistedeVarmi != null)
                        {
                            switch (tasınacakKartSecim)
                            {
                                case 1:
                                    methods.Tasi(done, toDo, donelistedeVarmi);
                                    break;
                                case 2:
                                    methods.Tasi(done, inProgress, donelistedeVarmi);
                                    break;
                                default:
                                    methods.HataDurumu();
                                    break;
                            }
                        }
                        else
                        {
                            methods.HataDurumu();
                        }

                        break;
                    
                    case 6:

                        return;

                    default:

                        methods.HataDurumu();

                        break;
                }
            }

        }
    }

}    
