using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_4_8
{
    class PostNord
    {
        public List<Mail> Letters { get; set; }
        public List<Mail> SortedLetters { get; set; }  

        public PostNord()
        {
            Letters = new List<Mail>();
            SortedLetters = new List<Mail>(); 
        }


        //Uppgift 6 Test med postnummer
        public void SortByDeliveryType()
        {
            char c;
            foreach (Mail m in Letters)
            {
                for (int i = 0; i < m.PostalCode.Length; i++)
                {
                    if (i == 2)
                    {
                        c = m.PostalCode[i];
                        if (c == '0')
                        {
                            m.DeliveryType = "Box";
                        }
                        else if (c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7')
                        {
                            m.DeliveryType = "Brevbäring";
                        }
                        else if (c == '8')
                        {
                            m.DeliveryType = "Svarspost";
                        }
                        else if (c == '9')
                        {
                            m.DeliveryType = "Tävlingspost";
                        }
                    }
                }
            }
        }

        ////Uppgift 7
        //public List<Mail> SortLettersToOstersund(List<string> locationsInÖstersund)
        //{
        //    List<Mail> SortedList = new List<Mail>();

        //    foreach (Mail mail in Letters)
        //    {

        //        if (mail.County == "Jämtland")
        //        {
        //            SortedList.Add(mail);
        //        }
        //        else
        //        {
        //            foreach (string s in locationsInÖstersund)
        //            {
        //                if (mail.Locality == s)
        //                {
        //                    SortedList.Add(mail);
        //                }
        //            }
        //        }
        //    }
        //    return SortedList;
        //}


        //Uppgift 7 UPPDATERAD
        public void SortLettersToOstersund2(Mail m)
        {
            List<string> locationsInOstersund = new List<string>() { "Berge", "Bjärme", "Bodal", "Bringåsen", "Brunflo", "Bye", "Böle", "Digernäs", "Erikslund", "Fannbyn", "Fillsta", "Fjäl", "Fåker", "Genvalla", "Gilleråsen", "Gusta", "Gärde", "Handog", "Hara", "Hegled", "Hornsberg", "Husås", "Häggenås", "Härke", "Klocksåsen", "Kläppe", "Klösta", "Knytta", "Lit", "Loke", "Lunne", "Marieby", "Munkflohögen", "målsta", "Norderåsen", "Nyvik", "Näs", "Ope", "Optand", "Orrviken", "Ringsta", "Rossbol", "Sandviken", "Singsjön", "Sjör", "Skickja", "Skute", "Slandrom", "Solberg", "Tandsbyn", "Torvalla by", "Valla", "Åkre", "Ångsta", "Ängsmon", "Östersund", "Österåsen" };

            if (m.County == "Jämtland")
            {
                SortedLetters.Add(m);
                Letters.Remove(m);
            }
            else
            {
                foreach (string s in locationsInOstersund)
                {
                    if (m.Locality == s)
                    {
                        SortedLetters.Add(m);
                        Letters.Remove(m);
                    }
                }
            }
        }



            //Uppgift 8
            public List<Mail> NominateWinners()
            {
                List<Mail> Winners = new List<Mail>();
                int mostNumOfDays = 0;

                foreach (Mail m in Letters)
                {
                    int numOfDays = (m.Delivered - m.Arrived).Days;
                    //TimeSpan diff = m.Delivered.Subtract(m.Arrived);

                    if (numOfDays > mostNumOfDays)
                    {
                        mostNumOfDays = numOfDays;
                        Winners.Add(m);
                    }
                    else if (numOfDays == mostNumOfDays)
                    {
                        Winners.Add(m);
                    }
                }
                return Winners;
            }

            //Uppgift 8 B
            public string ShowWinners()
            {
                List<Mail> Winners = NominateWinners();
                int price = 10000;

                int priceDivided = price / Winners.Count;
                string s = "";

                foreach (Mail m in Winners)
                {
                    s += m.Name + " vinner: " + priceDivided + " kr" + "\n";
                }
                return s;
            }
        }
    }
