using System;
using System.Collections.Generic;
using System.Text;

namespace Telefon.Rehberi.Uygulaması
{
    internal class Operations:PhoneBook
    {
        public void Regist()
        {
            Console.Write("Lütfen isim giriniz             :");
            Name = Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz          :");
            SurName = Console.ReadLine();
            Console.Write("Lütfen telefon numarası giriniz :");
            PhoneNum = Console.ReadLine();

            Person.Add(new PhoneBook { Name = Name, SurName = SurName, PhoneNum = PhoneNum });


        }

        public void Remove()
        {



            while (true)
            {
                Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ve soyadını giriniz:");
                Name = Console.ReadLine();
                SurName = Console.ReadLine();


                PhoneBook isGetNameListControl = Person.Find(i => i.Name == Name);
                PhoneBook isGetSurNameListControl = Person.Find(i => i.SurName == SurName);

                if (isGetNameListControl != null && isGetSurNameListControl != null)
                {
                    var getNameİndex = Person.IndexOf(isGetNameListControl);
                    Console.WriteLine($"{getNameİndex}isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                    string approval = Console.ReadLine();
                    switch (approval.ToUpper())
                    {
                        case "Y":
                            Person.Remove(Person[getNameİndex]);
                            return;
                        case "N":
                            return;
                        default:
                            Console.WriteLine("Yalnış işlem  girişi yaptınız!!!");
                            break;
                    }





                }
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("İşeme devam etmek için : (2)");
                    int operation = Convert.ToInt32(Console.ReadLine());
                    switch (operation)
                    {
                        case 1:
                            return;
                        case 2:
                            break;
                        default:
                            break;
                    }


                }
            }

        }

        public void Update()
        {

            while (true)
            {
                Name = Console.ReadLine();
                SurName = Console.ReadLine();


                PhoneBook isGetNameListControl = Person.Find(i => i.Name == Name);
                PhoneBook isGetSurNameListControl = Person.Find(i => i.SurName == SurName);

                if (isGetNameListControl != null && isGetSurNameListControl != null)
                {
                    var getNameİndex = Person.IndexOf(isGetNameListControl);
                    Console.WriteLine($"{getNameİndex}isimli kişinin numarasını rehberden güncellemek üzere, onaylıyor musunuz ?(y/n)");
                    string approval = Console.ReadLine();
                    switch (approval.ToUpper())
                    {
                        case "Y":
                            Person[getNameİndex].PhoneNum = Console.ReadLine();
                            return;
                        case "N":
                            return;
                        default:
                            break;
                    }

                    break;

                }
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("İşeme devam etmek için : (2)");
                    int operation = Convert.ToInt32(Console.ReadLine());
                    switch (operation)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        default:
                            break;
                    }
                }
            }

        }

        public void List()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");

            var lts = new List<string>();


            for (int i = 0; i < Person.Count; i++)
            {

                lts.Add(Person[i].Name);

            }

            lts.Sort();

            for (int j = 0; j < Person.Count; j++)
            {
                string ff = lts[j];
                PhoneBook isGetNameListControl = Person.Find(i => i.Name == ff);
                var getNameİndex = Person.IndexOf(isGetNameListControl);
                PhoneBook swap = Person[j];
                Person[j] = Person[getNameİndex];
                Person[getNameİndex] = swap;
            }

            Console.WriteLine("Liste sıralması yolunu seçiniz:A->Z için {1},Z->A için {2}");
            int operation = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    for (int i = 0; i < Person.Count; i++)
                    {
                        Console.WriteLine("isim:{0}", Person[i].Name);
                        Console.WriteLine("Soyisim:{0}", Person[i].SurName);
                        Console.WriteLine("Telefon Numarası:{0}", Person[i].PhoneNum);
                        Console.WriteLine("-");
                    }
                    break;

                case 2:
                    Person.Reverse();
                    for (int i = 0; i < Person.Count; i++)
                    {
                        Console.WriteLine("isim:{0}", Person[i].Name);
                        Console.WriteLine("Soyisim:{0}", Person[i].SurName);
                        Console.WriteLine("Telefon Numarası:{0}", Person[i].PhoneNum);
                        Console.WriteLine("-");
                    }
                    break;
                default:
                    break;
            }




        }

        public void Search()
        {

            Console.WriteLine(" Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("İsim ve Soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            int operation = Convert.ToInt32(Console.ReadLine());
            switch (operation)
            {
                case 1:
                    Name = Console.ReadLine();
                    SurName = Console.ReadLine();

                    PhoneBook isGetNameListControl = Person.Find(i => i.Name == Name);
                    PhoneBook isGetSurNameListControl = Person.Find(i => i.SurName == SurName);

                    var getNameIndex = Person.IndexOf(isGetNameListControl);

                    if (isGetNameListControl != null && isGetSurNameListControl != null)
                    {   
                        
                        Console.WriteLine("isim:{0}", Person[getNameIndex].Name);
                        Console.WriteLine("Soyisim:{0}", Person[getNameIndex].SurName);
                        Console.WriteLine("Telefon Numarası:{0}", Person[getNameIndex].PhoneNum);
                        Console.WriteLine("-");

                    }
                    else
                    {
                        Console.WriteLine("Aradığınız kişi rehberde yoktur.");
                    }

                    break;

                case 2:

                    
                    PhoneNum = Console.ReadLine();
                    PhoneBook isGetNameLstControl = Person.Find(i => i.PhoneNum == PhoneNum);
                    var getNameIndx = Person.IndexOf(isGetNameLstControl);

                    if (isGetNameLstControl != null)
                    {
                        Console.WriteLine("isim:{0}", Person[getNameIndx].Name);
                        Console.WriteLine("Soyisim:{0}", Person[getNameIndx].SurName);
                        Console.WriteLine("Telefon Numarası:{0}", Person[getNameIndx].PhoneNum);
                        Console.WriteLine("-");

                    }
                    else
                    {
                        Console.WriteLine("Aradığınız kişi rehberde yoktur.");
                    }



                    break;

                default:
                    break;
            }
        }
    }
}
