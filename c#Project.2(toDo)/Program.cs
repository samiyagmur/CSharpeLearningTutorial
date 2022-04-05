using System;
using System.Collections.Generic;


namespace toDo.Uygulamasi
{
    public class Program
    {   
        static void Main(string[] args)
        {
            
            
            Methods methods = new Methods();
            List<KartBilgileri> getToDo = KartBilgileri.todo;
            List<KartBilgileri> getInProgress = KartBilgileri.inProgress;
            List<KartBilgileri> getDone = KartBilgileri.done;
            short choseOperatingCard;


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
                short operation = Convert.ToInt16(Console.ReadLine());

                

                


                switch (operation)
                {
                    case 1:
                        for (int i = 1; i <= 3; i++)
                        {
                            switch (i)
                            {
                                case 1:
                                    methods.Listing(getToDo);
                                    break;
                                case 2:
                                    methods.Listing(getInProgress);
                                    break;
                                case 3:
                                    methods.Listing(getDone);
                                    break;
                                default:
                                    methods.GetErrorSituation();
                                    break;
                            }
                        }

                        break;
                    case 2:

                        choseOperatingCard = methods.GetCardSize();
                        switch (choseOperatingCard)
                        {
                            case 1:
                                methods.Add(getToDo);
                                break;
                            case 2:
                                methods.Add(getInProgress);
                                break;
                            case 3:
                                methods.Add(getDone);
                                break;
                            default:
                                methods.GetErrorSituation();
                                break;
                        }

                        break;
                    case 3:

                        choseOperatingCard = methods.GetCardSize();
                        switch (choseOperatingCard)
                        {
                            case 1:
                                methods.Remove(getToDo);
                                break;
                            case 2:
                                methods.Remove(getInProgress);
                                break;
                            case 3:
                                methods.Remove(getDone);
                                break;
                            default:
                                methods.GetErrorSituation();
                                break;
                        }

                        break;
                    case 4:

                        choseOperatingCard = methods.GetCardSize();
                        switch (choseOperatingCard)
                        {
                            case 1:
                                methods.Update(getToDo);
                                break;
                            case 2:
                                methods.Update(getInProgress);
                                break;
                            case 3:
                                methods.Update(getDone);
                                break;
                            default:
                                methods.GetErrorSituation();
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
                        methods.EnterYouTitle();
                        KartBilgileri isThereToDoList = getToDo.Find(x => x.Title == methods.Title);
                        KartBilgileri isThereProgressList = getInProgress.Find(x => x.Title == methods.Title);
                        KartBilgileri isThereDoneList = getDone.Find(x => x.Title == methods.Title);

                        if (isThereToDoList != null)
                        {   
                            switch (tasınacakKartSecim)
                            {
                                case 2:
                                    methods.Move(getToDo, getInProgress, isThereToDoList);
                                    break;
                                case 3:
                                    methods.Move(getToDo, getDone, isThereToDoList);
                                    break;
                                default:
                                    methods.GetErrorSituation();
                                    break;
                            }
                        }
                        else if (isThereProgressList != null)
                        {
                            switch (tasınacakKartSecim)
                            {
                                case 1:
                                    methods.Move(getInProgress, getToDo, isThereProgressList);
                                    break;
                                case 3:
                                    methods.Move(getInProgress, getDone, isThereProgressList);
                                    break;
                                default:
                                    methods.GetErrorSituation();
                                    break;
                            }
                        }
                        else if (isThereDoneList != null)
                        {
                            switch (tasınacakKartSecim)
                            {
                                case 1:
                                    methods.Move(getDone, getToDo, isThereDoneList);
                                    break;
                                case 2:
                                    methods.Move(getDone, getInProgress, isThereDoneList);
                                    break;
                                default:
                                    methods.GetErrorSituation();
                                    break;
                            }
                        }
                        else
                        {
                            methods.GetErrorSituation();
                        }

                        break;
                    
                    case 6:

                        return;

                    default:

                        methods.GetErrorSituation();

                        break;
                }
            }

        }
    }

}    
