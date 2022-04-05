using System;
using System.Collections;

//www.patika.dev
       
           
namespace Koleksiyonlar_Soru_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list1 = new ArrayList();
            ArrayList list2 = new ArrayList();
            int flagtr = 0;
            for (int i = 0; i < 20; i++) 
            {
                Console.Write("Lütfen işlem yapılmasını istediğiniz {0}.sayıyıları giriniz: ",i + 1);
                string num = Console.ReadLine();

                int turnSetNum;
                bool isNumTrue = int.TryParse(num, out turnSetNum);//if numbber can turn int that case get to true,And We understand this is int.
                                                                       //And We are set turnTheNumber Value to nu Value
                while(true)
                {   
                    if(0<turnSetNum && isNumTrue == true)//And We contrast them for being int and turnTheNumber more than zero
                    { 
                        for (int j = 2; j < turnSetNum; j++)
                        {
                            if(turnSetNum % j == 0)
                            {
                                flagtr = 1;//We are control with flag system.
                                break;
                            }
                    
                    
                        }
                        if (flagtr == 0)
                        {
                            list1.Add(turnSetNum);
                        }
                        else
                        {
                            list2.Add(turnSetNum);
                        }
                        flagtr = 0;
                        break;
                    }
                    else
                    {   Console.Write($"Lütfen karakter girişi yapmayınız.Lütfen {i+1}.sayıyı tekrar giriniz: ");
                        num = Console.ReadLine();
                        isNumTrue = int.TryParse(num, out turnSetNum);


                    }
                }
            }
            list1.Add(2);
            list1.Sort();
            list1.Reverse();
            
            list2.Sort();
            list2.Reverse();
            Console.WriteLine();
            Console.Write("Asal olan sayıların büyükten küçüğe doğru sıralaması: ");
            foreach (int i in list1)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            Console.Write("Asal olmayan sayıların büyükten küçüğe doğru sıralaması: ");
            foreach (int i in list2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.Write("Asal olan sayıların sayısı: ");
            Console.Write(list1.Count);
            Console.WriteLine();
            Console.Write("Asal olmayan sayıların sayısı: ");
            Console.Write(list2.Count);
            Console.WriteLine();
            Console.Write("Asal olan sayıların ortalaması: ");
            int sumOfList1 = 0;
            for(int i = 0; i < list1.Count; i++)
            {
                sumOfList1 += Convert.ToInt32(list1[i]);
            }
            Console.Write(sumOfList1 / list1.Count);
            Console.WriteLine();
            Console.Write("Asal olmayan sayıların ortalaması: ");
            int sumOfList2 = 0;
            for (int i = 0; i < list2.Count; i++)
            {
                sumOfList2 += Convert.ToInt32(list2[i]);
            }
            Console.Write(sumOfList2 / list2.Count);
        }
        
    }
}
