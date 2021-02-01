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

        public PostNord()
        {
            Letters = new List<Mail>();
        }

        //Uppgift 7
        public List<Mail> SortLettersToOstersund(List<string> locationsInÖstersund)
        {
            List<Mail> SortedList = new List<Mail>();

            foreach (Mail mail in Letters)
            {

                if (mail.County == "Jämtland")
                {
                    SortedList.Add(mail);
                }
                else
                {
                    foreach (string s in locationsInÖstersund)
                    {
                        if (mail.Locality == s)
                        {
                            SortedList.Add(mail);
                        }
                    }
                }
            }
            return SortedList;
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
