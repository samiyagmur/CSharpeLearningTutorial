using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace ToDo.App
{
    public class Methods: CardInformation
    {   
        public void GetCardInformations()
        {   
            
            Console.WriteLine("Lütfen işlem yapmak istediğiniz kişinin kart bilgilerini giriniz.");
            Console.Write("Başlık      :");
            Title = Console.ReadLine();
            Console.Write("\nİçerik      :");
            Scope = Console.ReadLine();
            Console.Write("\nAtanan Kişi :");
            Member = Console.ReadLine();
            Console.Write("\nBüyüklük    :-> XS(1),S(2),M(3),L(4),XL(5)");

            int getCardSizeFromEnum = Convert.ToInt32(Console.ReadLine());
            Size = Enum.GetName(typeof(KartBoyutları), getCardSizeFromEnum);
        }

        public void EnterYouTitle()
        {
            Console.WriteLine("Lütfen işlem yapmak istediğiniz kişinin kart bilgilerini giriniz.");
            Console.Write("Başlık      :");
            Title = Console.ReadLine();

        }
        public void GetErrorSituation()
        {
            Console.WriteLine("Aradığınız kıriterlere uygun kart board'da bulunamamış olabilir." +
                              "Kart bilgileriniz güncelleme veya taşımak istediğiniz kartta zaten  mevcut olabilir." +
                              "Lütfen bir seçim yapınız.");
            Console.Write("* İşlemi sonlandırmak için : (1) \n" 
                             +"* Yeniden denemek için : (2) \n"
                             +"İşlem=");
            short operation = Convert.ToInt16(Console.ReadLine());
            switch (operation)
            {
                case 1:
                    return;
                case 2:
                    break;
                default:
                    Console.WriteLine("Yalnış işlem girişi yaptınız");
                    break;
            }
        }

        public short GetCardSize()
        {
            Console.Write("İşlem yapmak istediğiniz kartının başlığı giriniz:\n"
                                  + "Todo için: (1)\n"
                                  + "InProgress için: (2)\n"
                                  + "Done için: (3)\n"
                                  + "İşlem=");
            short choseOperationCard = Convert.ToInt16(Console.ReadLine());
            return choseOperationCard;
        }
        public void Add(List<CardInformation> getOperationList)
        {
            GetCardInformations();
            CardInformation controlMemberToLists = getOperationList.Find(x => x.Member == Member);
            if (controlMemberToLists == null)
            {
                getOperationList.Add(new CardInformation()
                {
                    Title = Title,
                    Scope = Scope,
                    Size = Size,
                    Member = Member
                });
            }
            else
            {
                GetErrorSituation();
            }

        }
        public void Remove(List<CardInformation> getOperationList)
        {
            EnterYouTitle();
            var controlMemberToLists = getOperationList.Find(x => x.Title == Title);
            

            if (controlMemberToLists != null)
            {
                int getMamberIndex = getOperationList.IndexOf(controlMemberToLists);
                getOperationList.RemoveAt(getMamberIndex);
            }
            else
            {
                GetErrorSituation();
            }

        }
        public void Update(List<CardInformation> getOperationList)
        {
            GetCardInformations();
            var controlMemberToLists = getOperationList.Find(x => x.Title == Title);
            
            if (controlMemberToLists != null)
            {
                int getMamberIndex = getOperationList.IndexOf(controlMemberToLists);
                getOperationList.RemoveAt(getMamberIndex);

                getOperationList.Insert(getMamberIndex, new CardInformation()
                {
                    Title = Title,
                    Scope = Scope,
                    Size = Size,
                    Member = Member
                });

            }
            else
            {
                GetErrorSituation();
            }

        }

        public void Move (List<CardInformation> getOperationList, List<CardInformation> whichListMoveCardInformation, CardInformation toFindMemberİnOperationList)
        {
                
            int getMamberIndex = getOperationList.IndexOf(toFindMemberİnOperationList);
            getOperationList.RemoveAt(getMamberIndex);
            GetCardInformations();
            whichListMoveCardInformation.Add( new CardInformation()
                {
                    Title = Title,
                    Scope = Scope,
                    Size = Size,
                    Member = Member
                });
           
        }
        public void Listing(List<CardInformation> whichCardListing)
        {

            //for (int i = 0; i < listelenecekKart.Count; i++)
            //{
            //    listelenecekKart
            //}
            if (whichCardListing==todo)
            {
                Console.WriteLine("TODO Line\n"
                                 + "************************");
            }
            else if (whichCardListing==inProgress)
            {
                Console.WriteLine("IN PROGRESS Line\n"
                                 + "************************");
            }
            
            else
            {
                Console.WriteLine("DONE Line\n"
                                 + "************************");
            }
            bool flag = false;
            foreach (var item in whichCardListing)
            {
                flag = true;
                Console.WriteLine(
                                  "Başlık      :"+item.Title
                                + "\nİçerik      :"+item.Scope
                                + "\nAtanan Kişi :"+item.Member
                                + "\nBüyüklük    :"+item.Size
                                + "\n-");
                                
            }
            if (flag==false)
            {
                Console.WriteLine("~ BOŞ ~");
            }

        }

    }

}
